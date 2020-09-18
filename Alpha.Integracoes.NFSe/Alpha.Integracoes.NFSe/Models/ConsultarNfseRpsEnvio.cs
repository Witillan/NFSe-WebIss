using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alpha.Integracoes.NFSe.Models.ConsultarNfseRpsEnvio
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

	[XmlRoot(ElementName = "Prestador", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Prestador
	{
		[XmlElement(ElementName = "Cnpj", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Cnpj { get; set; }
		[XmlElement(ElementName = "InscricaoMunicipal", Namespace = "http://www.abrasf.org.br/nfse")]
		public string InscricaoMunicipal { get; set; }
	}

	[XmlRoot(ElementName = "ConsultarNfseRpsEnvio", Namespace = "http://www.abrasf.org.br/nfse")]
	public class ConsultarNfseRpsEnvio
	{
		[XmlElement(ElementName = "IdentificacaoRps", Namespace = "http://www.abrasf.org.br/nfse")]
		public IdentificacaoRps IdentificacaoRps { get; set; }
		[XmlElement(ElementName = "Prestador", Namespace = "http://www.abrasf.org.br/nfse")]
		public Prestador Prestador { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

}
