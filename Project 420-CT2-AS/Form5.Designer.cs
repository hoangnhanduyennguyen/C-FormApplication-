namespace Project_420_CT2_AS
{
    partial class Form5
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leftLable = new System.Windows.Forms.Label();
            this.rightLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.raBtnFC = new System.Windows.Forms.RadioButton();
            this.raBtnCF = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(307, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Location = new System.Drawing.Point(153, 404);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(94, 23);
            this.btnReadFile.TabIndex = 22;
            this.btnReadFile.Text = "&Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(24, 404);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(90, 23);
            this.btnConvert.TabIndex = 21;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(24, 271);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.ReadOnly = true;
            this.txtMess.Size = new System.Drawing.Size(358, 113);
            this.txtMess.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Message:";
            // 
            // leftLable
            // 
            this.leftLable.AutoSize = true;
            this.leftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLable.Location = new System.Drawing.Point(51, 205);
            this.leftLable.Name = "leftLable";
            this.leftLable.Size = new System.Drawing.Size(18, 16);
            this.leftLable.TabIndex = 18;
            this.leftLable.Text = "C";
            // 
            // rightLable
            // 
            this.rightLable.AutoSize = true;
            this.rightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLable.Location = new System.Drawing.Point(270, 205);
            this.rightLable.Name = "rightLable";
            this.rightLable.Size = new System.Drawing.Size(17, 16);
            this.rightLable.TabIndex = 17;
            this.rightLable.Text = "F";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "to";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(236, 171);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(146, 20);
            this.txtTo.TabIndex = 15;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(24, 171);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(140, 20);
            this.txtFrom.TabIndex = 14;
            // 
            // raBtnFC
            // 
            this.raBtnFC.AutoSize = true;
            this.raBtnFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raBtnFC.Location = new System.Drawing.Point(153, 106);
            this.raBtnFC.Name = "raBtnFC";
            this.raBtnFC.Size = new System.Drawing.Size(94, 20);
            this.raBtnFC.TabIndex = 13;
            this.raBtnFC.Text = "From F to C";
            this.raBtnFC.UseVisualStyleBackColor = true;
            this.raBtnFC.Click += new System.EventHandler(this.raBtnFC_Click);
            // 
            // raBtnCF
            // 
            this.raBtnCF.AutoSize = true;
            this.raBtnCF.Checked = true;
            this.raBtnCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raBtnCF.Location = new System.Drawing.Point(153, 61);
            this.raBtnCF.Name = "raBtnCF";
            this.raBtnCF.Size = new System.Drawing.Size(94, 20);
            this.raBtnCF.TabIndex = 12;
            this.raBtnCF.TabStop = true;
            this.raBtnCF.Text = "From C to F";
            this.raBtnCF.UseVisualStyleBackColor = true;
            this.raBtnCF.Click += new System.EventHandler(this.raBtnCF_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.leftLable);
            this.Controls.Add(this.rightLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.raBtnFC);
            this.Controls.Add(this.raBtnCF);
            this.Name = "Form5";
            this.Text = "Temperature Conversion - Hoang Nhan Duyen Nguyen";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label leftLable;
        private System.Windows.Forms.Label rightLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.RadioButton raBtnFC;
        private System.Windows.Forms.RadioButton raBtnCF;
    }
}