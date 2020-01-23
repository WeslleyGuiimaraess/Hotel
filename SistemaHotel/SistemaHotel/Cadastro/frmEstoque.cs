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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void HabilitarCampos()
        {
            txtProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;
            txtEstoque.Enabled = true;
            cbFornecedor.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;
            txtEstoque.Enabled = false;
            cbFornecedor.Enabled = false;
        }

        private void LimparCampos()
        {
            txtProduto.Text = "";
            txtEstoque.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            foreach (Control Componente in this.Controls)
            {
                if (Componente is ComboBox)
                {
                    (Componente as ComboBox).SelectedIndex = -1;
                }
            }
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvarEstoque.Enabled = true;
        }

        private void btnSalvarEstoque_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha o produto", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduto.Text = "";
                txtProduto.Focus();
                return;
            }

            if (cbFornecedor.Text.ToString() == "")
            {
                MessageBox.Show("Preecnha o fornecedor.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbFornecedor.Focus();
                return;
            }

            if (txtEstoque.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha o estoque.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEstoque.Text = "";
                txtEstoque.Focus();
                return;
            }

            if (txtQuantidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha a quantidade.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantidade.Text = "";
                txtQuantidade.Focus();
                return;
            }

            if (txtValor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o valor.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            btnSalvarEstoque.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
        }
    }
}
