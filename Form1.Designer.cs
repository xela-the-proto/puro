namespace winforms
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
            this.lbl_hello = new System.Windows.Forms.Label();
            this.btn_hello = new System.Windows.Forms.Button();
            this.btn_puro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Location = new System.Drawing.Point(12, 9);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(15, 13);
            this.lbl_hello.TabIndex = 0;
            this.lbl_hello.Text = "hi";
            // 
            // btn_hello
            // 
            this.btn_hello.Location = new System.Drawing.Point(383, 312);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(75, 23);
            this.btn_hello.TabIndex = 1;
            this.btn_hello.Text = "hello";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // btn_puro
            // 
            this.btn_puro.Location = new System.Drawing.Point(287, 312);
            this.btn_puro.Name = "btn_puro";
            this.btn_puro.Size = new System.Drawing.Size(90, 23);
            this.btn_puro.TabIndex = 3;
            this.btn_puro.Text = "puro jumpscare";
            this.btn_puro.UseVisualStyleBackColor = true;
            this.btn_puro.Click += new System.EventHandler(this.btn_puro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_puro);
            this.Controls.Add(this.btn_hello);
            this.Controls.Add(this.lbl_hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.Button btn_puro;
    }
}

