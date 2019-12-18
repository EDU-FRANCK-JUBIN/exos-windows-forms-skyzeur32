namespace QRcode
{
    partial class Main
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
            this.btn_QrCode = new System.Windows.Forms.Button();
            this.btn_Itext = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_QrCode
            // 
            this.btn_QrCode.Location = new System.Drawing.Point(26, 35);
            this.btn_QrCode.Name = "btn_QrCode";
            this.btn_QrCode.Size = new System.Drawing.Size(75, 23);
            this.btn_QrCode.TabIndex = 0;
            this.btn_QrCode.Text = "QRCode";
            this.btn_QrCode.UseVisualStyleBackColor = true;
            this.btn_QrCode.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Itext
            // 
            this.btn_Itext.Location = new System.Drawing.Point(26, 105);
            this.btn_Itext.Name = "btn_Itext";
            this.btn_Itext.Size = new System.Drawing.Size(75, 23);
            this.btn_Itext.TabIndex = 1;
            this.btn_Itext.Text = "Itext";
            this.btn_Itext.UseVisualStyleBackColor = true;
            this.btn_Itext.Click += new System.EventHandler(this.btn_Itext_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Itext);
            this.Controls.Add(this.btn_QrCode);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_QrCode;
        private System.Windows.Forms.Button btn_Itext;
        private System.Windows.Forms.Button button3;
    }
}