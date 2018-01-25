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
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Pessoa", 1, 1);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Endereço", 1, 1);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Contato", 1, 1);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Pessoa", 0, 2, new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Tarefa", 1, 1);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Tarefa", 0, 2, new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Cep", 1, 1);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Servidor de Email", 1, 1);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Sistema", 0, 2, new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuButton = new System.Windows.Forms.Button();
            this.menuTreeView = new System.Windows.Forms.TreeView();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStripPadrao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuTreeView.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTreeView.ImageIndex = 0;
            this.menuTreeView.ImageList = this.imageList1;
            this.menuTreeView.Location = new System.Drawing.Point(38, 55);
            this.menuTreeView.Name = "menuTreeView";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "pessoaPessoaNode";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "Pessoa";
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "pessoaEnderecoNode";
            treeNode11.SelectedImageIndex = 1;
            treeNode11.Text = "Endereço";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "pessoaContatoNode";
            treeNode12.SelectedImageIndex = 1;
            treeNode12.Text = "Contato";
            treeNode13.ImageIndex = 0;
            treeNode13.Name = "pessoaNode";
            treeNode13.SelectedImageIndex = 2;
            treeNode13.Text = "Pessoa";
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "tarefaTarefaNode";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "Tarefa";
            treeNode15.ImageIndex = 0;
            treeNode15.Name = "tarefaNode";
            treeNode15.SelectedImageIndex = 2;
            treeNode15.Text = "Tarefa";
            treeNode16.ImageIndex = 1;
            treeNode16.Name = "sistemaCepNode";
            treeNode16.SelectedImageIndex = 1;
            treeNode16.Text = "Cep";
            treeNode17.ImageIndex = 1;
            treeNode17.Name = "ServidorEmail";
            treeNode17.SelectedImageIndex = 1;
            treeNode17.Text = "Servidor de Email";
            treeNode18.ImageIndex = 0;
            treeNode18.Name = "sistemaNode";
            treeNode18.SelectedImageIndex = 2;
            treeNode18.Text = "Sistema";
            this.menuTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode15,
            treeNode18});
            this.menuTreeView.SelectedImageIndex = 0;
            this.menuTreeView.ShowLines = false;
            this.menuTreeView.ShowPlusMinus = false;
            this.menuTreeView.Size = new System.Drawing.Size(214, 732);
            this.menuTreeView.TabIndex = 9;
            this.menuTreeView.DoubleClick += new System.EventHandler(this.MenuTreeViewDoubleClick);
            this.menuTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveOnEnter);
            // 
            // menuDataGridView
            // 
            this.menuDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.menuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.menuDataGridView.Location = new System.Drawing.Point(275, 55);
            this.menuDataGridView.MultiSelect = false;
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.ReadOnly = true;
            this.menuDataGridView.RowHeadersVisible = false;
            this.menuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(275, 5);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(104, 47);
            this.adicionarButton.TabIndex = 23;
            this.adicionarButton.Text = "Adicionar";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.AdicionarButtonOnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.menuDataGridView);
            this.Controls.Add(this.menuTreeView);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
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
            this.Click += new System.EventHandler(this.MenuButtonOnClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveOnEnter);
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
    }
}

