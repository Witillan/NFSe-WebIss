using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alpha.Integracoes.NFSe.Models.TiposComplexos.ListaMensagemRetornoLote
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

	[XmlRoot(ElementName = "MensagemRetorno", Namespace = "http://www.abrasf.org.br/nfse")]
	public class MensagemRetorno
	{
		[XmlElement(ElementName = "IdentificacaoRps", Namespace = "http://www.abrasf.org.br/nfse")]
		public IdentificacaoRps IdentificacaoRps { get; set; }
		[XmlElement(ElementName = "Codigo", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Codigo { get; set; }
		[XmlElement(ElementName = "Mensagem", Namespace = "http://www.abrasf.org.br/nfse")]
		public string Mensagem { get; set; }
	}

	[XmlRoot(ElementName = "ListaMensagemRetornoLote", Namespace = "http://www.abrasf.org.br/nfse")]
	public class ListaMensagemRetornoLote
	{
		[XmlElement(ElementName = "MensagemRetorno", Namespace = "http://www.abrasf.org.br/nfse")]
		public List<MensagemRetorno> MensagemRetorno { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

}
