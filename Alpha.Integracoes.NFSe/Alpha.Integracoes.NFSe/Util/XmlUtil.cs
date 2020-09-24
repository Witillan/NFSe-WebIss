using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Serialization;

namespace Alpha.Integracoes.NFSe.Util
{
    public static class XmlUtil
    {
        public static T FromXml<T>(this string xml)
        {
            if (String.IsNullOrEmpty(xml)) throw new NotSupportedException("Empty string!!");

            T returnedXmlClass;

            using (TextReader reader = new StringReader(xml))
            {
                returnedXmlClass = (T)new XmlSerializer(typeof(T)).Deserialize(reader);
            }

            return returnedXmlClass;
        }
        public static string ToXml<T>(this T typeObj, XmlWriterSettings settings = null)
        {
            if (typeObj == null)
            {
                return string.Empty;
            }
            using (var stringWriter = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(xmlWriter, typeObj);
                    return stringWriter.ToString();
                }
            }
        }

        public static string AsString(this XmlDocument xmlDoc)
        {
            using (StringWriter sw = new StringWriter())
            {
                using (XmlTextWriter tx = new XmlTextWriter(sw))
                {
                    xmlDoc.WriteTo(tx);
                    string strXmlText = sw.ToString();
                    return strXmlText;
                }
            }
        }

        /// <summary>
        /// Assina o documento XML a partir de uma string
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="key"></param>
        /// <param name="certifica"></param>
        /// <returns></returns>
        public static string SignXmlFile(string xml, RSA key, string certificadoStr)
        {
            // Create a new XML document.
            var doc = new XmlDocument();

            // Load the passed XML file using its name.
            doc.LoadXml(xml);

            // Create a SignedXml object.
            var signedXml = new SignedXml(doc);

            // Add the key to the SignedXml document. 
            signedXml.SigningKey = key;
            signedXml.SignedInfo.SignatureMethod = SignedXml.XmlDsigRSASHA1Url;

            // Create a reference to be signed.
            var reference = new System.Security.Cryptography.Xml.Reference();
            reference.Uri = $"";

            // Add an enveloped transformation to the reference.
            reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
            reference.AddTransform(new XmlDsigC14NTransform());

            reference.DigestMethod = SignedXml.XmlDsigSHA1Url;

            // Add the reference to the SignedXml object.
            signedXml.AddReference(reference);

            var keyInfo = new System.Security.Cryptography.Xml.KeyInfo();
            KeyInfoX509Data keyInfoData = new KeyInfoX509Data();
            
            var certificate = GetCertificateFromStore(certificadoStr);
            keyInfoData.AddCertificate(certificate);

            keyInfo.AddClause(keyInfoData);
            signedXml.KeyInfo = keyInfo;

            // Compute the signature.
            signedXml.ComputeSignature();

            // Get the XML representation of the signature and save
            // it to an XmlElement object.
            var xmlDigitalSignature = signedXml.GetXml();

            // Append the element to the XML document.
            doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignature, true));

            if (doc.FirstChild is XmlDeclaration)
            {
                doc.RemoveChild(doc.FirstChild);
            }

            return doc.AsString();
        }

        public static X509Certificate2 GetCertificateFromStore(string certificadoStr)
        {
            X509Certificate2 certificate = null;
            var store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            var certificates = store.Certificates;
            foreach (var cert in certificates)
            {
                if (cert.Subject.Contains(certificadoStr))
                {
                    certificate = cert;
                    break;
                }
            }

            if (certificate == null)
            {
                throw new Exception("Certificado não encontrado");
            }

            return certificate;
        }

        // Verify the signature of an XML file and return the result.
        public static bool VerifyXmlFile(String xml, RSA Key)
        {
            // Create a new XML document.
            XmlDocument xmlDocument = new XmlDocument();

            // Load the passed XML file into the document. 
            xmlDocument.LoadXml(xml);

            // Create a new SignedXml object and pass it
            // the XML document class.
            SignedXml signedXml = new SignedXml(xmlDocument);

            // Find the "Signature" node and create a new
            // XmlNodeList object.
            XmlNodeList nodeList = xmlDocument.GetElementsByTagName("Signature");

            // Load the signature node.
            signedXml.LoadXml((XmlElement)nodeList[0]);

            // Check the signature and return the result.
            return signedXml.CheckSignature(Key);
        }
    }
}
