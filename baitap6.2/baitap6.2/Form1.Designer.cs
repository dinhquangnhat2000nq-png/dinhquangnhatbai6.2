namespace baitap6._2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage employeesTab;
        private TabPage attendanceTab;
        private TextBox txtSearch;
        private ComboBox cmbSearchDepartment;
        private Button btnSearch;
        private DataGridView dgvEmployees;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtCCCD;
        private ComboBox cmbPhongBan;
        private NumericUpDown numLuongCoBan;
        private NumericUpDown numHeSoLuong;
        private Button btnNew;
        private Button btnSaveEmployee;
        private Button btnDeleteEmployee;
        private DateTimePicker dtpThangNam;
        private Button btnLoadAttendance;
        private Button btnSaveAttendance;
        private Button btnClosePayroll;
        private DataGridView dgvAttendance;
        private Label lblEmployeeId;
        private Label lblHoTen;
        private Label lblNgaySinh;
        private Label lblCCCD;
        private Label lblPhongBan;
        private Label lblLuongCoBan;
        private Label lblHeSoLuong;

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
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            employeesTab = new TabPage();
            attendanceTab = new TabPage();
            txtSearch = new TextBox();
            cmbSearchDepartment = new ComboBox();
            btnSearch = new Button();
            dgvEmployees = new DataGridView();
            txtHoTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            txtCCCD = new TextBox();
            cmbPhongBan = new ComboBox();
            numLuongCoBan = new NumericUpDown();
            numHeSoLuong = new NumericUpDown();
            btnNew = new Button();
            btnSaveEmployee = new Button();
            btnDeleteEmployee = new Button();
            dtpThangNam = new DateTimePicker();
            btnLoadAttendance = new Button();
            btnSaveAttendance = new Button();
            btnClosePayroll = new Button();
            dgvAttendance = new DataGridView();
            lblEmployeeId = new Label();
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lblCCCD = new Label();
            lblPhongBan = new Label();
            lblLuongCoBan = new Label();
            lblHeSoLuong = new Label();
            tabControl.SuspendLayout();
            employeesTab.SuspendLayout();
            attendanceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLuongCoBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();

            tabControl.Controls.Add(employeesTab);
            tabControl.Controls.Add(attendanceTab);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1084, 661);
            tabControl.TabIndex = 0;

            employeesTab.Controls.Add(dgvEmployees);
            employeesTab.Controls.Add(btnDeleteEmployee);
            employeesTab.Controls.Add(btnSaveEmployee);
            employeesTab.Controls.Add(btnNew);
            employeesTab.Controls.Add(numHeSoLuong);
            employeesTab.Controls.Add(numLuongCoBan);
            employeesTab.Controls.Add(cmbPhongBan);
            employeesTab.Controls.Add(txtCCCD);
            employeesTab.Controls.Add(dtpNgaySinh);
            employeesTab.Controls.Add(txtHoTen);
            employeesTab.Controls.Add(lblEmployeeId);
            employeesTab.Controls.Add(lblHoTen);
            employeesTab.Controls.Add(lblNgaySinh);
            employeesTab.Controls.Add(lblCCCD);
            employeesTab.Controls.Add(lblPhongBan);
            employeesTab.Controls.Add(lblLuongCoBan);
            employeesTab.Controls.Add(lblHeSoLuong);
            employeesTab.Controls.Add(btnSearch);
            employeesTab.Controls.Add(cmbSearchDepartment);
            employeesTab.Controls.Add(txtSearch);
            employeesTab.Location = new Point(4, 24);
            employeesTab.Name = "employeesTab";
            employeesTab.Padding = new Padding(12);
            employeesTab.Size = new Size(1076, 633);
            employeesTab.TabIndex = 0;
            employeesTab.Text = "Nhân viên";
            employeesTab.UseVisualStyleBackColor = true;

            txtSearch.Location = new Point(16, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo tên hoặc CCCD";
            txtSearch.Size = new Size(270, 23);
            txtSearch.TabIndex = 0;

            cmbSearchDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchDepartment.Location = new Point(296, 16);
            cmbSearchDepartment.Name = "cmbSearchDepartment";
            cmbSearchDepartment.Size = new Size(220, 23);
            cmbSearchDepartment.TabIndex = 1;

            btnSearch.Location = new Point(526, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 26);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;

            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Location = new Point(16, 56);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(81, 15);
            lblEmployeeId.TabIndex = 3;
            lblEmployeeId.Text = "Mã NV: (mới)";

            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(16, 76);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(57, 15);
            lblHoTen.TabIndex = 14;
            lblHoTen.Text = "Họ và tên";

            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(226, 76);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(57, 15);
            lblNgaySinh.TabIndex = 15;
            lblNgaySinh.Text = "Ngày sinh";

            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(366, 76);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(36, 15);
            lblCCCD.TabIndex = 16;
            lblCCCD.Text = "CCCD";

            lblPhongBan.AutoSize = true;
            lblPhongBan.Location = new Point(536, 76);
            lblPhongBan.Name = "lblPhongBan";
            lblPhongBan.Size = new Size(61, 15);
            lblPhongBan.TabIndex = 17;
            lblPhongBan.Text = "Phòng ban";

            lblLuongCoBan.AutoSize = true;
            lblLuongCoBan.Location = new Point(726, 76);
            lblLuongCoBan.Name = "lblLuongCoBan";
            lblLuongCoBan.Size = new Size(74, 15);
            lblLuongCoBan.TabIndex = 18;
            lblLuongCoBan.Text = "Lương cơ bản";

            lblHeSoLuong.AutoSize = true;
            lblHeSoLuong.Location = new Point(886, 76);
            lblHeSoLuong.Name = "lblHeSoLuong";
            lblHeSoLuong.Size = new Size(69, 15);
            lblHeSoLuong.TabIndex = 19;
            lblHeSoLuong.Text = "Hệ số lương";

            txtHoTen.Location = new Point(16, 96);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "Họ và tên";
            txtHoTen.Size = new Size(200, 23);
            txtHoTen.TabIndex = 4;

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Location = new Point(226, 96);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(130, 23);
            dtpNgaySinh.TabIndex = 5;

            txtCCCD.Location = new Point(366, 96);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.PlaceholderText = "CCCD";
            txtCCCD.Size = new Size(160, 23);
            txtCCCD.TabIndex = 6;

            cmbPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPhongBan.Location = new Point(536, 96);
            cmbPhongBan.Name = "cmbPhongBan";
            cmbPhongBan.Size = new Size(180, 23);
            cmbPhongBan.TabIndex = 7;

            numLuongCoBan.DecimalPlaces = 2;
            numLuongCoBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numLuongCoBan.Location = new Point(726, 96);
            numLuongCoBan.Name = "numLuongCoBan";
            numLuongCoBan.Size = new Size(150, 23);
            numLuongCoBan.TabIndex = 8;
            numLuongCoBan.ThousandsSeparator = true;

            numHeSoLuong.DecimalPlaces = 2;
            numHeSoLuong.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            numHeSoLuong.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numHeSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numHeSoLuong.Location = new Point(886, 96);
            numHeSoLuong.Name = "numHeSoLuong";
            numHeSoLuong.Size = new Size(120, 23);
            numHeSoLuong.TabIndex = 9;
            numHeSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });

            btnNew.Location = new Point(16, 138);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(100, 30);
            btnNew.TabIndex = 10;
            btnNew.Text = "Làm mới";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;

            btnSaveEmployee.Location = new Point(126, 138);
            btnSaveEmployee.Name = "btnSaveEmployee";
            btnSaveEmployee.Size = new Size(120, 30);
            btnSaveEmployee.TabIndex = 11;
            btnSaveEmployee.Text = "Lưu nhân viên";
            btnSaveEmployee.UseVisualStyleBackColor = true;
            btnSaveEmployee.Click += btnSaveEmployee_Click;

            btnDeleteEmployee.Location = new Point(256, 138);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(100, 30);
            btnDeleteEmployee.TabIndex = 12;
            btnDeleteEmployee.Text = "Xóa";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;

            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.Location = new Point(16, 184);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1044, 430);
            dgvEmployees.TabIndex = 13;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;

            attendanceTab.Controls.Add(dgvAttendance);
            attendanceTab.Controls.Add(btnClosePayroll);
            attendanceTab.Controls.Add(btnSaveAttendance);
            attendanceTab.Controls.Add(btnLoadAttendance);
            attendanceTab.Controls.Add(dtpThangNam);
            attendanceTab.Location = new Point(4, 24);
            attendanceTab.Name = "attendanceTab";
            attendanceTab.Padding = new Padding(12);
            attendanceTab.Size = new Size(1076, 633);
            attendanceTab.TabIndex = 1;
            attendanceTab.Text = "Chấm công & lương";
            attendanceTab.UseVisualStyleBackColor = true;

            dtpThangNam.CustomFormat = "MM/yyyy";
            dtpThangNam.Format = DateTimePickerFormat.Custom;
            dtpThangNam.Location = new Point(16, 18);
            dtpThangNam.Name = "dtpThangNam";
            dtpThangNam.ShowUpDown = true;
            dtpThangNam.Size = new Size(130, 23);
            dtpThangNam.TabIndex = 0;

            btnLoadAttendance.Location = new Point(156, 16);
            btnLoadAttendance.Name = "btnLoadAttendance";
            btnLoadAttendance.Size = new Size(130, 28);
            btnLoadAttendance.TabIndex = 1;
            btnLoadAttendance.Text = "Tải chấm công";
            btnLoadAttendance.UseVisualStyleBackColor = true;
            btnLoadAttendance.Click += btnLoadAttendance_Click;

            btnSaveAttendance.Location = new Point(296, 16);
            btnSaveAttendance.Name = "btnSaveAttendance";
            btnSaveAttendance.Size = new Size(130, 28);
            btnSaveAttendance.TabIndex = 2;
            btnSaveAttendance.Text = "Lưu chấm công";
            btnSaveAttendance.UseVisualStyleBackColor = true;
            btnSaveAttendance.Click += btnSaveAttendance_Click;

            btnClosePayroll.Location = new Point(436, 16);
            btnClosePayroll.Name = "btnClosePayroll";
            btnClosePayroll.Size = new Size(150, 28);
            btnClosePayroll.TabIndex = 3;
            btnClosePayroll.Text = "Chốt lương tháng";
            btnClosePayroll.UseVisualStyleBackColor = true;
            btnClosePayroll.Click += btnClosePayroll_Click;

            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.Location = new Point(16, 62);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvAttendance.Size = new Size(1044, 552);
            dgvAttendance.TabIndex = 4;

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(tabControl);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HRM & Payroll System";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            employeesTab.ResumeLayout(false);
            employeesTab.PerformLayout();
            attendanceTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLuongCoBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
