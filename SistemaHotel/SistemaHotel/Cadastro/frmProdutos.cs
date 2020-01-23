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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
            rbPesquisarNao.Checked = true;
        }


        private void HabilitarCampos()
        {
            txtNomeProduto.Enabled = true;
            txtDescricaoProduto.Enabled = true;
            txtEstoqueProduto.Enabled = true;
            txtValorProduto.Enabled = true;
            cbFornecedores.Enabled = true;
            btnImagem.Enabled = true;
            txtNomeProduto.Focus();
        }

        private void DesabilitarCampos()
        {
            txtNomeProduto.Enabled = false;
            txtDescricaoProduto.Enabled = false;
            txtValorProduto.Enabled = false;
            txtEstoqueProduto.Enabled = false;
            cbFornecedores.Enabled = false;
            btnImagem.Enabled = false;
            btnNovoProduto.Enabled = true;
        }
            
        private void LimparCampos()
        {
            txtNomeProduto.Text = "";
            txtDescricaoProduto.Text = "";
            txtValorProduto.Text = "";
            txtEstoqueProduto.Text = "";

            foreach (Control Componente in this.Controls)
            {
                if (Componente is ComboBox)
                {
                    (Componente as ComboBox).SelectedIndex = -1;
                }
            }
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnNovoProduto.Enabled = false;
            btnSalvarProduto.Enabled = true;
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeProduto.Text = "";
                txtNomeProduto.Focus();
                return;
            }

            if (txtDescricaoProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha a descrição.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricaoProduto.Text = "";
                txtDescricaoProduto.Focus();
                return;
            }

            if (txtValorProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha o valor.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorProduto.Text = "";
                txtValorProduto.Focus();
                return;
            }

            if (txtEstoqueProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha o estoque.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEstoqueProduto.Text = "";
                txtEstoqueProduto.Focus();
                return;
            }

            if (cbFornecedores.Text.ToString() == "")
            {
                MessageBox.Show("Preecnha o fornecedor.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbFornecedores.Focus();
                return;
            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            DesabilitarCampos();
            LimparCampos();
            btnSalvarProduto.Enabled = false;
        }

        private void dgProdutos_Click(object sender, EventArgs e)
        {
            btnEditarProduto.Enabled = true;
            btnExluirProduto.Enabled = true;
            btnNovoProduto.Enabled = false;
            btnSalvarProduto.Enabled = false;
            HabilitarCampos();
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeProduto.Text = "";
                txtNomeProduto.Focus();
                return;
            }

            if (txtDescricaoProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha a descrição.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricaoProduto.Text = "";
                txtDescricaoProduto.Focus();
                return;
            }

            if (txtValorProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o valor.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorProduto.Text = "";
                txtValorProduto.Focus();
                return;
            }

            if (txtEstoqueProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o estoque.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEstoqueProduto.Text = "";
                txtEstoqueProduto.Focus();
                return;
            }

            if (cbFornecedores.Text.ToString() == "")
            {
                MessageBox.Show("Preencha o fornecedor.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbFornecedores.Focus();
                return;
            }

            MessageBox.Show("Cadastro atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btnSalvarProduto.Enabled = false;
            btnEditarProduto.Enabled = false;
            btnExluirProduto.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
        }

        private void btnExluirProduto_Click(object sender, EventArgs e)
        {
            var ExcluirItemProduto = MessageBox.Show("Deseja realmente excluir o registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ExcluirItemProduto == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro excluido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btnSalvarProduto.Enabled = false;
                btnEditarProduto.Enabled = false;
                btnExluirProduto.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
            }
        }

        private void rbPesquisar_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = true;
        }

        private void rbPesquisarNao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = false;
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            rbPesquisarNao.Checked = true;
        }
    }
}
