﻿namespace ALTO_VALE.VIEW.PS_PESSOA
{
    partial class IPessoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.observacaoTabPage = new System.Windows.Forms.TabPage();
            this.ObservacaoTextBox = new System.Windows.Forms.RichTextBox();
            this.abrangenciaTabPage = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.fornecedorCheckBox = new System.Windows.Forms.CheckBox();
            this.clienteCheckBox = new System.Windows.Forms.CheckBox();
            this.contatoTabPage = new System.Windows.Forms.TabPage();
            this.removerContatoButton = new System.Windows.Forms.Button();
            this.adicionarContatoButton = new System.Windows.Forms.Button();
            this.contatoDataGridView = new System.Windows.Forms.DataGridView();
            this.pessoaEnderecoTabpage = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.gravarButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cpfcnpjTextBox = new System.Windows.Forms.TextBox();
            this.razaoSocialTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.apelidoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.voltarButton = new System.Windows.Forms.Button();
            this.liberarButton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.enderecoDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.observacaoTabPage.SuspendLayout();
            this.abrangenciaTabPage.SuspendLayout();
            this.contatoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contatoDataGridView)).BeginInit();
            this.pessoaEnderecoTabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.observacaoTabPage);
            this.tabControl.Controls.Add(this.abrangenciaTabPage);
            this.tabControl.Controls.Add(this.contatoTabPage);
            this.tabControl.Controls.Add(this.pessoaEnderecoTabpage);
            this.tabControl.Font = new System.Drawing.Font("Arial", 10F);
            this.tabControl.Location = new System.Drawing.Point(6, 126);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(971, 157);
            this.tabControl.TabIndex = 22;
            // 
            // observacaoTabPage
            // 
            this.observacaoTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.observacaoTabPage.Controls.Add(this.ObservacaoTextBox);
            this.observacaoTabPage.Location = new System.Drawing.Point(4, 25);
            this.observacaoTabPage.Name = "observacaoTabPage";
            this.observacaoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.observacaoTabPage.Size = new System.Drawing.Size(963, 128);
            this.observacaoTabPage.TabIndex = 1;
            this.observacaoTabPage.Text = "Observação";
            this.observacaoTabPage.UseVisualStyleBackColor = true;
            // 
            // ObservacaoTextBox
            // 
            this.ObservacaoTextBox.Location = new System.Drawing.Point(1, 1);
            this.ObservacaoTextBox.MaxLength = 999;
            this.ObservacaoTextBox.Name = "ObservacaoTextBox";
            this.ObservacaoTextBox.Size = new System.Drawing.Size(960, 120);
            this.ObservacaoTextBox.TabIndex = 0;
            this.ObservacaoTextBox.Text = "";
            // 
            // abrangenciaTabPage
            // 
            this.abrangenciaTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.abrangenciaTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.abrangenciaTabPage.Controls.Add(this.checkBox3);
            this.abrangenciaTabPage.Controls.Add(this.fornecedorCheckBox);
            this.abrangenciaTabPage.Controls.Add(this.clienteCheckBox);
            this.abrangenciaTabPage.Location = new System.Drawing.Point(4, 25);
            this.abrangenciaTabPage.Name = "abrangenciaTabPage";
            this.abrangenciaTabPage.Size = new System.Drawing.Size(963, 128);
            this.abrangenciaTabPage.TabIndex = 3;
            this.abrangenciaTabPage.Text = "Abrangência";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 83);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(116, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Orgão público";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // fornecedorCheckBox
            // 
            this.fornecedorCheckBox.AutoSize = true;
            this.fornecedorCheckBox.Location = new System.Drawing.Point(15, 49);
            this.fornecedorCheckBox.Name = "fornecedorCheckBox";
            this.fornecedorCheckBox.Size = new System.Drawing.Size(101, 20);
            this.fornecedorCheckBox.TabIndex = 1;
            this.fornecedorCheckBox.Text = "Fornecedor";
            this.fornecedorCheckBox.UseVisualStyleBackColor = true;
            // 
            // clienteCheckBox
            // 
            this.clienteCheckBox.AutoSize = true;
            this.clienteCheckBox.Location = new System.Drawing.Point(15, 16);
            this.clienteCheckBox.Name = "clienteCheckBox";
            this.clienteCheckBox.Size = new System.Drawing.Size(71, 20);
            this.clienteCheckBox.TabIndex = 0;
            this.clienteCheckBox.Text = "Cliente";
            this.clienteCheckBox.UseVisualStyleBackColor = true;
            // 
            // contatoTabPage
            // 
            this.contatoTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.contatoTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contatoTabPage.Controls.Add(this.removerContatoButton);
            this.contatoTabPage.Controls.Add(this.adicionarContatoButton);
            this.contatoTabPage.Controls.Add(this.contatoDataGridView);
            this.contatoTabPage.Location = new System.Drawing.Point(4, 25);
            this.contatoTabPage.Name = "contatoTabPage";
            this.contatoTabPage.Size = new System.Drawing.Size(963, 128);
            this.contatoTabPage.TabIndex = 2;
            this.contatoTabPage.Text = "Contato";
            // 
            // removerContatoButton
            // 
            this.removerContatoButton.FlatAppearance.BorderSize = 0;
            this.removerContatoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removerContatoButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removerContatoButton.Location = new System.Drawing.Point(934, 24);
            this.removerContatoButton.Name = "removerContatoButton";
            this.removerContatoButton.Size = new System.Drawing.Size(24, 25);
            this.removerContatoButton.TabIndex = 61;
            this.removerContatoButton.Text = "-";
            this.removerContatoButton.UseVisualStyleBackColor = true;
            this.removerContatoButton.Click += new System.EventHandler(this.removerButtonOnClick);
            // 
            // adicionarContatoButton
            // 
            this.adicionarContatoButton.FlatAppearance.BorderSize = 0;
            this.adicionarContatoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarContatoButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarContatoButton.Location = new System.Drawing.Point(934, -2);
            this.adicionarContatoButton.Name = "adicionarContatoButton";
            this.adicionarContatoButton.Size = new System.Drawing.Size(24, 25);
            this.adicionarContatoButton.TabIndex = 60;
            this.adicionarContatoButton.Text = "+";
            this.adicionarContatoButton.UseVisualStyleBackColor = true;
            this.adicionarContatoButton.Click += new System.EventHandler(this.adicionarButtonOnClick);
            // 
            // contatoDataGridView
            // 
            this.contatoDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.contatoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.contatoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.contatoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contatoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contatoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.contatoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contatoDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.contatoDataGridView.Location = new System.Drawing.Point(2, 3);
            this.contatoDataGridView.MultiSelect = false;
            this.contatoDataGridView.Name = "contatoDataGridView";
            this.contatoDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contatoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.contatoDataGridView.RowHeadersVisible = false;
            this.contatoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contatoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contatoDataGridView.Size = new System.Drawing.Size(933, 119);
            this.contatoDataGridView.TabIndex = 3;
            this.contatoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            // 
            // pessoaEnderecoTabpage
            // 
            this.pessoaEnderecoTabpage.BackColor = System.Drawing.SystemColors.Window;
            this.pessoaEnderecoTabpage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pessoaEnderecoTabpage.Controls.Add(this.button1);
            this.pessoaEnderecoTabpage.Controls.Add(this.button2);
            this.pessoaEnderecoTabpage.Controls.Add(this.enderecoDataGridView);
            this.pessoaEnderecoTabpage.Location = new System.Drawing.Point(4, 25);
            this.pessoaEnderecoTabpage.Name = "pessoaEnderecoTabpage";
            this.pessoaEnderecoTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.pessoaEnderecoTabpage.Size = new System.Drawing.Size(963, 128);
            this.pessoaEnderecoTabpage.TabIndex = 0;
            this.pessoaEnderecoTabpage.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1338, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Código";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1342, 492);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 32);
            this.textBox2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.cancelarButton.Location = new System.Drawing.Point(770, 286);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(103, 32);
            this.cancelarButton.TabIndex = 23;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButtonOnClick);
            // 
            // gravarButton
            // 
            this.gravarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.gravarButton.Location = new System.Drawing.Point(874, 286);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(103, 32);
            this.gravarButton.TabIndex = 24;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButtonOnClick);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.emailTextBox.Location = new System.Drawing.Point(671, 86);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(302, 23);
            this.emailTextBox.TabIndex = 7;
            // 
            // cpfcnpjTextBox
            // 
            this.cpfcnpjTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.cpfcnpjTextBox.Location = new System.Drawing.Point(6, 86);
            this.cpfcnpjTextBox.MaxLength = 18;
            this.cpfcnpjTextBox.Name = "cpfcnpjTextBox";
            this.cpfcnpjTextBox.Size = new System.Drawing.Size(320, 23);
            this.cpfcnpjTextBox.TabIndex = 4;
            this.cpfcnpjTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpfCnpjKeyPress);
            // 
            // razaoSocialTextBox
            // 
            this.razaoSocialTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.razaoSocialTextBox.Location = new System.Drawing.Point(6, 30);
            this.razaoSocialTextBox.Name = "razaoSocialTextBox";
            this.razaoSocialTextBox.Size = new System.Drawing.Size(320, 23);
            this.razaoSocialTextBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(329, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Telefone";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Nome/razão social";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "CPF/CPNJ";
            // 
            // apelidoTextBox
            // 
            this.apelidoTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.apelidoTextBox.Location = new System.Drawing.Point(332, 30);
            this.apelidoTextBox.Name = "apelidoTextBox";
            this.apelidoTextBox.Size = new System.Drawing.Size(333, 23);
            this.apelidoTextBox.TabIndex = 2;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.telefoneTextBox.Location = new System.Drawing.Point(332, 86);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(165, 23);
            this.telefoneTextBox.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(329, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Apelido/nome fantasia";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(667, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 16);
            this.label16.TabIndex = 33;
            this.label16.Text = "E-mail";
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(671, 29);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(302, 24);
            this.tipoComboBox.TabIndex = 3;
            this.tipoComboBox.DropDown += new System.EventHandler(this.tipoDropDown);
            this.tipoComboBox.DropDownClosed += new System.EventHandler(this.tipoDropClosed);
            this.tipoComboBox.TextChanged += new System.EventHandler(this.tipoDropClosed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Celular";
            // 
            // celularTextBox
            // 
            this.celularTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.celularTextBox.Location = new System.Drawing.Point(503, 86);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(162, 23);
            this.celularTextBox.TabIndex = 6;
            // 
            // voltarButton
            // 
            this.voltarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.voltarButton.Location = new System.Drawing.Point(664, 286);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(103, 32);
            this.voltarButton.TabIndex = 45;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButtonOnClick);
            // 
            // liberarButton
            // 
            this.liberarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.liberarButton.Location = new System.Drawing.Point(560, 286);
            this.liberarButton.Name = "liberarButton";
            this.liberarButton.Size = new System.Drawing.Size(103, 32);
            this.liberarButton.TabIndex = 46;
            this.liberarButton.Text = "Liberar";
            this.liberarButton.UseVisualStyleBackColor = true;
            this.liberarButton.Visible = false;
            this.liberarButton.Click += new System.EventHandler(this.liberarButtonOnClick);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // enderecoDataGridView
            // 
            this.enderecoDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.enderecoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.enderecoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.enderecoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enderecoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enderecoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.enderecoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.enderecoDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.enderecoDataGridView.Location = new System.Drawing.Point(0, 2);
            this.enderecoDataGridView.MultiSelect = false;
            this.enderecoDataGridView.Name = "enderecoDataGridView";
            this.enderecoDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enderecoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.enderecoDataGridView.RowHeadersVisible = false;
            this.enderecoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.enderecoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enderecoDataGridView.Size = new System.Drawing.Size(933, 119);
            this.enderecoDataGridView.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(935, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 25);
            this.button1.TabIndex = 63;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(935, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 25);
            this.button2.TabIndex = 62;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // IPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(980, 320);
            this.Controls.Add(this.liberarButton);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.cpfcnpjTextBox);
            this.Controls.Add(this.razaoSocialTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.apelidoTextBox);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.gravarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa";
            this.Activated += new System.EventHandler(this.atualizarInformacoesDoFormulario);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IPessoa_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.observacaoTabPage.ResumeLayout(false);
            this.abrangenciaTabPage.ResumeLayout(false);
            this.abrangenciaTabPage.PerformLayout();
            this.contatoTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contatoDataGridView)).EndInit();
            this.pessoaEnderecoTabpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enderecoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pessoaEnderecoTabpage;
        private System.Windows.Forms.TabPage observacaoTabPage;
        private System.Windows.Forms.RichTextBox ObservacaoTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cpfcnpjTextBox;
        private System.Windows.Forms.TextBox razaoSocialTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox apelidoTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage contatoTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TabPage abrangenciaTabPage;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox fornecedorCheckBox;
        private System.Windows.Forms.CheckBox clienteCheckBox;
        private System.Windows.Forms.DataGridView contatoDataGridView;
        private System.Windows.Forms.Button adicionarContatoButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Button liberarButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button removerContatoButton;
        private System.Windows.Forms.DataGridView enderecoDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}