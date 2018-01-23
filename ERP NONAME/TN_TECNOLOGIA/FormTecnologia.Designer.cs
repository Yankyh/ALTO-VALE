namespace ALTO_VALE.TN_TECNOLOGIA
{
    partial class FormTecnologia
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
            this.contextMenuStripPadrao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStripPadrao.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripPadrao
            // 
            this.contextMenuStripPadrao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem});
            this.contextMenuStripPadrao.Name = "contextMenuStripPadrao";
            this.contextMenuStripPadrao.Size = new System.Drawing.Size(111, 26);
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormTecnologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 261);
            this.Controls.Add(this.button1);
            this.Name = "FormTecnologia";
            this.Text = "FormTecnologia";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EscOnClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightClick);
            this.contextMenuStripPadrao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripPadrao;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}