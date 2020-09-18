using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alpha.Integracoes.NFSe.Models.ConsultarSituacaoLoteRpsResposta
{
	[XmlRoot(ElementName = "ConsultarSituacaoLoteRpsResposta", Namespace = "http://www.abrasf.org.br/nfse")]
	public class ConsultarSituacaoLoteRpsResposta
	{
		[XmlElement(ElementName = "NumeroLote", Namespace = "http://www.abrasf.org.br/nfse")]
		public string NumeroLote { get; set; }
		[XmlElement(ElementName = "Situacao", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Situacao { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}
}
