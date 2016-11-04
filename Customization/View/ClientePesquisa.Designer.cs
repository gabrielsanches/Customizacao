namespace Customization.View
{
    partial class ClientePesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientePesquisa));
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbExportar = new System.Windows.Forms.ToolStripButton();
            this.tbFechar = new System.Windows.Forms.ToolStripButton();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.AllowUserToAddRows = false;
            this.dgvPessoas.AllowUserToDeleteRows = false;
            this.dgvPessoas.AllowUserToResizeRows = false;
            this.dgvPessoas.AutoGenerateColumns = false;
            this.dgvPessoas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPessoas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nome,
            this.apelidoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.telefone1});
            this.dgvPessoas.DataSource = this.pessoasBindingSource;
            this.dgvPessoas.EnableHeadersVisualStyles = false;
            this.dgvPessoas.Location = new System.Drawing.Point(90, 0);
            this.dgvPessoas.MultiSelect = false;
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.ReadOnly = true;
            this.dgvPessoas.RowHeadersVisible = false;
            this.dgvPessoas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoas.Size = new System.Drawing.Size(783, 402);
            this.dgvPessoas.TabIndex = 0;
            this.dgvPessoas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPessoas_CellMouseDoubleClick);
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPesquisa.Location = new System.Drawing.Point(90, 409);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(323, 20);
            this.tbPesquisa.TabIndex = 2;
            this.tbPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Items.AddRange(new object[] {
            "Nome",
            "Apelido",
            "Cpf/Cnpj",
            "Código"});
            this.cbPesquisa.Location = new System.Drawing.Point(419, 408);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(91, 21);
            this.cbPesquisa.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbExportar,
            this.tbFechar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(87, 435);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tbExportar
            // 
            this.tbExportar.Image = ((System.Drawing.Image)(resources.GetObject("tbExportar.Image")));
            this.tbExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbExportar.Name = "tbExportar";
            this.tbExportar.Size = new System.Drawing.Size(85, 20);
            this.tbExportar.Text = "Exportar";
            this.tbExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbExportar.Click += new System.EventHandler(this.tbExportar_Click);
            // 
            // tbFechar
            // 
            this.tbFechar.Image = ((System.Drawing.Image)(resources.GetObject("tbFechar.Image")));
            this.tbFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFechar.Name = "tbFechar";
            this.tbFechar.Size = new System.Drawing.Size(85, 20);
            this.tbFechar.Text = "Fechar";
            this.tbFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbFechar.Click += new System.EventHandler(this.tbFechar_Click);
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(Customization.Model.Pessoa);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.FillWeight = 60F;
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 60;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.FillWeight = 250F;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 250;
            // 
            // apelidoDataGridViewTextBoxColumn
            // 
            this.apelidoDataGridViewTextBoxColumn.DataPropertyName = "apelido";
            this.apelidoDataGridViewTextBoxColumn.FillWeight = 250F;
            this.apelidoDataGridViewTextBoxColumn.HeaderText = "Apelido";
            this.apelidoDataGridViewTextBoxColumn.Name = "apelidoDataGridViewTextBoxColumn";
            this.apelidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apelidoDataGridViewTextBoxColumn.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cpfCnpj";
            this.dataGridViewTextBoxColumn2.FillWeight = 120F;
            this.dataGridViewTextBoxColumn2.HeaderText = "CPF\\CNPJ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // telefone1
            // 
            this.telefone1.DataPropertyName = "telefone1";
            this.telefone1.FillWeight = 80F;
            this.telefone1.HeaderText = "Telefone1";
            this.telefone1.Name = "telefone1";
            this.telefone1.ReadOnly = true;
            this.telefone1.Width = 80;
            // 
            // ClientePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(874, 435);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.cbPesquisa);
            this.Controls.Add(this.tbPesquisa);
            this.Controls.Add(this.dgvPessoas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientePesquisa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pesquisa de Pessoas";
            this.Load += new System.EventHandler(this.ClientePesquisa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientePesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbExportar;
        private System.Windows.Forms.ToolStripButton tbFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1;
    }
}