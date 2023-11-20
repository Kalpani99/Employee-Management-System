namespace Employee_Management_System
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.great_user = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logout_btn = new Guna.UI.WinForms.GunaButton();
            this.salary_btn = new Guna.UI.WinForms.GunaButton();
            this.addEmployee_btn = new Guna.UI.WinForms.GunaButton();
            this.dashboard_btn = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboard1 = new Employee_Management_System.Dashboard();
            this.addEmployee1 = new Employee_Management_System.AddEmployee();
            this.salary1 = new Employee_Management_System.Salary();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Management System";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1077, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 21);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.salary_btn);
            this.panel2.Controls.Add(this.addEmployee_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.great_user);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 600);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sign Out";
            // 
            // great_user
            // 
            this.great_user.AutoSize = true;
            this.great_user.Font = new System.Drawing.Font("Tahoma", 10F);
            this.great_user.ForeColor = System.Drawing.Color.White;
            this.great_user.Location = new System.Drawing.Point(47, 184);
            this.great_user.Name = "great_user";
            this.great_user.Size = new System.Drawing.Size(122, 21);
            this.great_user.TabIndex = 1;
            this.great_user.Text = "Welcome, User";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(225, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 562);
            this.panel3.TabIndex = 2;
            // 
            // logout_btn
            // 
            this.logout_btn.AnimationHoverSpeed = 0.07F;
            this.logout_btn.AnimationSpeed = 0.03F;
            this.logout_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.logout_btn.BorderColor = System.Drawing.Color.Black;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logout_btn.FocusedColor = System.Drawing.Color.Empty;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::Employee_Management_System.Properties.Resources.logout;
            this.logout_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logout_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.logout_btn.Location = new System.Drawing.Point(22, 554);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.logout_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.logout_btn.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.logout_btn.OnHoverImage = null;
            this.logout_btn.OnPressedColor = System.Drawing.Color.Transparent;
            this.logout_btn.Size = new System.Drawing.Size(35, 35);
            this.logout_btn.TabIndex = 7;
            this.logout_btn.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // salary_btn
            // 
            this.salary_btn.AnimationHoverSpeed = 0.07F;
            this.salary_btn.AnimationSpeed = 0.03F;
            this.salary_btn.BackColor = System.Drawing.Color.Transparent;
            this.salary_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.salary_btn.BorderColor = System.Drawing.Color.White;
            this.salary_btn.BorderSize = 1;
            this.salary_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.salary_btn.FocusedColor = System.Drawing.Color.Empty;
            this.salary_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_btn.ForeColor = System.Drawing.Color.White;
            this.salary_btn.Image = global::Employee_Management_System.Properties.Resources.salary;
            this.salary_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salary_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.salary_btn.Location = new System.Drawing.Point(12, 370);
            this.salary_btn.Name = "salary_btn";
            this.salary_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.salary_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.salary_btn.OnHoverImage = null;
            this.salary_btn.OnPressedColor = System.Drawing.Color.Black;
            this.salary_btn.Radius = 10;
            this.salary_btn.Size = new System.Drawing.Size(200, 42);
            this.salary_btn.TabIndex = 6;
            this.salary_btn.Text = "SALARY";
            this.salary_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salary_btn.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // addEmployee_btn
            // 
            this.addEmployee_btn.AnimationHoverSpeed = 0.07F;
            this.addEmployee_btn.AnimationSpeed = 0.03F;
            this.addEmployee_btn.BackColor = System.Drawing.Color.Transparent;
            this.addEmployee_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_btn.BorderColor = System.Drawing.Color.White;
            this.addEmployee_btn.BorderSize = 1;
            this.addEmployee_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addEmployee_btn.FocusedColor = System.Drawing.Color.Empty;
            this.addEmployee_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.addEmployee_btn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_btn.Image = global::Employee_Management_System.Properties.Resources.addemployee;
            this.addEmployee_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addEmployee_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.addEmployee_btn.Location = new System.Drawing.Point(12, 308);
            this.addEmployee_btn.Name = "addEmployee_btn";
            this.addEmployee_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addEmployee_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.addEmployee_btn.OnHoverImage = null;
            this.addEmployee_btn.OnPressedColor = System.Drawing.Color.Black;
            this.addEmployee_btn.Radius = 10;
            this.addEmployee_btn.Size = new System.Drawing.Size(200, 42);
            this.addEmployee_btn.TabIndex = 5;
            this.addEmployee_btn.Text = "ADD EMPLOYEE";
            this.addEmployee_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addEmployee_btn.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.AnimationHoverSpeed = 0.07F;
            this.dashboard_btn.AnimationSpeed = 0.03F;
            this.dashboard_btn.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.dashboard_btn.BorderColor = System.Drawing.Color.White;
            this.dashboard_btn.BorderSize = 1;
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dashboard_btn.FocusedColor = System.Drawing.Color.Empty;
            this.dashboard_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::Employee_Management_System.Properties.Resources.dashboard;
            this.dashboard_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dashboard_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.dashboard_btn.Location = new System.Drawing.Point(12, 243);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboard_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dashboard_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.dashboard_btn.OnHoverImage = null;
            this.dashboard_btn.OnPressedColor = System.Drawing.Color.Black;
            this.dashboard_btn.Radius = 10;
            this.dashboard_btn.Size = new System.Drawing.Size(200, 42);
            this.dashboard_btn.TabIndex = 4;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dashboard_btn.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Employee_Management_System.Properties.Resources.Employee;
            this.pictureBox1.Location = new System.Drawing.Point(60, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(225, 34);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(875, 565);
            this.dashboard1.TabIndex = 4;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(225, 34);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(875, 565);
            this.addEmployee1.TabIndex = 3;
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(225, 34);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(875, 565);
            this.salary1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.addEmployee1);
            this.Controls.Add(this.salary1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label great_user;
        private Guna.UI.WinForms.GunaButton dashboard_btn;
        private Guna.UI.WinForms.GunaButton addEmployee_btn;
        private Guna.UI.WinForms.GunaButton salary_btn;
        private Guna.UI.WinForms.GunaButton logout_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Salary salary1;
        private AddEmployee addEmployee1;
        private Dashboard dashboard1;
    }
}