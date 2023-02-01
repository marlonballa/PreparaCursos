namespace SmartGym3
{
    partial class frmModalidades
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModalidades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovaModalidade = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvarModalidade = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCoachModalidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeModalidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMensalidadeModalidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodModalidade = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPesquisaModalidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbItemPesquisa = new System.Windows.Forms.ComboBox();
            this.modalidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartGYMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartGYMDataSet = new SmartGym3.SmartGYMDataSet();
            this.modalidadesTableAdapter = new SmartGym3.SmartGYMDataSetTableAdapters.ModalidadesTableAdapter();
            this.modalidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modalidadesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.modalidadesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dtgModalidades = new System.Windows.Forms.DataGridView();
            this.idModalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeModalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonalTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMensalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartGYMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartGYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgModalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovaModalidade,
            this.toolStripSeparator5,
            this.btnSalvarModalidade,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 70);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovaModalidade
            // 
            this.btnNovaModalidade.AutoSize = false;
            this.btnNovaModalidade.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaModalidade.Image")));
            this.btnNovaModalidade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovaModalidade.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.btnNovaModalidade.Name = "btnNovaModalidade";
            this.btnNovaModalidade.Size = new System.Drawing.Size(79, 67);
            this.btnNovaModalidade.Text = "Novo";
            this.btnNovaModalidade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovaModalidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovaModalidade.Click += new System.EventHandler(this.btnNovaModalidade_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 70);
            // 
            // btnSalvarModalidade
            // 
            this.btnSalvarModalidade.AutoSize = false;
            this.btnSalvarModalidade.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarModalidade.Image")));
            this.btnSalvarModalidade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvarModalidade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarModalidade.Name = "btnSalvarModalidade";
            this.btnSalvarModalidade.Size = new System.Drawing.Size(79, 67);
            this.btnSalvarModalidade.Text = "Salvar";
            this.btnSalvarModalidade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarModalidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvarModalidade.Click += new System.EventHandler(this.btnSavalModalidade_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 70);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCoachModalidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNomeModalidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMensalidadeModalidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodModalidade);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Modalidade";
            // 
            // cbCoachModalidade
            // 
            this.cbCoachModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoachModalidade.FormattingEnabled = true;
            this.cbCoachModalidade.Items.AddRange(new object[] {
            "Modalidade",
            "Coach"});
            this.cbCoachModalidade.Location = new System.Drawing.Point(299, 49);
            this.cbCoachModalidade.Name = "cbCoachModalidade";
            this.cbCoachModalidade.Size = new System.Drawing.Size(195, 21);
            this.cbCoachModalidade.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 70;
            this.label4.Text = "Coach:";
            // 
            // txtNomeModalidade
            // 
            this.txtNomeModalidade.Location = new System.Drawing.Point(68, 49);
            this.txtNomeModalidade.Name = "txtNomeModalidade";
            this.txtNomeModalidade.Size = new System.Drawing.Size(158, 20);
            this.txtNomeModalidade.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 68;
            this.label3.Text = "Nome:";
            // 
            // txtMensalidadeModalidade
            // 
            this.txtMensalidadeModalidade.Location = new System.Drawing.Point(299, 24);
            this.txtMensalidadeModalidade.Name = "txtMensalidadeModalidade";
            this.txtMensalidadeModalidade.Size = new System.Drawing.Size(103, 20);
            this.txtMensalidadeModalidade.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Mensal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "Código:";
            // 
            // txtCodModalidade
            // 
            this.txtCodModalidade.Enabled = false;
            this.txtCodModalidade.Location = new System.Drawing.Point(68, 24);
            this.txtCodModalidade.Name = "txtCodModalidade";
            this.txtCodModalidade.Size = new System.Drawing.Size(63, 20);
            this.txtCodModalidade.TabIndex = 65;
            this.txtCodModalidade.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPesquisaModalidade);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbItemPesquisa);
            this.groupBox2.Location = new System.Drawing.Point(518, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar:";
            // 
            // txtPesquisaModalidade
            // 
            this.txtPesquisaModalidade.Location = new System.Drawing.Point(211, 52);
            this.txtPesquisaModalidade.Name = "txtPesquisaModalidade";
            this.txtPesquisaModalidade.Size = new System.Drawing.Size(195, 20);
            this.txtPesquisaModalidade.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(207, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 19);
            this.label13.TabIndex = 63;
            this.label13.Text = "Valor a ser pesquisado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 19);
            this.label12.TabIndex = 62;
            this.label12.Text = "Pesquisar por:";
            // 
            // cbItemPesquisa
            // 
            this.cbItemPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemPesquisa.FormattingEnabled = true;
            this.cbItemPesquisa.Items.AddRange(new object[] {
            "Modalidade",
            "Coach"});
            this.cbItemPesquisa.Location = new System.Drawing.Point(6, 49);
            this.cbItemPesquisa.Name = "cbItemPesquisa";
            this.cbItemPesquisa.Size = new System.Drawing.Size(195, 21);
            this.cbItemPesquisa.TabIndex = 61;
            // 
            // modalidadesBindingSource
            // 
            this.modalidadesBindingSource.DataMember = "Modalidades";
            this.modalidadesBindingSource.DataSource = this.smartGYMDataSetBindingSource;
            // 
            // smartGYMDataSetBindingSource
            // 
            this.smartGYMDataSetBindingSource.DataSource = this.smartGYMDataSet;
            this.smartGYMDataSetBindingSource.Position = 0;
            // 
            // smartGYMDataSet
            // 
            this.smartGYMDataSet.DataSetName = "SmartGYMDataSet";
            this.smartGYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modalidadesTableAdapter
            // 
            this.modalidadesTableAdapter.ClearBeforeFill = true;
            // 
            // modalidadesBindingSource1
            // 
            this.modalidadesBindingSource1.DataMember = "Modalidades";
            this.modalidadesBindingSource1.DataSource = this.smartGYMDataSetBindingSource;
            // 
            // modalidadesBindingSource2
            // 
            this.modalidadesBindingSource2.DataMember = "Modalidades";
            this.modalidadesBindingSource2.DataSource = this.smartGYMDataSetBindingSource;
            // 
            // modalidadesBindingSource3
            // 
            this.modalidadesBindingSource3.DataMember = "Modalidades";
            this.modalidadesBindingSource3.DataSource = this.smartGYMDataSetBindingSource;
            // 
            // dtgModalidades
            // 
            this.dtgModalidades.AllowUserToAddRows = false;
            this.dtgModalidades.AllowUserToDeleteRows = false;
            this.dtgModalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgModalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idModalidade,
            this.nomeModalidade,
            this.nomeCoach,
            this.idPersonalTrainer,
            this.valorMensalidade,
            this.btnEdit,
            this.btnDelete});
            this.dtgModalidades.Location = new System.Drawing.Point(12, 179);
            this.dtgModalidades.Name = "dtgModalidades";
            this.dtgModalidades.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgModalidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgModalidades.RowHeadersVisible = false;
            this.dtgModalidades.Size = new System.Drawing.Size(984, 346);
            this.dtgModalidades.TabIndex = 13;
            // 
            // idModalidade
            // 
            this.idModalidade.DataPropertyName = "idModalidade";
            this.idModalidade.HeaderText = "Código:";
            this.idModalidade.Name = "idModalidade";
            this.idModalidade.ReadOnly = true;
            this.idModalidade.Width = 80;
            // 
            // nomeModalidade
            // 
            this.nomeModalidade.DataPropertyName = "nomeModalidade";
            this.nomeModalidade.HeaderText = "Modalidade:";
            this.nomeModalidade.Name = "nomeModalidade";
            this.nomeModalidade.ReadOnly = true;
            this.nomeModalidade.Width = 292;
            // 
            // nomeCoach
            // 
            this.nomeCoach.DataPropertyName = "NamePersonalTrainer";
            this.nomeCoach.HeaderText = "Coach:";
            this.nomeCoach.Name = "nomeCoach";
            this.nomeCoach.ReadOnly = true;
            this.nomeCoach.Width = 292;
            // 
            // idPersonalTrainer
            // 
            this.idPersonalTrainer.DataPropertyName = "idPersonalTrainer";
            this.idPersonalTrainer.HeaderText = "Matrícula:";
            this.idPersonalTrainer.Name = "idPersonalTrainer";
            this.idPersonalTrainer.ReadOnly = true;
            this.idPersonalTrainer.Width = 80;
            // 
            // valorMensalidade
            // 
            this.valorMensalidade.DataPropertyName = "valorMensalidade";
            this.valorMensalidade.HeaderText = "Mensalidade:";
            this.valorMensalidade.Name = "valorMensalidade";
            this.valorMensalidade.ReadOnly = true;
            this.valorMensalidade.Width = 80;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Editar:";
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Width = 80;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Excluir:";
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Width = 80;
            // 
            // frmModalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.dtgModalidades);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartGym - Controle de Modalidades";
            this.Load += new System.EventHandler(this.frmModalidades_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartGYMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartGYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgModalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovaModalidade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSalvarModalidade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbCoachModalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeModalidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMensalidadeModalidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodModalidade;
        private System.Windows.Forms.TextBox txtPesquisaModalidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbItemPesquisa;
        private System.Windows.Forms.BindingSource smartGYMDataSetBindingSource;
        private SmartGYMDataSet smartGYMDataSet;
        private System.Windows.Forms.BindingSource modalidadesBindingSource;
        private SmartGYMDataSetTableAdapters.ModalidadesTableAdapter modalidadesTableAdapter;
        private System.Windows.Forms.BindingSource modalidadesBindingSource1;
        private System.Windows.Forms.BindingSource modalidadesBindingSource2;
        private System.Windows.Forms.BindingSource modalidadesBindingSource3;
        private System.Windows.Forms.DataGridView dtgModalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeModalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonalTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMensalidade;
        private System.Windows.Forms.DataGridViewImageColumn btnEdit;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
    }
}