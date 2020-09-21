using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alpha.Integracoes.NFSe.Models.CancelarNfseEnvio
{
	[XmlRoot(ElementName = "IdentificacaoNfse", Namespace = "http://www.abrasf.org.br/nfse")]
	public class IdentificacaoNfse
	{
		/// <summary>
		/// Número 123
		/// </summary>
		[XmlElement(ElementName = "Numero", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Numero { get; set; }
		[XmlElement(ElementName = "Cnpj", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Cnpj { get; set; }
		[XmlElement(ElementName = "InscricaoMunicipal", Namespace = "http://www.abrasf.org.br/nfse")]
		public string InscricaoMunicipal { get; set; }
		[XmlElement(ElementName = "CodigoMunicipio", Namespace = "http://www.abrasf.org.br/nfse")]
		public string CodigoMunicipio { get; set; }
	}

	[XmlRoot(ElementName = "InfPedidoCancelamento", Namespace = "http://www.abrasf.org.br/nfse")]
	public class InfPedidoCancelamento
	{
		[XmlElement(ElementName = "IdentificacaoNfse", Namespace = "http://www.abrasf.org.br/nfse")]
		public IdentificacaoNfse IdentificacaoNfse { get; set; }
		[XmlElement(ElementName = "CodigoCancelamento", Namespace = "http://www.abrasf.org.br/nfse")]
		public string CodigoCancelamento { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class CanonicalizationMethod
	{
		[XmlAttribute(AttributeName = "Algorithm")]
		public string Algorithm { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class SignatureMethod
	{
		[XmlElement(ElementName = "HMACOutputLength", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string HMACOutputLength { get; set; }
		[XmlAttribute(AttributeName = "Algorithm")]
		public string Algorithm { get; set; }
	}

	[XmlRoot(ElementName = "any_element", Namespace = "otherNS")]
	public class Any_element
	{
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Transform
	{
		[XmlElement(ElementName = "any_element", Namespace = "otherNS")]
		public List<Any_element> Any_element { get; set; }
		[XmlElement(ElementName = "XPath", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string XPath { get; set; }
		[XmlAttribute(AttributeName = "Algorithm")]
		public string Algorithm { get; set; }
	}

	[XmlRoot(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Transforms
	{
		[XmlElement(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public List<Transform> Transform { get; set; }
	}

	[XmlRoot(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class DigestMethod
	{
		[XmlAttribute(AttributeName = "Algorithm")]
		public string Algorithm { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Reference
	{
		[XmlElement(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public Transforms Transforms { get; set; }
		[XmlElement(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public DigestMethod DigestMethod { get; set; }
		[XmlElement(ElementName = "DigestValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string DigestValue { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "URI")]
		public string URI { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class SignedInfo
	{
		[XmlElement(ElementName = "CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public CanonicalizationMethod CanonicalizationMethod { get; set; }
		[XmlElement(ElementName = "SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public SignatureMethod SignatureMethod { get; set; }
		[XmlElement(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public List<Reference> Reference { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class SignatureValue
	{
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "DSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class DSAKeyValue
	{
		[XmlElement(ElementName = "P", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string P { get; set; }
		[XmlElement(ElementName = "Q", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string Q { get; set; }
		[XmlElement(ElementName = "G", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string G { get; set; }
		[XmlElement(ElementName = "Y", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string Y { get; set; }
		[XmlElement(ElementName = "J", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string J { get; set; }
		[XmlElement(ElementName = "Seed", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string Seed { get; set; }
		[XmlElement(ElementName = "PgenCounter", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string PgenCounter { get; set; }
	}

	[XmlRoot(ElementName = "KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class KeyValue
	{
		[XmlElement(ElementName = "DSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public DSAKeyValue DSAKeyValue { get; set; }
	}

	[XmlRoot(ElementName = "RetrievalMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class RetrievalMethod
	{
		[XmlAttribute(AttributeName = "URI")]
		public string URI { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class KeyInfo
	{
		[XmlElement(ElementName = "KeyName", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string KeyName { get; set; }
		[XmlElement(ElementName = "KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public KeyValue KeyValue { get; set; }
		[XmlElement(ElementName = "RetrievalMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public RetrievalMethod RetrievalMethod { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "any_element", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Any_element2
	{
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Object", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Object
	{
		[XmlElement(ElementName = "any_element", Namespace = "http://www.abrasf.org.br/nfse")]
		public List<Any_element2> Any_element2 { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "MimeType")]
		public string MimeType { get; set; }
		[XmlAttribute(AttributeName = "Encoding")]
		public string Encoding { get; set; }
	}

	[XmlRoot(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Signature
	{
		[XmlElement(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public SignedInfo SignedInfo { get; set; }
		[XmlElement(ElementName = "SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public SignatureValue SignatureValue { get; set; }
		[XmlElement(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public KeyInfo KeyInfo { get; set; }
		[XmlElement(ElementName = "Object", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public List<Object> Object { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

	[XmlRoot(ElementName = "Pedido", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Pedido
	{
		[XmlElement(ElementName = "InfPedidoCancelamento", Namespace = "http://www.abrasf.org.br/nfse")]
		public InfPedidoCancelamento InfPedidoCancelamento { get; set; }
		[XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public Signature Signature { get; set; }
	}

	[XmlRoot(ElementName = "CancelarNfseEnvio", Namespace = "http://www.abrasf.org.br/nfse")]
	public class CancelarNfseEnvio
	{
		[XmlElement(ElementName = "Pedido", Namespace = "http://www.abrasf.org.br/nfse")]
		public Pedido Pedido { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}
}
