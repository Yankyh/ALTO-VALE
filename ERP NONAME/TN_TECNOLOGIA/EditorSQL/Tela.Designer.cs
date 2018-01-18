namespace ALTO_VALE.TN_TECNOLOGIA.EditorSQL
{
    partial class Tela
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
            this.textSQL = new System.Windows.Forms.RichTextBox();
            this.gridSQL = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // textSQL
            // 
            this.textSQL.Location = new System.Drawing.Point(0, 0);
            this.textSQL.Name = "textSQL";
            this.textSQL.Size = new System.Drawing.Size(1439, 392);
            this.textSQL.TabIndex = 0;
            this.textSQL.Text = "";
            this.textSQL.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.textSQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // gridSQL
            // 
            this.gridSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSQL.Location = new System.Drawing.Point(0, 398);
            this.gridSQL.Name = "gridSQL";
            this.gridSQL.Size = new System.Drawing.Size(1439, 228);
            this.gridSQL.TabIndex = 1;
            // 
            // Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 625);
            this.Controls.Add(this.gridSQL);
            this.Controls.Add(this.textSQL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela";
            this.Text = "Tela";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridSQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textSQL;
        private System.Windows.Forms.DataGridView gridSQL;
    }
}