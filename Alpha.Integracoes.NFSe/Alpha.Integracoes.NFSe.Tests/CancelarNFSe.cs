using Alpha.Integracoes.NFSe.Models.CancelarNfseEnvio;
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
    public partial class CancelarNFSe : Form
    {
        public CancelarNFSe()
        {
            InitializeComponent();
        }

        private void tbnCacelarNFSe_Click(object sender, EventArgs e)
        {
            var CancelarNFSeEnvio = new CancelarNfseEnvio
            {
                Pedido = new Pedido
                {
                    InfPedidoCancelamento = new InfPedidoCancelamento
                    {
                        IdentificacaoNfse = new IdentificacaoNfse
                        {
                            Cnpj = txtCNPJ_Prestador.Text,
                            CodigoMunicipio = txtCodMunicipio_Tomador.Text,
                            InscricaoMunicipal = txtInscricaoMunicipal_Prestador.Text,
                            Numero = txtNumNFSe.Text,
                        }
                    }
                }
            };
        }
    }
}
