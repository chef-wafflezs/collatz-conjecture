namespace Collatz1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CoefficientFormula = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Coefficient = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 257);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Iterration Calculator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.CoefficientFormula);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Coefficient);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.nValue);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(660, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Coefficient Sets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CoefficientFormula
            // 
            this.CoefficientFormula.AutoSize = true;
            this.CoefficientFormula.Location = new System.Drawing.Point(475, 21);
            this.CoefficientFormula.Name = "CoefficientFormula";
            this.CoefficientFormula.Size = new System.Drawing.Size(31, 17);
            this.CoefficientFormula.TabIndex = 5;
            this.CoefficientFormula.Text = "N/A";
            this.CoefficientFormula.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Equation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coefficient";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Coefficient
            // 
            this.Coefficient.FormattingEnabled = true;
            this.Coefficient.ItemHeight = 16;
            this.Coefficient.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.Coefficient.Location = new System.Drawing.Point(124, 21);
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.Size = new System.Drawing.Size(120, 52);
            this.Coefficient.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "n - value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nValue
            // 
            this.nValue.Location = new System.Drawing.Point(124, 92);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(120, 22);
            this.nValue.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate Equation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 283);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Collatz Conjecture";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Coefficient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CoefficientFormula;
        private System.Windows.Forms.Button button1;
    }
}

