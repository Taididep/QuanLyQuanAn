namespace QUANLYQUANAN
{
    partial class Main
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsv_bill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_totalPrice = new System.Windows.Forms.TextBox();
            this.cb_table = new System.Windows.Forms.ComboBox();
            this.btn_switchtable = new System.Windows.Forms.Button();
            this.nm_discount = new System.Windows.Forms.NumericUpDown();
            this.btn_discount = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.cb_food = new System.Windows.Forms.ComboBox();
            this.btn_addfood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nm_food = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adimnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flp_table = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_discount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_food)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsv_bill);
            this.panel2.Location = new System.Drawing.Point(730, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 398);
            this.panel2.TabIndex = 2;
            // 
            // lsv_bill
            // 
            this.lsv_bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsv_bill.GridLines = true;
            this.lsv_bill.HideSelection = false;
            this.lsv_bill.Location = new System.Drawing.Point(6, 3);
            this.lsv_bill.Name = "lsv_bill";
            this.lsv_bill.Size = new System.Drawing.Size(542, 385);
            this.lsv_bill.TabIndex = 0;
            this.lsv_bill.UseCompatibleStateImageBehavior = false;
            this.lsv_bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 168;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 147;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txb_totalPrice);
            this.panel3.Controls.Add(this.cb_table);
            this.panel3.Controls.Add(this.btn_switchtable);
            this.panel3.Controls.Add(this.nm_discount);
            this.panel3.Controls.Add(this.btn_discount);
            this.panel3.Controls.Add(this.btn_checkout);
            this.panel3.Location = new System.Drawing.Point(730, 610);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 104);
            this.panel3.TabIndex = 3;
            // 
            // txb_totalPrice
            // 
            this.txb_totalPrice.Location = new System.Drawing.Point(400, 61);
            this.txb_totalPrice.Name = "txb_totalPrice";
            this.txb_totalPrice.Size = new System.Drawing.Size(136, 20);
            this.txb_totalPrice.TabIndex = 7;
            // 
            // cb_table
            // 
            this.cb_table.FormattingEnabled = true;
            this.cb_table.Location = new System.Drawing.Point(24, 60);
            this.cb_table.Name = "cb_table";
            this.cb_table.Size = new System.Drawing.Size(153, 21);
            this.cb_table.TabIndex = 6;
            // 
            // btn_switchtable
            // 
            this.btn_switchtable.Location = new System.Drawing.Point(24, 17);
            this.btn_switchtable.Name = "btn_switchtable";
            this.btn_switchtable.Size = new System.Drawing.Size(154, 37);
            this.btn_switchtable.TabIndex = 5;
            this.btn_switchtable.Text = "Chuyển Bàn";
            this.btn_switchtable.UseVisualStyleBackColor = true;
            this.btn_switchtable.Click += new System.EventHandler(this.btn_switchtable_Click);
            // 
            // nm_discount
            // 
            this.nm_discount.Location = new System.Drawing.Point(211, 60);
            this.nm_discount.Name = "nm_discount";
            this.nm_discount.Size = new System.Drawing.Size(154, 20);
            this.nm_discount.TabIndex = 4;
            this.nm_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_discount
            // 
            this.btn_discount.Location = new System.Drawing.Point(211, 17);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(154, 37);
            this.btn_discount.TabIndex = 1;
            this.btn_discount.Text = "Giảm Giá";
            this.btn_discount.UseVisualStyleBackColor = true;
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(400, 17);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(136, 37);
            this.btn_checkout.TabIndex = 0;
            this.btn_checkout.Text = "Thanh Toán";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(5, 13);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(374, 21);
            this.cb_category.TabIndex = 0;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cb_food
            // 
            this.cb_food.FormattingEnabled = true;
            this.cb_food.Location = new System.Drawing.Point(5, 61);
            this.cb_food.Name = "cb_food";
            this.cb_food.Size = new System.Drawing.Size(374, 21);
            this.cb_food.TabIndex = 1;
            // 
            // btn_addfood
            // 
            this.btn_addfood.Location = new System.Drawing.Point(399, 13);
            this.btn_addfood.Name = "btn_addfood";
            this.btn_addfood.Size = new System.Drawing.Size(90, 69);
            this.btn_addfood.TabIndex = 2;
            this.btn_addfood.Text = "Thêm món";
            this.btn_addfood.UseVisualStyleBackColor = true;
            this.btn_addfood.Click += new System.EventHandler(this.btn_addfood_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nm_food);
            this.panel4.Controls.Add(this.cb_category);
            this.panel4.Controls.Add(this.btn_addfood);
            this.panel4.Controls.Add(this.cb_food);
            this.panel4.Location = new System.Drawing.Point(731, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(551, 85);
            this.panel4.TabIndex = 4;
            // 
            // nm_food
            // 
            this.nm_food.Location = new System.Drawing.Point(495, 49);
            this.nm_food.Name = "nm_food";
            this.nm_food.Size = new System.Drawing.Size(40, 20);
            this.nm_food.TabIndex = 3;
            this.nm_food.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Text = "Admin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adimnToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adimnToolStripMenuItem
            // 
            this.adimnToolStripMenuItem.Name = "adimnToolStripMenuItem";
            this.adimnToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.adimnToolStripMenuItem.Text = "Admin";
            this.adimnToolStripMenuItem.Click += new System.EventHandler(this.adimnToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(160, 23);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông Tin Cá Nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // flp_table
            // 
            this.flp_table.Location = new System.Drawing.Point(12, 66);
            this.flp_table.Name = "flp_table";
            this.flp_table.Size = new System.Drawing.Size(680, 523);
            this.flp_table.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 727);
            this.Controls.Add(this.flp_table);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_discount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nm_food)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_food;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.ComboBox cb_table;
        private System.Windows.Forms.Button btn_switchtable;
        private System.Windows.Forms.NumericUpDown nm_discount;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_addfood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nm_food;
        private System.Windows.Forms.ListView lsv_bill;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adimnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flp_table;
        private System.Windows.Forms.TextBox txb_totalPrice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}