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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            rbPesquisaNao.Checked = true;
        }

        private void rbPesquisa_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = true;
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtUser.Enabled = true;
            cbCargos.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtUser.Enabled = false;
            cbCargos.Enabled = false;
            btnNovoUsuario.Enabled = false;
        }

        private void LimparCampos()
        {
            txtUser.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            foreach (Control Componente in this.Controls)
            {
                if (Componente is ComboBox)
                {
                    (Componente as ComboBox).SelectedIndex = -1;
                }
            }
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvarUsuario.Enabled = true;
            btnNovoUsuario.Enabled = false;
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (cbCargos.Text.ToString() == "")
            {
                MessageBox.Show("Preencha o cargo.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbCargos.Focus();
                return;
            }

            if (txtUser.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o usuario.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Text = "";
                txtUser.Focus();
                return;
            }

            if (txtSenha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha a senha.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            DesabilitarCampos();
            LimparCampos();
            btnSalvarUsuario.Enabled = true;
        }

        private void dgUsuarios_Click(object sender, EventArgs e)
        {
            btnEditarUsuario.Enabled = true;
            btnExluirUsuario.Enabled = true;
            btnNovoUsuario.Enabled = false;
            btnSalvarUsuario.Enabled = false;
            HabilitarCampos();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (cbCargos.Text.ToString() == "")
            {
                MessageBox.Show("Preencha o cargo.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbCargos.Focus();
                return;
            }

            if (txtUser.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o usuario.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Text = "";
                txtUser.Focus();
                return;
            }

            if (txtSenha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha a senha.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }

            MessageBox.Show("Cadastro salvo com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btnEditarUsuario.Enabled = false;
            btnExluirUsuario.Enabled = false;
            btnSalvarUsuario.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
        }

        private void btnExluirUsuario_Click(object sender, EventArgs e)
        {
            var ExcluirUsuario = MessageBox.Show("Deseja realmente excluir o susario", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ExcluirUsuario == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro ecluido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btnSalvarUsuario.Enabled = false;
                btnEditarUsuario.Enabled = false;
                btnExluirUsuario.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
            }
        }

        private void rbPesquisaNao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = false;
        }
    }
}
