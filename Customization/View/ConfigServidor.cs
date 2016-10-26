using Customization.Properties;
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
    public partial class ConfigServidor : Form
    {
        public ConfigServidor()
        {
            InitializeComponent();
        }

        private void ExportaDadosFrm_Load(object sender, EventArgs e)
        {
            tbIp.Text = Properties.Settings.Default.ip;
            tbDatabase.Text = Properties.Settings.Default.database;
            tbPort.Text = Properties.Settings.Default.port;
            tbUser.Text = Properties.Settings.Default.user;
            tbPassword.Text = Properties.Settings.Default.password;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            Settings set = Settings.Default;
            string ip = "", database = "", port = null, user = "", password = "";

            if (tbIp.Text != null && tbIp.Text != "")
            {
                ip = tbIp.Text;
            }
            if (tbDatabase.Text != null && tbDatabase.Text != "")
            {
                database = tbDatabase.Text;
            }
            if (tbPort.Text != null && tbPort.Text != "")
            {
                port = tbPort.Text;
            }
            if (tbUser.Text != null && tbUser.Text != "")
            {
                user = tbUser.Text;
            }
            if (tbPassword.Text != null && tbPassword.Text != "")
            {
                password = tbPassword.Text;
            }
            try
            {
                set.ip = ip;
                set.database = database;
                set.port = port;
                set.user = user;
                set.password = password;
                Utility.getConexao();
                Utility.ExecutaBD("select 1; select 2;");
                set.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IntegracaoDadosFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btNext_Click(sender, e);
            }
        }
    }
}
