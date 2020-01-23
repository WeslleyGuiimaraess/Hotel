namespace SistemaHotel.Cadastro
{
    partial class frmQuartos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuartos));
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroQuarto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSuite = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbQuartos = new System.Windows.Forms.ComboBox();
            this.dgQuartos = new System.Windows.Forms.DataGridView();
            this.btnExluirQuarto = new System.Windows.Forms.Button();
            this.btnEditarQuarto = new System.Windows.Forms.Button();
            this.btnSalvarQuarto = new System.Windows.Forms.Button();
            this.btnNovoQuarto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Enabled = false;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(364, 24);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(322, 22);
            this.txtPesquisa.TabIndex = 5;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.Location = new System.Drawing.Point(239, 25);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(119, 20);
            this.rbNao.TabIndex = 4;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Pesquisar NÃO";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.CheckedChanged += new System.EventHandler(this.rbNao_CheckedChanged);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.Location = new System.Drawing.Point(102, 25);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(113, 20);
            this.rbSim.TabIndex = 3;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Pesquisar SIM";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número do quarto:";
            // 
            // txtNumeroQuarto
            // 
            this.txtNumeroQuarto.Enabled = false;
            this.txtNumeroQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroQuarto.Location = new System.Drawing.Point(137, 69);
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.Size = new System.Drawing.Size(123, 22);
            this.txtNumeroQuarto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Suite(s):";
            // 
            // cbSuite
            // 
            this.cbSuite.Enabled = false;
            this.cbSuite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuite.FormattingEnabled = true;
            this.cbSuite.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbSuite.Location = new System.Drawing.Point(341, 69);
            this.cbSuite.Name = "cbSuite";
            this.cbSuite.Size = new System.Drawing.Size(121, 24);
            this.cbSuite.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quarto(s):";
            // 
            // cbQuartos
            // 
            this.cbQuartos.Enabled = false;
            this.cbQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuartos.FormattingEnabled = true;
            this.cbQuartos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbQuartos.Location = new System.Drawing.Point(565, 69);
            this.cbQuartos.Name = "cbQuartos";
            this.cbQuartos.Size = new System.Drawing.Size(121, 24);
            this.cbQuartos.TabIndex = 11;
            // 
            // dgQuartos
            // 
            this.dgQuartos.BackgroundColor = System.Drawing.Color.White;
            this.dgQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuartos.Location = new System.Drawing.Point(15, 149);
            this.dgQuartos.Name = "dgQuartos";
            this.dgQuartos.Size = new System.Drawing.Size(671, 210);
            this.dgQuartos.TabIndex = 12;
            this.dgQuartos.Click += new System.EventHandler(this.dgQuartos_Click);
            // 
            // btnExluirQuarto
            // 
            this.btnExluirQuarto.BackColor = System.Drawing.Color.Transparent;
            this.btnExluirQuarto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExluirQuarto.Enabled = false;
            this.btnExluirQuarto.FlatAppearance.BorderSize = 0;
            this.btnExluirQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExluirQuarto.Image = ((System.Drawing.Image)(resources.GetObject("btnExluirQuarto.Image")));
            this.btnExluirQuarto.Location = new System.Drawing.Point(703, 282);
            this.btnExluirQuarto.Name = "btnExluirQuarto";
            this.btnExluirQuarto.Size = new System.Drawing.Size(76, 75);
            this.btnExluirQuarto.TabIndex = 25;
            this.btnExluirQuarto.UseVisualStyleBackColor = false;
            this.btnExluirQuarto.Click += new System.EventHandler(this.btnExluirQuarto_Click);
            // 
            // btnEditarQuarto
            // 
            this.btnEditarQuarto.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarQuarto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarQuarto.Enabled = false;
            this.btnEditarQuarto.FlatAppearance.BorderSize = 0;
            this.btnEditarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarQuarto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarQuarto.Image")));
            this.btnEditarQuarto.Location = new System.Drawing.Point(703, 196);
            this.btnEditarQuarto.Name = "btnEditarQuarto";
            this.btnEditarQuarto.Size = new System.Drawing.Size(76, 75);
            this.btnEditarQuarto.TabIndex = 24;
            this.btnEditarQuarto.UseVisualStyleBackColor = false;
            this.btnEditarQuarto.Click += new System.EventHandler(this.btnEditarQuarto_Click);
            // 
            // btnSalvarQuarto
            // 
            this.btnSalvarQuarto.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarQuarto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarQuarto.Enabled = false;
            this.btnSalvarQuarto.FlatAppearance.BorderSize = 0;
            this.btnSalvarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarQuarto.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarQuarto.Image")));
            this.btnSalvarQuarto.Location = new System.Drawing.Point(703, 110);
            this.btnSalvarQuarto.Name = "btnSalvarQuarto";
            this.btnSalvarQuarto.Size = new System.Drawing.Size(76, 75);
            this.btnSalvarQuarto.TabIndex = 23;
            this.btnSalvarQuarto.UseVisualStyleBackColor = false;
            this.btnSalvarQuarto.Click += new System.EventHandler(this.btnSalvarQuarto_Click);
            // 
            // btnNovoQuarto
            // 
            this.btnNovoQuarto.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoQuarto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoQuarto.FlatAppearance.BorderSize = 0;
            this.btnNovoQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoQuarto.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoQuarto.Image")));
            this.btnNovoQuarto.Location = new System.Drawing.Point(703, 24);
            this.btnNovoQuarto.Name = "btnNovoQuarto";
            this.btnNovoQuarto.Size = new System.Drawing.Size(76, 75);
            this.btnNovoQuarto.TabIndex = 22;
            this.btnNovoQuarto.UseVisualStyleBackColor = false;
            this.btnNovoQuarto.Click += new System.EventHandler(this.btnNovoQuarto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(137, 107);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(123, 22);
            this.txtValor.TabIndex = 27;
            // 
            // frmQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 370);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExluirQuarto);
            this.Controls.Add(this.btnEditarQuarto);
            this.Controls.Add(this.btnSalvarQuarto);
            this.Controls.Add(this.btnNovoQuarto);
            this.Controls.Add(this.dgQuartos);
            this.Controls.Add(this.cbQuartos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSuite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroQuarto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuartos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quartos";
            this.Load += new System.EventHandler(this.frmQuartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgQuartos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroQuarto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSuite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbQuartos;
        private System.Windows.Forms.DataGridView dgQuartos;
        private System.Windows.Forms.Button btnExluirQuarto;
        private System.Windows.Forms.Button btnEditarQuarto;
        private System.Windows.Forms.Button btnSalvarQuarto;
        private System.Windows.Forms.Button btnNovoQuarto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
    }
}