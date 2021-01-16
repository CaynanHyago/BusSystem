namespace TCC0._1
{
    partial class ConsultaCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.colCodFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodOnibus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnConsultaRelatorio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.rdbFiscal = new System.Windows.Forms.RadioButton();
            this.rdbMotorista = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodFiscal,
            this.CodOnibus,
            this.CodMotorista,
            this.colNome,
            this.colChapa});
            this.dgvCliente.Location = new System.Drawing.Point(355, 171);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(359, 278);
            this.dgvCliente.TabIndex = 3;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // colCodFiscal
            // 
            this.colCodFiscal.DataPropertyName = "CodFiscal";
            this.colCodFiscal.HeaderText = "Codigo";
            this.colCodFiscal.Name = "colCodFiscal";
            this.colCodFiscal.ReadOnly = true;
            this.colCodFiscal.Visible = false;
            // 
            // CodOnibus
            // 
            this.CodOnibus.DataPropertyName = "CodOnibus";
            this.CodOnibus.HeaderText = "CodOnibus";
            this.CodOnibus.Name = "CodOnibus";
            this.CodOnibus.ReadOnly = true;
            this.CodOnibus.Visible = false;
            // 
            // CodMotorista
            // 
            this.CodMotorista.DataPropertyName = "CodMotorista";
            this.CodMotorista.HeaderText = "CodigoMotorista";
            this.CodMotorista.Name = "CodMotorista";
            this.CodMotorista.ReadOnly = true;
            this.CodMotorista.Visible = false;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colChapa
            // 
            this.colChapa.DataPropertyName = "Chapa";
            this.colChapa.HeaderText = "Chapa";
            this.colChapa.Name = "colChapa";
            this.colChapa.ReadOnly = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(355, 145);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(398, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TCC0._1.Properties.Resources.BTNVOLTARREALMSM;
            this.pictureBox2.Location = new System.Drawing.Point(845, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TCC0._1.Properties.Resources.BTNPESQUISARREALMESMO;
            this.pictureBox1.Location = new System.Drawing.Point(652, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::TCC0._1.Properties.Resources.BTNEXCLUIR2;
            this.pictureBox4.Location = new System.Drawing.Point(813, 171);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(95, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TCC0._1.Properties.Resources.BTNALTERAR1;
            this.pictureBox3.Location = new System.Drawing.Point(813, 215);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // btnConsultaRelatorio
            // 
            this.btnConsultaRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultaRelatorio.FlatAppearance.BorderSize = 0;
            this.btnConsultaRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaRelatorio.Image = global::TCC0._1.Properties.Resources.btnSelectRelatorios;
            this.btnConsultaRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaRelatorio.Location = new System.Drawing.Point(0, 100);
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
            this.button2.Location = new System.Drawing.Point(0, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 38);
            this.button2.TabIndex = 26;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            this.button1.Location = new System.Drawing.Point(0, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 38);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.btnCadastrar.Location = new System.Drawing.Point(-6, 56);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(272, 41);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.btnCadastrar_MouseEnter);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.btnCadastrar_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::TCC0._1.Properties.Resources.logoappletreiro1;
            this.pictureBox5.Location = new System.Drawing.Point(0, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(142, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::TCC0._1.Properties.Resources.logoWhite1;
            this.pictureBox6.Location = new System.Drawing.Point(-2, 439);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(78, 76);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Image = global::TCC0._1.Properties.Resources.btnHelp;
            this.btnAjuda.Location = new System.Drawing.Point(876, 473);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(42, 42);
            this.btnAjuda.TabIndex = 30;
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            this.btnAjuda.MouseEnter += new System.EventHandler(this.btnAjuda_MouseEnter);
            this.btnAjuda.MouseLeave += new System.EventHandler(this.btnAjuda_MouseLeave);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::TCC0._1.Properties.Resources.btnSairEnter;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(806, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 33);
            this.btnSair.TabIndex = 31;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::TCC0._1.Properties.Resources.btnMin;
            this.btnMin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMin.Location = new System.Drawing.Point(727, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(83, 33);
            this.btnMin.TabIndex = 32;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            // 
            // rdbFiscal
            // 
            this.rdbFiscal.AutoSize = true;
            this.rdbFiscal.BackColor = System.Drawing.Color.Transparent;
            this.rdbFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFiscal.ForeColor = System.Drawing.Color.White;
            this.rdbFiscal.Location = new System.Drawing.Point(813, 275);
            this.rdbFiscal.Name = "rdbFiscal";
            this.rdbFiscal.Size = new System.Drawing.Size(65, 22);
            this.rdbFiscal.TabIndex = 34;
            this.rdbFiscal.TabStop = true;
            this.rdbFiscal.Text = "Fiscal";
            this.rdbFiscal.UseVisualStyleBackColor = false;
            // 
            // rdbMotorista
            // 
            this.rdbMotorista.AutoSize = true;
            this.rdbMotorista.BackColor = System.Drawing.Color.Transparent;
            this.rdbMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMotorista.ForeColor = System.Drawing.Color.White;
            this.rdbMotorista.Location = new System.Drawing.Point(813, 303);
            this.rdbMotorista.Name = "rdbMotorista";
            this.rdbMotorista.Size = new System.Drawing.Size(89, 22);
            this.rdbMotorista.TabIndex = 33;
            this.rdbMotorista.TabStop = true;
            this.rdbMotorista.Text = "Motorista";
            this.rdbMotorista.UseVisualStyleBackColor = false;
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC0._1.Properties.Resources.fundoRealOficial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 519);
            this.ControlBox = false;
            this.Controls.Add(this.rdbFiscal);
            this.Controls.Add(this.rdbMotorista);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnConsultaRelatorio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(565, 205);
            this.Name = "ConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaCliente";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.ConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnConsultaRelatorio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.RadioButton rdbFiscal;
        private System.Windows.Forms.RadioButton rdbMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodOnibus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChapa;
    }
}