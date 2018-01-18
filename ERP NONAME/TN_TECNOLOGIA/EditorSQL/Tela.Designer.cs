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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.textSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSQL_KeyDown);
            // 
            // gridSQL
            // 
            this.gridSQL.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.gridSQL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridSQL.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.gridSQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridSQL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSQL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSQL.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridSQL.Location = new System.Drawing.Point(0, 376);
            this.gridSQL.MultiSelect = false;
            this.gridSQL.Name = "gridSQL";
            this.gridSQL.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSQL.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridSQL.RowHeadersVisible = false;
            this.gridSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridSQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSQL.Size = new System.Drawing.Size(1439, 252);
            this.gridSQL.TabIndex = 4;
            // 
            // Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 625);
            this.Controls.Add(this.gridSQL);
            this.Controls.Add(this.textSQL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tela_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridSQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textSQL;
        private System.Windows.Forms.DataGridView gridSQL;
    }
}