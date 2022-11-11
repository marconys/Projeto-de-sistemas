namespace Tecnoo
{
    partial class Lista_Chamados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Chamados));
            this.tabChmados = new System.Windows.Forms.TabControl();
            this.tabListaChmados = new System.Windows.Forms.TabPage();
            this.dgv_chamados = new System.Windows.Forms.DataGridView();
            this.tabNovoChamado = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_laboratorio = new System.Windows.Forms.CheckBox();
            this.cb_remoto = new System.Windows.Forms.CheckBox();
            this.cb_domicilio = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_novoChamado = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radionaoFunciona = new System.Windows.Forms.RadioButton();
            this.radiofuncParcial = new System.Windows.Forms.RadioButton();
            this.radioFunciona = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textIdCliente = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovoChamado = new System.Windows.Forms.Button();
            this.btn_listarTodosOsChamados = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sair_chamaos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textMostraId = new System.Windows.Forms.TextBox();
            this.textMostraProtocolo = new System.Windows.Forms.TextBox();
            this.textMostrastatus = new System.Windows.Forms.TextBox();
            this.textMostraIdCli = new System.Windows.Forms.TextBox();
            this.textMostraPrioridade = new System.Windows.Forms.TextBox();
            this.textMostraTitulo = new System.Windows.Forms.TextBox();
            this.textMostraLocal = new System.Windows.Forms.TextBox();
            this.textMostraDescricao = new System.Windows.Forms.TextBox();
            this.textMostraData = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabChmados.SuspendLayout();
            this.tabListaChmados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chamados)).BeginInit();
            this.tabNovoChamado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChmados
            // 
            this.tabChmados.Controls.Add(this.tabListaChmados);
            this.tabChmados.Controls.Add(this.tabNovoChamado);
            this.tabChmados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabChmados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabChmados.Location = new System.Drawing.Point(0, 133);
            this.tabChmados.Name = "tabChmados";
            this.tabChmados.SelectedIndex = 0;
            this.tabChmados.Size = new System.Drawing.Size(1268, 405);
            this.tabChmados.TabIndex = 0;
            // 
            // tabListaChmados
            // 
            this.tabListaChmados.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabListaChmados.Controls.Add(this.groupBox2);
            this.tabListaChmados.Controls.Add(this.dgv_chamados);
            this.tabListaChmados.Location = new System.Drawing.Point(4, 22);
            this.tabListaChmados.Name = "tabListaChmados";
            this.tabListaChmados.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaChmados.Size = new System.Drawing.Size(1260, 379);
            this.tabListaChmados.TabIndex = 0;
            this.tabListaChmados.Text = "Lista de Chamados";
            // 
            // dgv_chamados
            // 
            this.dgv_chamados.AllowUserToAddRows = false;
            this.dgv_chamados.AllowUserToDeleteRows = false;
            this.dgv_chamados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_chamados.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgv_chamados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chamados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_chamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_chamados.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_chamados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_chamados.EnableHeadersVisualStyles = false;
            this.dgv_chamados.GridColor = System.Drawing.Color.Lavender;
            this.dgv_chamados.Location = new System.Drawing.Point(26, 41);
            this.dgv_chamados.Name = "dgv_chamados";
            this.dgv_chamados.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chamados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgv_chamados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_chamados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chamados.Size = new System.Drawing.Size(736, 289);
            this.dgv_chamados.TabIndex = 6;
            this.dgv_chamados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chamados_CellContentClick);
            this.dgv_chamados.Click += new System.EventHandler(this.dgv_chamados_Click);
            // 
            // tabNovoChamado
            // 
            this.tabNovoChamado.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabNovoChamado.Controls.Add(this.groupBox1);
            this.tabNovoChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNovoChamado.Location = new System.Drawing.Point(4, 22);
            this.tabNovoChamado.Name = "tabNovoChamado";
            this.tabNovoChamado.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovoChamado.Size = new System.Drawing.Size(1260, 379);
            this.tabNovoChamado.TabIndex = 1;
            this.tabNovoChamado.Text = "Novo Chamado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_laboratorio);
            this.groupBox1.Controls.Add(this.cb_remoto);
            this.groupBox1.Controls.Add(this.cb_domicilio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_novoChamado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radionaoFunciona);
            this.groupBox1.Controls.Add(this.radiofuncParcial);
            this.groupBox1.Controls.Add(this.radioFunciona);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textTitulo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textIdCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(184, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cb_laboratorio
            // 
            this.cb_laboratorio.AutoSize = true;
            this.cb_laboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_laboratorio.Location = new System.Drawing.Point(495, 294);
            this.cb_laboratorio.Name = "cb_laboratorio";
            this.cb_laboratorio.Size = new System.Drawing.Size(133, 20);
            this.cb_laboratorio.TabIndex = 12;
            this.cb_laboratorio.Text = "LABORATÓRIO";
            this.cb_laboratorio.UseVisualStyleBackColor = true;
            // 
            // cb_remoto
            // 
            this.cb_remoto.AutoSize = true;
            this.cb_remoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_remoto.Location = new System.Drawing.Point(398, 295);
            this.cb_remoto.Name = "cb_remoto";
            this.cb_remoto.Size = new System.Drawing.Size(91, 20);
            this.cb_remoto.TabIndex = 11;
            this.cb_remoto.Text = "REMOTO";
            this.cb_remoto.UseVisualStyleBackColor = true;
            // 
            // cb_domicilio
            // 
            this.cb_domicilio.AutoSize = true;
            this.cb_domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_domicilio.Location = new System.Drawing.Point(291, 295);
            this.cb_domicilio.Name = "cb_domicilio";
            this.cb_domicilio.Size = new System.Drawing.Size(101, 20);
            this.cb_domicilio.TabIndex = 10;
            this.cb_domicilio.Text = "DOMICÍLIO";
            this.cb_domicilio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(370, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "LOCAL DE ATENDIMENTO";
            // 
            // btn_novoChamado
            // 
            this.btn_novoChamado.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_novoChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novoChamado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_novoChamado.Location = new System.Drawing.Point(392, 321);
            this.btn_novoChamado.Name = "btn_novoChamado";
            this.btn_novoChamado.Size = new System.Drawing.Size(113, 38);
            this.btn_novoChamado.TabIndex = 8;
            this.btn_novoChamado.Text = "ENVIAR";
            this.btn_novoChamado.UseVisualStyleBackColor = false;
            this.btn_novoChamado.Click += new System.EventHandler(this.btn_novoChamado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(370, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "DESCRIÇÃO DO PROBLEMA";
            // 
            // radionaoFunciona
            // 
            this.radionaoFunciona.AutoSize = true;
            this.radionaoFunciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radionaoFunciona.Location = new System.Drawing.Point(531, 140);
            this.radionaoFunciona.Name = "radionaoFunciona";
            this.radionaoFunciona.Size = new System.Drawing.Size(138, 20);
            this.radionaoFunciona.TabIndex = 6;
            this.radionaoFunciona.TabStop = true;
            this.radionaoFunciona.Text = "NÃO FUNCIONA";
            this.radionaoFunciona.UseVisualStyleBackColor = true;
            // 
            // radiofuncParcial
            // 
            this.radiofuncParcial.AutoSize = true;
            this.radiofuncParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiofuncParcial.Location = new System.Drawing.Point(392, 140);
            this.radiofuncParcial.Name = "radiofuncParcial";
            this.radiofuncParcial.Size = new System.Drawing.Size(133, 20);
            this.radiofuncParcial.TabIndex = 5;
            this.radiofuncParcial.TabStop = true;
            this.radiofuncParcial.Text = "FUNC PARCIAL";
            this.radiofuncParcial.UseVisualStyleBackColor = true;
            // 
            // radioFunciona
            // 
            this.radioFunciona.AutoSize = true;
            this.radioFunciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFunciona.Location = new System.Drawing.Point(251, 140);
            this.radioFunciona.Name = "radioFunciona";
            this.radioFunciona.Size = new System.Drawing.Size(135, 20);
            this.radioFunciona.TabIndex = 4;
            this.radioFunciona.TabStop = true;
            this.radioFunciona.Text = "FUNCIONANDO";
            this.radioFunciona.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(370, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "TITULO DO PROBLEMA";
            // 
            // textTitulo
            // 
            this.textTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitulo.Location = new System.Drawing.Point(313, 89);
            this.textTitulo.MaxLength = 20;
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(267, 22);
            this.textTitulo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(310, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "QUAL O ATUAL ESTADO DO EQUIPAMENTO?";
            // 
            // textDescricao
            // 
            this.textDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescricao.Location = new System.Drawing.Point(326, 188);
            this.textDescricao.Multiline = true;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(267, 75);
            this.textDescricao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(395, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID CLIENTE";
            // 
            // textIdCliente
            // 
            this.textIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdCliente.Location = new System.Drawing.Point(392, 34);
            this.textIdCliente.Name = "textIdCliente";
            this.textIdCliente.Size = new System.Drawing.Size(100, 22);
            this.textIdCliente.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(781, 65);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(168, 62);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovoChamado
            // 
            this.btnNovoChamado.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNovoChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoChamado.Location = new System.Drawing.Point(561, 65);
            this.btnNovoChamado.Name = "btnNovoChamado";
            this.btnNovoChamado.Size = new System.Drawing.Size(168, 62);
            this.btnNovoChamado.TabIndex = 7;
            this.btnNovoChamado.Text = "Novo";
            this.btnNovoChamado.UseVisualStyleBackColor = false;
            this.btnNovoChamado.Click += new System.EventHandler(this.btnNovoChamado_Click);
            // 
            // btn_listarTodosOsChamados
            // 
            this.btn_listarTodosOsChamados.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_listarTodosOsChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarTodosOsChamados.Location = new System.Drawing.Point(999, 65);
            this.btn_listarTodosOsChamados.Name = "btn_listarTodosOsChamados";
            this.btn_listarTodosOsChamados.Size = new System.Drawing.Size(168, 62);
            this.btn_listarTodosOsChamados.TabIndex = 1;
            this.btn_listarTodosOsChamados.Text = "Todos";
            this.btn_listarTodosOsChamados.UseVisualStyleBackColor = false;
            this.btn_listarTodosOsChamados.Click += new System.EventHandler(this.btn_listarTodosOsChamados_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 108);
            this.label6.TabIndex = 3;
            this.label6.Text = "TecNoo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tecnoo.Properties.Resources.tecnoo;
            this.pictureBox1.Location = new System.Drawing.Point(378, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sair_chamaos
            // 
            this.btn_sair_chamaos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_sair_chamaos.BackgroundImage = global::Tecnoo.Properties.Resources.exit_icon_icons_com_70975;
            this.btn_sair_chamaos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sair_chamaos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair_chamaos.FlatAppearance.BorderSize = 0;
            this.btn_sair_chamaos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair_chamaos.Location = new System.Drawing.Point(1219, 9);
            this.btn_sair_chamaos.Name = "btn_sair_chamaos";
            this.btn_sair_chamaos.Size = new System.Drawing.Size(37, 42);
            this.btn_sair_chamaos.TabIndex = 0;
            this.btn_sair_chamaos.UseVisualStyleBackColor = false;
            this.btn_sair_chamaos.Click += new System.EventHandler(this.btn_sair_chamaos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textMostraData);
            this.groupBox2.Controls.Add(this.textMostraDescricao);
            this.groupBox2.Controls.Add(this.textMostraLocal);
            this.groupBox2.Controls.Add(this.textMostraTitulo);
            this.groupBox2.Controls.Add(this.textMostraPrioridade);
            this.groupBox2.Controls.Add(this.textMostraIdCli);
            this.groupBox2.Controls.Add(this.textMostrastatus);
            this.groupBox2.Controls.Add(this.textMostraProtocolo);
            this.groupBox2.Controls.Add(this.textMostraId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(768, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 296);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // textMostraId
            // 
            this.textMostraId.Location = new System.Drawing.Point(33, 32);
            this.textMostraId.Name = "textMostraId";
            this.textMostraId.ReadOnly = true;
            this.textMostraId.Size = new System.Drawing.Size(66, 20);
            this.textMostraId.TabIndex = 1;
            // 
            // textMostraProtocolo
            // 
            this.textMostraProtocolo.Location = new System.Drawing.Point(120, 32);
            this.textMostraProtocolo.Name = "textMostraProtocolo";
            this.textMostraProtocolo.ReadOnly = true;
            this.textMostraProtocolo.Size = new System.Drawing.Size(292, 20);
            this.textMostraProtocolo.TabIndex = 2;
            // 
            // textMostrastatus
            // 
            this.textMostrastatus.Location = new System.Drawing.Point(147, 144);
            this.textMostrastatus.Name = "textMostrastatus";
            this.textMostrastatus.ReadOnly = true;
            this.textMostrastatus.Size = new System.Drawing.Size(268, 20);
            this.textMostrastatus.TabIndex = 3;
            // 
            // textMostraIdCli
            // 
            this.textMostraIdCli.Location = new System.Drawing.Point(33, 87);
            this.textMostraIdCli.Name = "textMostraIdCli";
            this.textMostraIdCli.ReadOnly = true;
            this.textMostraIdCli.Size = new System.Drawing.Size(77, 20);
            this.textMostraIdCli.TabIndex = 4;
            // 
            // textMostraPrioridade
            // 
            this.textMostraPrioridade.Location = new System.Drawing.Point(33, 144);
            this.textMostraPrioridade.Name = "textMostraPrioridade";
            this.textMostraPrioridade.ReadOnly = true;
            this.textMostraPrioridade.Size = new System.Drawing.Size(97, 20);
            this.textMostraPrioridade.TabIndex = 5;
            // 
            // textMostraTitulo
            // 
            this.textMostraTitulo.Location = new System.Drawing.Point(124, 87);
            this.textMostraTitulo.Name = "textMostraTitulo";
            this.textMostraTitulo.ReadOnly = true;
            this.textMostraTitulo.Size = new System.Drawing.Size(288, 20);
            this.textMostraTitulo.TabIndex = 6;
            // 
            // textMostraLocal
            // 
            this.textMostraLocal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textMostraLocal.Location = new System.Drawing.Point(173, 201);
            this.textMostraLocal.Name = "textMostraLocal";
            this.textMostraLocal.ReadOnly = true;
            this.textMostraLocal.Size = new System.Drawing.Size(239, 20);
            this.textMostraLocal.TabIndex = 7;
            // 
            // textMostraDescricao
            // 
            this.textMostraDescricao.Location = new System.Drawing.Point(33, 254);
            this.textMostraDescricao.Multiline = true;
            this.textMostraDescricao.Name = "textMostraDescricao";
            this.textMostraDescricao.ReadOnly = true;
            this.textMostraDescricao.Size = new System.Drawing.Size(379, 36);
            this.textMostraDescricao.TabIndex = 8;
            // 
            // textMostraData
            // 
            this.textMostraData.Location = new System.Drawing.Point(33, 201);
            this.textMostraData.Name = "textMostraData";
            this.textMostraData.ReadOnly = true;
            this.textMostraData.Size = new System.Drawing.Size(100, 20);
            this.textMostraData.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "PRIORIDADE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "STATUS:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "DATA DE ABERTURA:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "DESCRICAO:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(172, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "LOCAL DO ATENDIMENTO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "ID-CLIENTE:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(121, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "TITULO:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(117, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "PROTOCOLO:";
            // 
            // Lista_Chamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1268, 538);
            this.Controls.Add(this.btnNovoChamado);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btn_listarTodosOsChamados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_sair_chamaos);
            this.Controls.Add(this.tabChmados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lista_Chamados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECNOO-CHAMADOS";
            this.Load += new System.EventHandler(this.Lista_Chamados_Load);
            this.tabChmados.ResumeLayout(false);
            this.tabListaChmados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chamados)).EndInit();
            this.tabNovoChamado.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabChmados;
        private System.Windows.Forms.TabPage tabListaChmados;
        private System.Windows.Forms.TabPage tabNovoChamado;
        private System.Windows.Forms.Button btn_sair_chamaos;
        private System.Windows.Forms.Button btn_listarTodosOsChamados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_novoChamado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radionaoFunciona;
        private System.Windows.Forms.RadioButton radiofuncParcial;
        private System.Windows.Forms.RadioButton radioFunciona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIdCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_laboratorio;
        private System.Windows.Forms.CheckBox cb_remoto;
        private System.Windows.Forms.CheckBox cb_domicilio;
        private System.Windows.Forms.DataGridView dgv_chamados;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovoChamado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textMostraData;
        private System.Windows.Forms.TextBox textMostraDescricao;
        private System.Windows.Forms.TextBox textMostraLocal;
        private System.Windows.Forms.TextBox textMostraTitulo;
        private System.Windows.Forms.TextBox textMostraPrioridade;
        private System.Windows.Forms.TextBox textMostraIdCli;
        private System.Windows.Forms.TextBox textMostrastatus;
        private System.Windows.Forms.TextBox textMostraProtocolo;
        private System.Windows.Forms.TextBox textMostraId;
        private System.Windows.Forms.Label label1;
    }
}