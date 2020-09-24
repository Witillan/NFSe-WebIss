using Alpha.Integracoes.NFSe.Models.ConsultarLoteRpsEnvio;
using Alpha.Integracoes.NFSe.Models.ConsultarNfseRpsEnvio;
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
    public partial class ConsutarNFSeRps : Form
    {
        public ConsutarNFSeRps()
        {
            InitializeComponent();
        }

        private void btnConsultarNFSeRps_Click(object sender, EventArgs e)
        {
            var ConsultarNfseRpsEnvio = new ConsultarNfseRpsEnvio
            {
                Prestador = new Models.ConsultarNfseRpsEnvio.Prestador
                {
                    Cnpj = txtCNPJ_Prestador.Text, InscricaoMunicipal = txtInscricaoMunicipal_Prestador.Text 
                },
                IdentificacaoRps = new IdentificacaoRps
                {
                    Numero = txtNumRPS.Text,
                    Serie = txtSerieRPS.Text,
                    Tipo = txtTipoRPS.Text,
                }
            };
        }
    }
}
