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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovaModalidade = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSavalModalidade = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCoachModalidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txNomeModalidade = new System.Windows.Forms.TextBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modalidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartGYMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartGYMDataSet = new SmartGym3.SmartGYMDataSet();
            this.modalidadesTableAdapter = new SmartGym3.SmartGYMDataSetTableAdapters.ModalidadesTableAdapter();
            this.idModalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeModalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonalTrainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePersonalTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMensalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartGYMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartGYMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovaModalidade,
            this.toolStripSeparator5,
            this.btnSavalModalidade,
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
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 70);
            // 
            // btnSavalModalidade
            // 
            this.btnSavalModalidade.AutoSize = false;
            this.btnSavalModalidade.Image = ((System.Drawing.Image)(resources.GetObject("btnSavalModalidade.Image")));
            this.btnSavalModalidade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSavalModalidade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavalModalidade.Name = "btnSavalModalidade";
            this.btnSavalModalidade.Size = new System.Drawing.Size(79, 67);
            this.btnSavalModalidade.Text = "Salvar";
            this.btnSavalModalidade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSavalModalidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.groupBox1.Controls.Add(this.txNomeModalidade);
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
            // txNomeModalidade
            // 
            this.txNomeModalidade.Location = new System.Drawing.Point(68, 49);
            this.txNomeModalidade.Name = "txNomeModalidade";
            this.txNomeModalidade.Size = new System.Drawing.Size(158, 20);
            this.txNomeModalidade.TabIndex = 69;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idModalidadeDataGridViewTextBoxColumn,
            this.nomeModalidadeDataGridViewTextBoxColumn,
            this.idPersonalTrainerDataGridViewTextBoxColumn,
            this.namePersonalTrainer,
            this.valorMensalidadeDataGridViewTextBoxColumn,
            this.btnEdit,
            this.btnDelete});
            this.dataGridView1.DataSource = this.modalidadesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(984, 346);
            this.dataGridView1.TabIndex = 13;
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
            // idModalidadeDataGridViewTextBoxColumn
            // 
            this.idModalidadeDataGridViewTextBoxColumn.DataPropertyName = "idModalidade";
            this.idModalidadeDataGridViewTextBoxColumn.HeaderText = "Código:";
            this.idModalidadeDataGridViewTextBoxColumn.Name = "idModalidadeDataGridViewTextBoxColumn";
            this.idModalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idModalidadeDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomeModalidadeDataGridViewTextBoxColumn
            // 
            this.nomeModalidadeDataGridViewTextBoxColumn.DataPropertyName = "nomeModalidade";
            this.nomeModalidadeDataGridViewTextBoxColumn.HeaderText = "Nome da Modalidade:";
            this.nomeModalidadeDataGridViewTextBoxColumn.Name = "nomeModalidadeDataGridViewTextBoxColumn";
            this.nomeModalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeModalidadeDataGridViewTextBoxColumn.Width = 280;
            // 
            // idPersonalTrainerDataGridViewTextBoxColumn
            // 
            this.idPersonalTrainerDataGridViewTextBoxColumn.DataPropertyName = "idPersonalTrainer";
            this.idPersonalTrainerDataGridViewTextBoxColumn.HeaderText = "idPersonalTrainer";
            this.idPersonalTrainerDataGridViewTextBoxColumn.Name = "idPersonalTrainerDataGridViewTextBoxColumn";
            this.idPersonalTrainerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPersonalTrainerDataGridViewTextBoxColumn.Visible = false;
            this.idPersonalTrainerDataGridViewTextBoxColumn.Width = 280;
            // 
            // namePersonalTrainer
            // 
            this.namePersonalTrainer.DataPropertyName = "NamePersonalTrainer";
            this.namePersonalTrainer.HeaderText = "Coach:";
            this.namePersonalTrainer.Name = "namePersonalTrainer";
            this.namePersonalTrainer.ReadOnly = true;
            // 
            // valorMensalidadeDataGridViewTextBoxColumn
            // 
            this.valorMensalidadeDataGridViewTextBoxColumn.DataPropertyName = "valorMensalidade";
            this.valorMensalidadeDataGridViewTextBoxColumn.HeaderText = "Mensalidade:";
            this.valorMensalidadeDataGridViewTextBoxColumn.Name = "valorMensalidadeDataGridViewTextBoxColumn";
            this.valorMensalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.DataPropertyName = "idModalidade";
            this.btnEdit.HeaderText = "Editar";
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.DataPropertyName = "idModalidade";
            this.btnDelete.HeaderText = "Deletar";
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            // 
            // frmModalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartGYMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartGYMDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovaModalidade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSavalModalidade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbCoachModalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txNomeModalidade;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idModalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeModalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonalTrainerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePersonalTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMensalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn btnEdit;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
    }
}