namespace SistemaHotel.Cadastro
{
    partial class frmHospede
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHospede));
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dgHospedes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumAdu = new System.Windows.Forms.TextBox();
            this.txtNumCrianca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExluirHospede = new System.Windows.Forms.Button();
            this.btnEditarHospede = new System.Windows.Forms.Button();
            this.btnSalvarHospede = new System.Windows.Forms.Button();
            this.btnNovoHospede = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.Location = new System.Drawing.Point(243, 26);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(113, 20);
            this.rbSim.TabIndex = 0;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Pesquisar SIM";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.Location = new System.Drawing.Point(380, 26);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(119, 20);
            this.rbNao.TabIndex = 1;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Pesquisar NÃO";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.CheckedChanged += new System.EventHandler(this.rbNao_CheckedChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Enabled = false;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(505, 25);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(322, 22);
            this.txtPesquisa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(83, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(273, 22);
            this.txtNome.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(453, 62);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(374, 22);
            this.txtEndereco.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(83, 106);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 22);
            this.txtTelefone.TabIndex = 8;
            // 
            // dgHospedes
            // 
            this.dgHospedes.BackgroundColor = System.Drawing.Color.White;
            this.dgHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHospedes.Location = new System.Drawing.Point(15, 146);
            this.dgHospedes.Name = "dgHospedes";
            this.dgHospedes.Size = new System.Drawing.Size(812, 227);
            this.dgHospedes.TabIndex = 9;
            this.dgHospedes.Click += new System.EventHandler(this.dgHospedes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Número de adultos:";
            // 
            // txtNumAdu
            // 
            this.txtNumAdu.Enabled = false;
            this.txtNumAdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAdu.Location = new System.Drawing.Point(339, 106);
            this.txtNumAdu.Name = "txtNumAdu";
            this.txtNumAdu.Size = new System.Drawing.Size(160, 22);
            this.txtNumAdu.TabIndex = 11;
            // 
            // txtNumCrianca
            // 
            this.txtNumCrianca.Enabled = false;
            this.txtNumCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCrianca.Location = new System.Drawing.Point(651, 106);
            this.txtNumCrianca.Name = "txtNumCrianca";
            this.txtNumCrianca.Size = new System.Drawing.Size(176, 22);
            this.txtNumCrianca.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Número de crianças:";
            // 
            // btnExluirHospede
            // 
            this.btnExluirHospede.BackColor = System.Drawing.Color.Transparent;
            this.btnExluirHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExluirHospede.Enabled = false;
            this.btnExluirHospede.FlatAppearance.BorderSize = 0;
            this.btnExluirHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExluirHospede.Image = ((System.Drawing.Image)(resources.GetObject("btnExluirHospede.Image")));
            this.btnExluirHospede.Location = new System.Drawing.Point(533, 390);
            this.btnExluirHospede.Name = "btnExluirHospede";
            this.btnExluirHospede.Size = new System.Drawing.Size(76, 75);
            this.btnExluirHospede.TabIndex = 21;
            this.btnExluirHospede.UseVisualStyleBackColor = false;
            this.btnExluirHospede.Click += new System.EventHandler(this.btnExluirHospede_Click);
            // 
            // btnEditarHospede
            // 
            this.btnEditarHospede.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarHospede.Enabled = false;
            this.btnEditarHospede.FlatAppearance.BorderSize = 0;
            this.btnEditarHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarHospede.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarHospede.Image")));
            this.btnEditarHospede.Location = new System.Drawing.Point(428, 390);
            this.btnEditarHospede.Name = "btnEditarHospede";
            this.btnEditarHospede.Size = new System.Drawing.Size(76, 75);
            this.btnEditarHospede.TabIndex = 20;
            this.btnEditarHospede.UseVisualStyleBackColor = false;
            this.btnEditarHospede.Click += new System.EventHandler(this.btnEditarHospede_Click);
            // 
            // btnSalvarHospede
            // 
            this.btnSalvarHospede.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarHospede.Enabled = false;
            this.btnSalvarHospede.FlatAppearance.BorderSize = 0;
            this.btnSalvarHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarHospede.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarHospede.Image")));
            this.btnSalvarHospede.Location = new System.Drawing.Point(323, 390);
            this.btnSalvarHospede.Name = "btnSalvarHospede";
            this.btnSalvarHospede.Size = new System.Drawing.Size(76, 75);
            this.btnSalvarHospede.TabIndex = 19;
            this.btnSalvarHospede.UseVisualStyleBackColor = false;
            this.btnSalvarHospede.Click += new System.EventHandler(this.btnSalvarHospede_Click);
            // 
            // btnNovoHospede
            // 
            this.btnNovoHospede.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoHospede.FlatAppearance.BorderSize = 0;
            this.btnNovoHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoHospede.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoHospede.Image")));
            this.btnNovoHospede.Location = new System.Drawing.Point(218, 390);
            this.btnNovoHospede.Name = "btnNovoHospede";
            this.btnNovoHospede.Size = new System.Drawing.Size(76, 75);
            this.btnNovoHospede.TabIndex = 18;
            this.btnNovoHospede.UseVisualStyleBackColor = false;
            this.btnNovoHospede.Click += new System.EventHandler(this.btnNovoHospede_Click);
            // 
            // frmHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 472);
            this.Controls.Add(this.btnExluirHospede);
            this.Controls.Add(this.btnEditarHospede);
            this.Controls.Add(this.btnSalvarHospede);
            this.Controls.Add(this.btnNovoHospede);
            this.Controls.Add(this.txtNumCrianca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumAdu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgHospedes);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHospede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospede";
            this.Load += new System.EventHandler(this.frmHospede_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.DataGridView dgHospedes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumAdu;
        private System.Windows.Forms.TextBox txtNumCrianca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExluirHospede;
        private System.Windows.Forms.Button btnEditarHospede;
        private System.Windows.Forms.Button btnSalvarHospede;
        private System.Windows.Forms.Button btnNovoHospede;
    }
}