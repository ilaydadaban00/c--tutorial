
namespace uygulama_2
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.btnYap = new System.Windows.Forms.Button();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(182, 182);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 0;
            // 
            // btnYap
            // 
            this.btnYap.Location = new System.Drawing.Point(332, 178);
            this.btnYap.Name = "btnYap";
            this.btnYap.Size = new System.Drawing.Size(75, 23);
            this.btnYap.TabIndex = 1;
            this.btnYap.Text = "tıkla";
            this.btnYap.UseVisualStyleBackColor = true;
            this.btnYap.Click += new System.EventHandler(this.btnYap_Click);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(481, 180);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.btnYap);
            this.Controls.Add(this.txtSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Button btnYap;
        private System.Windows.Forms.TextBox txtSayi2;
    }
}

