namespace Customization.View
{
    partial class TipoPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoPesquisa));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbExportar = new System.Windows.Forms.ToolStripButton();
            this.tbCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tbFechar = new System.Windows.Forms.ToolStripButton();
            this.dgvTipo = new System.Windows.Forms.DataGridView();
            this.idtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
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
            this.tbCadastrar,
            this.tbFechar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(87, 250);
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
            this.tbExportar.Click += new System.EventHandler(this.tbExportar_Click);
            // 
            // tbCadastrar
            // 
            this.tbCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("tbCadastrar.Image")));
            this.tbCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCadastrar.Name = "tbCadastrar";
            this.tbCadastrar.Size = new System.Drawing.Size(85, 20);
            this.tbCadastrar.Text = "Cadastrar";
            this.tbCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCadastrar.Click += new System.EventHandler(this.tbCadastrar_Click);
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
            // dgvTipo
            // 
            this.dgvTipo.AllowUserToAddRows = false;
            this.dgvTipo.AllowUserToDeleteRows = false;
            this.dgvTipo.AllowUserToResizeRows = false;
            this.dgvTipo.AutoGenerateColumns = false;
            this.dgvTipo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtipo,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgvTipo.DataSource = this.tipoBindingSource;
            this.dgvTipo.EnableHeadersVisualStyles = false;
            this.dgvTipo.Location = new System.Drawing.Point(90, 0);
            this.dgvTipo.MultiSelect = false;
            this.dgvTipo.Name = "dgvTipo";
            this.dgvTipo.ReadOnly = true;
            this.dgvTipo.RowHeadersVisible = false;
            this.dgvTipo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipo.Size = new System.Drawing.Size(363, 248);
            this.dgvTipo.TabIndex = 6;
            this.dgvTipo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTipo_CellMouseDoubleClick);
            // 
            // idtipo
            // 
            this.idtipo.DataPropertyName = "idtipo";
            this.idtipo.FillWeight = 60F;
            this.idtipo.HeaderText = "Código";
            this.idtipo.Name = "idtipo";
            this.idtipo.ReadOnly = true;
            this.idtipo.Width = 60;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.FillWeight = 300F;
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 300;
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataSource = typeof(Customization.Model.Tipo);
            // 
            // TipoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 250);
            this.Controls.Add(this.dgvTipo);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoPesquisa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipo";
            this.Load += new System.EventHandler(this.Tipo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tipo_KeyDown);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbExportar;
        private System.Windows.Forms.ToolStripButton tbCadastrar;
        private System.Windows.Forms.ToolStripButton tbFechar;
        private System.Windows.Forms.DataGridView dgvTipo;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}