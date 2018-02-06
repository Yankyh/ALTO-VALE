namespace ALTO_VALE.VIEW.MD_SISTEMA
{
    partial class IAnexoPadrao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IAnexoPadrao));
            this.excluirButton = new System.Windows.Forms.Button();
            this.exibirButton = new System.Windows.Forms.Button();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gravarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.caminhoAnexoTextBox = new System.Windows.Forms.TextBox();
            this.selecionarAnexoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // excluirButton
            // 
            this.excluirButton.Font = new System.Drawing.Font("Arial", 9F);
            this.excluirButton.Location = new System.Drawing.Point(161, 117);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(103, 32);
            this.excluirButton.TabIndex = 31;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Visible = false;
            this.excluirButton.Click += new System.EventHandler(this.excluirButtonOnClick);
            // 
            // exibirButton
            // 
            this.exibirButton.Font = new System.Drawing.Font("Arial", 9F);
            this.exibirButton.Location = new System.Drawing.Point(270, 117);
            this.exibirButton.Name = "exibirButton";
            this.exibirButton.Size = new System.Drawing.Size(103, 32);
            this.exibirButton.TabIndex = 32;
            this.exibirButton.Text = "Exibir";
            this.exibirButton.UseVisualStyleBackColor = true;
            this.exibirButton.Visible = false;
            this.exibirButton.Click += new System.EventHandler(this.exibirButtonOnClick);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.descricaoTextBox.Location = new System.Drawing.Point(15, 28);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(456, 23);
            this.descricaoTextBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Descrição / Nome";
            // 
            // gravarButton
            // 
            this.gravarButton.Font = new System.Drawing.Font("Arial", 9F);
            this.gravarButton.Location = new System.Drawing.Point(375, 117);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(103, 32);
            this.gravarButton.TabIndex = 33;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButtonOnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Arquivo";
            // 
            // caminhoAnexoTextBox
            // 
            this.caminhoAnexoTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.caminhoAnexoTextBox.Location = new System.Drawing.Point(4, 66);
            this.caminhoAnexoTextBox.Name = "caminhoAnexoTextBox";
            this.caminhoAnexoTextBox.ReadOnly = true;
            this.caminhoAnexoTextBox.Size = new System.Drawing.Size(418, 23);
            this.caminhoAnexoTextBox.TabIndex = 30;
            // 
            // selecionarAnexoButton
            // 
            this.selecionarAnexoButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionarAnexoButton.Location = new System.Drawing.Point(425, 66);
            this.selecionarAnexoButton.Name = "selecionarAnexoButton";
            this.selecionarAnexoButton.Size = new System.Drawing.Size(35, 23);
            this.selecionarAnexoButton.TabIndex = 35;
            this.selecionarAnexoButton.Text = "....";
            this.selecionarAnexoButton.UseVisualStyleBackColor = true;
            this.selecionarAnexoButton.Click += new System.EventHandler(this.selecionarAnexoButtonOnclick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.selecionarAnexoButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.caminhoAnexoTextBox);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 98);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(9, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 6);
            this.panel2.TabIndex = 38;
            // 
            // IAnexoPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 152);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.exibirButton);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IAnexoPadrao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anexo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnexoOnFormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button exibirButton;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caminhoAnexoTextBox;
        private System.Windows.Forms.Button selecionarAnexoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}