namespace SmartGym3
{
    partial class frmCoachs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoachs));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewCoach = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveCoach = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvPersonalTrainer = new System.Windows.Forms.DataGridView();
            this.dgvColumIdPersonalTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumNamePersonalTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumAddressPersonalTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumDistrictPersonalTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumCityPersonalTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumCEPPersonalTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumPhonePersonalTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumCPFPersonalTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumSalaryPersonalTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumCommentsPersonalTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.personalTrainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartGYMDataSet = new SmartGym3.SmartGYMDataSet();
            this.txtValorPesquisa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbItemPesquisa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.personalTrainerTableAdapter = new SmartGym3.SmartGYMDataSetTableAdapters.PersonalTrainerTableAdapter();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalTrainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalTrainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartGYMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewCoach,
            this.toolStripSeparator5,
            this.btnSaveCoach,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 70);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewCoach
            // 
            this.btnNewCoach.AutoSize = false;
            this.btnNewCoach.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCoach.Image")));
            this.btnNewCoach.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewCoach.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.btnNewCoach.Name = "btnNewCoach";
            this.btnNewCoach.Size = new System.Drawing.Size(79, 67);
            this.btnNewCoach.Text = "Novo Coach";
            this.btnNewCoach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewCoach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewCoach.Click += new System.EventHandler(this.btnNewCoach_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 70);
            // 
            // btnSaveCoach
            // 
            this.btnSaveCoach.AutoSize = false;
            this.btnSaveCoach.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCoach.Image")));
            this.btnSaveCoach.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveCoach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCoach.Name = "btnSaveCoach";
            this.btnSaveCoach.Size = new System.Drawing.Size(79, 67);
            this.btnSaveCoach.Text = "Salvar Coach";
            this.btnSaveCoach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveCoach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveCoach.Click += new System.EventHandler(this.btnSaveCoach_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 70);
            // 
            // dgvPersonalTrainer
            // 
            this.dgvPersonalTrainer.AllowUserToAddRows = false;
            this.dgvPersonalTrainer.AllowUserToDeleteRows = false;
            this.dgvPersonalTrainer.AutoGenerateColumns = false;
            this.dgvPersonalTrainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonalTrainer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumIdPersonalTrainer,
            this.dgvColumNamePersonalTrainer,
            this.dgvColumAddressPersonalTrainer,
            this.dgvColumDistrictPersonalTrainer,
            this.dgvColumCityPersonalTrainer,
            this.dgvColumCEPPersonalTrainer,
            this.dgvColumPhonePersonalTrainer,
            this.dgvColumCPFPersonalTrainer,
            this.dgvColumSalaryPersonalTrainer,
            this.dgvColumCommentsPersonalTrainer,
            this.btnEdit,
            this.btnDelete});
            this.dgvPersonalTrainer.DataSource = this.personalTrainerBindingSource;
            this.dgvPersonalTrainer.Location = new System.Drawing.Point(16, 202);
            this.dgvPersonalTrainer.Name = "dgvPersonalTrainer";
            this.dgvPersonalTrainer.ReadOnly = true;
            this.dgvPersonalTrainer.RowHeadersVisible = false;
            this.dgvPersonalTrainer.Size = new System.Drawing.Size(980, 323);
            this.dgvPersonalTrainer.TabIndex = 61;
            this.dgvPersonalTrainer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonalTrainer_CellContentClick);
            // 
            // dgvColumIdPersonalTrainer
            // 
            this.dgvColumIdPersonalTrainer.DataPropertyName = "IdPersonalTrainer";
            this.dgvColumIdPersonalTrainer.HeaderText = "ID";
            this.dgvColumIdPersonalTrainer.Name = "dgvColumIdPersonalTrainer";
            this.dgvColumIdPersonalTrainer.ReadOnly = true;
            this.dgvColumIdPersonalTrainer.Width = 40;
            // 
            // dgvColumNamePersonalTrainer
            // 
            this.dgvColumNamePersonalTrainer.DataPropertyName = "NamePersonalTrainer";
            this.dgvColumNamePersonalTrainer.HeaderText = "Nome";
            this.dgvColumNamePersonalTrainer.Name = "dgvColumNamePersonalTrainer";
            this.dgvColumNamePersonalTrainer.ReadOnly = true;
            this.dgvColumNamePersonalTrainer.Width = 280;
            // 
            // dgvColumAddressPersonalTrainer
            // 
            this.dgvColumAddressPersonalTrainer.DataPropertyName = "AddressPersonalTrainer";
            this.dgvColumAddressPersonalTrainer.HeaderText = "AddressPersonalTrainer";
            this.dgvColumAddressPersonalTrainer.Name = "dgvColumAddressPersonalTrainer";
            this.dgvColumAddressPersonalTrainer.ReadOnly = true;
            this.dgvColumAddressPersonalTrainer.Visible = false;
            // 
            // dgvColumDistrictPersonalTrainer
            // 
            this.dgvColumDistrictPersonalTrainer.DataPropertyName = "DistrictPersonalTrainer";
            this.dgvColumDistrictPersonalTrainer.HeaderText = "DistrictPersonalTrainer";
            this.dgvColumDistrictPersonalTrainer.Name = "dgvColumDistrictPersonalTrainer";
            this.dgvColumDistrictPersonalTrainer.ReadOnly = true;
            this.dgvColumDistrictPersonalTrainer.Visible = false;
            // 
            // dgvColumCityPersonalTrainer
            // 
            this.dgvColumCityPersonalTrainer.DataPropertyName = "CityPersonalTrainer";
            this.dgvColumCityPersonalTrainer.HeaderText = "Cidade:";
            this.dgvColumCityPersonalTrainer.Name = "dgvColumCityPersonalTrainer";
            this.dgvColumCityPersonalTrainer.ReadOnly = true;
            // 
            // dgvColumCEPPersonalTrainer
            // 
            this.dgvColumCEPPersonalTrainer.DataPropertyName = "CEPPersonalTrainer";
            this.dgvColumCEPPersonalTrainer.HeaderText = "CEPPersonalTrainer";
            this.dgvColumCEPPersonalTrainer.Name = "dgvColumCEPPersonalTrainer";
            this.dgvColumCEPPersonalTrainer.ReadOnly = true;
            this.dgvColumCEPPersonalTrainer.Visible = false;
            // 
            // dgvColumPhonePersonalTrainer
            // 
            this.dgvColumPhonePersonalTrainer.DataPropertyName = "PhonePersonalTrainer";
            this.dgvColumPhonePersonalTrainer.HeaderText = "Telefone: ";
            this.dgvColumPhonePersonalTrainer.Name = "dgvColumPhonePersonalTrainer";
            this.dgvColumPhonePersonalTrainer.ReadOnly = true;
            // 
            // dgvColumCPFPersonalTrainer
            // 
            this.dgvColumCPFPersonalTrainer.DataPropertyName = "CPFPersonalTrainer";
            this.dgvColumCPFPersonalTrainer.HeaderText = "CPFPersonalTrainer";
            this.dgvColumCPFPersonalTrainer.Name = "dgvColumCPFPersonalTrainer";
            this.dgvColumCPFPersonalTrainer.ReadOnly = true;
            this.dgvColumCPFPersonalTrainer.Visible = false;
            // 
            // dgvColumSalaryPersonalTrainer
            // 
            this.dgvColumSalaryPersonalTrainer.DataPropertyName = "SalaryPersonalTrainer";
            this.dgvColumSalaryPersonalTrainer.HeaderText = "Salário:";
            this.dgvColumSalaryPersonalTrainer.Name = "dgvColumSalaryPersonalTrainer";
            this.dgvColumSalaryPersonalTrainer.ReadOnly = true;
            // 
            // dgvColumCommentsPersonalTrainer
            // 
            this.dgvColumCommentsPersonalTrainer.DataPropertyName = "Comments";
            this.dgvColumCommentsPersonalTrainer.HeaderText = "Observações:";
            this.dgvColumCommentsPersonalTrainer.Name = "dgvColumCommentsPersonalTrainer";
            this.dgvColumCommentsPersonalTrainer.ReadOnly = true;
            this.dgvColumCommentsPersonalTrainer.Width = 260;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Editar";
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEdit.Width = 40;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Excluir";
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDelete.Width = 60;
            // 
            // personalTrainerBindingSource
            // 
            this.personalTrainerBindingSource.DataMember = "PersonalTrainer";
            this.personalTrainerBindingSource.DataSource = this.smartGYMDataSet;
            // 
            // smartGYMDataSet
            // 
            this.smartGYMDataSet.DataSetName = "SmartGYMDataSet";
            this.smartGYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtValorPesquisa
            // 
            this.txtValorPesquisa.Location = new System.Drawing.Point(801, 165);
            this.txtValorPesquisa.Name = "txtValorPesquisa";
            this.txtValorPesquisa.Size = new System.Drawing.Size(195, 20);
            this.txtValorPesquisa.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(797, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 19);
            this.label13.TabIndex = 59;
            this.label13.Text = "Valor a ser pesquisado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(596, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 19);
            this.label12.TabIndex = 58;
            this.label12.Text = "Pesquisar por:";
            // 
            // cbItemPesquisa
            // 
            this.cbItemPesquisa.FormattingEnabled = true;
            this.cbItemPesquisa.Items.AddRange(new object[] {
            "CPF",
            "Nome",
            "Endereço",
            "Bairro",
            "Cidade",
            "Celular",
            "CEP",
            "Salário"});
            this.cbItemPesquisa.Location = new System.Drawing.Point(596, 164);
            this.cbItemPesquisa.Name = "cbItemPesquisa";
            this.cbItemPesquisa.Size = new System.Drawing.Size(195, 21);
            this.cbItemPesquisa.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Salário:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(187, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "Cel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 52;
            this.label8.Text = "CPF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(383, 164);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(207, 20);
            this.txtCidade.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 50;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "CEP:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(87, 164);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(230, 20);
            this.txtBairro.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Bairro:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(87, 138);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(503, 20);
            this.txtEndereco.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Observações:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 112);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(503, 20);
            this.txtNome.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nome:";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(596, 112);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(400, 20);
            this.txtObservacoes.TabIndex = 40;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(87, 87);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(84, 20);
            this.txtCPF.TabIndex = 63;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(224, 89);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(93, 20);
            this.txtTelefone.TabIndex = 64;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(383, 88);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(63, 20);
            this.txtCep.TabIndex = 65;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(511, 89);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(79, 20);
            this.txtSalario.TabIndex = 66;
            // 
            // personalTrainerTableAdapter
            // 
            this.personalTrainerTableAdapter.ClearBeforeFill = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(917, 89);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 20);
            this.txtCodigo.TabIndex = 67;
            this.txtCodigo.Text = "0";
            // 
            // frmCoachs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.dgvPersonalTrainer);
            this.Controls.Add(this.txtValorPesquisa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbItemPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCoachs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Gym  - Adicionar Novos Coachs";
            this.Load += new System.EventHandler(this.frmCoachs_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalTrainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalTrainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartGYMDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewCoach;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSaveCoach;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridView dgvPersonalTrainer;
        private System.Windows.Forms.TextBox txtValorPesquisa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbItemPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtSalario;
        private SmartGYMDataSet smartGYMDataSet;
        private System.Windows.Forms.BindingSource personalTrainerBindingSource;
        private SmartGYMDataSetTableAdapters.PersonalTrainerTableAdapter personalTrainerTableAdapter;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumIdPersonalTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumNamePersonalTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumAddressPersonalTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumDistrictPersonalTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumCityPersonalTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumCEPPersonalTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumPhonePersonalTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumCPFPersonalTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumSalaryPersonalTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumCommentsPersonalTrainer;
        private System.Windows.Forms.DataGridViewImageColumn btnEdit;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
    }
}