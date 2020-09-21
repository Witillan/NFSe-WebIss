using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alpha.Integracoes.NFSe.Models.GerarNfseEnvio
{
	[XmlRoot(ElementName = "IdentificacaoRps", Namespace = "http://www.abrasf.org.br/nfse")]
	public class IdentificacaoRps
	{
		[XmlElement(ElementName = "Numero", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Numero { get; set; }
		[XmlElement(ElementName = "Serie", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Serie { get; set; }
		[XmlElement(ElementName = "Tipo", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Tipo { get; set; }
	}

	[XmlRoot(ElementName = "RpsSubstituido", Namespace = "http://www.abrasf.org.br/nfse")]
	public class RpsSubstituido
	{
		[XmlElement(ElementName = "Numero", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Numero { get; set; }
		[XmlElement(ElementName = "Serie", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Serie { get; set; }
		[XmlElement(ElementName = "Tipo", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Tipo { get; set; }
	}

	[XmlRoot(ElementName = "Valores", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Valores
	{
		[XmlElement(ElementName = "ValorServicos", Namespace = "http://www.abrasf.org.br/nfse")]
		public string ValorServicos { get; set; }
		[XmlElement(ElementName = "ValorDeducoes", Namespace = "http://www.abrasf.org.br/nfse")]
		public string ValorDeducoes { get; set; }
		[XmlElement(ElementName = "ValorPis", Namespace = "http://www.abrasf.org.br/nfse")]
		public string ValorPis { get; set; }
		[XmlElement(ElementName = "ValorCofins", Namespace = "http://www.abrasf.org.br/nfse")]
		public string ValorCofins { get; set; }
		[XmlElement(ElementName = "ValorInss", Namespace = "http://www.abrasf.org.br/nfse")]
		public string ValorInss { get; set; }
		[XmlElement(ElementName = "ValorIr", Namespace = "http://www.abrasf.org.br/nfse")]
		public string ValorIr { get; set; }
		[XmlElement(ElementName = "ValorCsll", Namespace = "http://www.abrasf.org.br/nfse")]
		public string ValorCsll { get; set; }
		[XmlElement(ElementName = "IssRetido", Namespace = "http://www.abrasf.org.br/nfse")]
		public string IssRetido { get; set; }
		[XmlElement(ElementName = "ValorIss", Namespace = "http://www.abrasf.org.br/nfse")]
		public string ValorIss { get; set; }
		[XmlElement(ElementName = "ValorIssRetido", Namespace = "http://www.abrasf.org.br/nfse")]
		public string ValorIssRetido { get; set; }
		[XmlElement(ElementName = "OutrasRetencoes", Namespace = "http://www.abrasf.org.br/nfse")]
		public string OutrasRetencoes { get; set; }
		[XmlElement(ElementName = "BaseCalculo", Namespace = "http://www.abrasf.org.br/nfse")]
		public string BaseCalculo { get; set; }
		[XmlElement(ElementName = "Aliquota", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Aliquota { get; set; }
		[XmlElement(ElementName = "ValorLiquidoNfse", Namespace = "http://www.abrasf.org.br/nfse")]
		public string ValorLiquidoNfse { get; set; }
		[XmlElement(ElementName = "DescontoIncondicionado", Namespace = "http://www.abrasf.org.br/nfse")]
		public string DescontoIncondicionado { get; set; }
		[XmlElement(ElementName = "DescontoCondicionado", Namespace = "http://www.abrasf.org.br/nfse")]
		public string DescontoCondicionado { get; set; }
	}

	[XmlRoot(ElementName = "Servico", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Servico
	{
		[XmlElement(ElementName = "Valores", Namespace = "http://www.abrasf.org.br/nfse")]
		public Valores Valores { get; set; }
		[XmlElement(ElementName = "ItemListaServico", Namespace = "http://www.abrasf.org.br/nfse")]
		public string ItemListaServico { get; set; }
		[XmlElement(ElementName = "CodigoCnae", Namespace = "http://www.abrasf.org.br/nfse")]
		public string CodigoCnae { get; set; }
		[XmlElement(ElementName = "CodigoTributacaoMunicipio", Namespace = "http://www.abrasf.org.br/nfse")]
		public string CodigoTributacaoMunicipio { get; set; }
		[XmlElement(ElementName = "Discriminacao", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Discriminacao { get; set; }
		[XmlElement(ElementName = "CodigoMunicipio", Namespace = "http://www.abrasf.org.br/nfse")]
		public string CodigoMunicipio { get; set; }
	}

	[XmlRoot(ElementName = "Prestador", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Prestador
	{
		[XmlElement(ElementName = "Cnpj", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Cnpj { get; set; }
		[XmlElement(ElementName = "InscricaoMunicipal", Namespace = "http://www.abrasf.org.br/nfse")]
		public string InscricaoMunicipal { get; set; }
	}

	[XmlRoot(ElementName = "CpfCnpj", Namespace = "http://www.abrasf.org.br/nfse")]
	public class CpfCnpj
	{
		[XmlElement(ElementName = "Cpf", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Cpf { get; set; }
	}

	[XmlRoot(ElementName = "IdentificacaoTomador", Namespace = "http://www.abrasf.org.br/nfse")]
	public class IdentificacaoTomador
	{
		[XmlElement(ElementName = "CpfCnpj", Namespace = "http://www.abrasf.org.br/nfse")]
		public CpfCnpj CpfCnpj { get; set; }
		[XmlElement(ElementName = "InscricaoMunicipal", Namespace = "http://www.abrasf.org.br/nfse")]
		public string InscricaoMunicipal { get; set; }
	}

	[XmlRoot(ElementName = "Endereco", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Endereco
	{
		[XmlElement(ElementName = "Endereco", Namespace = "http://www.abrasf.org.br/nfse")]
		public string EnderecoStr { get; set; }
		[XmlElement(ElementName = "Numero", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Numero { get; set; }
		[XmlElement(ElementName = "Complemento", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Complemento { get; set; }
		[XmlElement(ElementName = "Bairro", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Bairro { get; set; }
		[XmlElement(ElementName = "CodigoMunicipio", Namespace = "http://www.abrasf.org.br/nfse")]
		public string CodigoMunicipio { get; set; }
		[XmlElement(ElementName = "Uf", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Uf { get; set; }
		[XmlElement(ElementName = "Cep", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Cep { get; set; }
	}

	[XmlRoot(ElementName = "Contato", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Contato
	{
		[XmlElement(ElementName = "Telefone", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Telefone { get; set; }
		[XmlElement(ElementName = "Email", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Email { get; set; }
	}

	[XmlRoot(ElementName = "Tomador", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Tomador
	{
		[XmlElement(ElementName = "IdentificacaoTomador", Namespace = "http://www.abrasf.org.br/nfse")]
		public IdentificacaoTomador IdentificacaoTomador { get; set; }
		[XmlElement(ElementName = "RazaoSocial", Namespace = "http://www.abrasf.org.br/nfse")]
		public string RazaoSocial { get; set; }
		[XmlElement(ElementName = "Endereco", Namespace = "http://www.abrasf.org.br/nfse")]
		public Endereco Endereco { get; set; }
		[XmlElement(ElementName = "Contato", Namespace = "http://www.abrasf.org.br/nfse")]
		public Contato Contato { get; set; }
	}

	[XmlRoot(ElementName = "IntermediarioServico", Namespace = "http://www.abrasf.org.br/nfse")]
	public class IntermediarioServico
	{
		[XmlElement(ElementName = "RazaoSocial", Namespace = "http://www.abrasf.org.br/nfse")]
		public string RazaoSocial { get; set; }
		[XmlElement(ElementName = "CpfCnpj", Namespace = "http://www.abrasf.org.br/nfse")]
		public CpfCnpj CpfCnpj { get; set; }
		[XmlElement(ElementName = "InscricaoMunicipal", Namespace = "http://www.abrasf.org.br/nfse")]
		public string InscricaoMunicipal { get; set; }
	}

	[XmlRoot(ElementName = "ConstrucaoCivil", Namespace = "http://www.abrasf.org.br/nfse")]
	public class ConstrucaoCivil
	{
		[XmlElement(ElementName = "CodigoObra", Namespace = "http://www.abrasf.org.br/nfse")]
		public string CodigoObra { get; set; }
		[XmlElement(ElementName = "Art", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Art { get; set; }
	}

	[XmlRoot(ElementName = "InfRps", Namespace = "http://www.abrasf.org.br/nfse")]
	public class InfRps
	{
		[XmlElement(ElementName = "IdentificacaoRps", Namespace = "http://www.abrasf.org.br/nfse")]
		public IdentificacaoRps IdentificacaoRps { get; set; }
		[XmlElement(ElementName = "DataEmissao", Namespace = "http://www.abrasf.org.br/nfse")]
		public string DataEmissao { get; set; }
		[XmlElement(ElementName = "NaturezaOperacao", Namespace = "http://www.abrasf.org.br/nfse")]
		public string NaturezaOperacao { get; set; }
		[XmlElement(ElementName = "RegimeEspecialTributacao", Namespace = "http://www.abrasf.org.br/nfse")]
		public string RegimeEspecialTributacao { get; set; }
		[XmlElement(ElementName = "OptanteSimplesNacional", Namespace = "http://www.abrasf.org.br/nfse")]
		public string OptanteSimplesNacional { get; set; }
		[XmlElement(ElementName = "IncentivadorCultural", Namespace = "http://www.abrasf.org.br/nfse")]
		public string IncentivadorCultural { get; set; }
		[XmlElement(ElementName = "Status", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Status { get; set; }
		[XmlElement(ElementName = "RpsSubstituido", Namespace = "http://www.abrasf.org.br/nfse")]
		public RpsSubstituido RpsSubstituido { get; set; }
		[XmlElement(ElementName = "Servico", Namespace = "http://www.abrasf.org.br/nfse")]
		public Servico Servico { get; set; }
		[XmlElement(ElementName = "Prestador", Namespace = "http://www.abrasf.org.br/nfse")]
		public Prestador Prestador { get; set; }
		[XmlElement(ElementName = "Tomador", Namespace = "http://www.abrasf.org.br/nfse")]
		public Tomador Tomador { get; set; }
		[XmlElement(ElementName = "IntermediarioServico", Namespace = "http://www.abrasf.org.br/nfse")]
		public IntermediarioServico IntermediarioServico { get; set; }
		[XmlElement(ElementName = "ConstrucaoCivil", Namespace = "http://www.abrasf.org.br/nfse")]
		public ConstrucaoCivil ConstrucaoCivil { get; set; }
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

	[XmlRoot(ElementName = "Rps", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Rps
	{
		[XmlElement(ElementName = "InfRps", Namespace = "http://www.abrasf.org.br/nfse")]
		public InfRps InfRps { get; set; }
		[XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public Signature Signature { get; set; }
	}

	[XmlRoot(ElementName = "ListaRps", Namespace = "http://www.abrasf.org.br/nfse")]
	public class ListaRps
	{
		[XmlElement(ElementName = "Rps", Namespace = "http://www.abrasf.org.br/nfse")]
		public List<Rps> Rps { get; set; }
	}

	[XmlRoot(ElementName = "LoteRps", Namespace = "http://www.abrasf.org.br/nfse")]
	public class LoteRps
	{
		[XmlElement(ElementName = "NumeroLote", Namespace = "http://www.abrasf.org.br/nfse")]
		public string NumeroLote { get; set; }
		[XmlElement(ElementName = "Cnpj", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Cnpj { get; set; }
		[XmlElement(ElementName = "InscricaoMunicipal", Namespace = "http://www.abrasf.org.br/nfse")]
		public string InscricaoMunicipal { get; set; }
		[XmlElement(ElementName = "QuantidadeRps", Namespace = "http://www.abrasf.org.br/nfse")]
		public string QuantidadeRps { get; set; }
		[XmlElement(ElementName = "ListaRps", Namespace = "http://www.abrasf.org.br/nfse")]
		public ListaRps ListaRps { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "GerarNfseEnvio", Namespace = "http://www.abrasf.org.br/nfse")]
	public class GerarNfseEnvio
	{
		[XmlElement(ElementName = "LoteRps", Namespace = "http://www.abrasf.org.br/nfse")]
		public LoteRps LoteRps { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}
}
