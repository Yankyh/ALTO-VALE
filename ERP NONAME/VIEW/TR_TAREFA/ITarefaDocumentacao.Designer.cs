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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ITarefaDocumentacao));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.observacaoTabPage = new System.Windows.Forms.TabPage();
            this.ObservacaoTextBox = new System.Windows.Forms.RichTextBox();
            this.anexoTabPage = new System.Windows.Forms.TabPage();
            this.adicionarAnexoButton = new System.Windows.Forms.Button();
            this.anexoDataGridView = new System.Windows.Forms.DataGridView();
            this.liberarButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.gravarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tarefaTextBox = new System.Windows.Forms.TextBox();
            this.excluirButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.assuntoTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.observacaoTabPage.SuspendLayout();
            this.anexoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anexoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.observacaoTabPage);
            this.tabControl1.Controls.Add(this.anexoTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9F);
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
            this.observacaoTabPage.Location = new System.Drawing.Point(4, 24);
            this.observacaoTabPage.Name = "observacaoTabPage";
            this.observacaoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.observacaoTabPage.Size = new System.Drawing.Size(763, 129);
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
            // anexoTabPage
            // 
            this.anexoTabPage.Controls.Add(this.adicionarAnexoButton);
            this.anexoTabPage.Controls.Add(this.anexoDataGridView);
            this.anexoTabPage.Location = new System.Drawing.Point(4, 24);
            this.anexoTabPage.Name = "anexoTabPage";
            this.anexoTabPage.Size = new System.Drawing.Size(763, 129);
            this.anexoTabPage.TabIndex = 2;
            this.anexoTabPage.Text = "Anexo";
            this.anexoTabPage.UseVisualStyleBackColor = true;
            // 
            // adicionarAnexoButton
            // 
            this.adicionarAnexoButton.FlatAppearance.BorderSize = 0;
            this.adicionarAnexoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarAnexoButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarAnexoButton.Location = new System.Drawing.Point(737, 2);
            this.adicionarAnexoButton.Name = "adicionarAnexoButton";
            this.adicionarAnexoButton.Size = new System.Drawing.Size(24, 25);
            this.adicionarAnexoButton.TabIndex = 67;
            this.adicionarAnexoButton.Text = "+";
            this.adicionarAnexoButton.UseVisualStyleBackColor = false;
            this.adicionarAnexoButton.Click += new System.EventHandler(this.adicionarAnexoButtonOnClick);
            // 
            // anexoDataGridView
            // 
            this.anexoDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.anexoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.anexoDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.anexoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.anexoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.anexoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.anexoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.anexoDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.anexoDataGridView.Location = new System.Drawing.Point(2, 2);
            this.anexoDataGridView.MultiSelect = false;
            this.anexoDataGridView.Name = "anexoDataGridView";
            this.anexoDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.anexoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.anexoDataGridView.RowHeadersVisible = false;
            this.anexoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.anexoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.anexoDataGridView.Size = new System.Drawing.Size(733, 126);
            this.anexoDataGridView.TabIndex = 66;
            this.anexoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnexoDataGridViewDoubleClick);
            // 
            // liberarButton
            // 
            this.liberarButton.Font = new System.Drawing.Font("Arial", 9F);
            this.liberarButton.Location = new System.Drawing.Point(362, 235);
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
            this.voltarButton.Font = new System.Drawing.Font("Arial", 9F);
            this.voltarButton.Location = new System.Drawing.Point(466, 235);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(103, 32);
            this.voltarButton.TabIndex = 74;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.VoltarButtonOnClick);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Font = new System.Drawing.Font("Arial", 9F);
            this.cancelarButton.Location = new System.Drawing.Point(569, 235);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(103, 32);
            this.cancelarButton.TabIndex = 75;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButtonOnClick);
            // 
            // gravarButton
            // 
            this.gravarButton.Font = new System.Drawing.Font("Arial", 9F);
            this.gravarButton.Location = new System.Drawing.Point(673, 235);
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
            this.label12.Location = new System.Drawing.Point(675, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 77;
            this.label12.Text = "Tarefa";
            // 
            // tarefaTextBox
            // 
            this.tarefaTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.tarefaTextBox.Location = new System.Drawing.Point(678, 21);
            this.tarefaTextBox.Name = "tarefaTextBox";
            this.tarefaTextBox.Size = new System.Drawing.Size(85, 23);
            this.tarefaTextBox.TabIndex = 70;
            // 
            // excluirButton
            // 
            this.excluirButton.Font = new System.Drawing.Font("Arial", 9F);
            this.excluirButton.Location = new System.Drawing.Point(253, 235);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(103, 32);
            this.excluirButton.TabIndex = 82;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Visible = false;
            this.excluirButton.Click += new System.EventHandler(this.ExcluirButtonOnClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.Location = new System.Drawing.Point(518, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 84;
            this.label8.Text = "Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.assuntoTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tipoComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tarefaTextBox);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 62);
            this.panel1.TabIndex = 85;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Enabled = false;
            this.dataTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.dataTextBox.Location = new System.Drawing.Point(517, 21);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(157, 23);
            this.dataTextBox.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(209, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Assunto";
            // 
            // assuntoTextBox
            // 
            this.assuntoTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.assuntoTextBox.Location = new System.Drawing.Point(211, 21);
            this.assuntoTextBox.Name = "assuntoTextBox";
            this.assuntoTextBox.Size = new System.Drawing.Size(303, 23);
            this.assuntoTextBox.TabIndex = 85;
            // 
            // ITarefaDocumentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 269);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.liberarButton);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ITarefaDocumentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentação";
            this.Activated += new System.EventHandler(this.DocumentacaoOnFocus);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DocumentacaoFormClosed);
            this.tabControl1.ResumeLayout(false);
            this.observacaoTabPage.ResumeLayout(false);
            this.anexoTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anexoDataGridView)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox assuntoTextBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.TabPage anexoTabPage;
        private System.Windows.Forms.DataGridView anexoDataGridView;
        private System.Windows.Forms.Button adicionarAnexoButton;
    }
}