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
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Pessoa", 1, 1);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Pessoa", 0, 2, new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Tarefa", 1, 1);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Tarefa", 0, 2, new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Cep", 1, 1);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Servidor de Email", 1, 1);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Sistema", 0, 2, new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuButton = new System.Windows.Forms.Button();
            this.menuTreeView = new System.Windows.Forms.TreeView();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStripPadrao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.filtroCheckBox = new System.Windows.Forms.CheckedListBox();
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
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "pessoaPessoaNode";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "Pessoa";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "pessoaNode";
            treeNode9.SelectedImageIndex = 2;
            treeNode9.Text = "Pessoa";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "tarefaTarefaNode";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "Tarefa";
            treeNode11.ImageIndex = 0;
            treeNode11.Name = "tarefaNode";
            treeNode11.SelectedImageIndex = 2;
            treeNode11.Text = "Tarefa";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "sistemaCepNode";
            treeNode12.SelectedImageIndex = 1;
            treeNode12.Text = "Cep";
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "ServidorEmail";
            treeNode13.SelectedImageIndex = 1;
            treeNode13.Text = "Servidor de Email";
            treeNode14.ImageIndex = 0;
            treeNode14.Name = "sistemaNode";
            treeNode14.SelectedImageIndex = 2;
            treeNode14.Text = "Sistema";
            this.menuTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode11,
            treeNode14});
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.menuDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.menuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.menuDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.menuDataGridView.Location = new System.Drawing.Point(275, 55);
            this.menuDataGridView.MultiSelect = false;
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.ReadOnly = true;
            this.menuDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            // adicionarButton
            // 
            this.adicionarButton.BackColor = System.Drawing.Color.Transparent;
            this.adicionarButton.BackgroundImage = global::ALTO_VALE.Properties.Resources.ic_launcher2;
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
            // filtroCheckBox
            // 
            this.filtroCheckBox.FormattingEnabled = true;
            this.filtroCheckBox.Items.AddRange(new object[] {
            "Ativo",
            "Encerrado",
            "Cancelado",
            "Ag. modificações",
            "Cadastrado"});
            this.filtroCheckBox.Location = new System.Drawing.Point(275, 793);
            this.filtroCheckBox.Name = "filtroCheckBox";
            this.filtroCheckBox.Size = new System.Drawing.Size(112, 79);
            this.filtroCheckBox.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.filtroCheckBox);
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
        private System.Windows.Forms.CheckedListBox filtroCheckBox;
    }
}

