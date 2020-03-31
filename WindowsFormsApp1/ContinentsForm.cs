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
    public partial class ContinentsForm : Form
    {
        public ContinentsForm()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            DBManager.bindingSource = new BindingSource();
            DBManager.bindingSource.DataSource = DBManager.performSql("SELECT * FROM sqlist18_1_das.continents");
            dataGridView1.DataSource = DBManager.bindingSource;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;

            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView1.GridColor = Color.BlueViolet;

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Gainsboro;

            dataGridView1.Columns[0].HeaderText = "Айді континента";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "Назва континенту";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].Width = 150;



            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }
    }
}
