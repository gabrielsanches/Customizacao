namespace Customization.View
{
    partial class CustomizacaoLocalizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizacaoLocalizar));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbExportar = new System.Windows.Forms.ToolStripButton();
            this.tbFechar = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customizacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customizacaoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip2.Size = new System.Drawing.Size(87, 548);
            this.toolStrip2.TabIndex = 5;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.programadorDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.inicioDataGridViewTextBoxColumn,
            this.fimDataGridViewTextBoxColumn,
            this.entregaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customizacaoBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(91, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(958, 510);
            this.dataGridView1.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 60F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // programadorDataGridViewTextBoxColumn
            // 
            this.programadorDataGridViewTextBoxColumn.DataPropertyName = "programador";
            this.programadorDataGridViewTextBoxColumn.FillWeight = 200F;
            this.programadorDataGridViewTextBoxColumn.HeaderText = "Programador";
            this.programadorDataGridViewTextBoxColumn.Name = "programadorDataGridViewTextBoxColumn";
            this.programadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.programadorDataGridViewTextBoxColumn.Width = 200;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.FillWeight = 250F;
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 250;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.FillWeight = 200F;
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 200;
            // 
            // inicioDataGridViewTextBoxColumn
            // 
            this.inicioDataGridViewTextBoxColumn.DataPropertyName = "inicio";
            this.inicioDataGridViewTextBoxColumn.FillWeight = 80F;
            this.inicioDataGridViewTextBoxColumn.HeaderText = "Início";
            this.inicioDataGridViewTextBoxColumn.Name = "inicioDataGridViewTextBoxColumn";
            this.inicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.inicioDataGridViewTextBoxColumn.Width = 80;
            // 
            // fimDataGridViewTextBoxColumn
            // 
            this.fimDataGridViewTextBoxColumn.DataPropertyName = "fim";
            this.fimDataGridViewTextBoxColumn.FillWeight = 80F;
            this.fimDataGridViewTextBoxColumn.HeaderText = "Fim";
            this.fimDataGridViewTextBoxColumn.Name = "fimDataGridViewTextBoxColumn";
            this.fimDataGridViewTextBoxColumn.ReadOnly = true;
            this.fimDataGridViewTextBoxColumn.Width = 80;
            // 
            // entregaDataGridViewTextBoxColumn
            // 
            this.entregaDataGridViewTextBoxColumn.DataPropertyName = "entrega";
            this.entregaDataGridViewTextBoxColumn.FillWeight = 80F;
            this.entregaDataGridViewTextBoxColumn.HeaderText = "Entrega";
            this.entregaDataGridViewTextBoxColumn.Name = "entregaDataGridViewTextBoxColumn";
            this.entregaDataGridViewTextBoxColumn.ReadOnly = true;
            this.entregaDataGridViewTextBoxColumn.Width = 80;
            // 
            // customizacaoBindingSource
            // 
            this.customizacaoBindingSource.DataSource = typeof(Customization.Model.Customizacao);
            // 
            // CustomizacaoLocalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 548);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomizacaoLocalizar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Customizações";
            this.Load += new System.EventHandler(this.CustomizacaoLocalizar_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customizacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbExportar;
        private System.Windows.Forms.ToolStripButton tbFechar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource customizacaoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregaDataGridViewTextBoxColumn;
    }
}