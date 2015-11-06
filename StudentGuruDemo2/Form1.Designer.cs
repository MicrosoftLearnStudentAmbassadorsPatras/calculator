namespace StudentGuruDemo2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.BtnReg = new System.Windows.Forms.Button();
            this.BtnReg2 = new System.Windows.Forms.Button();
            this.BtnReg3 = new System.Windows.Forms.Button();
            this.BtnReg4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result: ";
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(120, 13);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalculate.TabIndex = 2;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(329, 13);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(75, 23);
            this.BtnReg.TabIndex = 3;
            this.BtnReg.Text = "Reg1";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnReg2
            // 
            this.BtnReg2.Location = new System.Drawing.Point(329, 42);
            this.BtnReg2.Name = "BtnReg2";
            this.BtnReg2.Size = new System.Drawing.Size(75, 23);
            this.BtnReg2.TabIndex = 4;
            this.BtnReg2.Text = "Reg2";
            this.BtnReg2.UseVisualStyleBackColor = true;
            this.BtnReg2.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnReg3
            // 
            this.BtnReg3.Location = new System.Drawing.Point(329, 71);
            this.BtnReg3.Name = "BtnReg3";
            this.BtnReg3.Size = new System.Drawing.Size(75, 23);
            this.BtnReg3.TabIndex = 5;
            this.BtnReg3.Text = "Reg3";
            this.BtnReg3.UseVisualStyleBackColor = true;
            this.BtnReg3.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnReg4
            // 
            this.BtnReg4.Location = new System.Drawing.Point(329, 100);
            this.BtnReg4.Name = "BtnReg4";
            this.BtnReg4.Size = new System.Drawing.Size(75, 23);
            this.BtnReg4.TabIndex = 6;
            this.BtnReg4.Text = "Reg4";
            this.BtnReg4.UseVisualStyleBackColor = true;
            this.BtnReg4.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 389);
            this.Controls.Add(this.BtnReg4);
            this.Controls.Add(this.BtnReg3);
            this.Controls.Add(this.BtnReg2);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button BtnReg2;
        private System.Windows.Forms.Button BtnReg3;
        private System.Windows.Forms.Button BtnReg4;
    }
}

