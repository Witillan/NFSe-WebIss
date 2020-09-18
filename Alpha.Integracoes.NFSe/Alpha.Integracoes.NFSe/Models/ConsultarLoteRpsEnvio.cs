using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alpha.Integracoes.NFSe.Models.ConsultarLoteRpsEnvio
{
	[XmlRoot(ElementName = "Prestador", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Prestador
	{
		[XmlElement(ElementName = "Cnpj", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Cnpj { get; set; }
		[XmlElement(ElementName = "InscricaoMunicipal", Namespace = "http://www.abrasf.org.br/nfse")]
		public string InscricaoMunicipal { get; set; }
	}

	[XmlRoot(ElementName = "ConsultarLoteRpsEnvio", Namespace = "http://www.abrasf.org.br/nfse")]
	public class ConsultarLoteRpsEnvio
	{
		[XmlElement(ElementName = "Prestador", Namespace = "http://www.abrasf.org.br/nfse")]
		public Prestador Prestador { get; set; }
		[XmlElement(ElementName = "Protocolo", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Protocolo { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}
}
