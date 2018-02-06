namespace ALTO_VALE
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
       protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Pessoa", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Pessoa", 0, 2, new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tarefa", 1, 1);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tarefa", 0, 2, new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Cep", 1, 1);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Servidor de Email", 1, 1);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Sistema", 0, 2, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuButton = new System.Windows.Forms.Button();
            this.menuTreeView = new System.Windows.Forms.TreeView();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStripPadrao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.canceladoCheckBox = new System.Windows.Forms.CheckBox();
            this.encerradoCheckBox = new System.Windows.Forms.CheckBox();
            this.AgmodificacoesCheckBox = new System.Windows.Forms.CheckBox();
            this.cadastradoCheckBox = new System.Windows.Forms.CheckBox();
            this.atualizarDataGridViewButton = new System.Windows.Forms.Button();
            this.adicionarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            this.contextMenuStripPadrao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1730, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alfa 0.01";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folderMenuIcon.png");
            this.imageList1.Images.SetKeyName(1, "fileMenuIcon.png");
            this.imageList1.Images.SetKeyName(2, "openFolderMenuIcon.png");
            // 
            // menuButton
            // 
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(0, 55);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(38, 732);
            this.menuButton.TabIndex = 17;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.MenuButtonOnClick);
            // 
            // menuTreeView
            // 
            this.menuTreeView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuTreeView.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTreeView.ImageIndex = 0;
            this.menuTreeView.ImageList = this.imageList1;
            this.menuTreeView.Location = new System.Drawing.Point(38, 55);
            this.menuTreeView.Name = "menuTreeView";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "pessoaPessoaNode";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Pessoa";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "pessoaNode";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Pessoa";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "tarefaTarefaNode";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Tarefa";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "tarefaNode";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "Tarefa";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "sistemaCepNode";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "Cep";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "ServidorEmail";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "Servidor de Email";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "sistemaNode";
            treeNode7.SelectedImageIndex = 2;
            treeNode7.Text = "Sistema";
            this.menuTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode7});
            this.menuTreeView.SelectedImageIndex = 0;
            this.menuTreeView.ShowLines = false;
            this.menuTreeView.ShowPlusMinus = false;
            this.menuTreeView.Size = new System.Drawing.Size(214, 732);
            this.menuTreeView.TabIndex = 9;
            this.menuTreeView.DoubleClick += new System.EventHandler(this.MenuTreeViewDoubleClick);
            // 
            // menuDataGridView
            // 
            this.menuDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.menuDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.menuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.menuDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.menuDataGridView.Location = new System.Drawing.Point(275, 55);
            this.menuDataGridView.MultiSelect = false;
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.ReadOnly = true;
            this.menuDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.menuDataGridView.RowHeadersVisible = false;
            this.menuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.menuDataGridView.Size = new System.Drawing.Size(1617, 732);
            this.menuDataGridView.TabIndex = 22;
            this.menuDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuDataGridViewCellDoubleClick);
            // 
            // contextMenuStripPadrao
            // 
            this.contextMenuStripPadrao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem});
            this.contextMenuStripPadrao.Name = "contextMenuStripPadrao";
            this.contextMenuStripPadrao.Size = new System.Drawing.Size(106, 26);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.Location = new System.Drawing.Point(275, 811);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ativoCheckBox.TabIndex = 24;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // canceladoCheckBox
            // 
            this.canceladoCheckBox.AutoSize = true;
            this.canceladoCheckBox.Location = new System.Drawing.Point(331, 811);
            this.canceladoCheckBox.Name = "canceladoCheckBox";
            this.canceladoCheckBox.Size = new System.Drawing.Size(77, 17);
            this.canceladoCheckBox.TabIndex = 25;
            this.canceladoCheckBox.Text = "Cancelado";
            this.canceladoCheckBox.UseVisualStyleBackColor = true;
            // 
            // encerradoCheckBox
            // 
            this.encerradoCheckBox.AutoSize = true;
            this.encerradoCheckBox.Location = new System.Drawing.Point(414, 813);
            this.encerradoCheckBox.Name = "encerradoCheckBox";
            this.encerradoCheckBox.Size = new System.Drawing.Size(75, 17);
            this.encerradoCheckBox.TabIndex = 26;
            this.encerradoCheckBox.Text = "Encerrado";
            this.encerradoCheckBox.UseVisualStyleBackColor = true;
            // 
            // AgmodificacoesCheckBox
            // 
            this.AgmodificacoesCheckBox.AutoSize = true;
            this.AgmodificacoesCheckBox.Location = new System.Drawing.Point(495, 813);
            this.AgmodificacoesCheckBox.Name = "AgmodificacoesCheckBox";
            this.AgmodificacoesCheckBox.Size = new System.Drawing.Size(107, 17);
            this.AgmodificacoesCheckBox.TabIndex = 27;
            this.AgmodificacoesCheckBox.Text = "Ag. modificações";
            this.AgmodificacoesCheckBox.UseVisualStyleBackColor = true;
            // 
            // cadastradoCheckBox
            // 
            this.cadastradoCheckBox.AutoSize = true;
            this.cadastradoCheckBox.Location = new System.Drawing.Point(608, 813);
            this.cadastradoCheckBox.Name = "cadastradoCheckBox";
            this.cadastradoCheckBox.Size = new System.Drawing.Size(80, 17);
            this.cadastradoCheckBox.TabIndex = 28;
            this.cadastradoCheckBox.Text = "Cadastrado";
            this.cadastradoCheckBox.UseVisualStyleBackColor = true;
            // 
            // atualizarDataGridViewButton
            // 
            this.atualizarDataGridViewButton.BackColor = System.Drawing.Color.Transparent;
          //  this.atualizarDataGridViewButton.BackgroundImage = global::ALTO_VALE.Properties.Resources.ic_launcher;
            this.atualizarDataGridViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.atualizarDataGridViewButton.FlatAppearance.BorderSize = 0;
            this.atualizarDataGridViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarDataGridViewButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizarDataGridViewButton.Location = new System.Drawing.Point(343, -9);
            this.atualizarDataGridViewButton.Margin = new System.Windows.Forms.Padding(0);
            this.atualizarDataGridViewButton.Name = "atualizarDataGridViewButton";
            this.atualizarDataGridViewButton.Size = new System.Drawing.Size(73, 62);
            this.atualizarDataGridViewButton.TabIndex = 29;
            this.atualizarDataGridViewButton.UseVisualStyleBackColor = false;
            this.atualizarDataGridViewButton.Click += new System.EventHandler(this.atualizarDataGridViewButtonOnClick);
            // 
            // adicionarButton
            // 
            this.adicionarButton.BackColor = System.Drawing.Color.Transparent;
           // this.adicionarButton.BackgroundImage = global::ALTO_VALE.Properties.Resources.ic_launcher2;
            this.adicionarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adicionarButton.Enabled = false;
            this.adicionarButton.FlatAppearance.BorderSize = 0;
            this.adicionarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarButton.Location = new System.Drawing.Point(270, -9);
            this.adicionarButton.Margin = new System.Windows.Forms.Padding(0);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(73, 61);
            this.adicionarButton.TabIndex = 23;
            this.adicionarButton.UseVisualStyleBackColor = false;
            this.adicionarButton.Click += new System.EventHandler(this.AdicionarButtonOnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.atualizarDataGridViewButton);
            this.Controls.Add(this.cadastradoCheckBox);
            this.Controls.Add(this.AgmodificacoesCheckBox);
            this.Controls.Add(this.encerradoCheckBox);
            this.Controls.Add(this.canceladoCheckBox);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.menuDataGridView);
            this.Controls.Add(this.menuTreeView);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MenuFormActivated);
            this.Deactivate += new System.EventHandler(this.MenuFormDeactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuFormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContextOnRightClick);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            this.contextMenuStripPadrao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.TreeView menuTreeView;
        private System.Windows.Forms.DataGridView menuDataGridView;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPadrao;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.CheckBox canceladoCheckBox;
        private System.Windows.Forms.CheckBox encerradoCheckBox;
        private System.Windows.Forms.CheckBox AgmodificacoesCheckBox;
        private System.Windows.Forms.CheckBox cadastradoCheckBox;
        private System.Windows.Forms.Button atualizarDataGridViewButton;
    }
}

