namespace Proyecto___1177318
{
    partial class Form1
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
            this.BT_Subir = new System.Windows.Forms.Button();
            this.PB_Original = new System.Windows.Forms.PictureBox();
            this.PB_Filtro = new System.Windows.Forms.PictureBox();
            this.RB_D = new System.Windows.Forms.RadioButton();
            this.RB_R = new System.Windows.Forms.RadioButton();
            this.RB_SI = new System.Windows.Forms.RadioButton();
            this.RB_SS = new System.Windows.Forms.RadioButton();
            this.RB_SIZ = new System.Windows.Forms.RadioButton();
            this.RB_SD = new System.Windows.Forms.RadioButton();
            this.RB_C = new System.Windows.Forms.RadioButton();
            this.RB_A = new System.Windows.Forms.RadioButton();
            this.RB_O = new System.Windows.Forms.RadioButton();
            this.RB_P = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_Aplicar = new System.Windows.Forms.Button();
            this.GB_Filtros = new System.Windows.Forms.GroupBox();
            this.TB_11 = new System.Windows.Forms.NumericUpDown();
            this.TB_12 = new System.Windows.Forms.NumericUpDown();
            this.TB_13 = new System.Windows.Forms.NumericUpDown();
            this.TB_21 = new System.Windows.Forms.NumericUpDown();
            this.TB_22 = new System.Windows.Forms.NumericUpDown();
            this.TB_23 = new System.Windows.Forms.NumericUpDown();
            this.TB_31 = new System.Windows.Forms.NumericUpDown();
            this.TB_32 = new System.Windows.Forms.NumericUpDown();
            this.TB_33 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Filtro)).BeginInit();
            this.panel1.SuspendLayout();
            this.GB_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_33)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Subir
            // 
            this.BT_Subir.Location = new System.Drawing.Point(808, 430);
            this.BT_Subir.Name = "BT_Subir";
            this.BT_Subir.Size = new System.Drawing.Size(70, 43);
            this.BT_Subir.TabIndex = 0;
            this.BT_Subir.Text = "SUBIR IMAGEN";
            this.BT_Subir.UseVisualStyleBackColor = true;
            this.BT_Subir.Click += new System.EventHandler(this.BT_Subir_Click);
            // 
            // PB_Original
            // 
            this.PB_Original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Original.Location = new System.Drawing.Point(12, 12);
            this.PB_Original.Name = "PB_Original";
            this.PB_Original.Size = new System.Drawing.Size(500, 370);
            this.PB_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Original.TabIndex = 1;
            this.PB_Original.TabStop = false;
            // 
            // PB_Filtro
            // 
            this.PB_Filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Filtro.Location = new System.Drawing.Point(518, 12);
            this.PB_Filtro.Name = "PB_Filtro";
            this.PB_Filtro.Size = new System.Drawing.Size(500, 370);
            this.PB_Filtro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Filtro.TabIndex = 2;
            this.PB_Filtro.TabStop = false;
            // 
            // RB_D
            // 
            this.RB_D.AutoSize = true;
            this.RB_D.Checked = true;
            this.RB_D.Location = new System.Drawing.Point(6, 19);
            this.RB_D.Name = "RB_D";
            this.RB_D.Size = new System.Drawing.Size(93, 17);
            this.RB_D.TabIndex = 3;
            this.RB_D.TabStop = true;
            this.RB_D.Text = "DIFUMINADO";
            this.RB_D.UseVisualStyleBackColor = true;
            this.RB_D.Click += new System.EventHandler(this.RB_D_Click);
            // 
            // RB_R
            // 
            this.RB_R.AutoSize = true;
            this.RB_R.Location = new System.Drawing.Point(6, 42);
            this.RB_R.Name = "RB_R";
            this.RB_R.Size = new System.Drawing.Size(75, 17);
            this.RB_R.TabIndex = 4;
            this.RB_R.Text = "REALZAR";
            this.RB_R.UseVisualStyleBackColor = true;
            this.RB_R.Click += new System.EventHandler(this.RB_R_Click);
            // 
            // RB_SI
            // 
            this.RB_SI.AutoSize = true;
            this.RB_SI.Location = new System.Drawing.Point(105, 19);
            this.RB_SI.Name = "RB_SI";
            this.RB_SI.Size = new System.Drawing.Size(114, 17);
            this.RB_SI.TabIndex = 5;
            this.RB_SI.Text = "SOBEL INFERIOR";
            this.RB_SI.UseVisualStyleBackColor = true;
            this.RB_SI.Click += new System.EventHandler(this.RB_SI_Click);
            // 
            // RB_SS
            // 
            this.RB_SS.AutoSize = true;
            this.RB_SS.Location = new System.Drawing.Point(105, 42);
            this.RB_SS.Name = "RB_SS";
            this.RB_SS.Size = new System.Drawing.Size(119, 17);
            this.RB_SS.TabIndex = 6;
            this.RB_SS.Text = "SOBEL SUPERIOR";
            this.RB_SS.UseVisualStyleBackColor = true;
            this.RB_SS.Click += new System.EventHandler(this.RB_SS_Click);
            // 
            // RB_SIZ
            // 
            this.RB_SIZ.AutoSize = true;
            this.RB_SIZ.Location = new System.Drawing.Point(105, 65);
            this.RB_SIZ.Name = "RB_SIZ";
            this.RB_SIZ.Size = new System.Drawing.Size(123, 17);
            this.RB_SIZ.TabIndex = 7;
            this.RB_SIZ.Text = "SOBEL IZQUIERDO";
            this.RB_SIZ.UseVisualStyleBackColor = true;
            this.RB_SIZ.Click += new System.EventHandler(this.RB_SIZ_Click);
            // 
            // RB_SD
            // 
            this.RB_SD.AutoSize = true;
            this.RB_SD.Location = new System.Drawing.Point(105, 88);
            this.RB_SD.Name = "RB_SD";
            this.RB_SD.Size = new System.Drawing.Size(116, 17);
            this.RB_SD.TabIndex = 8;
            this.RB_SD.Text = "SOBEL DERECHO";
            this.RB_SD.UseVisualStyleBackColor = true;
            this.RB_SD.Click += new System.EventHandler(this.RB_SD_Click);
            // 
            // RB_C
            // 
            this.RB_C.AutoSize = true;
            this.RB_C.Location = new System.Drawing.Point(6, 65);
            this.RB_C.Name = "RB_C";
            this.RB_C.Size = new System.Drawing.Size(87, 17);
            this.RB_C.TabIndex = 9;
            this.RB_C.Text = "CONTORNO";
            this.RB_C.UseVisualStyleBackColor = true;
            this.RB_C.Click += new System.EventHandler(this.RB_C_Click);
            // 
            // RB_A
            // 
            this.RB_A.AutoSize = true;
            this.RB_A.Location = new System.Drawing.Point(6, 88);
            this.RB_A.Name = "RB_A";
            this.RB_A.Size = new System.Drawing.Size(62, 17);
            this.RB_A.TabIndex = 10;
            this.RB_A.Text = "AFILAR";
            this.RB_A.UseVisualStyleBackColor = true;
            this.RB_A.Click += new System.EventHandler(this.RB_A_Click);
            // 
            // RB_O
            // 
            this.RB_O.AutoSize = true;
            this.RB_O.Location = new System.Drawing.Point(6, 111);
            this.RB_O.Name = "RB_O";
            this.RB_O.Size = new System.Drawing.Size(76, 17);
            this.RB_O.TabIndex = 11;
            this.RB_O.Text = "ORIGINAL";
            this.RB_O.UseVisualStyleBackColor = true;
            this.RB_O.Click += new System.EventHandler(this.RB_O_Click);
            // 
            // RB_P
            // 
            this.RB_P.AutoSize = true;
            this.RB_P.Location = new System.Drawing.Point(105, 111);
            this.RB_P.Name = "RB_P";
            this.RB_P.Size = new System.Drawing.Size(116, 17);
            this.RB_P.TabIndex = 12;
            this.RB_P.Text = "PERSONALIZADO";
            this.RB_P.UseVisualStyleBackColor = true;
            this.RB_P.Click += new System.EventHandler(this.RB_P_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TB_33);
            this.panel1.Controls.Add(this.TB_32);
            this.panel1.Controls.Add(this.TB_31);
            this.panel1.Controls.Add(this.TB_23);
            this.panel1.Controls.Add(this.TB_22);
            this.panel1.Controls.Add(this.TB_21);
            this.panel1.Controls.Add(this.TB_13);
            this.panel1.Controls.Add(this.TB_12);
            this.panel1.Controls.Add(this.TB_11);
            this.panel1.Location = new System.Drawing.Point(332, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 81);
            this.panel1.TabIndex = 13;
            // 
            // BT_Aplicar
            // 
            this.BT_Aplicar.Enabled = false;
            this.BT_Aplicar.Location = new System.Drawing.Point(884, 430);
            this.BT_Aplicar.Name = "BT_Aplicar";
            this.BT_Aplicar.Size = new System.Drawing.Size(70, 43);
            this.BT_Aplicar.TabIndex = 14;
            this.BT_Aplicar.Text = "APLICAR FILTRO";
            this.BT_Aplicar.UseVisualStyleBackColor = true;
            this.BT_Aplicar.Click += new System.EventHandler(this.BT_Aplicar_Click);
            // 
            // GB_Filtros
            // 
            this.GB_Filtros.Controls.Add(this.RB_D);
            this.GB_Filtros.Controls.Add(this.RB_R);
            this.GB_Filtros.Controls.Add(this.RB_C);
            this.GB_Filtros.Controls.Add(this.RB_A);
            this.GB_Filtros.Controls.Add(this.RB_O);
            this.GB_Filtros.Controls.Add(this.RB_SI);
            this.GB_Filtros.Controls.Add(this.RB_P);
            this.GB_Filtros.Controls.Add(this.RB_SS);
            this.GB_Filtros.Controls.Add(this.RB_SD);
            this.GB_Filtros.Controls.Add(this.RB_SIZ);
            this.GB_Filtros.Location = new System.Drawing.Point(12, 388);
            this.GB_Filtros.Name = "GB_Filtros";
            this.GB_Filtros.Size = new System.Drawing.Size(233, 132);
            this.GB_Filtros.TabIndex = 21;
            this.GB_Filtros.TabStop = false;
            this.GB_Filtros.Text = "Filtros";
            // 
            // TB_11
            // 
            this.TB_11.DecimalPlaces = 5;
            this.TB_11.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TB_11.Location = new System.Drawing.Point(3, 3);
            this.TB_11.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TB_11.Name = "TB_11";
            this.TB_11.Size = new System.Drawing.Size(120, 20);
            this.TB_11.TabIndex = 22;
            // 
            // TB_12
            // 
            this.TB_12.DecimalPlaces = 5;
            this.TB_12.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TB_12.Location = new System.Drawing.Point(129, 3);
            this.TB_12.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TB_12.Name = "TB_12";
            this.TB_12.Size = new System.Drawing.Size(120, 20);
            this.TB_12.TabIndex = 23;
            // 
            // TB_13
            // 
            this.TB_13.DecimalPlaces = 5;
            this.TB_13.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TB_13.Location = new System.Drawing.Point(255, 3);
            this.TB_13.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TB_13.Name = "TB_13";
            this.TB_13.Size = new System.Drawing.Size(120, 20);
            this.TB_13.TabIndex = 24;
            // 
            // TB_21
            // 
            this.TB_21.DecimalPlaces = 5;
            this.TB_21.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TB_21.Location = new System.Drawing.Point(3, 29);
            this.TB_21.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TB_21.Name = "TB_21";
            this.TB_21.Size = new System.Drawing.Size(120, 20);
            this.TB_21.TabIndex = 25;
            // 
            // TB_22
            // 
            this.TB_22.DecimalPlaces = 5;
            this.TB_22.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TB_22.Location = new System.Drawing.Point(129, 29);
            this.TB_22.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TB_22.Name = "TB_22";
            this.TB_22.Size = new System.Drawing.Size(120, 20);
            this.TB_22.TabIndex = 26;
            // 
            // TB_23
            // 
            this.TB_23.DecimalPlaces = 5;
            this.TB_23.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TB_23.Location = new System.Drawing.Point(255, 29);
            this.TB_23.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TB_23.Name = "TB_23";
            this.TB_23.Size = new System.Drawing.Size(120, 20);
            this.TB_23.TabIndex = 27;
            // 
            // TB_31
            // 
            this.TB_31.DecimalPlaces = 5;
            this.TB_31.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TB_31.Location = new System.Drawing.Point(3, 55);
            this.TB_31.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TB_31.Name = "TB_31";
            this.TB_31.Size = new System.Drawing.Size(120, 20);
            this.TB_31.TabIndex = 28;
            // 
            // TB_32
            // 
            this.TB_32.DecimalPlaces = 5;
            this.TB_32.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TB_32.Location = new System.Drawing.Point(129, 55);
            this.TB_32.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TB_32.Name = "TB_32";
            this.TB_32.Size = new System.Drawing.Size(120, 20);
            this.TB_32.TabIndex = 29;
            // 
            // TB_33
            // 
            this.TB_33.DecimalPlaces = 5;
            this.TB_33.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TB_33.Location = new System.Drawing.Point(255, 55);
            this.TB_33.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TB_33.Name = "TB_33";
            this.TB_33.Size = new System.Drawing.Size(120, 20);
            this.TB_33.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 528);
            this.Controls.Add(this.GB_Filtros);
            this.Controls.Add(this.BT_Aplicar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PB_Filtro);
            this.Controls.Add(this.PB_Original);
            this.Controls.Add(this.BT_Subir);
            this.Name = "Form1";
            this.Text = "FILTROS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Filtro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.GB_Filtros.ResumeLayout(false);
            this.GB_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_33)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Subir;
        private System.Windows.Forms.PictureBox PB_Original;
        private System.Windows.Forms.PictureBox PB_Filtro;
        private System.Windows.Forms.RadioButton RB_D;
        private System.Windows.Forms.RadioButton RB_R;
        private System.Windows.Forms.RadioButton RB_SI;
        private System.Windows.Forms.RadioButton RB_SS;
        private System.Windows.Forms.RadioButton RB_SIZ;
        private System.Windows.Forms.RadioButton RB_SD;
        private System.Windows.Forms.RadioButton RB_C;
        private System.Windows.Forms.RadioButton RB_A;
        private System.Windows.Forms.RadioButton RB_O;
        private System.Windows.Forms.RadioButton RB_P;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_Aplicar;
        private System.Windows.Forms.GroupBox GB_Filtros;
        private System.Windows.Forms.NumericUpDown TB_11;
        private System.Windows.Forms.NumericUpDown TB_33;
        private System.Windows.Forms.NumericUpDown TB_32;
        private System.Windows.Forms.NumericUpDown TB_31;
        private System.Windows.Forms.NumericUpDown TB_23;
        private System.Windows.Forms.NumericUpDown TB_22;
        private System.Windows.Forms.NumericUpDown TB_21;
        private System.Windows.Forms.NumericUpDown TB_13;
        private System.Windows.Forms.NumericUpDown TB_12;
    }
}

