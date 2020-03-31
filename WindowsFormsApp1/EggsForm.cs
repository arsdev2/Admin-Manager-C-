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
    public partial class EggsForm : Form
    {
        public EggsForm()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            DBManager.bindingSource = new BindingSource();
            DBManager.bindingSource.DataSource = DBManager.performSql("SELECT egg_id, egg_name, date, bird_name, calories FROM eggs left join birds on birds.bird_id=eggs.bird_id");
            dataGridView1.DataSource = DBManager.bindingSource;
            bindingNavigator1.BindingSource = DBManager.bindingSource;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;

            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView1.GridColor = Color.BlueViolet;

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Gainsboro;

            dataGridView1.Columns[0].HeaderText = "Айді яйця";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[0].Width = 50;

            dataGridView1.Columns[1].HeaderText = "Назва яйця";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Columns[2].HeaderText = "Дата створення";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].HeaderText = "Назва птахи";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].Width = 100;


            dataGridView1.Columns[4].HeaderText = "К-сть калорій";
            dataGridView1.Columns[4].Width = 125;




            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }
    }
}
