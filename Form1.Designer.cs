namespace CRUD_Basico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNovo = new System.Windows.Forms.Button();
            this.txtEditar = new System.Windows.Forms.Button();
            this.txtExcluir = new System.Windows.Forms.Button();
            this.txtExibir = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtConsultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(127, 86);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(181, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(127, 113);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(343, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(127, 139);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(181, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // txtNovo
            // 
            this.txtNovo.Location = new System.Drawing.Point(70, 189);
            this.txtNovo.Name = "txtNovo";
            this.txtNovo.Size = new System.Drawing.Size(75, 23);
            this.txtNovo.TabIndex = 6;
            this.txtNovo.Text = "Novo";
            this.txtNovo.UseVisualStyleBackColor = true;
            this.txtNovo.Click += new System.EventHandler(this.txtNovo_Click);
            // 
            // txtEditar
            // 
            this.txtEditar.Location = new System.Drawing.Point(151, 189);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(75, 23);
            this.txtEditar.TabIndex = 7;
            this.txtEditar.Text = "Editar";
            this.txtEditar.UseVisualStyleBackColor = true;
            this.txtEditar.Click += new System.EventHandler(this.txtEditar_Click);
            // 
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(394, 189);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(75, 23);
            this.txtExcluir.TabIndex = 8;
            this.txtExcluir.Text = "Excluir";
            this.txtExcluir.UseVisualStyleBackColor = true;
            this.txtExcluir.Click += new System.EventHandler(this.txtExcluir_Click);
            // 
            // txtExibir
            // 
            this.txtExibir.Location = new System.Drawing.Point(313, 189);
            this.txtExibir.Name = "txtExibir";
            this.txtExibir.Size = new System.Drawing.Size(75, 23);
            this.txtExibir.TabIndex = 9;
            this.txtExibir.Text = "Exibir";
            this.txtExibir.UseVisualStyleBackColor = true;
            this.txtExibir.Click += new System.EventHandler(this.txtExibir_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(22, 231);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(491, 227);
            this.dgvDados.TabIndex = 10;
            // 
            // txtConsultar
            // 
            this.txtConsultar.Location = new System.Drawing.Point(232, 189);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(75, 23);
            this.txtConsultar.TabIndex = 11;
            this.txtConsultar.Text = "Consultar";
            this.txtConsultar.UseVisualStyleBackColor = true;
            this.txtConsultar.Click += new System.EventHandler(this.txtConsultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cadastro Cliente";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(301, 473);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(153, 46);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Limpar Campos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtExibir);
            this.Controls.Add(this.txtExcluir);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.txtNovo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button txtNovo;
        private System.Windows.Forms.Button txtEditar;
        private System.Windows.Forms.Button txtExcluir;
        private System.Windows.Forms.Button txtExibir;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button txtConsultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button button1;
    }
}

