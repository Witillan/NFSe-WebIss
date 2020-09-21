using Alpha.Integracoes.NFSe.Models.GerarNfseEnvio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alpha.Integracoes.NFSe.WebIssHomologacao;

namespace NFS_e
{
    public partial class FormGerarNFSe : Form
    {
        public FormGerarNFSe()
        {
            InitializeComponent();
        }

        private void btnEnviarRPS_Click(object sender, EventArgs e)
        {
            var gerarNfseEnvio = new GerarNfseEnvio
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
                            new Rps
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
                                            CpfCnpj = new CpfCnpj{ Cpf = txtCNPJ_Tomador.Text}
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
                            }
                        }
                    }
                }
            };

            var service = new NfseServicesClient();

            service
        }
    }
}