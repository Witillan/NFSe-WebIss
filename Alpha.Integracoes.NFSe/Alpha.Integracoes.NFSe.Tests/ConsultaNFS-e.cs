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
    public partial class Consulta_NFS_e : Form
    {
        public Consulta_NFS_e()
        {
            InitializeComponent();
        }

        private void btnConsultarNFSe_Click(object sender, EventArgs e)
        {
            var ConsultarNFSeEnvio = new ConsultarLoteRpsEnvio
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
