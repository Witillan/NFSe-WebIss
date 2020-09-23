using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Alpha.Integracoes.NFSe.WebIssHomologacao;
using Alpha.Integracoes.NFSe.Models.TiposComplexos.Cabecalho;
using Alpha.Integracoes.NFSe.Util;
using System.Security.Cryptography;
using Alpha.Integracoes.NFSe.Models.EnviarLoteRpsEnvio;
using System.ServiceModel;

namespace NFS_e
{
  public partial class FormGerarNFSe : Form
  {
    private RSA Chave = RSA.Create();
    private string Certificado = "CN=CACOAL LOCACOES DE MAQUINAS E EQUIPAMENTOS EIRELI:11230116000133, OU=34173682000318, OU=RFB e-CNPJ A1, OU=Secretaria da Receita Federal do Brasil - RFB, O=ICP-Brasil, L=CACOAL, S=RO, C=BR";

    public FormGerarNFSe()
    {
      InitializeComponent();
    }

    private async void btnEnviarRPS_Click(object sender, EventArgs e)
    {
      var rps = new Rps
      {
        InfRps = new InfRps
        {
          NaturezaOperacao = txtNaturezaDaOperacao.Text,
          DataEmissao = dtDataEmissaoRPS.Text,
          IncentivadorCultural = txtIncentivadorCultural.Text,
          OptanteSimplesNacional = txtSimplesNacional.Text,
          Status = cboxStatus.Text,
          RegimeEspecialTributacao = txtRegimeEspecial.Text,
          Servico = new Servico
          {
            CodigoMunicipio = txtCodMunicipio.Text,
            CodigoTributacaoMunicipio = txtCodTributacao.Text,
            ItemListaServico = txtCodListaServico.Text,
            Discriminacao = txtDiscriminacao.Text,
            CodigoCnae = txtCodCNAE.Text,
            Valores = new Valores
            {
              Aliquota = txtAliquota.Text,
              BaseCalculo = txtBaseCalculo.Text,
              DescontoCondicionado = txtDescontoCondi.Text,
              DescontoIncondicionado = txtDescontoInco.Text,
              ValorInss = txtValorINSS.Text,
              ValorIss = txtValorISS.Text,
              ValorIssRetido = txtValorIssRetido.Text,
              ValorLiquidoNfse = txtValorLiquidoNFSe.Text,
              ValorPis = txtValorPIS.Text,
              ValorServicos = txtValorServicos.Text,
              ValorCofins = txtValorCofins.Text,
              OutrasRetencoes = txtOutrasRetencoes.Text,
              ValorCsll = txtValorCSLL.Text,
              ValorIr = txtValorIR.Text,
              IssRetido = txtISSRetido.Text,
            }
          },
          Tomador = new Tomador
          {
            IdentificacaoTomador = new IdentificacaoTomador
            {
              InscricaoMunicipal = txtInscricaoMunicipal_Tomador.Text,
              CpfCnpj = new CpfCnpj { Cpf = txtCNPJ_Tomador.Text }
            },
            Endereco = new Endereco
            {
              Bairro = txtBairro_Tomador.Text,
              Cep = txtCep_Tomador.Text,
              CodigoMunicipio = txtCodMunicipio_Tomador.Text,
              EnderecoStr = txtEndereco_Tomador.Text,
              Complemento = txtComplemento_Tomador.Text,
              Numero = txtNumEndereco_Tomador.Text,
              Uf = cboxUF_Tomador.Text,
            },
            Contato = new Contato
            {
              Email = txtEmail_Tomador.Text,
              Telefone = txtTelefone_Tomador.Text
            }
          },
          Prestador = new Prestador
          {
            Cnpj = txtCNPJ_Prestador.Text,
            InscricaoMunicipal = txtInscricaoMunicipal_Prestador.Text
          },
          IdentificacaoRps = new IdentificacaoRps
          {
            Numero = txtNumRPS.Text,
            Serie = txtNumRPS.Text,
            Tipo = txtTipoRPS.Text
          }
        }
      };

      rps = XmlUtil.SignXmlFile(rps.ToXml(), this.Chave, this.Certificado).FromXml<Rps>();

      var enviarLoteRpsEnvio = new EnviarLoteRpsEnvio
      {
        LoteRps = new LoteRps
        {
          Cnpj = txtCNPJ_Prestador.Text,
          InscricaoMunicipal = txtInscricaoMunicipal_Prestador.Text,
          NumeroLote = txtNumLote.Text,
          QuantidadeRps = txtQtdRPS.Text,
          ListaRps = new ListaRps
          {
            Rps = new List<Rps>()
                        {
                            rps
                        }
          }
        }
      };
      try
      {
        var service = new NfseServicesClient(new BasicHttpsBinding(BasicHttpsSecurityMode.TransportWithMessageCredential), new EndpointAddress("https://www4.webiss.com.br/cacoalro_wsnfse_homolog/NfseServices.svc?wsdl"));
        var x509certificado = XmlUtil.GetCertificateFromStore(this.Certificado);
        service.ClientCredentials.ClientCertificate.Certificate = x509certificado;

        if (service.State == CommunicationState.Closed)
        {
          service.Open();
        }

        var cabecalho = new Cabecalho { Versao = "01", VersaoDados = "01" };

        var resposta = await service.RecepcionarLoteRpsAsync(cabecalho.ToXml(), enviarLoteRpsEnvio.ToXml());
        MessageBox.Show(resposta);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}