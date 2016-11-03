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
    public partial class Principal : Form
    {
        public Customizacao customizacao { get; set; }
        public Conexao conexao { get; set; }
        private CustomizacaoEDAO eCustomizacaoDAO = new CustomizacaoEDAO();

        public Principal()
        {
            customizacao = new Customizacao();
            conexao = new Conexao();
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ExitRichText();
            Utility.getConexaoLocal();
        }

        public bool SalvarCustomizacao()
        {
            if (customizacao.cliente != null && customizacao.programador != null && customizacao.tipo != null)
            {
                eCustomizacaoDAO.Salvar(customizacao);
            }
            else
            {
                MessageBox.Show("Os campos cliente, programador e tipo devem ser preenchidos.",
                                "Campos Obrigatórios",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        public void SalvarQuery()
        {
            customizacao.query = richTextBox.Text;
        }

        public void ExitRichText()
        {
            richTextBox.Clear();
            richTextBox.Visible = false;
            menuStrip1.Visible = false;
            toolStrip2.Visible = false;
            statusStrip1.Visible = false;
        }

        #region Actions

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                if (!SalvarCustomizacao())
                {
                    return;
                }
            }
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            { 
                richTextBox.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog(); sv.Filter = "Text Documents(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                SalvarQuery();
            }
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            ExitRichText();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarQuery();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Cut();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void richTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                exitToolStripMenuItem_Click(sender, e);
            }
        }

        private void saveExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarQuery();
            ExitRichText();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanUndo)
            {
                richTextBox.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanRedo)
            {
                richTextBox.Redo();
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            nome_fonte = richTextBox.SelectionFont.Name;
            tamanho_fonte = richTextBox.SelectionFont.Size;
            if (!richTextBox.SelectionFont.Bold)
            {
                richTextBox.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
                toolStripButton1.CheckState = CheckState.Checked;
            }
            else
            {
                richTextBox.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
                toolStripButton1.CheckState = CheckState.Unchecked;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            nome_fonte = richTextBox.SelectionFont.Name;
            tamanho_fonte = richTextBox.SelectionFont.Size;
            if (richTextBox.SelectionFont.Italic == false)
            {
                richTextBox.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
                toolStripButton2.CheckState = CheckState.Checked;
            }
            else
            {
                richTextBox.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
                toolStripButton2.CheckState = CheckState.Unchecked;
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            nome_fonte = richTextBox.SelectionFont.Name;
            tamanho_fonte = richTextBox.SelectionFont.Size;
            if (richTextBox.SelectionFont.Underline == false)
            {
                richTextBox.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
                toolStripButton3.CheckState = CheckState.Checked;
            }
            else
            {
                richTextBox.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
                toolStripButton3.CheckState = CheckState.Unchecked;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FontDialog fontD = new FontDialog();
            DialogResult result = fontD.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (richTextBox.SelectionFont != null)
                {
                    richTextBox.SelectionFont = fontD.Font;
                }
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Find(richTextBox.SelectedText);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ColorDialog colorD = new ColorDialog();
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = colorD.Color;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ColorDialog colorD = new ColorDialog();
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                richTextBox.BackColor = colorD.Color;
            }
        }

        private void richTextBox_CursorPositionChanged(object sender, EventArgs e)
        {
            int line = richTextBox.CurrentLine;
            int col = richTextBox.CurrentColumn;
            int pos = richTextBox.CurrentPosition;

            toolStripStatusLabel1.Text = "Line " + line + ", Col " + col +
                             ", Position " + pos;
            toolStripStatusLabel2.Text = "";
        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            int start = richTextBox.SelectionStart;
            int end = richTextBox.SelectionEnd;
            int length = richTextBox.SelectionLength;

            toolStripStatusLabel2.Text = "             Start " + start + ", End " + end +
                             ", Length " + length;
            
        }

        private void tbCliente_Click(object sender, EventArgs e)
        {
            ClientePesquisa clientePesquisa = new ClientePesquisa(this,true);
            clientePesquisa.ShowDialog();
            if (customizacao.cliente!=null)
            {
                tbCliente.Text = customizacao.cliente.apelido;
            }
        }

        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
        
        private void tbCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                tbCliente.Text = "";
                customizacao.cliente = null;
            }
        }

        private void tbTipo_Click(object sender, EventArgs e)
        {
            TipoPesquisa tipoPesquisa = new TipoPesquisa(this);
            tipoPesquisa.ShowDialog();
            if (customizacao.tipo!=null)
            {
                tbTipo.Text = customizacao.tipo.descricao;
            }
            
        }

        private void tbTipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                tbTipo.Text = "";
                customizacao.tipo = null;
            }
        }

        private void tbNovo_Click(object sender, EventArgs e)
        {
            customizacao = new Customizacao();
            conexao = new Conexao();
            tbCliente.Text = "";
            tbTipo.Text = "";
        }

        private void tbTransacao_Click(object sender, EventArgs e)
        {
            richTextBox.Text = customizacao.query;
            richTextBox.Visible = true;
            menuStrip1.Visible = true;
            toolStrip2.Visible = true;
            statusStrip1.Visible = true;
        }

        private void tbAmbiente_Click(object sender, EventArgs e)
        {
            ConfigServidorExterno configServidor = new ConfigServidorExterno(this);
            configServidor.ShowDialog();
        }

        private void tbSalvar_Click(object sender, EventArgs e)
        {
            SalvarCustomizacao();
        }

        private void tbProgramador_Click(object sender, EventArgs e)
        {
            ClientePesquisa clientePesquisa = new ClientePesquisa(this, false);
            clientePesquisa.ShowDialog();
            if (customizacao.programador != null)
            {
                tbProgramador.Text = customizacao.programador.apelido;
            }
        }

        private void tbProgramador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                tbProgramador.Text = "";
                customizacao.programador = null;
            }
        }

        private void tbServer_Click(object sender, EventArgs e)
        {
            ConfigServidor configServidor = new ConfigServidor();
            configServidor.ShowDialog();
            Utility.ReloadConnectionLocal();
        }

        private void tbLocalizar_Click(object sender, EventArgs e)
        {
            CustomizacaoLocalizar customizacaoLocalizar = new CustomizacaoLocalizar();
            customizacaoLocalizar.ShowDialog();
        }

        #endregion
    }
}
