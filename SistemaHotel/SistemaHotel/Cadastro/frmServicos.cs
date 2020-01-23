using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Cadastro
{
    public partial class frmServicos : Form
    {
        public frmServicos()
        {
            InitializeComponent();
        }


        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtValor.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtValor.Enabled = false;
        }


        private void LimparCampos()
        {
            txtNome.Text = "";
            txtValor.Text = "";
        }

        private void btnNovoServico_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvarServico.Enabled = true;
        }

        private void btnSalvarServico_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtValor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o valor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSalvarServico.Enabled = false;
            LimparCampos();
        }

        private void dgServicos_Click(object sender, EventArgs e)
        {
            btnEditarServico.Enabled = true;
            btnExcluirServico.Enabled = true;
            btnNovoServico.Enabled = false;
            btnSalvarServico.Enabled = false;
            HabilitarCampos();
        }

        private void btnEditarServico_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtValor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o valor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }

            MessageBox.Show("Cadastro atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            btnEditarServico.Enabled = false;
            btnExcluirServico.Enabled = false;
            btnSalvarServico.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
        }

        private void btnExcluirServico_Click(object sender, EventArgs e)
        {
            var ExcluirServiço = MessageBox.Show("Deseja realmente excluir este serviço?", "Excluir Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ExcluirServiço == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro excluido ocm sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSalvarServico.Enabled = false;
                btnEditarServico.Enabled = false;
                btnExcluirServico.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
            }
        }

        private void frmServicos_Load(object sender, EventArgs e)
        {

        }
    }
}
