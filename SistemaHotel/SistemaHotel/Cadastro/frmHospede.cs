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
    public partial class frmHospede : Form
    {
        public frmHospede()
        {
            InitializeComponent();
        }

        private void frmHospede_Load(object sender, EventArgs e)
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
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumAdu.Enabled = true;
            txtNumCrianca.Enabled = true;
            txtTelefone.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumAdu.Enabled = false;
            txtNumCrianca.Enabled = false;
            txtTelefone.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumAdu.Text = "";
            txtNumCrianca.Text = "";
            txtTelefone.Text = "";
        }

        private void btnNovoHospede_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvarHospede.Enabled = true;
        }

        private void btnSalvarHospede_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtEndereco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o endereço.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndereco.Text = "";
                txtEndereco.Focus();
                return;
            }

            if (txtTelefone.Text.ToString().Trim() == "(  )     -")
            {
                MessageBox.Show("Preencha o telefone", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
                return;
            }

            if (txtNumAdu.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o número de adultos.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumAdu.Text = "";
                txtNumAdu.Focus();
                return;
            }

            if (txtNumCrianca.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o número de crianças.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumCrianca.Text = "";
                txtNumCrianca.Focus();
                return;
            }

            MessageBox.Show("Cadastro realizado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSalvarHospede.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
        }

        private void dgHospedes_Click(object sender, EventArgs e)
        {
            btnEditarHospede.Enabled = true;
            btnExluirHospede.Enabled = true;
            HabilitarCampos();
        }

        private void btnEditarHospede_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtEndereco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o endereço.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndereco.Text = "";
                txtEndereco.Focus();
                return;
            }

            if (txtTelefone.Text.ToString().Trim() == "(  )     -")
            {
                MessageBox.Show("Preencha o telefone", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
                return;
            }

            if (txtNumAdu.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o número de adultos.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumAdu.Text = "";
                txtNumAdu.Focus();
                return;
            }

            if (txtNumCrianca.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o número de crianças.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumCrianca.Text = "";
                txtNumCrianca.Focus();
                return;
            }

            MessageBox.Show("Cadastro atualizado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnEditarHospede.Enabled = false;
            btnExluirHospede.Enabled = false;
            btnSalvarHospede.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
        }

        private void btnExluirHospede_Click(object sender, EventArgs e)
        {
            var ExcluirHospede = MessageBox.Show("Deseja realmente excluir este hóspede?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ExcluirHospede == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro excluido com sucesso.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSalvarHospede.Enabled = true;
                btnEditarHospede.Enabled = true;
                btnExluirHospede.Enabled = true;
                DesabilitarCampos();
                LimparCampos();
            }
        }
    }
}
