namespace ALTO_VALE.VIEW.TR_TAREFA
{
    partial class ITarefaEncaminhamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ITarefaEncaminhamento));
            this.excluirButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.observacaoTabPage = new System.Windows.Forms.TabPage();
            this.descricaoTextBox = new System.Windows.Forms.RichTextBox();
            this.anexoTabPage = new System.Windows.Forms.TabPage();
            this.adicionarAnexoButton = new System.Windows.Forms.Button();
            this.anexoDataGridView = new System.Windows.Forms.DataGridView();
            this.liberarButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.gravarButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.assuntoTextBox = new System.Windows.Forms.TextBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tipoEncaminhamentoComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tarefaTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.severidadeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.responsavelComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.observacaoTabPage.SuspendLayout();
            this.anexoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anexoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // excluirButton
            // 
            this.excluirButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirButton.Location = new System.Drawing.Point(261, 320);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(103, 32);
            this.excluirButton.TabIndex = 12;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.observacaoTabPage);
            this.tabControl1.Controls.Add(this.anexoTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.tabControl1.Location = new System.Drawing.Point(6, 184);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 134);
            this.tabControl1.TabIndex = 90;
            // 
            // observacaoTabPage
            // 
            this.observacaoTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.observacaoTabPage.Controls.Add(this.descricaoTextBox);
            this.observacaoTabPage.Location = new System.Drawing.Point(4, 25);
            this.observacaoTabPage.Name = "observacaoTabPage";
            this.observacaoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.observacaoTabPage.Size = new System.Drawing.Size(770, 105);
            this.observacaoTabPage.TabIndex = 1;
            this.observacaoTabPage.Text = "Descrição";
            this.observacaoTabPage.UseVisualStyleBackColor = true;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BackColor = System.Drawing.Color.White;
            this.descricaoTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(1, 1);
            this.descricaoTextBox.MaxLength = 2000;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(766, 101);
            this.descricaoTextBox.TabIndex = 7;
            this.descricaoTextBox.Text = "";
            // 
            // anexoTabPage
            // 
            this.anexoTabPage.Controls.Add(this.adicionarAnexoButton);
            this.anexoTabPage.Controls.Add(this.anexoDataGridView);
            this.anexoTabPage.Location = new System.Drawing.Point(4, 25);
            this.anexoTabPage.Name = "anexoTabPage";
            this.anexoTabPage.Size = new System.Drawing.Size(770, 105);
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
            // 
            // anexoDataGridView
            // 
            this.anexoDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.anexoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.anexoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.anexoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.anexoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.anexoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.anexoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8F);
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 8F);
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
            // 
            // liberarButton
            // 
            this.liberarButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liberarButton.Location = new System.Drawing.Point(370, 320);
            this.liberarButton.Name = "liberarButton";
            this.liberarButton.Size = new System.Drawing.Size(103, 32);
            this.liberarButton.TabIndex = 9;
            this.liberarButton.Text = "Liberar";
            this.liberarButton.UseVisualStyleBackColor = true;
            this.liberarButton.Visible = false;
            // 
            // voltarButton
            // 
            this.voltarButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarButton.Location = new System.Drawing.Point(474, 320);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(103, 32);
            this.voltarButton.TabIndex = 10;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.Location = new System.Drawing.Point(577, 320);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(103, 32);
            this.cancelarButton.TabIndex = 11;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // gravarButton
            // 
            this.gravarButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravarButton.Location = new System.Drawing.Point(681, 320);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(103, 32);
            this.gravarButton.TabIndex = 8;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.assuntoTextBox);
            this.panel1.Controls.Add(this.dataTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tipoEncaminhamentoComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tarefaTextBox);
            this.panel1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 64);
            this.panel1.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label2.Location = new System.Drawing.Point(167, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 89;
            this.label2.Text = "Assunto";
            // 
            // assuntoTextBox
            // 
            this.assuntoTextBox.BackColor = System.Drawing.Color.LightGray;
            this.assuntoTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.assuntoTextBox.Location = new System.Drawing.Point(170, 25);
            this.assuntoTextBox.MaxLength = 60;
            this.assuntoTextBox.Name = "assuntoTextBox";
            this.assuntoTextBox.Size = new System.Drawing.Size(374, 23);
            this.assuntoTextBox.TabIndex = 2;
            // 
            // dataTextBox
            // 
            this.dataTextBox.BackColor = System.Drawing.Color.LightGray;
            this.dataTextBox.Enabled = false;
            this.dataTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.dataTextBox.Location = new System.Drawing.Point(550, 25);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(127, 23);
            this.dataTextBox.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label8.Location = new System.Drawing.Point(547, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 18);
            this.label8.TabIndex = 84;
            this.label8.Text = "Data";
            // 
            // tipoEncaminhamentoComboBox
            // 
            this.tipoEncaminhamentoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tipoEncaminhamentoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tipoEncaminhamentoComboBox.BackColor = System.Drawing.Color.LightGray;
            this.tipoEncaminhamentoComboBox.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.tipoEncaminhamentoComboBox.FormattingEnabled = true;
            this.tipoEncaminhamentoComboBox.Location = new System.Drawing.Point(6, 25);
            this.tipoEncaminhamentoComboBox.Name = "tipoEncaminhamentoComboBox";
            this.tipoEncaminhamentoComboBox.Size = new System.Drawing.Size(158, 24);
            this.tipoEncaminhamentoComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "Tipo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label12.Location = new System.Drawing.Point(680, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 18);
            this.label12.TabIndex = 77;
            this.label12.Text = "Tarefa";
            // 
            // tarefaTextBox
            // 
            this.tarefaTextBox.BackColor = System.Drawing.Color.LightGray;
            this.tarefaTextBox.Enabled = false;
            this.tarefaTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.tarefaTextBox.Location = new System.Drawing.Point(683, 25);
            this.tarefaTextBox.Name = "tarefaTextBox";
            this.tarefaTextBox.Size = new System.Drawing.Size(85, 23);
            this.tarefaTextBox.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.situacaoComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.severidadeComboBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tipoComboBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.responsavelComboBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(6, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 104);
            this.panel2.TabIndex = 93;
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.situacaoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.situacaoComboBox.BackColor = System.Drawing.Color.LightGray;
            this.situacaoComboBox.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Location = new System.Drawing.Point(214, 25);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(251, 24);
            this.situacaoComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label1.Location = new System.Drawing.Point(211, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 95;
            this.label1.Text = "Situação";
            // 
            // severidadeComboBox
            // 
            this.severidadeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.severidadeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.severidadeComboBox.BackColor = System.Drawing.Color.LightGray;
            this.severidadeComboBox.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.severidadeComboBox.FormattingEnabled = true;
            this.severidadeComboBox.Location = new System.Drawing.Point(6, 71);
            this.severidadeComboBox.Name = "severidadeComboBox";
            this.severidadeComboBox.Size = new System.Drawing.Size(202, 24);
            this.severidadeComboBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label7.Location = new System.Drawing.Point(3, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 93;
            this.label7.Text = "Severidade";
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tipoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tipoComboBox.BackColor = System.Drawing.Color.LightGray;
            this.tipoComboBox.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(471, 25);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(297, 24);
            this.tipoComboBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label9.Location = new System.Drawing.Point(467, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 91;
            this.label9.Text = "Tipo";
            // 
            // responsavelComboBox
            // 
            this.responsavelComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.responsavelComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.responsavelComboBox.BackColor = System.Drawing.Color.LightGray;
            this.responsavelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.responsavelComboBox.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.responsavelComboBox.FormattingEnabled = true;
            this.responsavelComboBox.Location = new System.Drawing.Point(6, 25);
            this.responsavelComboBox.Name = "responsavelComboBox";
            this.responsavelComboBox.Size = new System.Drawing.Size(202, 24);
            this.responsavelComboBox.TabIndex = 3;
            this.responsavelComboBox.DropDown += new System.EventHandler(this.ResponsavelOnDropDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label10.Location = new System.Drawing.Point(3, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 89;
            this.label10.Text = "Responsável";
            // 
            // ITarefaEncaminhamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 355);
            this.Controls.Add(this.panel2);
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
            this.Name = "ITarefaEncaminhamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encaminhamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.tabControl1.ResumeLayout(false);
            this.observacaoTabPage.ResumeLayout(false);
            this.anexoTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anexoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage observacaoTabPage;
        private System.Windows.Forms.RichTextBox descricaoTextBox;
        private System.Windows.Forms.TabPage anexoTabPage;
        private System.Windows.Forms.Button adicionarAnexoButton;
        private System.Windows.Forms.DataGridView anexoDataGridView;
        private System.Windows.Forms.Button liberarButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tipoEncaminhamentoComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tarefaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox assuntoTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox situacaoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox severidadeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox responsavelComboBox;
        private System.Windows.Forms.Label label10;
    }
}