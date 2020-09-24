using Alpha.Integracoes.NFSe.Models.ConsultarLoteRpsEnvio;
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
    public partial class ConsultarLoteRps : Form
    {
        public ConsultarLoteRps()
        {
            InitializeComponent();
        }

        private void btnConsultarLoteRps_Click(object sender, EventArgs e)
        {
            var ConsultarLoteRpsEnvio = new ConsultarLoteRpsEnvio
            {
                Prestador = new Prestador
                {
                    Cnpj = txtCNPJ_Prestador.Text,
                    InscricaoMunicipal = txtInscricaoMunicipal_Prestador.Text,
                }
            };
        }
    }
}
