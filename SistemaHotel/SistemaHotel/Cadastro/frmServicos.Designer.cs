namespace SistemaHotel.Cadastro
{
    partial class frmServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgServicos = new System.Windows.Forms.DataGridView();
            this.btnExcluirServico = new System.Windows.Forms.Button();
            this.btnEditarServico = new System.Windows.Forms.Button();
            this.btnSalvarServico = new System.Windows.Forms.Button();
            this.btnNovoServico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(69, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(243, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(389, 15);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(243, 26);
            this.txtValor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // dgServicos
            // 
            this.dgServicos.BackgroundColor = System.Drawing.Color.White;
            this.dgServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServicos.Location = new System.Drawing.Point(12, 59);
            this.dgServicos.Name = "dgServicos";
            this.dgServicos.Size = new System.Drawing.Size(620, 378);
            this.dgServicos.TabIndex = 4;
            this.dgServicos.Click += new System.EventHandler(this.dgServicos_Click);
            // 
            // btnExcluirServico
            // 
            this.btnExcluirServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirServico.Enabled = false;
            this.btnExcluirServico.FlatAppearance.BorderSize = 0;
            this.btnExcluirServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirServico.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirServico.Image")));
            this.btnExcluirServico.Location = new System.Drawing.Point(638, 362);
            this.btnExcluirServico.Name = "btnExcluirServico";
            this.btnExcluirServico.Size = new System.Drawing.Size(75, 75);
            this.btnExcluirServico.TabIndex = 10;
            this.btnExcluirServico.UseVisualStyleBackColor = true;
            this.btnExcluirServico.Click += new System.EventHandler(this.btnExcluirServico_Click);
            // 
            // btnEditarServico
            // 
            this.btnEditarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarServico.Enabled = false;
            this.btnEditarServico.FlatAppearance.BorderSize = 0;
            this.btnEditarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarServico.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarServico.Image")));
            this.btnEditarServico.Location = new System.Drawing.Point(638, 261);
            this.btnEditarServico.Name = "btnEditarServico";
            this.btnEditarServico.Size = new System.Drawing.Size(75, 75);
            this.btnEditarServico.TabIndex = 9;
            this.btnEditarServico.UseVisualStyleBackColor = true;
            this.btnEditarServico.Click += new System.EventHandler(this.btnEditarServico_Click);
            // 
            // btnSalvarServico
            // 
            this.btnSalvarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarServico.Enabled = false;
            this.btnSalvarServico.FlatAppearance.BorderSize = 0;
            this.btnSalvarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarServico.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarServico.Image")));
            this.btnSalvarServico.Location = new System.Drawing.Point(638, 160);
            this.btnSalvarServico.Name = "btnSalvarServico";
            this.btnSalvarServico.Size = new System.Drawing.Size(75, 75);
            this.btnSalvarServico.TabIndex = 8;
            this.btnSalvarServico.UseVisualStyleBackColor = true;
            this.btnSalvarServico.Click += new System.EventHandler(this.btnSalvarServico_Click);
            // 
            // btnNovoServico
            // 
            this.btnNovoServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoServico.FlatAppearance.BorderSize = 0;
            this.btnNovoServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoServico.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoServico.Image")));
            this.btnNovoServico.Location = new System.Drawing.Point(638, 59);
            this.btnNovoServico.Name = "btnNovoServico";
            this.btnNovoServico.Size = new System.Drawing.Size(75, 75);
            this.btnNovoServico.TabIndex = 7;
            this.btnNovoServico.UseVisualStyleBackColor = true;
            this.btnNovoServico.Click += new System.EventHandler(this.btnNovoServico_Click);
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 446);
            this.Controls.Add(this.btnExcluirServico);
            this.Controls.Add(this.btnEditarServico);
            this.Controls.Add(this.btnSalvarServico);
            this.Controls.Add(this.btnNovoServico);
            this.Controls.Add(this.dgServicos);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicos";
            this.Load += new System.EventHandler(this.frmServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgServicos;
        private System.Windows.Forms.Button btnExcluirServico;
        private System.Windows.Forms.Button btnEditarServico;
        private System.Windows.Forms.Button btnSalvarServico;
        private System.Windows.Forms.Button btnNovoServico;
    }
}