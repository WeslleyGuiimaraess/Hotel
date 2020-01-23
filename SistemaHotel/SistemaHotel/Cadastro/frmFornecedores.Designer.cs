namespace SistemaHotel.Cadastro
{
    partial class frmFornecedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedores));
            this.rbPesquisaSim = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnderecoFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dgFornecedor = new System.Windows.Forms.DataGridView();
            this.btnExluirFornecedor = new System.Windows.Forms.Button();
            this.btnEditarFornecedor = new System.Windows.Forms.Button();
            this.btnSalvarFornecedor = new System.Windows.Forms.Button();
            this.btnNovoFornecedor = new System.Windows.Forms.Button();
            this.rbPesquisaNao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // rbPesquisaSim
            // 
            this.rbPesquisaSim.AutoSize = true;
            this.rbPesquisaSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPesquisaSim.Location = new System.Drawing.Point(354, 13);
            this.rbPesquisaSim.Name = "rbPesquisaSim";
            this.rbPesquisaSim.Size = new System.Drawing.Size(134, 24);
            this.rbPesquisaSim.TabIndex = 0;
            this.rbPesquisaSim.TabStop = true;
            this.rbPesquisaSim.Text = "Pesquisar SIM:";
            this.rbPesquisaSim.UseVisualStyleBackColor = true;
            this.rbPesquisaSim.CheckedChanged += new System.EventHandler(this.rbPesquisaSim_CheckedChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Enabled = false;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(667, 12);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(254, 26);
            this.txtPesquisa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Enabled = false;
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFornecedor.Location = new System.Drawing.Point(73, 59);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(285, 26);
            this.txtNomeFornecedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Endereço:";
            // 
            // txtEnderecoFornecedor
            // 
            this.txtEnderecoFornecedor.Enabled = false;
            this.txtEnderecoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoFornecedor.Location = new System.Drawing.Point(474, 59);
            this.txtEnderecoFornecedor.Name = "txtEnderecoFornecedor";
            this.txtEnderecoFornecedor.Size = new System.Drawing.Size(447, 26);
            this.txtEnderecoFornecedor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(939, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(1020, 59);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(119, 26);
            this.txtTelefone.TabIndex = 7;
            // 
            // dgFornecedor
            // 
            this.dgFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.dgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedor.Location = new System.Drawing.Point(16, 102);
            this.dgFornecedor.Name = "dgFornecedor";
            this.dgFornecedor.Size = new System.Drawing.Size(1123, 259);
            this.dgFornecedor.TabIndex = 8;
            this.dgFornecedor.Click += new System.EventHandler(this.dgFornecedor_Click);
            // 
            // btnExluirFornecedor
            // 
            this.btnExluirFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnExluirFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExluirFornecedor.Enabled = false;
            this.btnExluirFornecedor.FlatAppearance.BorderSize = 0;
            this.btnExluirFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExluirFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnExluirFornecedor.Image")));
            this.btnExluirFornecedor.Location = new System.Drawing.Point(669, 388);
            this.btnExluirFornecedor.Name = "btnExluirFornecedor";
            this.btnExluirFornecedor.Size = new System.Drawing.Size(75, 75);
            this.btnExluirFornecedor.TabIndex = 21;
            this.btnExluirFornecedor.UseVisualStyleBackColor = false;
            this.btnExluirFornecedor.Click += new System.EventHandler(this.btnExluirFornecedor_Click);
            // 
            // btnEditarFornecedor
            // 
            this.btnEditarFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarFornecedor.Enabled = false;
            this.btnEditarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnEditarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarFornecedor.Image")));
            this.btnEditarFornecedor.Location = new System.Drawing.Point(564, 388);
            this.btnEditarFornecedor.Name = "btnEditarFornecedor";
            this.btnEditarFornecedor.Size = new System.Drawing.Size(75, 75);
            this.btnEditarFornecedor.TabIndex = 20;
            this.btnEditarFornecedor.UseVisualStyleBackColor = false;
            this.btnEditarFornecedor.Click += new System.EventHandler(this.btnEditarFornecedor_Click);
            // 
            // btnSalvarFornecedor
            // 
            this.btnSalvarFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarFornecedor.Enabled = false;
            this.btnSalvarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnSalvarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarFornecedor.Image")));
            this.btnSalvarFornecedor.Location = new System.Drawing.Point(459, 388);
            this.btnSalvarFornecedor.Name = "btnSalvarFornecedor";
            this.btnSalvarFornecedor.Size = new System.Drawing.Size(75, 75);
            this.btnSalvarFornecedor.TabIndex = 19;
            this.btnSalvarFornecedor.UseVisualStyleBackColor = false;
            this.btnSalvarFornecedor.Click += new System.EventHandler(this.btnSalvarFornecedor_Click);
            // 
            // btnNovoFornecedor
            // 
            this.btnNovoFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoFornecedor.FlatAppearance.BorderSize = 0;
            this.btnNovoFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoFornecedor.Image")));
            this.btnNovoFornecedor.Location = new System.Drawing.Point(354, 388);
            this.btnNovoFornecedor.Name = "btnNovoFornecedor";
            this.btnNovoFornecedor.Size = new System.Drawing.Size(75, 75);
            this.btnNovoFornecedor.TabIndex = 18;
            this.btnNovoFornecedor.UseVisualStyleBackColor = false;
            this.btnNovoFornecedor.Click += new System.EventHandler(this.btnNovoFornecedor_Click);
            // 
            // rbPesquisaNao
            // 
            this.rbPesquisaNao.AutoSize = true;
            this.rbPesquisaNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPesquisaNao.Location = new System.Drawing.Point(505, 13);
            this.rbPesquisaNao.Name = "rbPesquisaNao";
            this.rbPesquisaNao.Size = new System.Drawing.Size(139, 24);
            this.rbPesquisaNao.TabIndex = 22;
            this.rbPesquisaNao.TabStop = true;
            this.rbPesquisaNao.Text = "Pesquisar NAO:";
            this.rbPesquisaNao.UseVisualStyleBackColor = true;
            this.rbPesquisaNao.CheckedChanged += new System.EventHandler(this.rbPesquisaNao_CheckedChanged);
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1151, 472);
            this.Controls.Add(this.rbPesquisaNao);
            this.Controls.Add(this.btnExluirFornecedor);
            this.Controls.Add(this.btnEditarFornecedor);
            this.Controls.Add(this.btnSalvarFornecedor);
            this.Controls.Add(this.btnNovoFornecedor);
            this.Controls.Add(this.dgFornecedor);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnderecoFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.rbPesquisaSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPesquisaSim;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnderecoFornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.DataGridView dgFornecedor;
        private System.Windows.Forms.Button btnExluirFornecedor;
        private System.Windows.Forms.Button btnEditarFornecedor;
        private System.Windows.Forms.Button btnSalvarFornecedor;
        private System.Windows.Forms.Button btnNovoFornecedor;
        private System.Windows.Forms.RadioButton rbPesquisaNao;
    }
}