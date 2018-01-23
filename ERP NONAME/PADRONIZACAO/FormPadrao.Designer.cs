namespace ALTO_VALE.PADRONIZACAO
{
    partial class FormPadrao
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStripPrincipal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teste3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripPrincipal
            // 
            this.contextMenuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teste3ToolStripMenuItem,
            this.abcToolStripMenuItem});
            this.contextMenuStripPrincipal.Name = "contextMenuStripPrincipal";
            this.contextMenuStripPrincipal.Size = new System.Drawing.Size(153, 70);
            // 
            // teste3ToolStripMenuItem
            // 
            this.teste3ToolStripMenuItem.Name = "teste3ToolStripMenuItem";
            this.teste3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.teste3ToolStripMenuItem.Text = "teste3";
            // 
            // abcToolStripMenuItem
            // 
            this.abcToolStripMenuItem.Name = "abcToolStripMenuItem";
            this.abcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abcToolStripMenuItem.Text = "abc";
            // 
            // FormPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormPadrao";
            this.Text = "FormPadrao";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EscOnClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightClick);
            this.contextMenuStripPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem teste3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abcToolStripMenuItem;
    }
}