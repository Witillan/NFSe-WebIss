
using System.Xml.Serialization;

namespace Alpha.Integracoes.NFSe.Models.TiposComplexos.Cabecalho
{
	[XmlRoot(ElementName = "cabecalho", Namespace = "http://www.abrasf.org.br/nfse")]
	public class Cabecalho
	{
		[XmlAttribute(AttributeName = "versao", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Versao { get; set; }
		[XmlElement(ElementName = "versaoDados", Namespace = "http://www.abrasf.org.br/nfse")]
		public string VersaoDados { get; set; }
	}
}
