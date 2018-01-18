namespace ALTO_VALE
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pessoaButton = new System.Windows.Forms.Button();
            this.enderecoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.JOHANN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(323, 612);
            this.treeView1.TabIndex = 0;
            // 
            // pessoaButton
            // 
            this.pessoaButton.Location = new System.Drawing.Point(78, 78);
            this.pessoaButton.Name = "pessoaButton";
            this.pessoaButton.Size = new System.Drawing.Size(75, 23);
            this.pessoaButton.TabIndex = 1;
            this.pessoaButton.Text = "Pessoa";
            this.pessoaButton.UseVisualStyleBackColor = true;
            this.pessoaButton.Click += new System.EventHandler(this.pessoaButtonOnClick);
            // 
            // enderecoButton
            // 
            this.enderecoButton.Location = new System.Drawing.Point(78, 107);
            this.enderecoButton.Name = "enderecoButton";
            this.enderecoButton.Size = new System.Drawing.Size(75, 23);
            this.enderecoButton.TabIndex = 2;
            this.enderecoButton.Text = "Endereço";
            this.enderecoButton.UseVisualStyleBackColor = true;
            this.enderecoButton.Click += new System.EventHandler(this.enderecoButtonOnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "CEP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "CEP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.TESTE);
            // 
            // JOHANN
            // 
            this.JOHANN.Location = new System.Drawing.Point(573, 253);
            this.JOHANN.Name = "JOHANN";
            this.JOHANN.Size = new System.Drawing.Size(75, 23);
            this.JOHANN.TabIndex = 6;
            this.JOHANN.Text = "JOHANN";
            this.JOHANN.UseVisualStyleBackColor = true;
            this.JOHANN.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.JOHANN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enderecoButton);
            this.Controls.Add(this.pessoaButton);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button pessoaButton;
        private System.Windows.Forms.Button enderecoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button JOHANN;
    }
}

