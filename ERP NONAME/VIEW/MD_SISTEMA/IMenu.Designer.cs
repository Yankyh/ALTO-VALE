﻿namespace ALTO_VALE
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Pessoa", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Endereço", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Contato", 1, 1);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Pessoa", 0, 2, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tarefa", 1, 1);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tarefa", 0, 2, new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Cep", 1, 1);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Sistema", 0, 2, new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuButton = new System.Windows.Forms.Button();
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
            // menuTreeView
            // 
            this.menuTreeView.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuTreeView.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTreeView.ImageIndex = 0;
            this.menuTreeView.ImageList = this.imageList1;
            this.menuTreeView.Location = new System.Drawing.Point(68, 55);
            this.menuTreeView.Name = "menuTreeView";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "pessoaPessoaNode";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Pessoa";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "pessoaEnderecoNode";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Endereço";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "pessoaContatoNode";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Contato";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "pessoaNode";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "Pessoa";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "tarefaTarefaNode";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "Tarefa";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "tarefaNode";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "Tarefa";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "sistemaCepNode";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Cep";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "sistemaNode";
            treeNode8.SelectedImageIndex = 2;
            treeNode8.Text = "Sistema";
            this.menuTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6,
            treeNode8});
            this.menuTreeView.SelectedImageIndex = 0;
            this.menuTreeView.ShowLines = false;
            this.menuTreeView.ShowPlusMinus = false;
            this.menuTreeView.Size = new System.Drawing.Size(214, 732);
            this.menuTreeView.TabIndex = 9;
            this.menuTreeView.DoubleClick += new System.EventHandler(this.MenuTreeViewDoubleClick);
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
            this.menuButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(281, 55);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(38, 732);
            this.menuButton.TabIndex = 17;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.MenuButtonOnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1604, 882);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.menuTreeView);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.MenuButtonOnClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView menuTreeView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button menuButton;
    }
}

