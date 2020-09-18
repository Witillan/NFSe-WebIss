using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alpha.Integracoes.NFSe.Models.EnviarLoteRpsResposta
{
	[XmlRoot(ElementName = "EnviarLoteRpsResposta", Namespace = "http://www.abrasf.org.br/nfse")]
	public class EnviarLoteRpsResposta
	{
		[XmlElement(ElementName = "NumeroLote", Namespace = "http://www.abrasf.org.br/nfse")]
		public string NumeroLote { get; set; }
		[XmlElement(ElementName = "DataRecebimento", Namespace = "http://www.abrasf.org.br/nfse")]
		public string DataRecebimento { get; set; }
		[XmlElement(ElementName = "Protocolo", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Protocolo { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}
}
