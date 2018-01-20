namespace ALTO_VALE.VIEW.TR_TAREFA
{
    partial class ITarefaDocumentacao
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.observacaoTabPage = new System.Windows.Forms.TabPage();
            this.ObservacaoTextBox = new System.Windows.Forms.RichTextBox();
            this.liberarButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.gravarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tarefaTextBox = new System.Windows.Forms.TextBox();
            this.excluirButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.observacaoTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.observacaoTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.tabControl1.Location = new System.Drawing.Point(10, 109);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 157);
            this.tabControl1.TabIndex = 81;
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
            this.ObservacaoTextBox.TabIndex = 5;
            this.ObservacaoTextBox.Text = "";
            // 
            // liberarButton
            // 
            this.liberarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.liberarButton.Location = new System.Drawing.Point(360, 269);
            this.liberarButton.Name = "liberarButton";
            this.liberarButton.Size = new System.Drawing.Size(103, 32);
            this.liberarButton.TabIndex = 73;
            this.liberarButton.Text = "Liberar";
            this.liberarButton.UseVisualStyleBackColor = true;
            this.liberarButton.Visible = false;
            this.liberarButton.Click += new System.EventHandler(this.LiberarButtonOnClick);
            // 
            // voltarButton
            // 
            this.voltarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.voltarButton.Location = new System.Drawing.Point(464, 269);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(103, 32);
            this.voltarButton.TabIndex = 74;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.VoltarButtonOnClick);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.cancelarButton.Location = new System.Drawing.Point(567, 269);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(103, 32);
            this.cancelarButton.TabIndex = 75;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButtonOnClick);
            // 
            // gravarButton
            // 
            this.gravarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.gravarButton.Location = new System.Drawing.Point(671, 269);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(103, 32);
            this.gravarButton.TabIndex = 76;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.GravarButtonOnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Tipo";
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoComboBox.Font = new System.Drawing.Font("Arial", 10F);
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(10, 28);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(202, 24);
            this.tipoComboBox.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 10F);
            this.label12.Location = new System.Drawing.Point(702, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 77;
            this.label12.Text = "Tarefa";
            // 
            // tarefaTextBox
            // 
            this.tarefaTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.tarefaTextBox.Location = new System.Drawing.Point(705, 29);
            this.tarefaTextBox.Name = "tarefaTextBox";
            this.tarefaTextBox.Size = new System.Drawing.Size(69, 23);
            this.tarefaTextBox.TabIndex = 70;
            // 
            // excluirButton
            // 
            this.excluirButton.Font = new System.Drawing.Font("Arial", 10F);
            this.excluirButton.Location = new System.Drawing.Point(251, 269);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(103, 32);
            this.excluirButton.TabIndex = 82;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Visible = false;
            this.excluirButton.Click += new System.EventHandler(this.ExcluirButtonOnClick);
            // 
            // ITarefaDocumentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 308);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.liberarButton);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tarefaTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ITarefaDocumentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentação";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DocumentacaoFormClosed);
            this.tabControl1.ResumeLayout(false);
            this.observacaoTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage observacaoTabPage;
        private System.Windows.Forms.RichTextBox ObservacaoTextBox;
        private System.Windows.Forms.Button liberarButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tarefaTextBox;
        private System.Windows.Forms.Button excluirButton;
    }
}