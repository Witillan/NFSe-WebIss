using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alpha.Integracoes.NFSe.Models.TiposComplexos.ListaMensagemRetorno
{
	[XmlRoot(ElementName = "MensagemRetorno", Namespace = "http://www.abrasf.org.br/nfse")]
	public class MensagemRetorno
	{
		[XmlElement(ElementName = "Codigo", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Codigo { get; set; }
		[XmlElement(ElementName = "Mensagem", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Mensagem { get; set; }
		[XmlElement(ElementName = "Correcao", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Correcao { get; set; }
	}

	[XmlRoot(ElementName = "ListaMensagemRetorno", Namespace = "http://www.abrasf.org.br/nfse")]
	public class ListaMensagemRetorno
	{
		[XmlElement(ElementName = "MensagemRetorno", Namespace = "http://www.abrasf.org.br/nfse")]
		public List<MensagemRetorno> MensagemRetorno { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}
}
