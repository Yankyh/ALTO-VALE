namespace ALTO_VALE.VIEW.PS_PESSOA
{
    partial class IPessoaContato
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
            this.label1 = new System.Windows.Forms.Label();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.liberarButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.gravarButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.observacaoTabPage = new System.Windows.Forms.TabPage();
            this.ObservacaoTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.observacaoTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(382, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Celular";
            // 
            // celularTextBox
            // 
            this.celularTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.celularTextBox.Location = new System.Drawing.Point(385, 29);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(170, 23);
            this.celularTextBox.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Tipo";
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoComboBox.Font = new System.Drawing.Font("Arial", 10F);
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(6, 28);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(202, 24);
            this.tipoComboBox.TabIndex = 47;
            this.tipoComboBox.DropDown += new System.EventHandler(this.tipoDropDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 10F);
            this.label12.Location = new System.Drawing.Point(209, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 54;
            this.label12.Text = "Telefone";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.telefoneTextBox.Location = new System.Drawing.Point(212, 29);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(170, 23);
            this.telefoneTextBox.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(555, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "E-mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.emailTextBox.Location = new System.Drawing.Point(558, 29);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(213, 23);
            this.emailTextBox.TabIndex = 59;
            // 
            // liberarButton
            // 
            this.liberarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.liberarButton.Location = new System.Drawing.Point(357, 228);
            this.liberarButton.Name = "liberarButton";
            this.liberarButton.Size = new System.Drawing.Size(103, 32);
            this.liberarButton.TabIndex = 65;
            this.liberarButton.Text = "Liberar";
            this.liberarButton.UseVisualStyleBackColor = true;
            this.liberarButton.Visible = false;
            this.liberarButton.Click += new System.EventHandler(this.liberarButtonOnClick);
            // 
            // voltarButton
            // 
            this.voltarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.voltarButton.Location = new System.Drawing.Point(461, 228);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(103, 32);
            this.voltarButton.TabIndex = 64;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButtonOnClick);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.cancelarButton.Location = new System.Drawing.Point(564, 228);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(103, 32);
            this.cancelarButton.TabIndex = 62;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButtonOnClick);
            // 
            // gravarButton
            // 
            this.gravarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.gravarButton.Location = new System.Drawing.Point(668, 228);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(103, 32);
            this.gravarButton.TabIndex = 63;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButtonOnClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.observacaoTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.tabControl1.Location = new System.Drawing.Point(6, 69);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 157);
            this.tabControl1.TabIndex = 66;
            // 
            // observacaoTabPage
            // 
            this.observacaoTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.observacaoTabPage.Controls.Add(this.ObservacaoTextBox);
            this.observacaoTabPage.Location = new System.Drawing.Point(4, 25);
            this.observacaoTabPage.Name = "observacaoTabPage";
            this.observacaoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.observacaoTabPage.Size = new System.Drawing.Size(757, 128);
            this.observacaoTabPage.TabIndex = 1;
            this.observacaoTabPage.Text = "Observação";
            this.observacaoTabPage.UseVisualStyleBackColor = true;
            // 
            // ObservacaoTextBox
            // 
            this.ObservacaoTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.ObservacaoTextBox.Location = new System.Drawing.Point(1, 1);
            this.ObservacaoTextBox.MaxLength = 999;
            this.ObservacaoTextBox.Name = "ObservacaoTextBox";
            this.ObservacaoTextBox.Size = new System.Drawing.Size(753, 123);
            this.ObservacaoTextBox.TabIndex = 9;
            this.ObservacaoTextBox.Text = "";
            // 
            // IPessoaContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 263);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.liberarButton);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.telefoneTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPessoaContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contato";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.contatoFormClosed);
            this.tabControl1.ResumeLayout(false);
            this.observacaoTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button liberarButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage observacaoTabPage;
        private System.Windows.Forms.RichTextBox ObservacaoTextBox;
    }
}