namespace SistemaHotel.Cadastro
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstoqueProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFornecedores = new System.Windows.Forms.ComboBox();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnExluirProduto = new System.Windows.Forms.Button();
            this.btnImagem = new System.Windows.Forms.Button();
            this.rbPesquisarSim = new System.Windows.Forms.RadioButton();
            this.rbPesquisarNao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Enabled = false;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(468, 12);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(286, 26);
            this.txtPesquisa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(75, 50);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(254, 26);
            this.txtNomeProduto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Enabled = false;
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(468, 50);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(420, 26);
            this.txtDescricaoProduto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor:";
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Enabled = false;
            this.txtValorProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProduto.Location = new System.Drawing.Point(75, 95);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(254, 26);
            this.txtValorProduto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estoque:";
            // 
            // txtEstoqueProduto
            // 
            this.txtEstoqueProduto.Enabled = false;
            this.txtEstoqueProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueProduto.Location = new System.Drawing.Point(468, 92);
            this.txtEstoqueProduto.Name = "txtEstoqueProduto";
            this.txtEstoqueProduto.Size = new System.Drawing.Size(84, 26);
            this.txtEstoqueProduto.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(558, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fornecedores:";
            // 
            // cbFornecedores
            // 
            this.cbFornecedores.Enabled = false;
            this.cbFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFornecedores.FormattingEnabled = true;
            this.cbFornecedores.Items.AddRange(new object[] {
            "Coca Cola",
            "Veja"});
            this.cbFornecedores.Location = new System.Drawing.Point(676, 92);
            this.cbFornecedores.Name = "cbFornecedores";
            this.cbFornecedores.Size = new System.Drawing.Size(212, 28);
            this.cbFornecedores.TabIndex = 11;
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(903, 14);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(86, 107);
            this.pbImagem.TabIndex = 12;
            this.pbImagem.TabStop = false;
            // 
            // dgProdutos
            // 
            this.dgProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(18, 139);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(971, 188);
            this.dgProdutos.TabIndex = 13;
            this.dgProdutos.Click += new System.EventHandler(this.dgProdutos_Click);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoProduto.FlatAppearance.BorderSize = 0;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoProduto.Image")));
            this.btnNovoProduto.Location = new System.Drawing.Point(287, 347);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(76, 75);
            this.btnNovoProduto.TabIndex = 14;
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarProduto.Enabled = false;
            this.btnSalvarProduto.FlatAppearance.BorderSize = 0;
            this.btnSalvarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarProduto.Image")));
            this.btnSalvarProduto.Location = new System.Drawing.Point(392, 347);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(76, 75);
            this.btnSalvarProduto.TabIndex = 15;
            this.btnSalvarProduto.UseVisualStyleBackColor = false;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarProduto.Enabled = false;
            this.btnEditarProduto.FlatAppearance.BorderSize = 0;
            this.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProduto.Image")));
            this.btnEditarProduto.Location = new System.Drawing.Point(497, 347);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(76, 75);
            this.btnEditarProduto.TabIndex = 16;
            this.btnEditarProduto.UseVisualStyleBackColor = false;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnExluirProduto
            // 
            this.btnExluirProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnExluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExluirProduto.Enabled = false;
            this.btnExluirProduto.FlatAppearance.BorderSize = 0;
            this.btnExluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExluirProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnExluirProduto.Image")));
            this.btnExluirProduto.Location = new System.Drawing.Point(602, 347);
            this.btnExluirProduto.Name = "btnExluirProduto";
            this.btnExluirProduto.Size = new System.Drawing.Size(76, 75);
            this.btnExluirProduto.TabIndex = 17;
            this.btnExluirProduto.UseVisualStyleBackColor = false;
            this.btnExluirProduto.Click += new System.EventHandler(this.btnExluirProduto_Click);
            // 
            // btnImagem
            // 
            this.btnImagem.BackColor = System.Drawing.Color.AliceBlue;
            this.btnImagem.ForeColor = System.Drawing.Color.Black;
            this.btnImagem.Location = new System.Drawing.Point(802, 14);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(86, 25);
            this.btnImagem.TabIndex = 18;
            this.btnImagem.Text = "Imgem";
            this.btnImagem.UseVisualStyleBackColor = false;
            // 
            // rbPesquisarSim
            // 
            this.rbPesquisarSim.AutoSize = true;
            this.rbPesquisarSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPesquisarSim.Location = new System.Drawing.Point(216, 16);
            this.rbPesquisarSim.Name = "rbPesquisarSim";
            this.rbPesquisarSim.Size = new System.Drawing.Size(116, 20);
            this.rbPesquisarSim.TabIndex = 19;
            this.rbPesquisarSim.TabStop = true;
            this.rbPesquisarSim.Text = "Pesquisar Sim:";
            this.rbPesquisarSim.UseVisualStyleBackColor = true;
            this.rbPesquisarSim.CheckedChanged += new System.EventHandler(this.rbPesquisar_CheckedChanged);
            // 
            // rbPesquisarNao
            // 
            this.rbPesquisarNao.AutoSize = true;
            this.rbPesquisarNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPesquisarNao.Location = new System.Drawing.Point(338, 16);
            this.rbPesquisarNao.Name = "rbPesquisarNao";
            this.rbPesquisarNao.Size = new System.Drawing.Size(119, 20);
            this.rbPesquisarNao.TabIndex = 20;
            this.rbPesquisarNao.TabStop = true;
            this.rbPesquisarNao.Text = "Pesquisar Nao:";
            this.rbPesquisarNao.UseVisualStyleBackColor = true;
            this.rbPesquisarNao.CheckedChanged += new System.EventHandler(this.rbPesquisarNao_CheckedChanged);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(999, 434);
            this.Controls.Add(this.rbPesquisarNao);
            this.Controls.Add(this.rbPesquisarSim);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.btnExluirProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnSalvarProduto);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.cbFornecedores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEstoqueProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstoqueProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFornecedores;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnExluirProduto;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.RadioButton rbPesquisarSim;
        private System.Windows.Forms.RadioButton rbPesquisarNao;
    }
}