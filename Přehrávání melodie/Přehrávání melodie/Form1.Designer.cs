namespace Přehrávání_melodie
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
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_filedialog = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(12, 151);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(208, 51);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Přehraj";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_filedialog
            // 
            this.btn_filedialog.Location = new System.Drawing.Point(12, 55);
            this.btn_filedialog.Name = "btn_filedialog";
            this.btn_filedialog.Size = new System.Drawing.Size(208, 51);
            this.btn_filedialog.TabIndex = 0;
            this.btn_filedialog.Text = "Najít soubor";
            this.btn_filedialog.UseVisualStyleBackColor = true;
            this.btn_filedialog.Click += new System.EventHandler(this.btn_filedialog_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Přehraj a čekej";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Opakovaně přehrávej";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Zastav přehrávání";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(465, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Cesta k souboru";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 310);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_filedialog);
            this.Controls.Add(this.btn_play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_filedialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

