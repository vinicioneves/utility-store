namespace UtilityStore
{
    partial class Cadastrousuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.bt_cancelarusuario = new System.Windows.Forms.Button();
            this.bt_voltarusuario = new System.Windows.Forms.Button();
            this.bt_cadastrarusuario = new System.Windows.Forms.Button();
            this.bt_irusuario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_codusuarios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuários";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(77, 77);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(195, 20);
            this.tb_login.TabIndex = 3;
            this.tb_login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(77, 116);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(195, 20);
            this.tb_senha.TabIndex = 4;
            // 
            // bt_cancelarusuario
            // 
            this.bt_cancelarusuario.Location = new System.Drawing.Point(12, 151);
            this.bt_cancelarusuario.Name = "bt_cancelarusuario";
            this.bt_cancelarusuario.Size = new System.Drawing.Size(109, 35);
            this.bt_cancelarusuario.TabIndex = 26;
            this.bt_cancelarusuario.Text = "Cancelar Cadastro";
            this.bt_cancelarusuario.UseVisualStyleBackColor = true;
            // 
            // bt_voltarusuario
            // 
            this.bt_voltarusuario.Location = new System.Drawing.Point(127, 151);
            this.bt_voltarusuario.Name = "bt_voltarusuario";
            this.bt_voltarusuario.Size = new System.Drawing.Size(55, 35);
            this.bt_voltarusuario.TabIndex = 27;
            this.bt_voltarusuario.Text = "<<";
            this.bt_voltarusuario.UseVisualStyleBackColor = true;
            // 
            // bt_cadastrarusuario
            // 
            this.bt_cadastrarusuario.Location = new System.Drawing.Point(249, 151);
            this.bt_cadastrarusuario.Name = "bt_cadastrarusuario";
            this.bt_cadastrarusuario.Size = new System.Drawing.Size(99, 35);
            this.bt_cadastrarusuario.TabIndex = 28;
            this.bt_cadastrarusuario.Text = "Efetuar Cadastro";
            this.bt_cadastrarusuario.UseVisualStyleBackColor = true;
            // 
            // bt_irusuario
            // 
            this.bt_irusuario.Location = new System.Drawing.Point(188, 151);
            this.bt_irusuario.Name = "bt_irusuario";
            this.bt_irusuario.Size = new System.Drawing.Size(55, 35);
            this.bt_irusuario.TabIndex = 29;
            this.bt_irusuario.Text = ">>";
            this.bt_irusuario.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Código";
            // 
            // tb_codusuarios
            // 
            this.tb_codusuarios.Location = new System.Drawing.Point(233, 24);
            this.tb_codusuarios.Name = "tb_codusuarios";
            this.tb_codusuarios.Size = new System.Drawing.Size(115, 20);
            this.tb_codusuarios.TabIndex = 31;
            // 
            // Cadastrousuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 198);
            this.Controls.Add(this.tb_codusuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_irusuario);
            this.Controls.Add(this.bt_cadastrarusuario);
            this.Controls.Add(this.bt_voltarusuario);
            this.Controls.Add(this.bt_cancelarusuario);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrousuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Cadastrousuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button bt_cancelarusuario;
        private System.Windows.Forms.Button bt_voltarusuario;
        private System.Windows.Forms.Button bt_cadastrarusuario;
        private System.Windows.Forms.Button bt_irusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_codusuarios;
    }
}

