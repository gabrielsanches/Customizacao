using Customization.EntityDAO;
using Customization.Model;
using Customization.Negócio;
using Customization.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customization.View
{
    public partial class TipoPesquisa : Form
    {
        private TipoNegocio TipoNegocio = new TipoNegocio();
        public DataTable dataTableTipo = null;
        Principal principal;

        public TipoPesquisa(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        public void LoadDGV()
        {
            dataTableTipo = TipoNegocio.ListarTodos();
            List<Tipo> tipos = Utility.ConvertDataTable<Tipo>(dataTableTipo);
            dgvTipo.DataSource = dataTableTipo;
        }

        private void Tipo_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void Tipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void tbCadastrar_Click(object sender, EventArgs e)
        {
            TipoCadastro tipoCadastro = new TipoCadastro();
            tipoCadastro.ShowDialog();
            LoadDGV();
        }

        private void tbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbExportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }

        private void dgvTipo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Exportar();
        }

        public void Exportar()
        {
            int codigoTipo = Convert.ToInt32(dgvTipo.SelectedRows[0].Cells[0].Value);
            var tipo = dataTableTipo.AsEnumerable().Where(x => x.Field<int>("idtipo") == codigoTipo).First();
            principal.customizacao.tipo = Utility.GetItem<Tipo>(tipo);
            this.Close();
        }
    }
}
