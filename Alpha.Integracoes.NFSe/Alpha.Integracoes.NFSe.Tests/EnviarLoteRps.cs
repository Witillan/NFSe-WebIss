using Alpha.Integracoes.NFSe.Models.EnviarLoteRpsEnvio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha.Integracoes.NFSe.Tests
{
    public partial class Enviar_Lote_de_RPS : Form
    {
        public Enviar_Lote_de_RPS()
        {
            InitializeComponent();
        }

        private void btnEnviarLoteRPS_Click(object sender, EventArgs e)
        {
            var EnviarLoteRpsEnvio = new EnviarLoteRpsEnvio
            {
                LoteRps = new LoteRps()
                {
                    NumeroLote = txtNumLote.Text,
                    QuantidadeRps = txtQtdRPS.Text,
                    Cnpj = txtCNPJ_Prestador.Text,
                    InscricaoMunicipal = txtInscricaoMunicipal_Prestador.Text,
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
        }
    }
}
