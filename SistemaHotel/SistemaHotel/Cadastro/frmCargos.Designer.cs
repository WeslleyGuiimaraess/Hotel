namespace SistemaHotel.Cadastro
{
    partial class frmCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCargo = new System.Windows.Forms.TextBox();
            this.dgCargos = new System.Windows.Forms.DataGridView();
            this.btnNovoCargo = new System.Windows.Forms.Button();
            this.btnSalvarCargo = new System.Windows.Forms.Button();
            this.btnEditarCargo = new System.Windows.Forms.Button();
            this.btnExcluirCargo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeCargo
            // 
            this.txtNomeCargo.Enabled = false;
            this.txtNomeCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCargo.Location = new System.Drawing.Point(85, 18);
            this.txtNomeCargo.Name = "txtNomeCargo";
            this.txtNomeCargo.Size = new System.Drawing.Size(299, 29);
            this.txtNomeCargo.TabIndex = 1;
            // 
            // dgCargos
            // 
            this.dgCargos.BackgroundColor = System.Drawing.Color.White;
            this.dgCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCargos.Location = new System.Drawing.Point(16, 68);
            this.dgCargos.Name = "dgCargos";
            this.dgCargos.Size = new System.Drawing.Size(368, 448);
            this.dgCargos.TabIndex = 2;
            this.dgCargos.Click += new System.EventHandler(this.dgCargos_Click);
            // 
            // btnNovoCargo
            // 
            this.btnNovoCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoCargo.FlatAppearance.BorderSize = 0;
            this.btnNovoCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCargo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCargo.Image")));
            this.btnNovoCargo.Location = new System.Drawing.Point(402, 68);
            this.btnNovoCargo.Name = "btnNovoCargo";
            this.btnNovoCargo.Size = new System.Drawing.Size(75, 75);
            this.btnNovoCargo.TabIndex = 3;
            this.btnNovoCargo.UseVisualStyleBackColor = true;
            this.btnNovoCargo.Click += new System.EventHandler(this.btnNovoCargo_Click);
            // 
            // btnSalvarCargo
            // 
            this.btnSalvarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarCargo.Enabled = false;
            this.btnSalvarCargo.FlatAppearance.BorderSize = 0;
            this.btnSalvarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCargo.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCargo.Image")));
            this.btnSalvarCargo.Location = new System.Drawing.Point(402, 169);
            this.btnSalvarCargo.Name = "btnSalvarCargo";
            this.btnSalvarCargo.Size = new System.Drawing.Size(75, 75);
            this.btnSalvarCargo.TabIndex = 4;
            this.btnSalvarCargo.UseVisualStyleBackColor = true;
            this.btnSalvarCargo.Click += new System.EventHandler(this.btnSalvarCargo_Click);
            // 
            // btnEditarCargo
            // 
            this.btnEditarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarCargo.Enabled = false;
            this.btnEditarCargo.FlatAppearance.BorderSize = 0;
            this.btnEditarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCargo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCargo.Image")));
            this.btnEditarCargo.Location = new System.Drawing.Point(402, 270);
            this.btnEditarCargo.Name = "btnEditarCargo";
            this.btnEditarCargo.Size = new System.Drawing.Size(75, 75);
            this.btnEditarCargo.TabIndex = 5;
            this.btnEditarCargo.UseVisualStyleBackColor = true;
            this.btnEditarCargo.Click += new System.EventHandler(this.btnEditarCargo_Click);
            // 
            // btnExcluirCargo
            // 
            this.btnExcluirCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirCargo.Enabled = false;
            this.btnExcluirCargo.FlatAppearance.BorderSize = 0;
            this.btnExcluirCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCargo.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCargo.Image")));
            this.btnExcluirCargo.Location = new System.Drawing.Point(402, 371);
            this.btnExcluirCargo.Name = "btnExcluirCargo";
            this.btnExcluirCargo.Size = new System.Drawing.Size(75, 75);
            this.btnExcluirCargo.TabIndex = 6;
            this.btnExcluirCargo.UseVisualStyleBackColor = true;
            this.btnExcluirCargo.Click += new System.EventHandler(this.btnExcluirCargo_Click);
            // 
            // frmCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(490, 528);
            this.Controls.Add(this.btnExcluirCargo);
            this.Controls.Add(this.btnEditarCargo);
            this.Controls.Add(this.btnSalvarCargo);
            this.Controls.Add(this.btnNovoCargo);
            this.Controls.Add(this.dgCargos);
            this.Controls.Add(this.txtNomeCargo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargos";
            ((System.ComponentModel.ISupportInitialize)(this.dgCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCargo;
        private System.Windows.Forms.DataGridView dgCargos;
        private System.Windows.Forms.Button btnNovoCargo;
        private System.Windows.Forms.Button btnSalvarCargo;
        private System.Windows.Forms.Button btnEditarCargo;
        private System.Windows.Forms.Button btnExcluirCargo;
    }
}