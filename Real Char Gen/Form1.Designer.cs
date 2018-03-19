namespace Real_Char_Gen
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
            this.O1 = new System.Windows.Forms.RadioButton();
            this.O2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.O3 = new System.Windows.Forms.RadioButton();
            this.O4 = new System.Windows.Forms.RadioButton();
            this.O5 = new System.Windows.Forms.RadioButton();
            this.O6 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // O1
            // 
            this.O1.AutoSize = true;
            this.O1.Checked = true;
            this.O1.Location = new System.Drawing.Point(13, 96);
            this.O1.Name = "O1";
            this.O1.Size = new System.Drawing.Size(14, 13);
            this.O1.TabIndex = 0;
            this.O1.TabStop = true;
            this.O1.UseVisualStyleBackColor = true;
            this.O1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WhenO1Q1Clicked);
            this.O1.Checked = false;
            // 
            // O2
            // 
            this.O2.AutoSize = true;
            this.O2.Location = new System.Drawing.Point(13, 119);
            this.O2.Name = "O2";
            this.O2.Size = new System.Drawing.Size(14, 13);
            this.O2.TabIndex = 1;
            this.O2.UseVisualStyleBackColor = true;
            this.O2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WhenO2Q1Clicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NextPage1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 77);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // O3
            // 
            this.O3.AutoSize = true;
            this.O3.Location = new System.Drawing.Point(13, 143);
            this.O3.Name = "O3";
            this.O3.Size = new System.Drawing.Size(14, 13);
            this.O3.TabIndex = 4;
            this.O3.UseVisualStyleBackColor = true;
            this.O3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WhenO3Q1Clicked);
            // 
            // O4
            // 
            this.O4.AutoSize = true;
            this.O4.Location = new System.Drawing.Point(13, 167);
            this.O4.Name = "O4";
            this.O4.Size = new System.Drawing.Size(14, 13);
            this.O4.TabIndex = 5;
            this.O4.UseVisualStyleBackColor = true;
            this.O4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WhenO4Q1Clicked);
            // 
            // O5
            // 
            this.O5.AutoSize = true;
            this.O5.Location = new System.Drawing.Point(13, 191);
            this.O5.Name = "O5";
            this.O5.Size = new System.Drawing.Size(14, 13);
            this.O5.TabIndex = 6;
            this.O5.UseVisualStyleBackColor = true;
            this.O5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WhenO5Q1Clicked);
            // 
            // O6
            // 
            this.O6.AutoSize = true;
            this.O6.Location = new System.Drawing.Point(13, 215);
            this.O6.Name = "O6";
            this.O6.Size = new System.Drawing.Size(14, 13);
            this.O6.TabIndex = 7;
            this.O6.UseVisualStyleBackColor = true;
            this.O6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WhenO6Q1Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 558);
            this.Controls.Add(this.O6);
            this.Controls.Add(this.O5);
            this.Controls.Add(this.O4);
            this.Controls.Add(this.O3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.O2);
            this.Controls.Add(this.O1);
            this.Name = "Form1";
            this.Text = "Character Sheet Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton O1;
        public System.Windows.Forms.RadioButton O2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.RadioButton O3;
        public System.Windows.Forms.RadioButton O4;
        public System.Windows.Forms.RadioButton O5;
        public System.Windows.Forms.RadioButton O6;
    }
}

