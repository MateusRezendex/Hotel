using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            txtNome.Focus();

            HabilitarBotoes();
            btnNovo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarBotoes();
            DesabilitarCampos();
            btnNovo.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SalvarExcluir();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SalvarExcluir();
        }


        private void DesabilitarBotoes()
        {
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void HabilitarBotoes()
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtCpf.Enabled = true;
            txtTelefone.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtCpf.Enabled = false;
            txtTelefone.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
        }

        private void SalvarExcluir()
        {
            LimparCampos();
            DesabilitarBotoes();
            DesabilitarCampos();
            btnNovo.Enabled = true;
        }
    }    
}
