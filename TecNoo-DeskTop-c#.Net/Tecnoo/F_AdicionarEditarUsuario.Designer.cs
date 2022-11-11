namespace Tecnoo
{
    partial class F_AdicionarEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AdicionarEditarUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.btn_foto = new System.Windows.Forms.Button();
            this.cbNivelUser = new System.Windows.Forms.ComboBox();
            this.textNomeuser = new System.Windows.Forms.TextBox();
            this.textEmailUser = new System.Windows.Forms.TextBox();
            this.textLoginUser = new System.Windows.Forms.TextBox();
            this.textSenhaUser = new System.Windows.Forms.TextBox();
            this.textIdUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sairGerUser = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_enviar);
            this.groupBox1.Controls.Add(this.btn_foto);
            this.groupBox1.Controls.Add(this.pictureBoxFoto);
            this.groupBox1.Controls.Add(this.cbNivelUser);
            this.groupBox1.Controls.Add(this.textNomeuser);
            this.groupBox1.Controls.Add(this.textEmailUser);
            this.groupBox1.Controls.Add(this.textLoginUser);
            this.groupBox1.Controls.Add(this.textSenhaUser);
            this.groupBox1.Controls.Add(this.textIdUsuario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(103, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_enviar.Location = new System.Drawing.Point(570, 237);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(185, 59);
            this.btn_enviar.TabIndex = 17;
            this.btn_enviar.Text = "ENVIAR";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // btn_foto
            // 
            this.btn_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_foto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_foto.Location = new System.Drawing.Point(324, 237);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(100, 23);
            this.btn_foto.TabIndex = 16;
            this.btn_foto.Text = "FOTO";
            this.btn_foto.UseVisualStyleBackColor = true;
            // 
            // cbNivelUser
            // 
            this.cbNivelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbNivelUser.FormattingEnabled = true;
            this.cbNivelUser.Items.AddRange(new object[] {
            "SUPERVISOR",
            "TÉCNICO I",
            "TÉCNICO II",
            "DESLIGADO"});
            this.cbNivelUser.Location = new System.Drawing.Point(626, 133);
            this.cbNivelUser.Name = "cbNivelUser";
            this.cbNivelUser.Size = new System.Drawing.Size(129, 24);
            this.cbNivelUser.TabIndex = 14;
            // 
            // textNomeuser
            // 
            this.textNomeuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeuser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textNomeuser.Location = new System.Drawing.Point(463, 85);
            this.textNomeuser.Name = "textNomeuser";
            this.textNomeuser.Size = new System.Drawing.Size(292, 22);
            this.textNomeuser.TabIndex = 13;
            // 
            // textEmailUser
            // 
            this.textEmailUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmailUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textEmailUser.Location = new System.Drawing.Point(324, 133);
            this.textEmailUser.Name = "textEmailUser";
            this.textEmailUser.Size = new System.Drawing.Size(266, 22);
            this.textEmailUser.TabIndex = 12;
            // 
            // textLoginUser
            // 
            this.textLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLoginUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textLoginUser.Location = new System.Drawing.Point(324, 186);
            this.textLoginUser.Name = "textLoginUser";
            this.textLoginUser.Size = new System.Drawing.Size(142, 22);
            this.textLoginUser.TabIndex = 10;
            // 
            // textSenhaUser
            // 
            this.textSenhaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenhaUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSenhaUser.Location = new System.Drawing.Point(506, 186);
            this.textSenhaUser.Name = "textSenhaUser";
            this.textSenhaUser.PasswordChar = '$';
            this.textSenhaUser.Size = new System.Drawing.Size(249, 22);
            this.textSenhaUser.TabIndex = 8;
            // 
            // textIdUsuario
            // 
            this.textIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textIdUsuario.Location = new System.Drawing.Point(324, 85);
            this.textIdUsuario.Name = "textIdUsuario";
            this.textIdUsuario.ReadOnly = true;
            this.textIdUsuario.Size = new System.Drawing.Size(100, 22);
            this.textIdUsuario.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(623, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "ID-NÍVEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(321, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "E-MAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(503, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SENHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(460, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(321, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(321, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(494, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 55);
            this.label6.TabIndex = 7;
            this.label6.Text = "TecNoo";
            // 
            // btn_sairGerUser
            // 
            this.btn_sairGerUser.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_sairGerUser.BackgroundImage = global::Tecnoo.Properties.Resources.exit_icon_icons_com_70975;
            this.btn_sairGerUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sairGerUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sairGerUser.FlatAppearance.BorderSize = 0;
            this.btn_sairGerUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sairGerUser.Location = new System.Drawing.Point(1244, 12);
            this.btn_sairGerUser.Name = "btn_sairGerUser";
            this.btn_sairGerUser.Size = new System.Drawing.Size(37, 42);
            this.btn_sairGerUser.TabIndex = 8;
            this.btn_sairGerUser.UseVisualStyleBackColor = false;
            this.btn_sairGerUser.Click += new System.EventHandler(this.btn_sairGerUser_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tecnoo.Properties.Resources.tecnoo;
            this.pictureBox2.Location = new System.Drawing.Point(693, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackgroundImage = global::Tecnoo.Properties.Resources.msn_user_avatar_person_people_icon_124220;
            this.pictureBoxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFoto.Location = new System.Drawing.Point(324, 266);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(100, 101);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 15;
            this.pictureBoxFoto.TabStop = false;
            this.pictureBoxFoto.Click += new System.EventHandler(this.pictureBoxFoto_Click);
            // 
            // F_AdicionarEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1293, 538);
            this.Controls.Add(this.btn_sairGerUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_AdicionarEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECNOO - GERENCIAMENTO DE USUÁRIOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.ComboBox cbNivelUser;
        private System.Windows.Forms.TextBox textNomeuser;
        private System.Windows.Forms.TextBox textEmailUser;
        private System.Windows.Forms.TextBox textLoginUser;
        private System.Windows.Forms.TextBox textSenhaUser;
        private System.Windows.Forms.TextBox textIdUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sairGerUser;
    }
}