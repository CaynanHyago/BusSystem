namespace TCC0._1
{
    partial class RelatorioDesingn
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
            this.components = new System.ComponentModel.Container();
            this.dgv_Listagem = new System.Windows.Forms.DataGridView();
            this.CodRelatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relatorioNegocioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.relatorioNegocioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConsultaRelatorio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioNegocioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioNegocioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Listagem
            // 
            this.dgv_Listagem.AutoGenerateColumns = false;
            this.dgv_Listagem.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodRelatorio,
            this.NomeFiscal,
            this.NomeMotorista,
            this.Numero,
            this.DataHora,
            this.Linha,
            this.Tabela});
            this.dgv_Listagem.DataSource = this.relatorioNegocioBindingSource1;
            this.dgv_Listagem.Location = new System.Drawing.Point(264, 195);
            this.dgv_Listagem.MultiSelect = false;
            this.dgv_Listagem.Name = "dgv_Listagem";
            this.dgv_Listagem.ReadOnly = true;
            this.dgv_Listagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Listagem.Size = new System.Drawing.Size(644, 236);
            this.dgv_Listagem.TabIndex = 3;
            this.dgv_Listagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_Listagem.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Listagem_RowEnter);
            // 
            // CodRelatorio
            // 
            this.CodRelatorio.DataPropertyName = "CodRelatorio";
            this.CodRelatorio.HeaderText = "CodRelatorio";
            this.CodRelatorio.Name = "CodRelatorio";
            this.CodRelatorio.ReadOnly = true;
            this.CodRelatorio.Visible = false;
            // 
            // NomeFiscal
            // 
            this.NomeFiscal.DataPropertyName = "NomeFiscal";
            this.NomeFiscal.HeaderText = "Fiscal";
            this.NomeFiscal.Name = "NomeFiscal";
            this.NomeFiscal.ReadOnly = true;
            // 
            // NomeMotorista
            // 
            this.NomeMotorista.DataPropertyName = "NomeMotorista";
            this.NomeMotorista.HeaderText = "Motorista";
            this.NomeMotorista.Name = "NomeMotorista";
            this.NomeMotorista.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Onibus";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // DataHora
            // 
            this.DataHora.DataPropertyName = "DiaHora";
            this.DataHora.HeaderText = "Dia/Hora";
            this.DataHora.Name = "DataHora";
            this.DataHora.ReadOnly = true;
            // 
            // Linha
            // 
            this.Linha.DataPropertyName = "Linha";
            this.Linha.HeaderText = "Linha";
            this.Linha.Name = "Linha";
            this.Linha.ReadOnly = true;
            // 
            // Tabela
            // 
            this.Tabela.DataPropertyName = "Tabela";
            this.Tabela.HeaderText = "Tabela";
            this.Tabela.Name = "Tabela";
            this.Tabela.ReadOnly = true;
            // 
            // relatorioNegocioBindingSource1
            // 
            this.relatorioNegocioBindingSource1.DataSource = typeof(Negocios.RelatorioNegocio);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TCC0._1.Properties.Resources.BTNPESQUISARREALMESMO;
            this.pictureBox1.Location = new System.Drawing.Point(320, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TCC0._1.Properties.Resources.BTNVOLTARREALMSM;
            this.pictureBox2.Location = new System.Drawing.Point(864, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TCC0._1.Properties.Resources.BTNALTERAR1;
            this.pictureBox3.Location = new System.Drawing.Point(282, 437);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::TCC0._1.Properties.Resources.BTNEXCLUIR2;
            this.pictureBox4.Location = new System.Drawing.Point(412, 437);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(95, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // relatorioNegocioBindingSource
            // 
            this.relatorioNegocioBindingSource.DataSource = typeof(Negocios.RelatorioNegocio);
            // 
            // btnConsultaRelatorio
            // 
            this.btnConsultaRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultaRelatorio.FlatAppearance.BorderSize = 0;
            this.btnConsultaRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaRelatorio.Image = global::TCC0._1.Properties.Resources.btnSelectRelatorios;
            this.btnConsultaRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaRelatorio.Location = new System.Drawing.Point(-2, 109);
            this.btnConsultaRelatorio.Name = "btnConsultaRelatorio";
            this.btnConsultaRelatorio.Size = new System.Drawing.Size(266, 38);
            this.btnConsultaRelatorio.TabIndex = 27;
            this.btnConsultaRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaRelatorio.UseMnemonic = false;
            this.btnConsultaRelatorio.UseVisualStyleBackColor = false;
            this.btnConsultaRelatorio.Click += new System.EventHandler(this.btnConsultaRelatorio_Click);
            this.btnConsultaRelatorio.MouseEnter += new System.EventHandler(this.btnConsultaRelatorio_MouseEnter);
            this.btnConsultaRelatorio.MouseLeave += new System.EventHandler(this.btnConsultaRelatorio_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::TCC0._1.Properties.Resources.btnSelectFunc;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-2, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 38);
            this.button2.TabIndex = 26;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TCC0._1.Properties.Resources.btnCreateRelatorio;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-2, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 38);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Image = global::TCC0._1.Properties.Resources.btnCadastrar;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.Location = new System.Drawing.Point(-8, 65);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(272, 41);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.btnCadastrar_MouseEnter);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.btnCadastrar_MouseLeave);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Image = global::TCC0._1.Properties.Resources.btnHelp;
            this.btnAjuda.Location = new System.Drawing.Point(878, 473);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(42, 42);
            this.btnAjuda.TabIndex = 33;
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            this.btnAjuda.MouseEnter += new System.EventHandler(this.btnAjuda_MouseEnter);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::TCC0._1.Properties.Resources.btnMin;
            this.btnMin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMin.Location = new System.Drawing.Point(729, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(83, 33);
            this.btnMin.TabIndex = 32;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::TCC0._1.Properties.Resources.btnSairEnter;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(808, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 33);
            this.btnSair.TabIndex = 31;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::TCC0._1.Properties.Resources.logoWhite1;
            this.pictureBox6.Location = new System.Drawing.Point(0, 439);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(78, 76);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::TCC0._1.Properties.Resources.logoappletreiro1;
            this.pictureBox7.Location = new System.Drawing.Point(2, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(142, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            // 
            // RelatorioDesingn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC0._1.Properties.Resources.fundoRealOficial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 519);
            this.ControlBox = false;
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btnConsultaRelatorio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_Listagem);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(545, 250);
            this.Name = "RelatorioDesingn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioNegocioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioNegocioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Listagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.BindingSource relatorioNegocioBindingSource;
        private System.Windows.Forms.BindingSource relatorioNegocioBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tabela;
        private System.Windows.Forms.Button btnConsultaRelatorio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}