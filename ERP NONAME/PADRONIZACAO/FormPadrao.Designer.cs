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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripPrincipal
            // 
            this.contextMenuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teste3ToolStripMenuItem,
            this.abcToolStripMenuItem});
            this.contextMenuStripPrincipal.Name = "contextMenuStripPrincipal";
            this.contextMenuStripPrincipal.Size = new System.Drawing.Size(106, 48);
            // 
            // teste3ToolStripMenuItem
            // 
            this.teste3ToolStripMenuItem.Name = "teste3ToolStripMenuItem";
            this.teste3ToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.teste3ToolStripMenuItem.Text = "teste3";
            // 
            // abcToolStripMenuItem
            // 
            this.abcToolStripMenuItem.Name = "abcToolStripMenuItem";
            this.abcToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.abcToolStripMenuItem.Text = "abc";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(439, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 488);
            this.Controls.Add(this.checkBox1);
            this.Name = "FormPadrao";
            this.Text = "FormPadrao";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightClick);
            this.contextMenuStripPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem teste3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abcToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}