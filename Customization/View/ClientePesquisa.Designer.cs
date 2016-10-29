﻿namespace Customization.View
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbExportar = new System.Windows.Forms.ToolStripButton();
            this.tbFechar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
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
            this.dataGridViewTextBoxColumn1,
            this.apelidoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.codigoDataGridViewTextBoxColumn});
            this.dgvPessoas.DataSource = this.pessoasBindingSource;
            this.dgvPessoas.EnableHeadersVisualStyles = false;
            this.dgvPessoas.Location = new System.Drawing.Point(90, 0);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.ReadOnly = true;
            this.dgvPessoas.RowHeadersVisible = false;
            this.dgvPessoas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoas.Size = new System.Drawing.Size(723, 402);
            this.dgvPessoas.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "razaoSocial";
            this.dataGridViewTextBoxColumn1.FillWeight = 250F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.FillWeight = 80F;
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 80;
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(Customization.Model.Pessoas);
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
            this.toolStrip2.Size = new System.Drawing.Size(87, 433);
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
            // ClientePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(814, 433);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.cbPesquisa);
            this.Controls.Add(this.tbPesquisa);
            this.Controls.Add(this.dgvPessoas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientePesquisa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Clientes";
            this.Load += new System.EventHandler(this.ClientePesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
    }
}