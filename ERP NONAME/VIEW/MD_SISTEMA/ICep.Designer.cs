namespace ALTO_VALE.VIEW.MD_SISTEMA
{
    partial class ICep
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
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.liberarButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.gravarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cepTextBox
            // 
            this.cepTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.cepTextBox.Location = new System.Drawing.Point(6, 25);
            this.cepTextBox.MaxLength = 8;
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(177, 23);
            this.cepTextBox.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "Cep";
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.logradouroTextBox.Location = new System.Drawing.Point(210, 72);
            this.logradouroTextBox.MaxLength = 18;
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(282, 23);
            this.logradouroTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Logradouro";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.bairroTextBox.Location = new System.Drawing.Point(6, 72);
            this.bairroTextBox.MaxLength = 18;
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(200, 23);
            this.bairroTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Bairro";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.cidadeTextBox.Location = new System.Drawing.Point(413, 24);
            this.cidadeTextBox.MaxLength = 18;
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(305, 23);
            this.cidadeTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Estado";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.Font = new System.Drawing.Font("Arial", 9.5F);
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas\t",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.estadoComboBox.Location = new System.Drawing.Point(498, 71);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(220, 24);
            this.estadoComboBox.TabIndex = 6;
            // 
            // paisComboBox
            // 
            this.paisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paisComboBox.Font = new System.Drawing.Font("Arial", 9.5F);
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Items.AddRange(new object[] {
            "Brasil"});
            this.paisComboBox.Location = new System.Drawing.Point(187, 24);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(220, 24);
            this.paisComboBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "País";
            // 
            // liberarButton
            // 
            this.liberarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.liberarButton.Location = new System.Drawing.Point(304, 114);
            this.liberarButton.Name = "liberarButton";
            this.liberarButton.Size = new System.Drawing.Size(103, 32);
            this.liberarButton.TabIndex = 7;
            this.liberarButton.Text = "Liberar";
            this.liberarButton.UseVisualStyleBackColor = true;
            this.liberarButton.Visible = false;
            this.liberarButton.Click += new System.EventHandler(this.liberarButtonOnClick);
            // 
            // voltarButton
            // 
            this.voltarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.voltarButton.Location = new System.Drawing.Point(408, 114);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(103, 32);
            this.voltarButton.TabIndex = 8;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButtonOnClick);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.cancelarButton.Location = new System.Drawing.Point(511, 114);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(103, 32);
            this.cancelarButton.TabIndex = 9;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButtonOnClick);
            // 
            // gravarButton
            // 
            this.gravarButton.Font = new System.Drawing.Font("Arial", 10F);
            this.gravarButton.Location = new System.Drawing.Point(615, 114);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(103, 32);
            this.gravarButton.TabIndex = 10;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButtonOnClick);
            // 
            // ICep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 150);
            this.Controls.Add(this.liberarButton);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.paisComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logradouroTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ICep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereço";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button liberarButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button gravarButton;
    }
}