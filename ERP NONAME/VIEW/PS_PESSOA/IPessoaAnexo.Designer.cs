namespace ALTO_VALE.VIEW.PS_PESSOA
{
    partial class IPessoaAnexo
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
            this.selecionarAnexoButton = new System.Windows.Forms.Button();
            this.caminhoAnexoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gravarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.exibirButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selecionarAnexoButton
            // 
            this.selecionarAnexoButton.Location = new System.Drawing.Point(439, 68);
            this.selecionarAnexoButton.Name = "selecionarAnexoButton";
            this.selecionarAnexoButton.Size = new System.Drawing.Size(35, 23);
            this.selecionarAnexoButton.TabIndex = 3;
            this.selecionarAnexoButton.Text = "....";
            this.selecionarAnexoButton.UseVisualStyleBackColor = true;
            this.selecionarAnexoButton.Click += new System.EventHandler(this.selecionarAnexoButtonOnclick);
            // 
            // caminhoAnexoTextBox
            // 
            this.caminhoAnexoTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caminhoAnexoTextBox.Location = new System.Drawing.Point(9, 68);
            this.caminhoAnexoTextBox.Name = "caminhoAnexoTextBox";
            this.caminhoAnexoTextBox.Size = new System.Drawing.Size(428, 22);
            this.caminhoAnexoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arquivo";
          
            // 
            // gravarButton
            // 
            this.gravarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.gravarButton.Location = new System.Drawing.Point(373, 107);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(103, 32);
            this.gravarButton.TabIndex = 6;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButtonOnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Descrição";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(9, 24);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(465, 22);
            this.descricaoTextBox.TabIndex = 1;
            // 
            // exibirButton
            // 
            this.exibirButton.Font = new System.Drawing.Font("Arial", 10F);
            this.exibirButton.Location = new System.Drawing.Point(268, 107);
            this.exibirButton.Name = "exibirButton";
            this.exibirButton.Size = new System.Drawing.Size(103, 32);
            this.exibirButton.TabIndex = 5;
            this.exibirButton.Text = "Exibir";
            this.exibirButton.UseVisualStyleBackColor = true;
            this.exibirButton.Visible = false;
            this.exibirButton.Click += new System.EventHandler(this.exibirButtonOnClick);
            // 
            // excluirButton
            // 
            this.excluirButton.Font = new System.Drawing.Font("Arial", 10F);
            this.excluirButton.Location = new System.Drawing.Point(159, 107);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(103, 32);
            this.excluirButton.TabIndex = 4;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Visible = false;
            this.excluirButton.Click += new System.EventHandler(this.excluirButtonOnClick);
            // 
            // IPessoaAnexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 142);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.exibirButton);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caminhoAnexoTextBox);
            this.Controls.Add(this.selecionarAnexoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPessoaAnexo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anexo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.anexoFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selecionarAnexoButton;
        private System.Windows.Forms.TextBox caminhoAnexoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button exibirButton;
        private System.Windows.Forms.Button excluirButton;
    }
}