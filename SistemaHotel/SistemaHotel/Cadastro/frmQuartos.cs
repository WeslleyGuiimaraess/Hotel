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
    public partial class frmQuartos : Form
    {
        public frmQuartos()
        {
            InitializeComponent();
        }

        private void frmQuartos_Load(object sender, EventArgs e)
        {
            rbNao.Checked = true;
            rbSim.Checked = false;
        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = true;
        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtNumeroQuarto.Enabled = true;
            cbQuartos.Enabled = true;
            cbSuite.Enabled = true;
            txtValor.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNumeroQuarto.Enabled = false;
            cbQuartos.Enabled = false;
            cbSuite.Enabled = false;
            txtValor.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNumeroQuarto.Text = "";
            txtValor.Text = "";
            foreach (Control Componente in this.Controls)
            {
                if (Componente is ComboBox)
                {
                    (Componente as ComboBox).SelectedIndex = -1;
                }
            }
        }

        private void btnNovoQuarto_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvarQuarto.Enabled = true;
        }

        private void btnSalvarQuarto_Click(object sender, EventArgs e)
        {
            if (txtNumeroQuarto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o numero do quarto.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumeroQuarto.Text = "";
                txtNumeroQuarto.Focus();
                return;
            }

            if (cbSuite.Text.ToString() == "")
            {
                MessageBox.Show("Preencha a suite.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbSuite.Focus();
                return;
            }

            if (cbQuartos.Text.ToString() == "")
            {
                MessageBox.Show("Preencha o numero de quartos.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbQuartos.Focus();
                return;
            }

            if (txtValor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha o valor.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }

            MessageBox.Show("Cadastro realizado com sucesso.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSalvarQuarto.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
        }

        private void dgQuartos_Click(object sender, EventArgs e)
        {
            btnExluirQuarto.Enabled = true;
            btnEditarQuarto.Enabled = true;
            HabilitarCampos();
        }

        private void btnEditarQuarto_Click(object sender, EventArgs e)
        {
            if (txtNumeroQuarto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o numero do quarto.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumeroQuarto.Text = "";
                txtNumeroQuarto.Focus();
                return;
            }

            if (cbSuite.Text.ToString() == "")
            {
                MessageBox.Show("Preencha a suite.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbSuite.Focus();
                return;
            }

            if (cbQuartos.Text.ToString() == "")
            {
                MessageBox.Show("Preencha o numero de quartos.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbQuartos.Focus();
                return;
            }

            if (txtValor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha o valor.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }

            MessageBox.Show("Cadastro atualizado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnEditarQuarto.Enabled = false;
            btnExluirQuarto.Enabled = false;
            btnSalvarQuarto.Enabled = false;
            btnNovoQuarto.Enabled = true;
            DesabilitarCampos();
            LimparCampos();
        }

        private void btnExluirQuarto_Click(object sender, EventArgs e)
        {
            var ExcluirQuarto = MessageBox.Show("Deseja realmente excluir este quarto?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(ExcluirQuarto == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro ecluido com sucesso.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEditarQuarto.Enabled = false;
                btnExluirQuarto.Enabled = false;
                btnSalvarQuarto.Enabled = false;
                btnNovoQuarto.Enabled = true;
                DesabilitarCampos();
                LimparCampos();
            }
        }
    }
}
