namespace CK_QLKS
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox6 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox4 = new GroupBox();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            btnLogout = new Button();
            btnClossingAccount = new Button();
            groupBox2 = new GroupBox();
            btnReturn = new Button();
            btnReport = new Button();
            btnQuanLyPhong = new Button();
            groupBox1 = new GroupBox();
            btnKhangHang = new Button();
            btnOnlineOrder = new Button();
            btnPhong = new Button();
            pnlContainer = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(groupBox6);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 79);
            panel1.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(250, 0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(346, 79);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "groupBox6";
            // 
            // groupBox5
            // 
            groupBox5.Dock = DockStyle.Right;
            groupBox5.Location = new Point(596, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(345, 79);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.InactiveCaption;
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 79);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 414);
            panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLogout);
            groupBox3.Controls.Add(btnClossingAccount);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 284);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 105);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "CLOSE";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 63);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(217, 31);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnClossingAccount
            // 
            btnClossingAccount.Location = new Point(12, 26);
            btnClossingAccount.Name = "btnClossingAccount";
            btnClossingAccount.Size = new Size(217, 31);
            btnClossingAccount.TabIndex = 3;
            btnClossingAccount.Text = "CLOSSING ACCOUNT";
            btnClossingAccount.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnReturn);
            groupBox2.Controls.Add(btnReport);
            groupBox2.Controls.Add(btnQuanLyPhong);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 140);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "MANAGER";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(12, 100);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(217, 31);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "RETURN";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(12, 63);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(217, 31);
            btnReport.TabIndex = 2;
            btnReport.Text = "REPORT";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyPhong
            // 
            btnQuanLyPhong.Location = new Point(12, 26);
            btnQuanLyPhong.Name = "btnQuanLyPhong";
            btnQuanLyPhong.Size = new Size(217, 31);
            btnQuanLyPhong.TabIndex = 1;
            btnQuanLyPhong.Text = "QUẢN LÝ PHÒNG";
            btnQuanLyPhong.UseVisualStyleBackColor = true;
            btnQuanLyPhong.Click += FrmMain_Load;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKhangHang);
            groupBox1.Controls.Add(btnOnlineOrder);
            groupBox1.Controls.Add(btnPhong);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "OPEN";
            // 
            // btnKhangHang
            // 
            btnKhangHang.Location = new Point(12, 100);
            btnKhangHang.Name = "btnKhangHang";
            btnKhangHang.Size = new Size(217, 31);
            btnKhangHang.TabIndex = 2;
            btnKhangHang.Text = "KHÁCH HÀNG";
            btnKhangHang.UseVisualStyleBackColor = true;
            // 
            // btnOnlineOrder
            // 
            btnOnlineOrder.Location = new Point(12, 63);
            btnOnlineOrder.Name = "btnOnlineOrder";
            btnOnlineOrder.Size = new Size(217, 31);
            btnOnlineOrder.TabIndex = 1;
            btnOnlineOrder.Text = "ONLINE ORDER";
            btnOnlineOrder.UseVisualStyleBackColor = true;
            // 
            // btnPhong
            // 
            btnPhong.Location = new Point(12, 26);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(217, 31);
            btnPhong.TabIndex = 0;
            btnPhong.Text = "ORDER PHÒNG";
            btnPhong.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(250, 79);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(691, 414);
            pnlContainer.TabIndex = 3;
            pnlContainer.Visible = false;
            pnlContainer.Click += pnGiaoDienChinh_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 493);
            Controls.Add(pnlContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm Quản lý Khách sạn";
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnPhong;
        private Panel panel3;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Panel pnlContainer;
        private Button btnLogout;
        private Button btnClossingAccount;
        private Button btnReturn;
        private Button btnReport;
        private Button btnQuanLyPhong;
        private Button button3;
        private Button btnOnlineOrder;
        private Button btnKhangHang;
    }
}
