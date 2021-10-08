namespace Project_420_CT2_AS
{
    partial class Form4
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.raBtnVND2 = new System.Windows.Forms.RadioButton();
            this.raBtnGBP2 = new System.Windows.Forms.RadioButton();
            this.raBtnEUR2 = new System.Windows.Forms.RadioButton();
            this.raBtnUSD2 = new System.Windows.Forms.RadioButton();
            this.raBtnCAD2 = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtConVal = new System.Windows.Forms.TextBox();
            this.txtEnVal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raBtnVND1 = new System.Windows.Forms.RadioButton();
            this.raBtnGBP1 = new System.Windows.Forms.RadioButton();
            this.raBtnEUR1 = new System.Windows.Forms.RadioButton();
            this.raBtnUSD1 = new System.Windows.Forms.RadioButton();
            this.raBtnCAD1 = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.raBtnVND2);
            this.groupBox2.Controls.Add(this.raBtnGBP2);
            this.groupBox2.Controls.Add(this.raBtnEUR2);
            this.groupBox2.Controls.Add(this.raBtnUSD2);
            this.groupBox2.Controls.Add(this.raBtnCAD2);
            this.groupBox2.Location = new System.Drawing.Point(178, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 171);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // raBtnVND2
            // 
            this.raBtnVND2.AutoSize = true;
            this.raBtnVND2.Location = new System.Drawing.Point(21, 121);
            this.raBtnVND2.Name = "raBtnVND2";
            this.raBtnVND2.Size = new System.Drawing.Size(48, 17);
            this.raBtnVND2.TabIndex = 4;
            this.raBtnVND2.Text = "VND";
            this.raBtnVND2.UseVisualStyleBackColor = true;
            this.raBtnVND2.Click += new System.EventHandler(this.To_click);
            // 
            // raBtnGBP2
            // 
            this.raBtnGBP2.AutoSize = true;
            this.raBtnGBP2.Location = new System.Drawing.Point(21, 98);
            this.raBtnGBP2.Name = "raBtnGBP2";
            this.raBtnGBP2.Size = new System.Drawing.Size(47, 17);
            this.raBtnGBP2.TabIndex = 3;
            this.raBtnGBP2.Text = "GBP";
            this.raBtnGBP2.UseVisualStyleBackColor = true;
            this.raBtnGBP2.Click += new System.EventHandler(this.To_click);
            // 
            // raBtnEUR2
            // 
            this.raBtnEUR2.AutoSize = true;
            this.raBtnEUR2.Location = new System.Drawing.Point(21, 75);
            this.raBtnEUR2.Name = "raBtnEUR2";
            this.raBtnEUR2.Size = new System.Drawing.Size(48, 17);
            this.raBtnEUR2.TabIndex = 2;
            this.raBtnEUR2.Text = "EUR";
            this.raBtnEUR2.UseVisualStyleBackColor = true;
            this.raBtnEUR2.Click += new System.EventHandler(this.To_click);
            // 
            // raBtnUSD2
            // 
            this.raBtnUSD2.AutoSize = true;
            this.raBtnUSD2.Location = new System.Drawing.Point(21, 52);
            this.raBtnUSD2.Name = "raBtnUSD2";
            this.raBtnUSD2.Size = new System.Drawing.Size(48, 17);
            this.raBtnUSD2.TabIndex = 1;
            this.raBtnUSD2.Text = "USD";
            this.raBtnUSD2.UseVisualStyleBackColor = true;
            this.raBtnUSD2.Click += new System.EventHandler(this.To_click);
            // 
            // raBtnCAD2
            // 
            this.raBtnCAD2.AutoSize = true;
            this.raBtnCAD2.Checked = true;
            this.raBtnCAD2.Location = new System.Drawing.Point(21, 29);
            this.raBtnCAD2.Name = "raBtnCAD2";
            this.raBtnCAD2.Size = new System.Drawing.Size(47, 17);
            this.raBtnCAD2.TabIndex = 0;
            this.raBtnCAD2.TabStop = true;
            this.raBtnCAD2.Text = "CAD";
            this.raBtnCAD2.UseVisualStyleBackColor = true;
            this.raBtnCAD2.Click += new System.EventHandler(this.To_click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(221, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 25);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(118, 281);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(82, 25);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "&Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(12, 281);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(82, 25);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtConVal
            // 
            this.txtConVal.Location = new System.Drawing.Point(178, 228);
            this.txtConVal.Name = "txtConVal";
            this.txtConVal.ReadOnly = true;
            this.txtConVal.Size = new System.Drawing.Size(125, 20);
            this.txtConVal.TabIndex = 9;
            // 
            // txtEnVal
            // 
            this.txtEnVal.Location = new System.Drawing.Point(12, 228);
            this.txtEnVal.Name = "txtEnVal";
            this.txtEnVal.Size = new System.Drawing.Size(125, 20);
            this.txtEnVal.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raBtnVND1);
            this.groupBox1.Controls.Add(this.raBtnGBP1);
            this.groupBox1.Controls.Add(this.raBtnEUR1);
            this.groupBox1.Controls.Add(this.raBtnUSD1);
            this.groupBox1.Controls.Add(this.raBtnCAD1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 171);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // raBtnVND1
            // 
            this.raBtnVND1.AutoSize = true;
            this.raBtnVND1.Location = new System.Drawing.Point(17, 121);
            this.raBtnVND1.Name = "raBtnVND1";
            this.raBtnVND1.Size = new System.Drawing.Size(48, 17);
            this.raBtnVND1.TabIndex = 4;
            this.raBtnVND1.Text = "VND";
            this.raBtnVND1.UseVisualStyleBackColor = true;
            this.raBtnVND1.Click += new System.EventHandler(this.From_click);
            // 
            // raBtnGBP1
            // 
            this.raBtnGBP1.AutoSize = true;
            this.raBtnGBP1.Location = new System.Drawing.Point(17, 98);
            this.raBtnGBP1.Name = "raBtnGBP1";
            this.raBtnGBP1.Size = new System.Drawing.Size(47, 17);
            this.raBtnGBP1.TabIndex = 3;
            this.raBtnGBP1.Text = "GBP";
            this.raBtnGBP1.UseVisualStyleBackColor = true;
            this.raBtnGBP1.Click += new System.EventHandler(this.From_click);
            // 
            // raBtnEUR1
            // 
            this.raBtnEUR1.AutoSize = true;
            this.raBtnEUR1.Location = new System.Drawing.Point(17, 75);
            this.raBtnEUR1.Name = "raBtnEUR1";
            this.raBtnEUR1.Size = new System.Drawing.Size(48, 17);
            this.raBtnEUR1.TabIndex = 2;
            this.raBtnEUR1.Text = "EUR";
            this.raBtnEUR1.UseVisualStyleBackColor = true;
            this.raBtnEUR1.Click += new System.EventHandler(this.From_click);
            // 
            // raBtnUSD1
            // 
            this.raBtnUSD1.AutoSize = true;
            this.raBtnUSD1.Location = new System.Drawing.Point(17, 52);
            this.raBtnUSD1.Name = "raBtnUSD1";
            this.raBtnUSD1.Size = new System.Drawing.Size(48, 17);
            this.raBtnUSD1.TabIndex = 1;
            this.raBtnUSD1.Text = "USD";
            this.raBtnUSD1.UseVisualStyleBackColor = true;
            this.raBtnUSD1.Click += new System.EventHandler(this.From_click);
            // 
            // raBtnCAD1
            // 
            this.raBtnCAD1.AutoSize = true;
            this.raBtnCAD1.Checked = true;
            this.raBtnCAD1.Location = new System.Drawing.Point(17, 29);
            this.raBtnCAD1.Name = "raBtnCAD1";
            this.raBtnCAD1.Size = new System.Drawing.Size(47, 17);
            this.raBtnCAD1.TabIndex = 0;
            this.raBtnCAD1.TabStop = true;
            this.raBtnCAD1.Text = "CAD";
            this.raBtnCAD1.UseVisualStyleBackColor = true;
            this.raBtnCAD1.CheckedChanged += new System.EventHandler(this.raBtnCAD1_CheckedChanged);
            this.raBtnCAD1.Click += new System.EventHandler(this.From_click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtConVal);
            this.Controls.Add(this.txtEnVal);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Money Exchange - Hoang Nhan Duyen Nguyen";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton raBtnVND2;
        private System.Windows.Forms.RadioButton raBtnGBP2;
        private System.Windows.Forms.RadioButton raBtnEUR2;
        private System.Windows.Forms.RadioButton raBtnUSD2;
        private System.Windows.Forms.RadioButton raBtnCAD2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtConVal;
        private System.Windows.Forms.TextBox txtEnVal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton raBtnVND1;
        private System.Windows.Forms.RadioButton raBtnGBP1;
        private System.Windows.Forms.RadioButton raBtnEUR1;
        private System.Windows.Forms.RadioButton raBtnUSD1;
        private System.Windows.Forms.RadioButton raBtnCAD1;
    }
}