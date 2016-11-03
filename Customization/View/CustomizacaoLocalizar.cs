using Customization.EntityDAO;
using Customization.Model;
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
    public partial class CustomizacaoLocalizar : Form
    {
        private CustomizacaoEDAO eCustomizacaoDAO = new CustomizacaoEDAO();
        private List<Customizacao> listCustom = null;

        public CustomizacaoLocalizar()
        {
            InitializeComponent();
        }

        private void tbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomizacaoLocalizar_Load(object sender, EventArgs e)
        {
            listCustom = eCustomizacaoDAO.

        }
    }
}
