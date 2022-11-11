namespace Tecnoo
{
    partial class F_EditaChamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_EditaChamado));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.cbLocalAtendimento = new System.Windows.Forms.ComboBox();
            this.cbStatusChamado = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textId_cliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.textComentario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textProtocolo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textIdChamado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_sairChamado = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPrioridade);
            this.groupBox2.Controls.Add(this.cbLocalAtendimento);
            this.groupBox2.Controls.Add(this.cbStatusChamado);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textId_cliente);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btn_Atualizar);
            this.groupBox2.Controls.Add(this.textComentario);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textProtocolo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textIdChamado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(91, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1078, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Media",
            "Alta"});
            this.cbPrioridade.Location = new System.Drawing.Point(661, 195);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(103, 24);
            this.cbPrioridade.TabIndex = 17;
            // 
            // cbLocalAtendimento
            // 
            this.cbLocalAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocalAtendimento.FormattingEnabled = true;
            this.cbLocalAtendimento.Items.AddRange(new object[] {
            "Domicilio",
            "Remoto",
            "Laboratorio"});
            this.cbLocalAtendimento.Location = new System.Drawing.Point(544, 129);
            this.cbLocalAtendimento.Name = "cbLocalAtendimento";
            this.cbLocalAtendimento.Size = new System.Drawing.Size(220, 24);
            this.cbLocalAtendimento.TabIndex = 16;
            // 
            // cbStatusChamado
            // 
            this.cbStatusChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusChamado.FormattingEnabled = true;
            this.cbStatusChamado.Items.AddRange(new object[] {
            "Aguardando equipamento",
            "Em Tratamento",
            "Cancelado",
            "Finalizado"});
            this.cbStatusChamado.Location = new System.Drawing.Point(542, 65);
            this.cbStatusChamado.Name = "cbStatusChamado";
            this.cbStatusChamado.Size = new System.Drawing.Size(220, 24);
            this.cbStatusChamado.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(541, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "ID-CLIENTE";
            // 
            // textId_cliente
            // 
            this.textId_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId_cliente.Location = new System.Drawing.Point(542, 195);
            this.textId_cliente.Name = "textId_cliente";
            this.textId_cliente.Size = new System.Drawing.Size(100, 22);
            this.textId_cliente.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(539, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "STATUS DO CHAMADO";
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Atualizar.Location = new System.Drawing.Point(639, 264);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(123, 50);
            this.btn_Atualizar.TabIndex = 10;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // textComentario
            // 
            this.textComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textComentario.Location = new System.Drawing.Point(315, 195);
            this.textComentario.Multiline = true;
            this.textComentario.Name = "textComentario";
            this.textComentario.Size = new System.Drawing.Size(220, 119);
            this.textComentario.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(314, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "COMENTÁRIO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(541, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "LOCAL DE ATENDIMENTO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(658, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "PRIORIDADE";
            // 
            // textProtocolo
            // 
            this.textProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProtocolo.Location = new System.Drawing.Point(315, 129);
            this.textProtocolo.Name = "textProtocolo";
            this.textProtocolo.ReadOnly = true;
            this.textProtocolo.Size = new System.Drawing.Size(220, 22);
            this.textProtocolo.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(314, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "PROTOCOLO";
            // 
            // textIdChamado
            // 
            this.textIdChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdChamado.Location = new System.Drawing.Point(315, 65);
            this.textIdChamado.Name = "textIdChamado";
            this.textIdChamado.ReadOnly = true;
            this.textIdChamado.Size = new System.Drawing.Size(102, 22);
            this.textIdChamado.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID-CHAMADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(477, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 55);
            this.label6.TabIndex = 5;
            this.label6.Text = "TecNoo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tecnoo.Properties.Resources.tecnoo;
            this.pictureBox2.Location = new System.Drawing.Point(676, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btn_sairChamado
            // 
            this.btn_sairChamado.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_sairChamado.BackgroundImage = global::Tecnoo.Properties.Resources.exit_icon_icons_com_70975;
            this.btn_sairChamado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sairChamado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sairChamado.FlatAppearance.BorderSize = 0;
            this.btn_sairChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sairChamado.Location = new System.Drawing.Point(1218, 12);
            this.btn_sairChamado.Name = "btn_sairChamado";
            this.btn_sairChamado.Size = new System.Drawing.Size(37, 42);
            this.btn_sairChamado.TabIndex = 6;
            this.btn_sairChamado.UseVisualStyleBackColor = false;
            this.btn_sairChamado.Click += new System.EventHandler(this.btn_sairChamado_Click);
            // 
            // F_EditaChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1267, 540);
            this.Controls.Add(this.btn_sairChamado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_EditaChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECNOO - ATUALIZA CHAMADO";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textId_cliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.TextBox textComentario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textProtocolo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textIdChamado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_sairChamado;
        private System.Windows.Forms.ComboBox cbPrioridade;
        private System.Windows.Forms.ComboBox cbLocalAtendimento;
        private System.Windows.Forms.ComboBox cbStatusChamado;
    }
}