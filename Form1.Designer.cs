namespace TipsMaskinen
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitelBox = new System.Windows.Forms.TextBox();
            this.FörfattareBox = new System.Windows.Forms.TextBox();
            this.TidskriftCheck = new System.Windows.Forms.CheckBox();
            this.NovellsamlingCheck = new System.Windows.Forms.CheckBox();
            this.romanTypecCheck = new System.Windows.Forms.CheckBox();
            this.Addbok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "TipsaMig";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(42, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(70, 13);
            this.label1.MinimumSize = new System.Drawing.Size(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipsmaksin";
            // 
            // TitelBox
            // 
            this.TitelBox.Location = new System.Drawing.Point(113, 271);
            this.TitelBox.Name = "TitelBox";
            this.TitelBox.Size = new System.Drawing.Size(112, 20);
            this.TitelBox.TabIndex = 4;
            this.TitelBox.TextChanged += new System.EventHandler(this.TitelBox_TextChanged);
            // 
            // FörfattareBox
            // 
            this.FörfattareBox.Location = new System.Drawing.Point(280, 271);
            this.FörfattareBox.Name = "FörfattareBox";
            this.FörfattareBox.Size = new System.Drawing.Size(111, 20);
            this.FörfattareBox.TabIndex = 8;
            this.FörfattareBox.TextChanged += new System.EventHandler(this.FörfattareBox_TextChanged);
            // 
            // TidskriftCheck
            // 
            this.TidskriftCheck.AutoSize = true;
            this.TidskriftCheck.Location = new System.Drawing.Point(328, 319);
            this.TidskriftCheck.Name = "TidskriftCheck";
            this.TidskriftCheck.Size = new System.Drawing.Size(63, 17);
            this.TidskriftCheck.TabIndex = 9;
            this.TidskriftCheck.Text = "Tidskrift";
            this.TidskriftCheck.UseVisualStyleBackColor = true;
            this.TidskriftCheck.CheckedChanged += new System.EventHandler(this.TidskriftCheck_CheckedChanged);
            // 
            // NovellsamlingCheck
            // 
            this.NovellsamlingCheck.AutoSize = true;
            this.NovellsamlingCheck.Location = new System.Drawing.Point(186, 319);
            this.NovellsamlingCheck.Name = "NovellsamlingCheck";
            this.NovellsamlingCheck.Size = new System.Drawing.Size(91, 17);
            this.NovellsamlingCheck.TabIndex = 10;
            this.NovellsamlingCheck.Text = "Novellsamling";
            this.NovellsamlingCheck.UseVisualStyleBackColor = true;
            this.NovellsamlingCheck.CheckedChanged += new System.EventHandler(this.NovellsamlingCheck_CheckedChanged);
            // 
            // romanTypecCheck
            // 
            this.romanTypecCheck.AutoSize = true;
            this.romanTypecCheck.Location = new System.Drawing.Point(70, 319);
            this.romanTypecCheck.Name = "romanTypecCheck";
            this.romanTypecCheck.Size = new System.Drawing.Size(60, 17);
            this.romanTypecCheck.TabIndex = 11;
            this.romanTypecCheck.Text = "Roman";
            this.romanTypecCheck.UseVisualStyleBackColor = true;
            this.romanTypecCheck.CheckedChanged += new System.EventHandler(this.romanTypecCheck_CheckedChanged);
            // 
            // Addbok
            // 
            this.Addbok.Location = new System.Drawing.Point(103, 362);
            this.Addbok.Name = "Addbok";
            this.Addbok.Size = new System.Drawing.Size(226, 25);
            this.Addbok.TabIndex = 12;
            this.Addbok.Text = "AddBoken";
            this.Addbok.UseVisualStyleBackColor = true;
            this.Addbok.Click += new System.EventHandler(this.Addbok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "SkrivTitel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "SkrivFörfattaren";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 465);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Addbok);
            this.Controls.Add(this.romanTypecCheck);
            this.Controls.Add(this.NovellsamlingCheck);
            this.Controls.Add(this.TidskriftCheck);
            this.Controls.Add(this.FörfattareBox);
            this.Controls.Add(this.TitelBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitelBox;
        private System.Windows.Forms.TextBox FörfattareBox;
        private System.Windows.Forms.CheckBox TidskriftCheck;
        private System.Windows.Forms.CheckBox NovellsamlingCheck;
        private System.Windows.Forms.CheckBox romanTypecCheck;
        private System.Windows.Forms.Button Addbok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

