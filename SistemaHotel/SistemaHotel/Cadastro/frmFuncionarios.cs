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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            cbCargo.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            cbCargo.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            foreach (Control Componente in this.Controls)
            {
                if (Componente is ComboBox)
                {
                    (Componente as ComboBox).SelectedIndex = -1;
                }
            }
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesNome.Visible = true;
            txtPesCpf.Visible = false;

            txtPesNome.Text = "";
            txtPesCpf.Text = "";
        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {
            txtPesCpf.Visible = true;
            txtPesNome.Visible = false;

            txtPesCpf.Text = "";
            txtPesNome.Text = "";
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            rbNome.Checked = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtCpf.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o Cpf.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Focus();
                return;
            }

            if (txtEndereco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Endereço.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndereco.Text = "";
                txtEndereco.Focus();
                return;
            }

            if (txtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o Telefone", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
                return;
            }

            if (cbCargo.Text.ToString() == "")
            {
                MessageBox.Show("Preencha o cargo.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbCargo.Focus();
                return;
            }

            MessageBox.Show("Cadastro salvo com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            DesabilitarCampos();
            LimparCampos();
            btnSalvar.Enabled = false;
        }

        private void dgFuncionario_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = false;
            HabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtCpf.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o cpf.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Focus();
                return;
            }

            if (txtEndereco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o endereço.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndereco.Text = "";
                txtEndereco.Focus();
                return;
            }

            if (txtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o telefone.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
                return;
            }

            if (cbCargo.Text.ToString() == "")
            {
                MessageBox.Show("Preencha o cargo.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbCargo.Focus();
                return;
            }

            MessageBox.Show("Cadastro atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro excluido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btnSalvar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
            }
        }
    }
}
