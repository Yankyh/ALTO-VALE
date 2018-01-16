namespace ALTO_VALE.VIEW.MD_SISTEMA
{
    partial class GCep
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
            this.cepDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cepDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cepDataGridView
            // 
            this.cepDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cepDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cepDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cepDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cepDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cepDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cepDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cepDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.cepDataGridView.Location = new System.Drawing.Point(4, 56);
            this.cepDataGridView.MultiSelect = false;
            this.cepDataGridView.Name = "cepDataGridView";
            this.cepDataGridView.ReadOnly = true;
            this.cepDataGridView.RowHeadersVisible = false;
            this.cepDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cepDataGridView.Size = new System.Drawing.Size(1896, 937);
            this.cepDataGridView.TabIndex = 1;
            this.cepDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickOnClick);
            this.cepDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cepDataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 46);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.adicionarButtonOnClick);
            // 
            // GCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 996);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cepDataGridView);
            this.Name = "GCep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCep";
            this.Activated += new System.EventHandler(this.OnActivated);
            ((System.ComponentModel.ISupportInitialize)(this.cepDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cepDataGridView;
        private System.Windows.Forms.Button button1;
    }
}