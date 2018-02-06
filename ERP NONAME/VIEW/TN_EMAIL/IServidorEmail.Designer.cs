namespace ALTO_VALE.VIEW.TN_EMAIL
{
    partial class IServidorEmail
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
            this.richTextBoxSmtp = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPop = new System.Windows.Forms.RichTextBox();
            this.labelSmtptext = new System.Windows.Forms.Label();
            this.labelPop = new System.Windows.Forms.Label();
            this.labelSmtp = new System.Windows.Forms.Label();
            this.labelPop2 = new System.Windows.Forms.Label();
            this.richTextBoxSmtpPorta = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPopPorta = new System.Windows.Forms.RichTextBox();
            this.checkBoxSslSmtp = new System.Windows.Forms.CheckBox();
            this.checkBoxSslPop = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.richTextBoxNome = new System.Windows.Forms.RichTextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxSmtp
            // 
            this.richTextBoxSmtp.Location = new System.Drawing.Point(53, 218);
            this.richTextBoxSmtp.Name = "richTextBoxSmtp";
            this.richTextBoxSmtp.Size = new System.Drawing.Size(218, 21);
            this.richTextBoxSmtp.TabIndex = 0;
            this.richTextBoxSmtp.Text = "";
            // 
            // richTextBoxPop
            // 
            this.richTextBoxPop.Location = new System.Drawing.Point(53, 263);
            this.richTextBoxPop.Name = "richTextBoxPop";
            this.richTextBoxPop.Size = new System.Drawing.Size(218, 21);
            this.richTextBoxPop.TabIndex = 1;
            this.richTextBoxPop.Text = "";
            // 
            // labelSmtptext
            // 
            this.labelSmtptext.AutoSize = true;
            this.labelSmtptext.Location = new System.Drawing.Point(12, 226);
            this.labelSmtptext.Name = "labelSmtptext";
            this.labelSmtptext.Size = new System.Drawing.Size(31, 13);
            this.labelSmtptext.TabIndex = 2;
            this.labelSmtptext.Text = "Smtp";
            // 
            // labelPop
            // 
            this.labelPop.AutoSize = true;
            this.labelPop.Location = new System.Drawing.Point(12, 271);
            this.labelPop.Name = "labelPop";
            this.labelPop.Size = new System.Drawing.Size(26, 13);
            this.labelPop.TabIndex = 3;
            this.labelPop.Text = "Pop";
            // 
            // labelSmtp
            // 
            this.labelSmtp.AutoSize = true;
            this.labelSmtp.Location = new System.Drawing.Point(280, 224);
            this.labelSmtp.Name = "labelSmtp";
            this.labelSmtp.Size = new System.Drawing.Size(32, 13);
            this.labelSmtp.TabIndex = 4;
            this.labelSmtp.Text = "Porta";
            // 
            // labelPop2
            // 
            this.labelPop2.AutoSize = true;
            this.labelPop2.Location = new System.Drawing.Point(278, 269);
            this.labelPop2.Name = "labelPop2";
            this.labelPop2.Size = new System.Drawing.Size(32, 13);
            this.labelPop2.TabIndex = 5;
            this.labelPop2.Text = "Porta";
            // 
            // richTextBoxSmtpPorta
            // 
            this.richTextBoxSmtpPorta.Location = new System.Drawing.Point(327, 217);
            this.richTextBoxSmtpPorta.Name = "richTextBoxSmtpPorta";
            this.richTextBoxSmtpPorta.Size = new System.Drawing.Size(58, 21);
            this.richTextBoxSmtpPorta.TabIndex = 6;
            this.richTextBoxSmtpPorta.Text = "";
            // 
            // richTextBoxPopPorta
            // 
            this.richTextBoxPopPorta.Location = new System.Drawing.Point(327, 263);
            this.richTextBoxPopPorta.Name = "richTextBoxPopPorta";
            this.richTextBoxPopPorta.Size = new System.Drawing.Size(58, 21);
            this.richTextBoxPopPorta.TabIndex = 7;
            this.richTextBoxPopPorta.Text = "";
            // 
            // checkBoxSslSmtp
            // 
            this.checkBoxSslSmtp.AutoSize = true;
            this.checkBoxSslSmtp.Location = new System.Drawing.Point(414, 220);
            this.checkBoxSslSmtp.Name = "checkBoxSslSmtp";
            this.checkBoxSslSmtp.Size = new System.Drawing.Size(40, 17);
            this.checkBoxSslSmtp.TabIndex = 9;
            this.checkBoxSslSmtp.Text = "Ssl";
            this.checkBoxSslSmtp.UseVisualStyleBackColor = true;
            // 
            // checkBoxSslPop
            // 
            this.checkBoxSslPop.AutoSize = true;
            this.checkBoxSslPop.Location = new System.Drawing.Point(414, 263);
            this.checkBoxSslPop.Name = "checkBoxSslPop";
            this.checkBoxSslPop.Size = new System.Drawing.Size(40, 17);
            this.checkBoxSslPop.TabIndex = 10;
            this.checkBoxSslPop.Text = "Ssl";
            this.checkBoxSslPop.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2OnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Liberar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1OnClick);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(379, 377);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 13;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // richTextBoxNome
            // 
            this.richTextBoxNome.Location = new System.Drawing.Point(53, 170);
            this.richTextBoxNome.Name = "richTextBoxNome";
            this.richTextBoxNome.Size = new System.Drawing.Size(332, 21);
            this.richTextBoxNome.TabIndex = 14;
            this.richTextBoxNome.Text = "";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(7, 173);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(46, 13);
            this.labelNome.TabIndex = 15;
            this.labelNome.Text = "Servidor";
            // 
            // IServidorEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 453);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.richTextBoxNome);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBoxSslPop);
            this.Controls.Add(this.checkBoxSslSmtp);
            this.Controls.Add(this.richTextBoxPopPorta);
            this.Controls.Add(this.richTextBoxSmtpPorta);
            this.Controls.Add(this.labelPop2);
            this.Controls.Add(this.labelSmtp);
            this.Controls.Add(this.labelPop);
            this.Controls.Add(this.labelSmtptext);
            this.Controls.Add(this.richTextBoxPop);
            this.Controls.Add(this.richTextBoxSmtp);
            this.Name = "IServidorEmail";
            this.Text = "IServidorEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSmtp;
        private System.Windows.Forms.RichTextBox richTextBoxPop;
        private System.Windows.Forms.Label labelSmtptext;
        private System.Windows.Forms.Label labelPop;
        private System.Windows.Forms.Label labelSmtp;
        private System.Windows.Forms.Label labelPop2;
        private System.Windows.Forms.RichTextBox richTextBoxSmtpPorta;
        private System.Windows.Forms.RichTextBox richTextBoxPopPorta;
        private System.Windows.Forms.CheckBox checkBoxSslSmtp;
        private System.Windows.Forms.CheckBox checkBoxSslPop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.RichTextBox richTextBoxNome;
        private System.Windows.Forms.Label labelNome;
    }
}