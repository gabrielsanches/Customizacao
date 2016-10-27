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
        public Principal()
        {
            InitializeComponent();
        }

        public void Salvar()
        {

        }
        public void Exit()
        {
            richTextBox.Clear();
            richTextBox.Visible = false;
            menuStrip1.Visible = false;
            toolStrip2.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
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
            DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Salvar();
            }
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
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
            Salvar();
            Exit();
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

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {/*
            richTextBox.Curre
            //int line = 1 + richTextBox.GetLineFromCharIndex(richTextBox.GetFirstCharIndexOfCurrentLine());
            int column = 1 + richTextBox.SelectionStart - richTextBox.GetFirstCharIndexOfCurrentLine();
            toolStripStatusLabel1.Text = "Linha: " + line.ToString() + ", Coluna: " + column.ToString();*/
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
    }
}
