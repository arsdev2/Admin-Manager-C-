namespace WindowsFormsApp1
{
    partial class ContinentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContinentsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingSortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.заПолемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idSortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.nameSortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.searchLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.filterActionButton = new System.Windows.Forms.ToolStripButton();
            this.filterTitleLabel = new System.Windows.Forms.ToolStripLabel();
            this.filterColumnsDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.filterOperator = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.filterValueTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.filterEnterTextButton = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(861, 403);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортуванняToolStripMenuItem,
            this.заПолемToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сортуванняToolStripMenuItem
            // 
            this.сортуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingSortButton,
            this.descendingButton});
            this.сортуванняToolStripMenuItem.Name = "сортуванняToolStripMenuItem";
            this.сортуванняToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.сортуванняToolStripMenuItem.Text = "Сортування";
            // 
            // ascendingSortButton
            // 
            this.ascendingSortButton.CheckOnClick = true;
            this.ascendingSortButton.Name = "ascendingSortButton";
            this.ascendingSortButton.Size = new System.Drawing.Size(180, 22);
            this.ascendingSortButton.Text = "За зростанням";
            this.ascendingSortButton.Click += new System.EventHandler(this.aesClicked);
            // 
            // descendingButton
            // 
            this.descendingButton.CheckOnClick = true;
            this.descendingButton.Name = "descendingButton";
            this.descendingButton.Size = new System.Drawing.Size(180, 22);
            this.descendingButton.Text = "За спаданням";
            this.descendingButton.Click += new System.EventHandler(this.descClicked);
            // 
            // заПолемToolStripMenuItem
            // 
            this.заПолемToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idSortButton,
            this.nameSortButton});
            this.заПолемToolStripMenuItem.Name = "заПолемToolStripMenuItem";
            this.заПолемToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.заПолемToolStripMenuItem.Text = "За полем";
            // 
            // idSortButton
            // 
            this.idSortButton.CheckOnClick = true;
            this.idSortButton.Name = "idSortButton";
            this.idSortButton.Size = new System.Drawing.Size(106, 22);
            this.idSortButton.Text = "ID";
            this.idSortButton.Click += new System.EventHandler(this.onIdClick);
            // 
            // nameSortButton
            // 
            this.nameSortButton.CheckOnClick = true;
            this.nameSortButton.Name = "nameSortButton";
            this.nameSortButton.Size = new System.Drawing.Size(106, 22);
            this.nameSortButton.Text = "Назва";
            this.nameSortButton.Click += new System.EventHandler(this.nameSortButton_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.searchLabel,
            this.searchTextBox,
            this.filterActionButton,
            this.filterTitleLabel,
            this.filterColumnsDropDown,
            this.filterOperator,
            this.filterValueTextBox,
            this.filterEnterTextButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton4;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton3;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(914, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton1";
            this.toolStripButton5.Click += new System.EventHandler(this.searchClick);
            // 
            // searchLabel
            // 
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(52, 22);
            this.searchLabel.Text = "Пошук: ";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 25);
            this.searchTextBox.Leave += new System.EventHandler(this.OnSearchTextBoxLeave);
            this.searchTextBox.TextChanged += new System.EventHandler(this.OnSearchTextBoxChanged);
            // 
            // filterActionButton
            // 
            this.filterActionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filterActionButton.Image = ((System.Drawing.Image)(resources.GetObject("filterActionButton.Image")));
            this.filterActionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterActionButton.Name = "filterActionButton";
            this.filterActionButton.Size = new System.Drawing.Size(23, 22);
            this.filterActionButton.Text = "toolStripButton2";
            this.filterActionButton.Click += new System.EventHandler(this.filterActionButton_Click);
            // 
            // filterTitleLabel
            // 
            this.filterTitleLabel.Name = "filterTitleLabel";
            this.filterTitleLabel.Size = new System.Drawing.Size(86, 22);
            this.filterTitleLabel.Text = "Введіть фільтр";
            // 
            // filterColumnsDropDown
            // 
            this.filterColumnsDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filterColumnsDropDown.Image = ((System.Drawing.Image)(resources.GetObject("filterColumnsDropDown.Image")));
            this.filterColumnsDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterColumnsDropDown.Name = "filterColumnsDropDown";
            this.filterColumnsDropDown.Size = new System.Drawing.Size(102, 22);
            this.filterColumnsDropDown.Text = "Назва колонки";
            this.filterColumnsDropDown.ToolTipText = "Назва колонки";
            this.filterColumnsDropDown.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.onColumnToolstripSelected);
            // 
            // filterOperator
            // 
            this.filterOperator.AutoToolTip = false;
            this.filterOperator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filterOperator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.filterOperator.Image = ((System.Drawing.Image)(resources.GetObject("filterOperator.Image")));
            this.filterOperator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterOperator.Name = "filterOperator";
            this.filterOperator.Size = new System.Drawing.Size(98, 22);
            this.filterOperator.Text = "Логічний знак";
            this.filterOperator.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.onFilterOperatorItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem2.Text = "=";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem3.Text = ">";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem4.Text = "<";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem5.Text = ">=";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem6.Text = "<=";
            // 
            // filterValueTextBox
            // 
            this.filterValueTextBox.Name = "filterValueTextBox";
            this.filterValueTextBox.Size = new System.Drawing.Size(100, 25);
            this.filterValueTextBox.Visible = false;
            this.filterValueTextBox.Leave += new System.EventHandler(this.onFilterValueLeave);
            // 
            // filterEnterTextButton
            // 
            this.filterEnterTextButton.Name = "filterEnterTextButton";
            this.filterEnterTextButton.Size = new System.Drawing.Size(34, 22);
            this.filterEnterTextButton.Text = "Enter";
            this.filterEnterTextButton.Click += new System.EventHandler(this.filterEnterTextButton_Click);
            // 
            // ContinentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 457);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ContinentsForm";
            this.Text = "ContinentsForm";
            this.Load += new System.EventHandler(this.onLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingSortButton;
        private System.Windows.Forms.ToolStripMenuItem descendingButton;
        private System.Windows.Forms.ToolStripMenuItem заПолемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idSortButton;
        private System.Windows.Forms.ToolStripMenuItem nameSortButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel searchLabel;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
        private System.Windows.Forms.ToolStripButton filterActionButton;
        private System.Windows.Forms.ToolStripLabel filterTitleLabel;
        private System.Windows.Forms.ToolStripDropDownButton filterColumnsDropDown;
        private System.Windows.Forms.ToolStripDropDownButton filterOperator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripTextBox filterValueTextBox;
        private System.Windows.Forms.ToolStripLabel filterEnterTextButton;
    }
}