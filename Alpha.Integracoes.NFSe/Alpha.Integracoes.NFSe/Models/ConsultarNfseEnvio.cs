using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alpha.Integracoes.NFSe.Models.ConsultarNfseEnvio
{
	[XmlRoot(ElementName = "Prestador", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Prestador
	{
		[XmlElement(ElementName = "Cnpj", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Cnpj { get; set; }
		[XmlElement(ElementName = "InscricaoMunicipal", Namespace = "http://www.abrasf.org.br/nfse")]
		public string InscricaoMunicipal { get; set; }
	}

	[XmlRoot(ElementName = "PeriodoEmissao", Namespace = "http://www.abrasf.org.br/nfse")]
	public class PeriodoEmissao
	{
		[XmlElement(ElementName = "DataInicial", Namespace = "http://www.abrasf.org.br/nfse")]
		public string DataInicial { get; set; }
		[XmlElement(ElementName = "DataFinal", Namespace = "http://www.abrasf.org.br/nfse")]
		public string DataFinal { get; set; }
	}

	[XmlRoot(ElementName = "CpfCnpj", Namespace = "http://www.abrasf.org.br/nfse")]
	public class CpfCnpj
	{
		[XmlElement(ElementName = "Cpf", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Cpf { get; set; }
	}

	[XmlRoot(ElementName = "Tomador", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Tomador
	{
		[XmlElement(ElementName = "CpfCnpj", Namespace = "http://www.abrasf.org.br/nfse")]
		public CpfCnpj CpfCnpj { get; set; }
		[XmlElement(ElementName = "InscricaoMunicipal", Namespace = "http://www.abrasf.org.br/nfse")]
		public string InscricaoMunicipal { get; set; }
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

	[XmlRoot(ElementName = "ConsultarNfseEnvio", Namespace = "http://www.abrasf.org.br/nfse")]
	public class ConsultarNfseEnvio
	{
		[XmlElement(ElementName = "Prestador", Namespace = "http://www.abrasf.org.br/nfse")]
		public Prestador Prestador { get; set; }
		[XmlElement(ElementName = "NumeroNfse", Namespace = "http://www.abrasf.org.br/nfse")]
		public string NumeroNfse { get; set; }
		[XmlElement(ElementName = "PeriodoEmissao", Namespace = "http://www.abrasf.org.br/nfse")]
		public PeriodoEmissao PeriodoEmissao { get; set; }
		[XmlElement(ElementName = "Tomador", Namespace = "http://www.abrasf.org.br/nfse")]
		public Tomador Tomador { get; set; }
		[XmlElement(ElementName = "IntermediarioServico", Namespace = "http://www.abrasf.org.br/nfse")]
		public IntermediarioServico IntermediarioServico { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

}
