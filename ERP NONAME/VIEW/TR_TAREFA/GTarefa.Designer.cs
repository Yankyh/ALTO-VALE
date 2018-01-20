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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tarefaDataGridView = new System.Windows.Forms.DataGridView();
            this.adcionarButton = new System.Windows.Forms.Button();
            this.ehEncerradoCheckBox = new System.Windows.Forms.CheckBox();
            this.ehCanceladoCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tarefaDataGridView
            // 
            this.tarefaDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tarefaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.tarefaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tarefaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tarefaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tarefaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tarefaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tarefaDataGridView.DefaultCellStyle = dataGridViewCellStyle15;
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
            this.adcionarButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adcionarButton.Location = new System.Drawing.Point(4, 4);
            this.adcionarButton.Name = "adcionarButton";
            this.adcionarButton.Size = new System.Drawing.Size(94, 46);
            this.adcionarButton.TabIndex = 3;
            this.adcionarButton.Text = "Novo";
            this.adcionarButton.UseVisualStyleBackColor = true;
            this.adcionarButton.Click += new System.EventHandler(this.adicionarButtonOnClick);
            // 
            // ehEncerradoCheckBox
            // 
            this.ehEncerradoCheckBox.AutoSize = true;
            this.ehEncerradoCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ehEncerradoCheckBox.Location = new System.Drawing.Point(146, 19);
            this.ehEncerradoCheckBox.Name = "ehEncerradoCheckBox";
            this.ehEncerradoCheckBox.Size = new System.Drawing.Size(83, 19);
            this.ehEncerradoCheckBox.TabIndex = 4;
            this.ehEncerradoCheckBox.Text = "Encerrado";
            this.ehEncerradoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ehCanceladoCheckBox
            // 
            this.ehCanceladoCheckBox.AutoSize = true;
            this.ehCanceladoCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ehCanceladoCheckBox.Location = new System.Drawing.Point(235, 19);
            this.ehCanceladoCheckBox.Name = "ehCanceladoCheckBox";
            this.ehCanceladoCheckBox.Size = new System.Drawing.Size(86, 19);
            this.ehCanceladoCheckBox.TabIndex = 5;
            this.ehCanceladoCheckBox.Text = "Cancelado";
            this.ehCanceladoCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(327, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AtualizarButtonOnClick);
            // 
            // GTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 996);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ehCanceladoCheckBox);
            this.Controls.Add(this.ehEncerradoCheckBox);
            this.Controls.Add(this.adcionarButton);
            this.Controls.Add(this.tarefaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefa";
            this.Activated += new System.EventHandler(this.TarefaActivated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TarefaFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tarefaDataGridView;
        private System.Windows.Forms.Button adcionarButton;
        private System.Windows.Forms.CheckBox ehEncerradoCheckBox;
        private System.Windows.Forms.CheckBox ehCanceladoCheckBox;
        private System.Windows.Forms.Button button1;
    }
}