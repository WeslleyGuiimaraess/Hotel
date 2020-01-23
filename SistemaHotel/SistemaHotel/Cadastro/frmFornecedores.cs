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
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
            rbPesquisaNao.Checked = false;
        }

        private void HabilitarCampos()
        {
            txtNomeFornecedor.Enabled = true;
            txtEnderecoFornecedor.Enabled = true;
            txtTelefone.Enabled = true;
            txtNomeFornecedor.Focus();
        }

        private void DesbilitarCampos()
        {
            txtNomeFornecedor.Enabled = false;
            txtEnderecoFornecedor.Enabled = false;
            txtTelefone.Enabled = false;
            btnNovoFornecedor.Enabled = true;
        }

        private void LimparCampos()
        {
            txtNomeFornecedor.Text = "";
            txtEnderecoFornecedor.Text = "";
            txtTelefone.Text = "";
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvarFornecedor.Enabled = true;
            btnNovoFornecedor.Enabled = false;
        }

        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeFornecedor.Text = "";
                txtNomeFornecedor.Focus();
                return;
            }

            if (txtEnderecoFornecedor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o endereço.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnderecoFornecedor.Text = "";
                txtEnderecoFornecedor.Focus();
                return;
            }

            if (txtTelefone.Text.ToString().Trim() == "(  )     -")
            {
                MessageBox.Show("Preencha o telefone.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
                return;
            }

            MessageBox.Show("Cadastro salvo com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            DesbilitarCampos();
            LimparCampos();
            btnSalvarFornecedor.Enabled = false;
        }

        private void dgFornecedor_Click(object sender, EventArgs e)
        {
            btnEditarFornecedor.Enabled = true;
            btnExluirFornecedor.Enabled = true;
            btnNovoFornecedor.Enabled = false;
            btnSalvarFornecedor.Enabled = false;
            HabilitarCampos();
        }

        private void btnEditarFornecedor_Click(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeFornecedor.Text = "";
                txtNomeFornecedor.Focus();
                return;
            }

            if (txtEnderecoFornecedor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o endereço.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnderecoFornecedor.Text = "";
                txtEnderecoFornecedor.Focus();
                return;
            }

            if (txtTelefone.Text.ToString().Trim() == "(  )     -")
            {
                MessageBox.Show("Preencha o telefone.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
                return;

            }

            MessageBox.Show("Cadastro atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btnSalvarFornecedor.Enabled = false;
            btnEditarFornecedor.Enabled = false;
            btnExluirFornecedor.Enabled = false;
            DesbilitarCampos();
            LimparCampos();
        }

        private void btnExluirFornecedor_Click(object sender, EventArgs e)
        {
            var ExcluirCadastro = MessageBox.Show("Deseja realmente excluir o registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ExcluirCadastro == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro excluido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSalvarFornecedor.Enabled = false;
                btnEditarFornecedor.Enabled = false;
                btnExluirFornecedor.Enabled = false;
                DesbilitarCampos();
                LimparCampos();
            }
        }

        private void rbPesquisaSim_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = true;
        }

        private void rbPesquisaNao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = false;
        }
    }
}
