using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumirAPITesteEstagio.API;
using ConsumirAPITesteEstagio.DB;
using ConsumirAPITesteEstagio.Utilities;

namespace ConsumirAPITesteEstagio
{
    public partial class FrmPrincipal : Form
    {
        Dados dados = new Dados();
        FormatTxt ftxt = new FormatTxt();
        public FrmPrincipal()
        {
            InitializeComponent();
            ftxt.somenteNum(txtID);
        }

        private void btnConsultarAPI_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                ConsumirAPI consuApi = new ConsumirAPI();
                string[] resultado = consuApi.consumirAPI(txtID.Text);
                txtUserID.Text = resultado[0];
                txtTitle.Text = resultado[1];
                txtBody.Text = resultado[2];

            }
            else
            {
                MessageBox.Show("Digite um ID para buscar");
            }
        }

        private void btnConsultarDB_Click(object sender, EventArgs e)
        {
            dgvDados.DataSource = dados.consDados().Tables[0];
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            dados.cadDados(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtUserID.Text), txtTitle.Text, txtBody.Text);
        }
    }
}
