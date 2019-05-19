using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChildForm cf = new ChildForm();
            cf.MdiParent = this;
            cf.Show();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cascadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var cf = (ChildForm) this.ActiveMdiChild;
                cf.richTextBox1.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var cf = (ChildForm)this.ActiveMdiChild;
                cf.richTextBox1.Redo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var cf = (ChildForm)this.ActiveMdiChild;
                cf.richTextBox1.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var cf = (ChildForm)this.ActiveMdiChild;
                cf.richTextBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var cf = (ChildForm)this.ActiveMdiChild;
                cf.richTextBox1.Paste();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var cf = (ChildForm) this.ActiveMdiChild;
                saveFileDialog1.Filter = "Rich Text File|*.rtf";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    cf.richTextBox1.SaveFile(saveFileDialog1.FileName);
                    cf.Text = saveFileDialog1.FileName;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Rich Text File |*.rtf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var cf = new ChildForm();
                cf.richTextBox1.LoadFile(openFileDialog1.FileName);
                cf.Text = openFileDialog1.FileName;
                cf.MdiParent = this;
                cf.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var cf = new ChildForm();

            

            cf.MdiParent = this;
            cf.Show();
        }
    }
}
