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
            this.dataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.observacaoTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.observacaoTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.tabControl1.Location = new System.Drawing.Point(5, 78);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 157);
            this.tabControl1.TabIndex = 81;
            // 
            // observacaoTabPage
            // 
            this.observacaoTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.observacaoTabPage.Controls.Add(this.ObservacaoTextBox);
            this.observacaoTabPage.Location = new System.Drawing.Point(4, 25);
            this.observacaoTabPage.Name = "observacaoTabPage";
            this.observacaoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.observacaoTabPage.Size = new System.Drawing.Size(763, 128);
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
            this.liberarButton.Location = new System.Drawing.Point(362, 241);
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
            this.voltarButton.Location = new System.Drawing.Point(466, 241);
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
            this.cancelarButton.Location = new System.Drawing.Point(569, 241);
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
            this.gravarButton.Location = new System.Drawing.Point(673, 241);
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
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(3, 3);
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
            this.tipoComboBox.Location = new System.Drawing.Point(6, 20);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(202, 24);
            this.tipoComboBox.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label12.Font = new System.Drawing.Font("Arial", 10F);
            this.label12.Location = new System.Drawing.Point(678, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 77;
            this.label12.Text = "Tarefa";
            // 
            // tarefaTextBox
            // 
            this.tarefaTextBox.Font = new System.Drawing.Font("Arial", 9F);
            this.tarefaTextBox.Location = new System.Drawing.Point(681, 22);
            this.tarefaTextBox.Name = "tarefaTextBox";
            this.tarefaTextBox.Size = new System.Drawing.Size(81, 21);
            this.tarefaTextBox.TabIndex = 70;
            // 
            // excluirButton
            // 
            this.excluirButton.Font = new System.Drawing.Font("Arial", 10F);
            this.excluirButton.Location = new System.Drawing.Point(253, 241);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(103, 32);
            this.excluirButton.TabIndex = 82;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Visible = false;
            this.excluirButton.Click += new System.EventHandler(this.ExcluirButtonOnClick);
            // 
            // dataTimePicker
            // 
            this.dataTimePicker.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dataTimePicker.Font = new System.Drawing.Font("Arial", 9F);
            this.dataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataTimePicker.Location = new System.Drawing.Point(524, 22);
            this.dataTimePicker.Name = "dataTimePicker";
            this.dataTimePicker.Size = new System.Drawing.Size(139, 21);
            this.dataTimePicker.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 84;
            this.label8.Text = "Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dataTimePicker);
            this.panel1.Controls.Add(this.tipoComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tarefaTextBox);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 62);
            this.panel1.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(212, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Assunto";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox1.Location = new System.Drawing.Point(214, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 23);
            this.textBox1.TabIndex = 85;
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ITarefaDocumentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentação";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DocumentacaoFormClosed);
            this.tabControl1.ResumeLayout(false);
            this.observacaoTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DateTimePicker dataTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}