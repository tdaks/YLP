namespace 서버_개발
{
    partial class DBM_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lv_Cateferia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_create = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pk = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tb_cafeteriaPK = new System.Windows.Forms.TextBox();
            this.btn_cafeteriaAllMenu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 441);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lv_Cateferia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "식당 목록";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lv_Cateferia
            // 
            this.lv_Cateferia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_Cateferia.Location = new System.Drawing.Point(0, 0);
            this.lv_Cateferia.Name = "lv_Cateferia";
            this.lv_Cateferia.Size = new System.Drawing.Size(428, 401);
            this.lv_Cateferia.TabIndex = 0;
            this.lv_Cateferia.UseCompatibleStateImageBehavior = false;
            this.lv_Cateferia.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Primary Key";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "전화번호";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "주소";
            this.columnHeader4.Width = 135;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "식당 추가";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_create);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_address);
            this.panel1.Controls.Add(this.tb_number);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.tb_pk);
            this.panel1.Location = new System.Drawing.Point(8, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 131);
            this.panel1.TabIndex = 2;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(221, 15);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(53, 101);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "생성";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "전화번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primary Key";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(89, 96);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(119, 21);
            this.tb_address.TabIndex = 3;
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(89, 69);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(119, 21);
            this.tb_number.TabIndex = 2;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(89, 42);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(119, 21);
            this.tb_name.TabIndex = 1;
            // 
            // tb_pk
            // 
            this.tb_pk.Location = new System.Drawing.Point(89, 15);
            this.tb_pk.Name = "tb_pk";
            this.tb_pk.Size = new System.Drawing.Size(119, 21);
            this.tb_pk.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "식당 제거";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_cafeteriaAllMenu);
            this.tabPage4.Controls.Add(this.tb_cafeteriaPK);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(646, 415);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "식당 메뉴판";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tb_cafeteriaPK
            // 
            this.tb_cafeteriaPK.Location = new System.Drawing.Point(8, 6);
            this.tb_cafeteriaPK.Name = "tb_cafeteriaPK";
            this.tb_cafeteriaPK.Size = new System.Drawing.Size(100, 21);
            this.tb_cafeteriaPK.TabIndex = 0;
            // 
            // btn_cafeteriaAllMenu
            // 
            this.btn_cafeteriaAllMenu.Location = new System.Drawing.Point(114, 6);
            this.btn_cafeteriaAllMenu.Name = "btn_cafeteriaAllMenu";
            this.btn_cafeteriaAllMenu.Size = new System.Drawing.Size(75, 23);
            this.btn_cafeteriaAllMenu.TabIndex = 1;
            this.btn_cafeteriaAllMenu.Text = "button1";
            this.btn_cafeteriaAllMenu.UseVisualStyleBackColor = true;
            this.btn_cafeteriaAllMenu.Click += new System.EventHandler(this.btn_cafeteriaAllMenu_Click);
            // 
            // DBM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 466);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DBM_Main";
            this.Text = "DBM_Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lv_Cateferia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_pk;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_cafeteriaAllMenu;
        private System.Windows.Forms.TextBox tb_cafeteriaPK;
    }
}