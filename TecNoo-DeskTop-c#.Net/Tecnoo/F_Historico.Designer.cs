namespace Tecnoo
{
    partial class F_Historico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Historico));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sairHistorico = new System.Windows.Forms.Button();
            this.dgv_Historico = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textMostraData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textMostraIdUser = new System.Windows.Forms.TextBox();
            this.textMostraComentario = new System.Windows.Forms.TextBox();
            this.textMostraIdCha = new System.Windows.Forms.TextBox();
            this.textMostraIdHist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tecnoo.Properties.Resources.tecnoo;
            this.pictureBox1.Location = new System.Drawing.Point(378, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 108);
            this.label6.TabIndex = 5;
            this.label6.Text = "TecNoo";
            // 
            // btn_sairHistorico
            // 
            this.btn_sairHistorico.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_sairHistorico.BackgroundImage = global::Tecnoo.Properties.Resources.exit_icon_icons_com_70975;
            this.btn_sairHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sairHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sairHistorico.FlatAppearance.BorderSize = 0;
            this.btn_sairHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sairHistorico.Location = new System.Drawing.Point(1213, 12);
            this.btn_sairHistorico.Name = "btn_sairHistorico";
            this.btn_sairHistorico.Size = new System.Drawing.Size(37, 42);
            this.btn_sairHistorico.TabIndex = 8;
            this.btn_sairHistorico.UseVisualStyleBackColor = false;
            this.btn_sairHistorico.Click += new System.EventHandler(this.btn_sairHistorico_Click);
            // 
            // dgv_Historico
            // 
            this.dgv_Historico.AllowUserToAddRows = false;
            this.dgv_Historico.AllowUserToDeleteRows = false;
            this.dgv_Historico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Historico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Historico.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgv_Historico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Historico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Historico.ColumnHeadersHeight = 25;
            this.dgv_Historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Historico.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Historico.EnableHeadersVisualStyles = false;
            this.dgv_Historico.GridColor = System.Drawing.Color.Lavender;
            this.dgv_Historico.Location = new System.Drawing.Point(176, 194);
            this.dgv_Historico.Name = "dgv_Historico";
            this.dgv_Historico.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Historico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Historico.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Historico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Historico.Size = new System.Drawing.Size(491, 211);
            this.dgv_Historico.TabIndex = 0;
            this.dgv_Historico.Click += new System.EventHandler(this.dgv_Historico_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textMostraData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textMostraIdUser);
            this.groupBox1.Controls.Add(this.textMostraComentario);
            this.groupBox1.Controls.Add(this.textMostraIdCha);
            this.groupBox1.Controls.Add(this.textMostraIdHist);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(673, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 218);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // textMostraData
            // 
            this.textMostraData.Location = new System.Drawing.Point(204, 96);
            this.textMostraData.Name = "textMostraData";
            this.textMostraData.Size = new System.Drawing.Size(122, 21);
            this.textMostraData.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "COMENTARIO:";
            // 
            // textMostraIdUser
            // 
            this.textMostraIdUser.Location = new System.Drawing.Point(55, 96);
            this.textMostraIdUser.Name = "textMostraIdUser";
            this.textMostraIdUser.Size = new System.Drawing.Size(97, 21);
            this.textMostraIdUser.TabIndex = 7;
            // 
            // textMostraComentario
            // 
            this.textMostraComentario.Location = new System.Drawing.Point(55, 153);
            this.textMostraComentario.Multiline = true;
            this.textMostraComentario.Name = "textMostraComentario";
            this.textMostraComentario.Size = new System.Drawing.Size(271, 59);
            this.textMostraComentario.TabIndex = 6;
            // 
            // textMostraIdCha
            // 
            this.textMostraIdCha.Location = new System.Drawing.Point(204, 35);
            this.textMostraIdCha.Name = "textMostraIdCha";
            this.textMostraIdCha.Size = new System.Drawing.Size(122, 21);
            this.textMostraIdCha.TabIndex = 5;
            // 
            // textMostraIdHist
            // 
            this.textMostraIdHist.Location = new System.Drawing.Point(55, 35);
            this.textMostraIdHist.Name = "textMostraIdHist";
            this.textMostraIdHist.Size = new System.Drawing.Size(97, 21);
            this.textMostraIdHist.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "DATA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID-CHAMADO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID-USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // F_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1262, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Historico);
            this.Controls.Add(this.btn_sairHistorico);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECNOO - HISTÓRICOS DE ATENDIMENTOS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sairHistorico;
        private System.Windows.Forms.DataGridView dgv_Historico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textMostraIdUser;
        private System.Windows.Forms.TextBox textMostraComentario;
        private System.Windows.Forms.TextBox textMostraIdCha;
        private System.Windows.Forms.TextBox textMostraIdHist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMostraData;
        private System.Windows.Forms.Label label5;
    }
}