namespace MelhorProjetoDaVida.Ui
{
    partial class FrmDados
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.num_id = new System.Windows.Forms.NumericUpDown();
            this.num_p08 = new System.Windows.Forms.NumericUpDown();
            this.lbl_p08 = new System.Windows.Forms.Label();
            this.num_n19 = new System.Windows.Forms.NumericUpDown();
            this.lbl_n19 = new System.Windows.Forms.Label();
            this.txt_phcfn = new System.Windows.Forms.TextBox();
            this.lbl_phcfn = new System.Windows.Forms.Label();
            this.lbl_dados = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_p08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_n19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(9, 64);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            // 
            // num_id
            // 
            this.num_id.Location = new System.Drawing.Point(12, 89);
            this.num_id.Name = "num_id";
            this.num_id.Size = new System.Drawing.Size(39, 20);
            this.num_id.TabIndex = 1;
            // 
            // num_p08
            // 
            this.num_p08.Location = new System.Drawing.Point(217, 89);
            this.num_p08.Name = "num_p08";
            this.num_p08.Size = new System.Drawing.Size(76, 20);
            this.num_p08.TabIndex = 3;
            // 
            // lbl_p08
            // 
            this.lbl_p08.AutoSize = true;
            this.lbl_p08.Location = new System.Drawing.Point(214, 64);
            this.lbl_p08.Name = "lbl_p08";
            this.lbl_p08.Size = new System.Drawing.Size(26, 13);
            this.lbl_p08.TabIndex = 2;
            this.lbl_p08.Text = "P08";
            // 
            // num_n19
            // 
            this.num_n19.Location = new System.Drawing.Point(317, 89);
            this.num_n19.Name = "num_n19";
            this.num_n19.Size = new System.Drawing.Size(76, 20);
            this.num_n19.TabIndex = 5;
            // 
            // lbl_n19
            // 
            this.lbl_n19.AutoSize = true;
            this.lbl_n19.Location = new System.Drawing.Point(314, 64);
            this.lbl_n19.Name = "lbl_n19";
            this.lbl_n19.Size = new System.Drawing.Size(27, 13);
            this.lbl_n19.TabIndex = 4;
            this.lbl_n19.Text = "N19";
            // 
            // txt_phcfn
            // 
            this.txt_phcfn.Location = new System.Drawing.Point(69, 89);
            this.txt_phcfn.Name = "txt_phcfn";
            this.txt_phcfn.Size = new System.Drawing.Size(127, 20);
            this.txt_phcfn.TabIndex = 7;
            // 
            // lbl_phcfn
            // 
            this.lbl_phcfn.AutoSize = true;
            this.lbl_phcfn.Location = new System.Drawing.Point(66, 64);
            this.lbl_phcfn.Name = "lbl_phcfn";
            this.lbl_phcfn.Size = new System.Drawing.Size(43, 13);
            this.lbl_phcfn.TabIndex = 6;
            this.lbl_phcfn.Text = "PHCFN";
            // 
            // lbl_dados
            // 
            this.lbl_dados.AutoSize = true;
            this.lbl_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados.Location = new System.Drawing.Point(166, 18);
            this.lbl_dados.Name = "lbl_dados";
            this.lbl_dados.Size = new System.Drawing.Size(74, 25);
            this.lbl_dados.TabIndex = 8;
            this.lbl_dados.Text = "Dados";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(12, 142);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(82, 23);
            this.btn_cadastrar.TabIndex = 9;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(114, 142);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(82, 23);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(217, 142);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(82, 23);
            this.btn_excluir.TabIndex = 11;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 222);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(381, 172);
            this.dataGridView.TabIndex = 12;
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(311, 142);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(82, 23);
            this.btn_listar.TabIndex = 70;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Location = new System.Drawing.Point(161, 192);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(82, 23);
            this.btn_usuarios.TabIndex = 76;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // FrmDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 406);
            this.Controls.Add(this.btn_usuarios);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_dados);
            this.Controls.Add(this.txt_phcfn);
            this.Controls.Add(this.lbl_phcfn);
            this.Controls.Add(this.num_n19);
            this.Controls.Add(this.lbl_n19);
            this.Controls.Add(this.num_p08);
            this.Controls.Add(this.lbl_p08);
            this.Controls.Add(this.num_id);
            this.Controls.Add(this.lbl_id);
            this.Name = "FrmDados";
            this.Text = "FrmDados";
            ((System.ComponentModel.ISupportInitialize)(this.num_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_p08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_n19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.NumericUpDown num_id;
        private System.Windows.Forms.NumericUpDown num_p08;
        private System.Windows.Forms.Label lbl_p08;
        private System.Windows.Forms.NumericUpDown num_n19;
        private System.Windows.Forms.Label lbl_n19;
        private System.Windows.Forms.TextBox txt_phcfn;
        private System.Windows.Forms.Label lbl_phcfn;
        private System.Windows.Forms.Label lbl_dados;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_usuarios;
    }
}