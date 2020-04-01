namespace WindowsFormsApp1
{
    partial class BirdsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirdsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingSortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.заПолемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idSortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.nameSortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.continentNameSort = new System.Windows.Forms.ToolStripMenuItem();
            this.IntelijenceSortButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1,
            this.searchLabel,
            this.searchTextBox,
            this.filterActionButton,
            this.filterTitleLabel,
            this.filterColumnsDropDown,
            this.filterOperator,
            this.filterValueTextBox,
            this.filterEnterTextButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(892, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.searchClick);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортуванняToolStripMenuItem,
            this.заПолемToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 4;
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
            this.nameSortButton,
            this.continentNameSort,
            this.IntelijenceSortButton});
            this.заПолемToolStripMenuItem.Name = "заПолемToolStripMenuItem";
            this.заПолемToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.заПолемToolStripMenuItem.Text = "За полем";
            // 
            // idSortButton
            // 
            this.idSortButton.CheckOnClick = true;
            this.idSortButton.Name = "idSortButton";
            this.idSortButton.Size = new System.Drawing.Size(180, 22);
            this.idSortButton.Text = "ID";
            this.idSortButton.Click += new System.EventHandler(this.onIdClick);
            // 
            // nameSortButton
            // 
            this.nameSortButton.CheckOnClick = true;
            this.nameSortButton.Name = "nameSortButton";
            this.nameSortButton.Size = new System.Drawing.Size(180, 22);
            this.nameSortButton.Text = "Назва";
            this.nameSortButton.Click += new System.EventHandler(this.nameSortPerform);
            // 
            // continentNameSort
            // 
            this.continentNameSort.CheckOnClick = true;
            this.continentNameSort.Name = "continentNameSort";
            this.continentNameSort.Size = new System.Drawing.Size(180, 22);
            this.continentNameSort.Text = "Назва континенту";
            this.continentNameSort.Click += new System.EventHandler(this.continentNameSortPerform);
            // 
            // IntelijenceSortButton
            // 
            this.IntelijenceSortButton.CheckOnClick = true;
            this.IntelijenceSortButton.Name = "IntelijenceSortButton";
            this.IntelijenceSortButton.Size = new System.Drawing.Size(180, 22);
            this.IntelijenceSortButton.Text = "Інтелект";
            this.IntelijenceSortButton.Click += new System.EventHandler(this.intelijenceSortPerform);
            // 
            // BirdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 323);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BirdsForm";
            this.Text = "BirdsForm";
            this.Load += new System.EventHandler(this.loaded);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingSortButton;
        private System.Windows.Forms.ToolStripMenuItem descendingButton;
        private System.Windows.Forms.ToolStripMenuItem заПолемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idSortButton;
        private System.Windows.Forms.ToolStripMenuItem nameSortButton;
        private System.Windows.Forms.ToolStripMenuItem continentNameSort;
        private System.Windows.Forms.ToolStripMenuItem IntelijenceSortButton;
    }
}