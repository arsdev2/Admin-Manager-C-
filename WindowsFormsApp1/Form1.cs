using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private BirdsForm birdForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void birdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new BirdsForm());
        }

        private void showForm(Form form) {
            form.ShowDialog();
        }

        private void continentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new ContinentsForm());
        }

        private void eggsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new EggsForm());
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.D1))
            {
                showForm(new BirdsForm());
                return true;
            }else if (keyData == (Keys.Control | Keys.D2)) {
                showForm(new ContinentsForm());
                return true;
            }else if (keyData == (Keys.Control | Keys.D3)) {
                showForm(new EggsForm());
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new AboutProgramForm());
        }

        private void calcMenu_Click(object sender, EventArgs e)
        {
            showForm(new Calculator());
        }
    }
}
