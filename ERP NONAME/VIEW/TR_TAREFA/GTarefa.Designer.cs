namespace ALTO_VALE.VIEW.TR_TAREFA
{
    partial class GTarefa
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
            this.tarefaDataGridView = new System.Windows.Forms.DataGridView();
            this.adcionarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tarefaDataGridView
            // 
            this.tarefaDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tarefaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tarefaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tarefaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tarefaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tarefaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tarefaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tarefaDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.tarefaDataGridView.Location = new System.Drawing.Point(2, 58);
            this.tarefaDataGridView.MultiSelect = false;
            this.tarefaDataGridView.Name = "tarefaDataGridView";
            this.tarefaDataGridView.ReadOnly = true;
            this.tarefaDataGridView.RowHeadersVisible = false;
            this.tarefaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tarefaDataGridView.Size = new System.Drawing.Size(1896, 937);
            this.tarefaDataGridView.TabIndex = 2;
            this.tarefaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TarefaCellDoubleClick);
            // 
            // adcionarButton
            // 
            this.adcionarButton.Location = new System.Drawing.Point(4, 4);
            this.adcionarButton.Name = "adcionarButton";
            this.adcionarButton.Size = new System.Drawing.Size(94, 46);
            this.adcionarButton.TabIndex = 3;
            this.adcionarButton.UseVisualStyleBackColor = true;
            this.adcionarButton.Click += new System.EventHandler(this.adicionarButtonOnClick);
            // 
            // GTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 996);
            this.Controls.Add(this.adcionarButton);
            this.Controls.Add(this.tarefaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTarefa";
            this.Activated += new System.EventHandler(this.TarefaActivated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TarefaFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tarefaDataGridView;
        private System.Windows.Forms.Button adcionarButton;
    }
}