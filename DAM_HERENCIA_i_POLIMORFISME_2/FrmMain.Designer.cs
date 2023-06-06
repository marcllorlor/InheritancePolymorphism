namespace DAM_HERENCIA_i_POLIMORFISME_2
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.rdQuadrat = new System.Windows.Forms.RadioButton();
            this.rdRectangle = new System.Windows.Forms.RadioButton();
            this.rdCercle = new System.Windows.Forms.RadioButton();
            this.rdTriangle = new System.Windows.Forms.RadioButton();
            this.lbEstat = new System.Windows.Forms.Label();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.nudNumeroEscalar = new System.Windows.Forms.NumericUpDown();
            this.btnEscalar = new System.Windows.Forms.Button();
            this.chkInterior = new System.Windows.Forms.CheckBox();
            this.pnlColorInterior = new System.Windows.Forms.Panel();
            this.pnlColorVora = new System.Windows.Forms.Panel();
            this.lbColorVora = new System.Windows.Forms.Label();
            this.gruixVora = new System.Windows.Forms.NumericUpDown();
            this.lbGruixVora = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.NumericUpDown();
            this.lbAltura = new System.Windows.Forms.Label();
            this.ample = new System.Windows.Forms.NumericUpDown();
            this.lbAmple = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.rdRombe = new System.Windows.Forms.RadioButton();
            this.cbEscalarTots = new System.Windows.Forms.CheckBox();
            this.pnlConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroEscalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruixVora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ample)).BeginInit();
            this.SuspendLayout();
            // 
            // rdQuadrat
            // 
            this.rdQuadrat.AutoSize = true;
            this.rdQuadrat.Checked = true;
            this.rdQuadrat.Location = new System.Drawing.Point(13, 15);
            this.rdQuadrat.Name = "rdQuadrat";
            this.rdQuadrat.Size = new System.Drawing.Size(94, 22);
            this.rdQuadrat.TabIndex = 0;
            this.rdQuadrat.TabStop = true;
            this.rdQuadrat.Text = " Quadrat";
            this.rdQuadrat.UseVisualStyleBackColor = true;
            this.rdQuadrat.CheckedChanged += new System.EventHandler(this.rdQuadrat_CheckedChanged);
            // 
            // rdRectangle
            // 
            this.rdRectangle.AutoSize = true;
            this.rdRectangle.Location = new System.Drawing.Point(13, 39);
            this.rdRectangle.Name = "rdRectangle";
            this.rdRectangle.Size = new System.Drawing.Size(101, 22);
            this.rdRectangle.TabIndex = 1;
            this.rdRectangle.Text = "Rectangle";
            this.rdRectangle.UseVisualStyleBackColor = true;
            this.rdRectangle.CheckedChanged += new System.EventHandler(this.rdRectangle_CheckedChanged);
            // 
            // rdCercle
            // 
            this.rdCercle.AutoSize = true;
            this.rdCercle.Location = new System.Drawing.Point(13, 63);
            this.rdCercle.Name = "rdCercle";
            this.rdCercle.Size = new System.Drawing.Size(75, 22);
            this.rdCercle.TabIndex = 2;
            this.rdCercle.Text = "Cercle";
            this.rdCercle.UseVisualStyleBackColor = true;
            this.rdCercle.CheckedChanged += new System.EventHandler(this.rdCercle_CheckedChanged);
            // 
            // rdTriangle
            // 
            this.rdTriangle.AutoSize = true;
            this.rdTriangle.Location = new System.Drawing.Point(13, 87);
            this.rdTriangle.Name = "rdTriangle";
            this.rdTriangle.Size = new System.Drawing.Size(85, 22);
            this.rdTriangle.TabIndex = 3;
            this.rdTriangle.Text = "Triangle";
            this.rdTriangle.UseVisualStyleBackColor = true;
            this.rdTriangle.CheckedChanged += new System.EventHandler(this.rdTriangle_CheckedChanged);
            // 
            // lbEstat
            // 
            this.lbEstat.AutoSize = true;
            this.lbEstat.Location = new System.Drawing.Point(224, 619);
            this.lbEstat.Name = "lbEstat";
            this.lbEstat.Size = new System.Drawing.Size(419, 18);
            this.lbEstat.TabIndex = 3;
            this.lbEstat.Text = "Tria la figura que vulguis i fes doble clic on vols que surti";
            // 
            // pnlConfig
            // 
            this.pnlConfig.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfig.Controls.Add(this.cbEscalarTots);
            this.pnlConfig.Controls.Add(this.rdRombe);
            this.pnlConfig.Controls.Add(this.nudNumeroEscalar);
            this.pnlConfig.Controls.Add(this.btnEscalar);
            this.pnlConfig.Controls.Add(this.chkInterior);
            this.pnlConfig.Controls.Add(this.pnlColorInterior);
            this.pnlConfig.Controls.Add(this.pnlColorVora);
            this.pnlConfig.Controls.Add(this.lbColorVora);
            this.pnlConfig.Controls.Add(this.gruixVora);
            this.pnlConfig.Controls.Add(this.lbGruixVora);
            this.pnlConfig.Controls.Add(this.altura);
            this.pnlConfig.Controls.Add(this.lbAltura);
            this.pnlConfig.Controls.Add(this.ample);
            this.pnlConfig.Controls.Add(this.lbAmple);
            this.pnlConfig.Controls.Add(this.rdCercle);
            this.pnlConfig.Controls.Add(this.rdTriangle);
            this.pnlConfig.Controls.Add(this.rdQuadrat);
            this.pnlConfig.Controls.Add(this.rdRectangle);
            this.pnlConfig.Location = new System.Drawing.Point(0, 0);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(200, 644);
            this.pnlConfig.TabIndex = 4;
            // 
            // nudNumeroEscalar
            // 
            this.nudNumeroEscalar.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNumeroEscalar.Location = new System.Drawing.Point(131, 351);
            this.nudNumeroEscalar.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNumeroEscalar.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNumeroEscalar.Name = "nudNumeroEscalar";
            this.nudNumeroEscalar.Size = new System.Drawing.Size(49, 26);
            this.nudNumeroEscalar.TabIndex = 14;
            this.nudNumeroEscalar.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnEscalar
            // 
            this.btnEscalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEscalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscalar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEscalar.Location = new System.Drawing.Point(12, 343);
            this.btnEscalar.Name = "btnEscalar";
            this.btnEscalar.Size = new System.Drawing.Size(95, 38);
            this.btnEscalar.TabIndex = 13;
            this.btnEscalar.Text = "Escalar";
            this.btnEscalar.UseVisualStyleBackColor = false;
            this.btnEscalar.Click += new System.EventHandler(this.btnEscalar_Click);
            // 
            // chkInterior
            // 
            this.chkInterior.AutoSize = true;
            this.chkInterior.Checked = true;
            this.chkInterior.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInterior.Location = new System.Drawing.Point(96, 290);
            this.chkInterior.Name = "chkInterior";
            this.chkInterior.Size = new System.Drawing.Size(84, 22);
            this.chkInterior.TabIndex = 12;
            this.chkInterior.Text = "Interior";
            this.chkInterior.UseVisualStyleBackColor = true;
            this.chkInterior.CheckedChanged += new System.EventHandler(this.chkInterior_CheckedChanged);
            // 
            // pnlColorInterior
            // 
            this.pnlColorInterior.BackColor = System.Drawing.Color.Orange;
            this.pnlColorInterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorInterior.Location = new System.Drawing.Point(54, 286);
            this.pnlColorInterior.Name = "pnlColorInterior";
            this.pnlColorInterior.Size = new System.Drawing.Size(26, 26);
            this.pnlColorInterior.TabIndex = 11;
            this.pnlColorInterior.Click += new System.EventHandler(this.pnlColorInterior_Click);
            // 
            // pnlColorVora
            // 
            this.pnlColorVora.BackColor = System.Drawing.Color.Black;
            this.pnlColorVora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorVora.Location = new System.Drawing.Point(54, 241);
            this.pnlColorVora.Name = "pnlColorVora";
            this.pnlColorVora.Size = new System.Drawing.Size(26, 26);
            this.pnlColorVora.TabIndex = 5;
            this.pnlColorVora.Click += new System.EventHandler(this.pnlColorVora_Click);
            // 
            // lbColorVora
            // 
            this.lbColorVora.AutoSize = true;
            this.lbColorVora.Location = new System.Drawing.Point(13, 246);
            this.lbColorVora.Name = "lbColorVora";
            this.lbColorVora.Size = new System.Drawing.Size(42, 18);
            this.lbColorVora.TabIndex = 10;
            this.lbColorVora.Text = "Vora";
            // 
            // gruixVora
            // 
            this.gruixVora.Location = new System.Drawing.Point(134, 244);
            this.gruixVora.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gruixVora.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.gruixVora.Name = "gruixVora";
            this.gruixVora.Size = new System.Drawing.Size(47, 26);
            this.gruixVora.TabIndex = 9;
            this.gruixVora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gruixVora.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbGruixVora
            // 
            this.lbGruixVora.AutoSize = true;
            this.lbGruixVora.Location = new System.Drawing.Point(86, 246);
            this.lbGruixVora.Name = "lbGruixVora";
            this.lbGruixVora.Size = new System.Drawing.Size(47, 18);
            this.lbGruixVora.TabIndex = 8;
            this.lbGruixVora.Text = "Gruix";
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(96, 171);
            this.altura.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.altura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(59, 26);
            this.altura.TabIndex = 7;
            this.altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.altura.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.altura.Visible = false;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(96, 154);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(56, 18);
            this.lbAltura.TabIndex = 6;
            this.lbAltura.Text = "Alçada";
            this.lbAltura.Visible = false;
            // 
            // ample
            // 
            this.ample.Location = new System.Drawing.Point(21, 171);
            this.ample.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ample.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ample.Name = "ample";
            this.ample.Size = new System.Drawing.Size(59, 26);
            this.ample.TabIndex = 5;
            this.ample.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ample.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbAmple
            // 
            this.lbAmple.AutoSize = true;
            this.lbAmple.Location = new System.Drawing.Point(21, 154);
            this.lbAmple.Name = "lbAmple";
            this.lbAmple.Size = new System.Drawing.Size(72, 18);
            this.lbAmple.TabIndex = 4;
            this.lbAmple.Text = "Amplada";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.BackColor = System.Drawing.Color.LightGray;
            this.lbArea.Location = new System.Drawing.Point(14, 619);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(47, 18);
            this.lbArea.TabIndex = 5;
            this.lbArea.Text = "Àrea ";
            // 
            // rdRombe
            // 
            this.rdRombe.AutoSize = true;
            this.rdRombe.Location = new System.Drawing.Point(12, 115);
            this.rdRombe.Name = "rdRombe";
            this.rdRombe.Size = new System.Drawing.Size(82, 22);
            this.rdRombe.TabIndex = 15;
            this.rdRombe.TabStop = true;
            this.rdRombe.Text = "Rombe";
            this.rdRombe.UseVisualStyleBackColor = true;
            this.rdRombe.CheckedChanged += new System.EventHandler(this.rdRombe_CheckedChanged);
            // 
            // cbEscalarTots
            // 
            this.cbEscalarTots.AutoSize = true;
            this.cbEscalarTots.Location = new System.Drawing.Point(40, 397);
            this.cbEscalarTots.Name = "cbEscalarTots";
            this.cbEscalarTots.Size = new System.Drawing.Size(118, 22);
            this.cbEscalarTots.TabIndex = 16;
            this.cbEscalarTots.Text = "Escalar Tots";
            this.cbEscalarTots.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1272, 642);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbEstat);
            this.Controls.Add(this.pnlConfig);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "POLÍGONS (Herència i Polimorfisme)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.DoubleClick += new System.EventHandler(this.FrmMain_DoubleClick);
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroEscalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruixVora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdTriangle;
        private System.Windows.Forms.RadioButton rdCercle;
        private System.Windows.Forms.RadioButton rdRectangle;
        private System.Windows.Forms.RadioButton rdQuadrat;
        private System.Windows.Forms.Label lbEstat;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.NumericUpDown altura;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.NumericUpDown ample;
        private System.Windows.Forms.Label lbAmple;
        private System.Windows.Forms.Panel pnlColorVora;
        private System.Windows.Forms.Label lbColorVora;
        private System.Windows.Forms.NumericUpDown gruixVora;
        private System.Windows.Forms.Label lbGruixVora;
        private System.Windows.Forms.CheckBox chkInterior;
        private System.Windows.Forms.Panel pnlColorInterior;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.NumericUpDown nudNumeroEscalar;
        private System.Windows.Forms.Button btnEscalar;
        private System.Windows.Forms.RadioButton rdRombe;
        private System.Windows.Forms.CheckBox cbEscalarTots;
    }
}

