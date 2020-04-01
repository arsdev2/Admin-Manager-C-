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
    public partial class BirdsForm : Form
    {

        private ListSortDirection sortType = ListSortDirection.Ascending;

        private string filterColumnNameTitle
        {
            get
            {
                return "Назва колонки";
            }
        }
        private string filterOperatorTitle
        {
            get
            {
                return "Логічний знак";
            }
        }

        private string filterOperatorUsed;
        private string filterColumnName;

        public BirdsForm()
        {
            InitializeComponent();
            hideSearchElements();
            hideFilterElements();
        }

        private void loaded(object sender, EventArgs e)
        {
            DBManager.bindingSource = new BindingSource();
            DBManager.bindingSource.DataSource = DBManager.performSql("SELECT bird_id, bird_name, continent_name, intelijence FROM birds left join continents on continents.continent_id=birds.continent_id");
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

            dataGridView1.Columns[0].HeaderText = "Айді птахи";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 50;

            dataGridView1.Columns[1].HeaderText = "Назва птахи";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Назва континенту";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "IQ";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].Width = 50;



            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                ToolStripMenuItem toolStripButton = new ToolStripMenuItem();
                toolStripButton.Text = column.Name;

                filterColumnsDropDown.DropDownItems.Add(toolStripButton);
            }

        }
        private void resetFilter()
        {
            filterColumnsDropDown.Text = filterColumnNameTitle;
            filterOperator.Text = filterOperatorTitle;

            filterOperatorUsed = filterOperatorTitle;
            filterColumnName = filterColumnNameTitle;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                showSearchElements();
                return true;
            }
            else if (keyData == Keys.Enter)
            {
                if (filterValueTextBox.Focused)
                {
                    performFilter();
                    hideFilterElements();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        

        private void sortByColumnName(string columnName)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name.Equals(columnName))
                {
                    dataGridView1.Sort(column, sortType);
                    break;
                }
            }
        }

        private void aesClicked(object sender, EventArgs e)
        {
            sortType = ListSortDirection.Ascending;
            ascendingSortButton.Checked = true;
            descendingButton.Checked = false;
        }

        private void descClicked(object sender, EventArgs e)
        {
            sortType = ListSortDirection.Descending;
            ascendingSortButton.Checked = false;
            descendingButton.Checked = true;
        }

        private void onIdClick(object sender, EventArgs e)
        {
            idSortButton.Checked = true;
            nameSortButton.Checked = false;
            continentNameSort.Checked = false;
            IntelijenceSortButton.Checked = false;
            sortByColumnName("bird_id");
        }

        private void nameSortPerform(object sender, EventArgs e)
        {
            idSortButton.Checked = false;
            nameSortButton.Checked = true;
            continentNameSort.Checked = false;
            IntelijenceSortButton.Checked = false;
            sortByColumnName("bird_name");
        }

        private void continentNameSortPerform(object sender, EventArgs e)
        {
            idSortButton.Checked = false;
            nameSortButton.Checked = false;
            continentNameSort.Checked = true;
            IntelijenceSortButton.Checked = false;
            sortByColumnName("continent_name");
        }

        private void intelijenceSortPerform(object sender, EventArgs e)
        {
            idSortButton.Checked = false;
            nameSortButton.Checked = false;
            continentNameSort.Checked = false;
            IntelijenceSortButton.Checked = true;
            sortByColumnName("intelijence");
        }

        private void searchClick(object sender, EventArgs e)
        {
            hideFilterElements();
            showSearchElements();
        }

        private void showSearchElements()
        {
            searchLabel.Visible = true;
            searchTextBox.Visible = true;
            searchTextBox.Text = "";
            searchTextBox.Focus();
            disableAllRows();
        }

        private void disableAllRows()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.Selected = false;
            }
        }

        private void hideSearchElements()
        {
            searchTextBox.Visible = false;
            searchLabel.Visible = false;
            searchTextBox.Text = "";
            disableAllRows();
        }

        private void OnSearchTextBoxLeave(object sender, EventArgs e)
        {
            hideSearchElements();
        }

        private void OnSearchTextBoxChanged(object sender, EventArgs e)
        {
            string textToSearch = searchTextBox.Text;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.Selected = false;
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    DataGridViewCell cell = row.Cells[j];
                    object valueObj = cell.Value;
                    if (valueObj != null)
                    {
                        string value = valueObj.ToString();
                        if (value.Contains(textToSearch))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void filterActionButton_Click(object sender, EventArgs e)
        {
            hideSearchElements();
            showFilterElements();

        }

        private void showFilterElements()
        {
            filterOperator.Visible = true;
            filterTitleLabel.Visible = true;
            filterColumnsDropDown.Visible = true;
            filterValueTextBox.Visible = true;
            filterValueTextBox.Focus();
            filterEnterTextButton.Visible = true;
        }

        private void hideFilterElements()
        {
            filterOperator.Visible = false;
            filterTitleLabel.Visible = false;
            filterColumnsDropDown.Visible = false;
            filterValueTextBox.Visible = false;
            filterEnterTextButton.Visible = false;
            resetFilter();
        }

        private void onColumnToolstripSelected(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem != null)
            {
                filterColumnsDropDown.Text = e.ClickedItem.Text;
                filterColumnName = e.ClickedItem.Text;
            }
        }

        private void onFilterOperatorItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem != null)
            {
                filterOperator.Text = e.ClickedItem.Text;
                filterOperatorUsed = e.ClickedItem.Text;
            }
        }
        private void performFilter()
        {
            if (filterColumnName.Equals(filterColumnNameTitle) ||
                filterOperatorUsed.Equals(filterOperatorTitle))
            {
                return;
            }
            string filterValue = filterValueTextBox.Text;

            int tmpVal = 0;
            bool isNum = int.TryParse(filterValue, out _)
                            || long.TryParse(filterValue, out _)
                            || double.TryParse(filterValue, out _)
                            || float.TryParse(filterValue, out _);
            bool isStr = !isNum;


            try
            {
                string val = (isNum ? "" : "'");
                string filterStr = $"{filterColumnName} {filterOperatorUsed} {val}{filterValue}{val}";
                Console.WriteLine(filterStr);
                DBManager.bindingSource.Filter = filterStr;
            }
            catch (Exception e)
            {
                MessageBox.Show("Неправильно вибрані фільтри");
            }
        }

        private void filterEnterTextButton_Click(object sender, EventArgs e)
        {
            performFilter();
            hideFilterElements();
        }

        private void onFilterValueLeave(object sender, EventArgs e)
        {
            performFilter();
            hideFilterElements();
        }
    }
}
