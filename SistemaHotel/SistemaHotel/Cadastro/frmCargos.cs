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
    public partial class frmCargos : Form
    {
        public frmCargos()
        {
            InitializeComponent();
        }

        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            txtNomeCargo.Enabled = true;
            btnSalvarCargo.Enabled = true;
            btnNovoCargo.Enabled = false;
        }

        private void btnSalvarCargo_Click(object sender, EventArgs e)
        {
            if (txtNomeCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCargo.Text = "";
                txtNomeCargo.Focus();
                return;
            }

            MessageBox.Show("Cadastro salvo com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtNomeCargo.Text = "";

            btnNovoCargo.Enabled = true;
            btnSalvarCargo.Enabled = false;
            txtNomeCargo.Text = "";
        }


        private void btnEditarCargo_Click(object sender, EventArgs e)
        {
            if (txtNomeCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecha o nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCargo.Text = "";
                txtNomeCargo.Focus();
                return;
            }

            MessageBox.Show("Cadastro atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtNomeCargo.Text = "";

            btnNovoCargo.Enabled = true;
            btnSalvarCargo.Enabled = false;
            txtNomeCargo.Text = "";
            btnEditarCargo.Enabled = false;
            btnExcluirCargo.Enabled = false;
        }

        private void btnExcluirCargo_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro excluido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeCargo.Text = "";
                btnNovoCargo.Enabled = true;
                btnSalvarCargo.Enabled = false;
                btnEditarCargo.Enabled = false;
                btnExcluirCargo.Enabled = false;
                txtNomeCargo.Text = "";
            }
        }

        private void dgCargos_Click(object sender, EventArgs e)
        {
            btnEditarCargo.Enabled = true;
            btnExcluirCargo.Enabled = true;
            btnSalvarCargo.Enabled = false;
            btnNovoCargo.Enabled = false;
            txtNomeCargo.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
