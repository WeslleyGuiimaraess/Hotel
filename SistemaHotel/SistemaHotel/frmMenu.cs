using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlTopo.BackColor = Color.FromArgb(230, 230, 230);
            pnlLateral.BackColor = Color.FromArgb(130, 130, 130);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.frmFuncionarios func = new Cadastro.frmFuncionarios();
            func.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.frmCargos ChamarCargo = new Cadastro.frmCargos();
            ChamarCargo.Show();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.frmProdutos ChamarProdutos = new Cadastro.frmProdutos();
            ChamarProdutos.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Cadastro.frmProdutos ChamarProdutos = new Cadastro.frmProdutos();
            ChamarProdutos.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.frmFornecedores ChamarFornecedor = new Cadastro.frmFornecedores();
            ChamarFornecedor.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.frmUsuarios ChamarUser = new Cadastro.frmUsuarios();
            ChamarUser.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.frmServicos ChamarServico = new Cadastro.frmServicos();
            ChamarServico.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.frmEstoque ChamarEstoque = new Cadastro.frmEstoque();
            ChamarEstoque.Show();
        }

        private void hospedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.frmHospede ChamarHospede = new Cadastro.frmHospede();
            ChamarHospede.Show();
        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.frmQuartos ChamarQuartos = new Cadastro.frmQuartos();
            ChamarQuartos.Show();
        }
    }
}
