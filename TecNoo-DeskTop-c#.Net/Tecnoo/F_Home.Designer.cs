namespace Tecnoo
{
    partial class F_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Home));
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lbUserLogado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFPSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seja Bem-Vindo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIniciar.Location = new System.Drawing.Point(465, 428);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(290, 78);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lbUserLogado
            // 
            this.lbUserLogado.AutoSize = true;
            this.lbUserLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserLogado.Location = new System.Drawing.Point(648, 43);
            this.lbUserLogado.Name = "lbUserLogado";
            this.lbUserLogado.Size = new System.Drawing.Size(0, 31);
            this.lbUserLogado.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tecnoo.Properties.Resources.carrousel_0;
            this.pictureBox1.Location = new System.Drawing.Point(283, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnFPSair
            // 
            this.btnFPSair.BackgroundImage = global::Tecnoo.Properties.Resources.exit_closethesession_close_6317;
            this.btnFPSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFPSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFPSair.FlatAppearance.BorderSize = 0;
            this.btnFPSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFPSair.Location = new System.Drawing.Point(1201, 12);
            this.btnFPSair.Name = "btnFPSair";
            this.btnFPSair.Size = new System.Drawing.Size(32, 32);
            this.btnFPSair.TabIndex = 1;
            this.btnFPSair.UseVisualStyleBackColor = true;
            this.btnFPSair.Click += new System.EventHandler(this.btnFPSair_Click);
            // 
            // F_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1245, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbUserLogado);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnFPSair);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TecNoo - HOME";
            this.Shown += new System.EventHandler(this.F_Home_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFPSair;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lbUserLogado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}