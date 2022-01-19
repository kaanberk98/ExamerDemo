namespace ExamerDemo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwCourse = new System.Windows.Forms.DataGridView();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.tbxCourseID = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.tbxCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseInfo = new System.Windows.Forms.Label();
            this.tbxCourseInfo = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxCourseNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxCourseInfoUpdate = new System.Windows.Forms.TextBox();
            this.lblCourseInfoUpdate = new System.Windows.Forms.Label();
            this.lblCourseNameUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgwExam = new System.Windows.Forms.DataGridView();
            this.lblExamID = new System.Windows.Forms.Label();
            this.tbxExamID = new System.Windows.Forms.TextBox();
            this.lblCourseIDFK = new System.Windows.Forms.Label();
            this.tbxCourseIDFK = new System.Windows.Forms.TextBox();
            this.lblExamName = new System.Windows.Forms.Label();
            this.tbxExamName = new System.Windows.Forms.TextBox();
            this.lblExamInfo = new System.Windows.Forms.Label();
            this.tbxExamInfo = new System.Windows.Forms.TextBox();
            this.gbxAdd2 = new System.Windows.Forms.GroupBox();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.gbxUpdate2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.tbxExamNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxExamInfoUpdate = new System.Windows.Forms.TextBox();
            this.lblExamInfoUpdate = new System.Windows.Forms.Label();
            this.lblExamNameUpdate = new System.Windows.Forms.Label();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.dgwEroom = new System.Windows.Forms.DataGridView();
            this.lblEroomID = new System.Windows.Forms.Label();
            this.tbxEroomID = new System.Windows.Forms.TextBox();
            this.lblEroomCapacity = new System.Windows.Forms.Label();
            this.tbxEroomCapacity = new System.Windows.Forms.TextBox();
            this.lblEroomInfo = new System.Windows.Forms.Label();
            this.tbxEroomInfo = new System.Windows.Forms.TextBox();
            this.gbxAdd3 = new System.Windows.Forms.GroupBox();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.gbxUpdate3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate3 = new System.Windows.Forms.Button();
            this.tbxEroomCapacityUpdate = new System.Windows.Forms.TextBox();
            this.tbxEroomInfoUpdate = new System.Windows.Forms.TextBox();
            this.lblEroomInfoUpdate = new System.Windows.Forms.Label();
            this.lblEroomCapacityUpdate = new System.Windows.Forms.Label();
            this.btnRemove3 = new System.Windows.Forms.Button();
            this.dgwCalendarRecord = new System.Windows.Forms.DataGridView();
            this.lblExamDateTime = new System.Windows.Forms.Label();
            this.tbxExamDateTime = new System.Windows.Forms.TextBox();
            this.lblExamDurationMinute = new System.Windows.Forms.Label();
            this.tbxExamDurationMinute = new System.Windows.Forms.TextBox();
            this.lblEroomIDFK = new System.Windows.Forms.Label();
            this.tbxEroomIDFK = new System.Windows.Forms.TextBox();
            this.lblExamIDFK = new System.Windows.Forms.Label();
            this.tbxExamIDFK = new System.Windows.Forms.TextBox();
            this.gbxAdd4 = new System.Windows.Forms.GroupBox();
            this.btnAdd4 = new System.Windows.Forms.Button();
            this.gbxUpdate4 = new System.Windows.Forms.GroupBox();
            this.btnUpdate4 = new System.Windows.Forms.Button();
            this.lblExamDateTimeUpdate = new System.Windows.Forms.Label();
            this.tbxExamDateTimeUpdate = new System.Windows.Forms.TextBox();
            this.lblExamDurationMinuteUpdate = new System.Windows.Forms.Label();
            this.tbxExamDurationMinuteUpdate = new System.Windows.Forms.TextBox();
            this.btnRemove4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCourse)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExam)).BeginInit();
            this.gbxAdd2.SuspendLayout();
            this.gbxUpdate2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEroom)).BeginInit();
            this.gbxAdd3.SuspendLayout();
            this.gbxUpdate3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCalendarRecord)).BeginInit();
            this.gbxAdd4.SuspendLayout();
            this.gbxUpdate4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCourse
            // 
            this.dgwCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCourse.Location = new System.Drawing.Point(800, 11);
            this.dgwCourse.Name = "dgwCourse";
            this.dgwCourse.Size = new System.Drawing.Size(302, 110);
            this.dgwCourse.TabIndex = 0;
            this.dgwCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCourse_CellClick);
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(5, 18);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(49, 12);
            this.lblCourseID.TabIndex = 1;
            this.lblCourseID.Text = "CourseID";
            // 
            // tbxCourseID
            // 
            this.tbxCourseID.Location = new System.Drawing.Point(117, 18);
            this.tbxCourseID.Name = "tbxCourseID";
            this.tbxCourseID.Size = new System.Drawing.Size(100, 20);
            this.tbxCourseID.TabIndex = 2;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(5, 46);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(66, 12);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "CourseName";
            // 
            // tbxCourseName
            // 
            this.tbxCourseName.Location = new System.Drawing.Point(117, 46);
            this.tbxCourseName.Name = "tbxCourseName";
            this.tbxCourseName.Size = new System.Drawing.Size(100, 20);
            this.tbxCourseName.TabIndex = 4;
            // 
            // lblCourseInfo
            // 
            this.lblCourseInfo.AutoSize = true;
            this.lblCourseInfo.Location = new System.Drawing.Point(5, 78);
            this.lblCourseInfo.Name = "lblCourseInfo";
            this.lblCourseInfo.Size = new System.Drawing.Size(57, 12);
            this.lblCourseInfo.TabIndex = 5;
            this.lblCourseInfo.Text = "CourseInfo";
            // 
            // tbxCourseInfo
            // 
            this.tbxCourseInfo.Location = new System.Drawing.Point(117, 78);
            this.tbxCourseInfo.Name = "tbxCourseInfo";
            this.tbxCourseInfo.Size = new System.Drawing.Size(100, 20);
            this.tbxCourseInfo.TabIndex = 6;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxCourseName);
            this.gbxAdd.Controls.Add(this.tbxCourseInfo);
            this.gbxAdd.Controls.Add(this.lblCourseID);
            this.gbxAdd.Controls.Add(this.lblCourseInfo);
            this.gbxAdd.Controls.Add(this.tbxCourseID);
            this.gbxAdd.Controls.Add(this.lblCourseName);
            this.gbxAdd.Location = new System.Drawing.Point(12, 11);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(334, 115);
            this.gbxAdd.TabIndex = 7;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add A Course";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(253, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 21);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxCourseNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxCourseInfoUpdate);
            this.gbxUpdate.Controls.Add(this.lblCourseInfoUpdate);
            this.gbxUpdate.Controls.Add(this.lblCourseNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(363, 11);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(331, 115);
            this.gbxUpdate.TabIndex = 8;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update A Course";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(250, 89);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 21);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxCourseNameUpdate
            // 
            this.tbxCourseNameUpdate.Location = new System.Drawing.Point(117, 46);
            this.tbxCourseNameUpdate.Name = "tbxCourseNameUpdate";
            this.tbxCourseNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxCourseNameUpdate.TabIndex = 4;
            // 
            // tbxCourseInfoUpdate
            // 
            this.tbxCourseInfoUpdate.Location = new System.Drawing.Point(117, 78);
            this.tbxCourseInfoUpdate.Name = "tbxCourseInfoUpdate";
            this.tbxCourseInfoUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxCourseInfoUpdate.TabIndex = 6;
            // 
            // lblCourseInfoUpdate
            // 
            this.lblCourseInfoUpdate.AutoSize = true;
            this.lblCourseInfoUpdate.Location = new System.Drawing.Point(5, 78);
            this.lblCourseInfoUpdate.Name = "lblCourseInfoUpdate";
            this.lblCourseInfoUpdate.Size = new System.Drawing.Size(57, 12);
            this.lblCourseInfoUpdate.TabIndex = 5;
            this.lblCourseInfoUpdate.Text = "CourseInfo";
            // 
            // lblCourseNameUpdate
            // 
            this.lblCourseNameUpdate.AutoSize = true;
            this.lblCourseNameUpdate.Location = new System.Drawing.Point(5, 46);
            this.lblCourseNameUpdate.Name = "lblCourseNameUpdate";
            this.lblCourseNameUpdate.Size = new System.Drawing.Size(66, 12);
            this.lblCourseNameUpdate.TabIndex = 3;
            this.lblCourseNameUpdate.Text = "CourseName";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(700, 100);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 21);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgwExam
            // 
            this.dgwExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwExam.Location = new System.Drawing.Point(800, 166);
            this.dgwExam.Name = "dgwExam";
            this.dgwExam.Size = new System.Drawing.Size(302, 143);
            this.dgwExam.TabIndex = 10;
            this.dgwExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwExam_CellClick);
            // 
            // lblExamID
            // 
            this.lblExamID.AutoSize = true;
            this.lblExamID.Location = new System.Drawing.Point(8, 21);
            this.lblExamID.Name = "lblExamID";
            this.lblExamID.Size = new System.Drawing.Size(41, 12);
            this.lblExamID.TabIndex = 11;
            this.lblExamID.Text = "ExamID";
            // 
            // tbxExamID
            // 
            this.tbxExamID.Location = new System.Drawing.Point(117, 21);
            this.tbxExamID.Name = "tbxExamID";
            this.tbxExamID.Size = new System.Drawing.Size(100, 20);
            this.tbxExamID.TabIndex = 12;
            // 
            // lblCourseIDFK
            // 
            this.lblCourseIDFK.AutoSize = true;
            this.lblCourseIDFK.Location = new System.Drawing.Point(8, 56);
            this.lblCourseIDFK.Name = "lblCourseIDFK";
            this.lblCourseIDFK.Size = new System.Drawing.Size(61, 12);
            this.lblCourseIDFK.TabIndex = 13;
            this.lblCourseIDFK.Text = "CourseIDFK";
            // 
            // tbxCourseIDFK
            // 
            this.tbxCourseIDFK.Location = new System.Drawing.Point(117, 56);
            this.tbxCourseIDFK.Name = "tbxCourseIDFK";
            this.tbxCourseIDFK.Size = new System.Drawing.Size(100, 20);
            this.tbxCourseIDFK.TabIndex = 14;
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Location = new System.Drawing.Point(8, 91);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(58, 12);
            this.lblExamName.TabIndex = 15;
            this.lblExamName.Text = "ExamName";
            // 
            // tbxExamName
            // 
            this.tbxExamName.Location = new System.Drawing.Point(117, 91);
            this.tbxExamName.Name = "tbxExamName";
            this.tbxExamName.Size = new System.Drawing.Size(100, 20);
            this.tbxExamName.TabIndex = 16;
            // 
            // lblExamInfo
            // 
            this.lblExamInfo.AutoSize = true;
            this.lblExamInfo.Location = new System.Drawing.Point(8, 131);
            this.lblExamInfo.Name = "lblExamInfo";
            this.lblExamInfo.Size = new System.Drawing.Size(49, 12);
            this.lblExamInfo.TabIndex = 17;
            this.lblExamInfo.Text = "ExamInfo";
            // 
            // tbxExamInfo
            // 
            this.tbxExamInfo.Location = new System.Drawing.Point(117, 126);
            this.tbxExamInfo.Name = "tbxExamInfo";
            this.tbxExamInfo.Size = new System.Drawing.Size(100, 20);
            this.tbxExamInfo.TabIndex = 18;
            // 
            // gbxAdd2
            // 
            this.gbxAdd2.Controls.Add(this.btnAdd2);
            this.gbxAdd2.Controls.Add(this.tbxExamName);
            this.gbxAdd2.Controls.Add(this.tbxExamInfo);
            this.gbxAdd2.Controls.Add(this.lblExamID);
            this.gbxAdd2.Controls.Add(this.lblExamInfo);
            this.gbxAdd2.Controls.Add(this.tbxExamID);
            this.gbxAdd2.Controls.Add(this.lblCourseIDFK);
            this.gbxAdd2.Controls.Add(this.lblExamName);
            this.gbxAdd2.Controls.Add(this.tbxCourseIDFK);
            this.gbxAdd2.Location = new System.Drawing.Point(12, 166);
            this.gbxAdd2.Name = "gbxAdd2";
            this.gbxAdd2.Size = new System.Drawing.Size(331, 149);
            this.gbxAdd2.TabIndex = 19;
            this.gbxAdd2.TabStop = false;
            this.gbxAdd2.Text = "Add An Exam";
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(250, 122);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 21);
            this.btnAdd2.TabIndex = 19;
            this.btnAdd2.Text = "Add2";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // gbxUpdate2
            // 
            this.gbxUpdate2.Controls.Add(this.btnUpdate2);
            this.gbxUpdate2.Controls.Add(this.tbxExamNameUpdate);
            this.gbxUpdate2.Controls.Add(this.tbxExamInfoUpdate);
            this.gbxUpdate2.Controls.Add(this.lblExamInfoUpdate);
            this.gbxUpdate2.Controls.Add(this.lblExamNameUpdate);
            this.gbxUpdate2.Location = new System.Drawing.Point(363, 166);
            this.gbxUpdate2.Name = "gbxUpdate2";
            this.gbxUpdate2.Size = new System.Drawing.Size(331, 149);
            this.gbxUpdate2.TabIndex = 20;
            this.gbxUpdate2.TabStop = false;
            this.gbxUpdate2.Text = "Update An Exam";
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.Location = new System.Drawing.Point(250, 122);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(75, 21);
            this.btnUpdate2.TabIndex = 19;
            this.btnUpdate2.Text = "Update2";
            this.btnUpdate2.UseVisualStyleBackColor = true;
            this.btnUpdate2.Click += new System.EventHandler(this.btnUpdate2_Click);
            // 
            // tbxExamNameUpdate
            // 
            this.tbxExamNameUpdate.Location = new System.Drawing.Point(117, 91);
            this.tbxExamNameUpdate.Name = "tbxExamNameUpdate";
            this.tbxExamNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxExamNameUpdate.TabIndex = 16;
            // 
            // tbxExamInfoUpdate
            // 
            this.tbxExamInfoUpdate.Location = new System.Drawing.Point(117, 126);
            this.tbxExamInfoUpdate.Name = "tbxExamInfoUpdate";
            this.tbxExamInfoUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxExamInfoUpdate.TabIndex = 18;
            // 
            // lblExamInfoUpdate
            // 
            this.lblExamInfoUpdate.AutoSize = true;
            this.lblExamInfoUpdate.Location = new System.Drawing.Point(8, 131);
            this.lblExamInfoUpdate.Name = "lblExamInfoUpdate";
            this.lblExamInfoUpdate.Size = new System.Drawing.Size(49, 12);
            this.lblExamInfoUpdate.TabIndex = 17;
            this.lblExamInfoUpdate.Text = "ExamInfo";
            // 
            // lblExamNameUpdate
            // 
            this.lblExamNameUpdate.AutoSize = true;
            this.lblExamNameUpdate.Location = new System.Drawing.Point(8, 91);
            this.lblExamNameUpdate.Name = "lblExamNameUpdate";
            this.lblExamNameUpdate.Size = new System.Drawing.Size(58, 12);
            this.lblExamNameUpdate.TabIndex = 15;
            this.lblExamNameUpdate.Text = "ExamName";
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(700, 287);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(75, 21);
            this.btnRemove2.TabIndex = 21;
            this.btnRemove2.Text = "Remove2";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // dgwEroom
            // 
            this.dgwEroom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwEroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEroom.Location = new System.Drawing.Point(800, 345);
            this.dgwEroom.Name = "dgwEroom";
            this.dgwEroom.Size = new System.Drawing.Size(302, 142);
            this.dgwEroom.TabIndex = 22;
            this.dgwEroom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEroom_CellClick);
            // 
            // lblEroomID
            // 
            this.lblEroomID.AutoSize = true;
            this.lblEroomID.Location = new System.Drawing.Point(11, 34);
            this.lblEroomID.Name = "lblEroomID";
            this.lblEroomID.Size = new System.Drawing.Size(47, 12);
            this.lblEroomID.TabIndex = 23;
            this.lblEroomID.Text = "EroomID";
            // 
            // tbxEroomID
            // 
            this.tbxEroomID.Location = new System.Drawing.Point(117, 34);
            this.tbxEroomID.Name = "tbxEroomID";
            this.tbxEroomID.Size = new System.Drawing.Size(100, 20);
            this.tbxEroomID.TabIndex = 24;
            // 
            // lblEroomCapacity
            // 
            this.lblEroomCapacity.AutoSize = true;
            this.lblEroomCapacity.Location = new System.Drawing.Point(11, 65);
            this.lblEroomCapacity.Name = "lblEroomCapacity";
            this.lblEroomCapacity.Size = new System.Drawing.Size(79, 12);
            this.lblEroomCapacity.TabIndex = 25;
            this.lblEroomCapacity.Text = "EroomCapacity";
            // 
            // tbxEroomCapacity
            // 
            this.tbxEroomCapacity.Location = new System.Drawing.Point(117, 65);
            this.tbxEroomCapacity.Name = "tbxEroomCapacity";
            this.tbxEroomCapacity.Size = new System.Drawing.Size(100, 20);
            this.tbxEroomCapacity.TabIndex = 26;
            // 
            // lblEroomInfo
            // 
            this.lblEroomInfo.AutoSize = true;
            this.lblEroomInfo.Location = new System.Drawing.Point(11, 96);
            this.lblEroomInfo.Name = "lblEroomInfo";
            this.lblEroomInfo.Size = new System.Drawing.Size(55, 12);
            this.lblEroomInfo.TabIndex = 27;
            this.lblEroomInfo.Text = "EroomInfo";
            // 
            // tbxEroomInfo
            // 
            this.tbxEroomInfo.Location = new System.Drawing.Point(117, 96);
            this.tbxEroomInfo.Name = "tbxEroomInfo";
            this.tbxEroomInfo.Size = new System.Drawing.Size(100, 20);
            this.tbxEroomInfo.TabIndex = 28;
            // 
            // gbxAdd3
            // 
            this.gbxAdd3.Controls.Add(this.btnAdd3);
            this.gbxAdd3.Controls.Add(this.tbxEroomCapacity);
            this.gbxAdd3.Controls.Add(this.tbxEroomInfo);
            this.gbxAdd3.Controls.Add(this.lblEroomID);
            this.gbxAdd3.Controls.Add(this.lblEroomInfo);
            this.gbxAdd3.Controls.Add(this.tbxEroomID);
            this.gbxAdd3.Controls.Add(this.lblEroomCapacity);
            this.gbxAdd3.Location = new System.Drawing.Point(15, 345);
            this.gbxAdd3.Name = "gbxAdd3";
            this.gbxAdd3.Size = new System.Drawing.Size(331, 142);
            this.gbxAdd3.TabIndex = 29;
            this.gbxAdd3.TabStop = false;
            this.gbxAdd3.Text = "Add An Eroom";
            // 
            // btnAdd3
            // 
            this.btnAdd3.Location = new System.Drawing.Point(247, 115);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(75, 21);
            this.btnAdd3.TabIndex = 29;
            this.btnAdd3.Text = "Add3";
            this.btnAdd3.UseVisualStyleBackColor = true;
            this.btnAdd3.Click += new System.EventHandler(this.btnAdd3_Click);
            // 
            // gbxUpdate3
            // 
            this.gbxUpdate3.Controls.Add(this.btnUpdate3);
            this.gbxUpdate3.Controls.Add(this.tbxEroomCapacityUpdate);
            this.gbxUpdate3.Controls.Add(this.tbxEroomInfoUpdate);
            this.gbxUpdate3.Controls.Add(this.lblEroomInfoUpdate);
            this.gbxUpdate3.Controls.Add(this.lblEroomCapacityUpdate);
            this.gbxUpdate3.Location = new System.Drawing.Point(363, 345);
            this.gbxUpdate3.Name = "gbxUpdate3";
            this.gbxUpdate3.Size = new System.Drawing.Size(331, 142);
            this.gbxUpdate3.TabIndex = 30;
            this.gbxUpdate3.TabStop = false;
            this.gbxUpdate3.Text = "Update An Eroom";
            // 
            // btnUpdate3
            // 
            this.btnUpdate3.Location = new System.Drawing.Point(247, 115);
            this.btnUpdate3.Name = "btnUpdate3";
            this.btnUpdate3.Size = new System.Drawing.Size(75, 21);
            this.btnUpdate3.TabIndex = 29;
            this.btnUpdate3.Text = "Update3";
            this.btnUpdate3.UseVisualStyleBackColor = true;
            this.btnUpdate3.Click += new System.EventHandler(this.btnUpdate3_Click);
            // 
            // tbxEroomCapacityUpdate
            // 
            this.tbxEroomCapacityUpdate.Location = new System.Drawing.Point(117, 65);
            this.tbxEroomCapacityUpdate.Name = "tbxEroomCapacityUpdate";
            this.tbxEroomCapacityUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxEroomCapacityUpdate.TabIndex = 26;
            // 
            // tbxEroomInfoUpdate
            // 
            this.tbxEroomInfoUpdate.Location = new System.Drawing.Point(117, 96);
            this.tbxEroomInfoUpdate.Name = "tbxEroomInfoUpdate";
            this.tbxEroomInfoUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxEroomInfoUpdate.TabIndex = 28;
            // 
            // lblEroomInfoUpdate
            // 
            this.lblEroomInfoUpdate.AutoSize = true;
            this.lblEroomInfoUpdate.Location = new System.Drawing.Point(11, 96);
            this.lblEroomInfoUpdate.Name = "lblEroomInfoUpdate";
            this.lblEroomInfoUpdate.Size = new System.Drawing.Size(55, 12);
            this.lblEroomInfoUpdate.TabIndex = 27;
            this.lblEroomInfoUpdate.Text = "EroomInfo";
            // 
            // lblEroomCapacityUpdate
            // 
            this.lblEroomCapacityUpdate.AutoSize = true;
            this.lblEroomCapacityUpdate.Location = new System.Drawing.Point(11, 65);
            this.lblEroomCapacityUpdate.Name = "lblEroomCapacityUpdate";
            this.lblEroomCapacityUpdate.Size = new System.Drawing.Size(79, 12);
            this.lblEroomCapacityUpdate.TabIndex = 25;
            this.lblEroomCapacityUpdate.Text = "EroomCapacity";
            // 
            // btnRemove3
            // 
            this.btnRemove3.Location = new System.Drawing.Point(701, 460);
            this.btnRemove3.Name = "btnRemove3";
            this.btnRemove3.Size = new System.Drawing.Size(75, 21);
            this.btnRemove3.TabIndex = 31;
            this.btnRemove3.Text = "Remove3";
            this.btnRemove3.UseVisualStyleBackColor = true;
            this.btnRemove3.Click += new System.EventHandler(this.btnRemove3_Click);
            // 
            // dgwCalendarRecord
            // 
            this.dgwCalendarRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCalendarRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCalendarRecord.Location = new System.Drawing.Point(800, 517);
            this.dgwCalendarRecord.Name = "dgwCalendarRecord";
            this.dgwCalendarRecord.Size = new System.Drawing.Size(302, 157);
            this.dgwCalendarRecord.TabIndex = 32;
            this.dgwCalendarRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCalendarRecord_CellClick);
            // 
            // lblExamDateTime
            // 
            this.lblExamDateTime.AutoSize = true;
            this.lblExamDateTime.Location = new System.Drawing.Point(21, 22);
            this.lblExamDateTime.Name = "lblExamDateTime";
            this.lblExamDateTime.Size = new System.Drawing.Size(76, 12);
            this.lblExamDateTime.TabIndex = 33;
            this.lblExamDateTime.Text = "ExamDateTime";
            // 
            // tbxExamDateTime
            // 
            this.tbxExamDateTime.Location = new System.Drawing.Point(132, 16);
            this.tbxExamDateTime.Name = "tbxExamDateTime";
            this.tbxExamDateTime.Size = new System.Drawing.Size(100, 20);
            this.tbxExamDateTime.TabIndex = 34;
            // 
            // lblExamDurationMinute
            // 
            this.lblExamDurationMinute.AutoSize = true;
            this.lblExamDurationMinute.Location = new System.Drawing.Point(21, 57);
            this.lblExamDurationMinute.Name = "lblExamDurationMinute";
            this.lblExamDurationMinute.Size = new System.Drawing.Size(106, 12);
            this.lblExamDurationMinute.TabIndex = 35;
            this.lblExamDurationMinute.Text = "ExamDurationMinute";
            // 
            // tbxExamDurationMinute
            // 
            this.tbxExamDurationMinute.Location = new System.Drawing.Point(132, 51);
            this.tbxExamDurationMinute.Name = "tbxExamDurationMinute";
            this.tbxExamDurationMinute.Size = new System.Drawing.Size(100, 20);
            this.tbxExamDurationMinute.TabIndex = 36;
            // 
            // lblEroomIDFK
            // 
            this.lblEroomIDFK.AutoSize = true;
            this.lblEroomIDFK.Location = new System.Drawing.Point(21, 98);
            this.lblEroomIDFK.Name = "lblEroomIDFK";
            this.lblEroomIDFK.Size = new System.Drawing.Size(59, 12);
            this.lblEroomIDFK.TabIndex = 37;
            this.lblEroomIDFK.Text = "EroomIDFK";
            // 
            // tbxEroomIDFK
            // 
            this.tbxEroomIDFK.Location = new System.Drawing.Point(132, 91);
            this.tbxEroomIDFK.Name = "tbxEroomIDFK";
            this.tbxEroomIDFK.Size = new System.Drawing.Size(100, 20);
            this.tbxEroomIDFK.TabIndex = 38;
            // 
            // lblExamIDFK
            // 
            this.lblExamIDFK.AutoSize = true;
            this.lblExamIDFK.Location = new System.Drawing.Point(21, 128);
            this.lblExamIDFK.Name = "lblExamIDFK";
            this.lblExamIDFK.Size = new System.Drawing.Size(53, 12);
            this.lblExamIDFK.TabIndex = 39;
            this.lblExamIDFK.Text = "ExamIDFK";
            // 
            // tbxExamIDFK
            // 
            this.tbxExamIDFK.Location = new System.Drawing.Point(132, 126);
            this.tbxExamIDFK.Name = "tbxExamIDFK";
            this.tbxExamIDFK.Size = new System.Drawing.Size(100, 20);
            this.tbxExamIDFK.TabIndex = 40;
            // 
            // gbxAdd4
            // 
            this.gbxAdd4.Controls.Add(this.btnAdd4);
            this.gbxAdd4.Controls.Add(this.tbxEroomIDFK);
            this.gbxAdd4.Controls.Add(this.tbxExamIDFK);
            this.gbxAdd4.Controls.Add(this.lblExamDateTime);
            this.gbxAdd4.Controls.Add(this.lblExamIDFK);
            this.gbxAdd4.Controls.Add(this.tbxExamDateTime);
            this.gbxAdd4.Controls.Add(this.lblExamDurationMinute);
            this.gbxAdd4.Controls.Add(this.lblEroomIDFK);
            this.gbxAdd4.Controls.Add(this.tbxExamDurationMinute);
            this.gbxAdd4.Location = new System.Drawing.Point(15, 517);
            this.gbxAdd4.Name = "gbxAdd4";
            this.gbxAdd4.Size = new System.Drawing.Size(331, 157);
            this.gbxAdd4.TabIndex = 41;
            this.gbxAdd4.TabStop = false;
            this.gbxAdd4.Text = "Add A CalendarRecord";
            // 
            // btnAdd4
            // 
            this.btnAdd4.Location = new System.Drawing.Point(247, 130);
            this.btnAdd4.Name = "btnAdd4";
            this.btnAdd4.Size = new System.Drawing.Size(75, 21);
            this.btnAdd4.TabIndex = 41;
            this.btnAdd4.Text = "Add4";
            this.btnAdd4.UseVisualStyleBackColor = true;
            this.btnAdd4.Click += new System.EventHandler(this.btnAdd4_Click);
            // 
            // gbxUpdate4
            // 
            this.gbxUpdate4.Controls.Add(this.btnUpdate4);
            this.gbxUpdate4.Controls.Add(this.lblExamDateTimeUpdate);
            this.gbxUpdate4.Controls.Add(this.tbxExamDateTimeUpdate);
            this.gbxUpdate4.Controls.Add(this.lblExamDurationMinuteUpdate);
            this.gbxUpdate4.Controls.Add(this.tbxExamDurationMinuteUpdate);
            this.gbxUpdate4.Location = new System.Drawing.Point(374, 517);
            this.gbxUpdate4.Name = "gbxUpdate4";
            this.gbxUpdate4.Size = new System.Drawing.Size(320, 157);
            this.gbxUpdate4.TabIndex = 42;
            this.gbxUpdate4.TabStop = false;
            this.gbxUpdate4.Text = "Update A CalendarRecord";
            // 
            // btnUpdate4
            // 
            this.btnUpdate4.Location = new System.Drawing.Point(239, 130);
            this.btnUpdate4.Name = "btnUpdate4";
            this.btnUpdate4.Size = new System.Drawing.Size(75, 21);
            this.btnUpdate4.TabIndex = 41;
            this.btnUpdate4.Text = "Update4";
            this.btnUpdate4.UseVisualStyleBackColor = true;
            this.btnUpdate4.Click += new System.EventHandler(this.btnUpdate4_Click);
            // 
            // lblExamDateTimeUpdate
            // 
            this.lblExamDateTimeUpdate.AutoSize = true;
            this.lblExamDateTimeUpdate.Location = new System.Drawing.Point(21, 22);
            this.lblExamDateTimeUpdate.Name = "lblExamDateTimeUpdate";
            this.lblExamDateTimeUpdate.Size = new System.Drawing.Size(76, 12);
            this.lblExamDateTimeUpdate.TabIndex = 33;
            this.lblExamDateTimeUpdate.Text = "ExamDateTime";
            // 
            // tbxExamDateTimeUpdate
            // 
            this.tbxExamDateTimeUpdate.Location = new System.Drawing.Point(132, 16);
            this.tbxExamDateTimeUpdate.Name = "tbxExamDateTimeUpdate";
            this.tbxExamDateTimeUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxExamDateTimeUpdate.TabIndex = 34;
            // 
            // lblExamDurationMinuteUpdate
            // 
            this.lblExamDurationMinuteUpdate.AutoSize = true;
            this.lblExamDurationMinuteUpdate.Location = new System.Drawing.Point(21, 57);
            this.lblExamDurationMinuteUpdate.Name = "lblExamDurationMinuteUpdate";
            this.lblExamDurationMinuteUpdate.Size = new System.Drawing.Size(106, 12);
            this.lblExamDurationMinuteUpdate.TabIndex = 35;
            this.lblExamDurationMinuteUpdate.Text = "ExamDurationMinute";
            // 
            // tbxExamDurationMinuteUpdate
            // 
            this.tbxExamDurationMinuteUpdate.Location = new System.Drawing.Point(132, 51);
            this.tbxExamDurationMinuteUpdate.Name = "tbxExamDurationMinuteUpdate";
            this.tbxExamDurationMinuteUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxExamDurationMinuteUpdate.TabIndex = 36;
            // 
            // btnRemove4
            // 
            this.btnRemove4.Location = new System.Drawing.Point(701, 647);
            this.btnRemove4.Name = "btnRemove4";
            this.btnRemove4.Size = new System.Drawing.Size(75, 21);
            this.btnRemove4.TabIndex = 43;
            this.btnRemove4.Text = "Remove4";
            this.btnRemove4.UseVisualStyleBackColor = true;
            this.btnRemove4.Click += new System.EventHandler(this.btnRemove4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 702);
            this.Controls.Add(this.btnRemove4);
            this.Controls.Add(this.gbxUpdate4);
            this.Controls.Add(this.gbxAdd4);
            this.Controls.Add(this.dgwCalendarRecord);
            this.Controls.Add(this.btnRemove3);
            this.Controls.Add(this.gbxUpdate3);
            this.Controls.Add(this.gbxAdd3);
            this.Controls.Add(this.dgwEroom);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.gbxUpdate2);
            this.Controls.Add(this.gbxAdd2);
            this.Controls.Add(this.dgwExam);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwCourse);
            this.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Name = "Form1";
            this.Text = "EXAMER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCourse)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExam)).EndInit();
            this.gbxAdd2.ResumeLayout(false);
            this.gbxAdd2.PerformLayout();
            this.gbxUpdate2.ResumeLayout(false);
            this.gbxUpdate2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEroom)).EndInit();
            this.gbxAdd3.ResumeLayout(false);
            this.gbxAdd3.PerformLayout();
            this.gbxUpdate3.ResumeLayout(false);
            this.gbxUpdate3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCalendarRecord)).EndInit();
            this.gbxAdd4.ResumeLayout(false);
            this.gbxAdd4.PerformLayout();
            this.gbxUpdate4.ResumeLayout(false);
            this.gbxUpdate4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCourse;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.TextBox tbxCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox tbxCourseName;
        private System.Windows.Forms.Label lblCourseInfo;
        private System.Windows.Forms.TextBox tbxCourseInfo;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxCourseNameUpdate;
        private System.Windows.Forms.TextBox tbxCourseInfoUpdate;
        private System.Windows.Forms.Label lblCourseInfoUpdate;
        private System.Windows.Forms.Label lblCourseNameUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgwExam;
        private System.Windows.Forms.Label lblExamID;
        private System.Windows.Forms.TextBox tbxExamID;
        private System.Windows.Forms.Label lblCourseIDFK;
        private System.Windows.Forms.TextBox tbxCourseIDFK;
        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.TextBox tbxExamName;
        private System.Windows.Forms.Label lblExamInfo;
        private System.Windows.Forms.TextBox tbxExamInfo;
        private System.Windows.Forms.GroupBox gbxAdd2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.GroupBox gbxUpdate2;
        private System.Windows.Forms.Button btnUpdate2;
        private System.Windows.Forms.TextBox tbxExamNameUpdate;
        private System.Windows.Forms.TextBox tbxExamInfoUpdate;
        private System.Windows.Forms.Label lblExamInfoUpdate;
        private System.Windows.Forms.Label lblExamNameUpdate;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.DataGridView dgwEroom;
        private System.Windows.Forms.Label lblEroomID;
        private System.Windows.Forms.TextBox tbxEroomID;
        private System.Windows.Forms.Label lblEroomCapacity;
        private System.Windows.Forms.TextBox tbxEroomCapacity;
        private System.Windows.Forms.Label lblEroomInfo;
        private System.Windows.Forms.TextBox tbxEroomInfo;
        private System.Windows.Forms.GroupBox gbxAdd3;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.GroupBox gbxUpdate3;
        private System.Windows.Forms.Button btnUpdate3;
        private System.Windows.Forms.TextBox tbxEroomCapacityUpdate;
        private System.Windows.Forms.TextBox tbxEroomInfoUpdate;
        private System.Windows.Forms.Label lblEroomInfoUpdate;
        private System.Windows.Forms.Label lblEroomCapacityUpdate;
        private System.Windows.Forms.Button btnRemove3;
        private System.Windows.Forms.DataGridView dgwCalendarRecord;
        private System.Windows.Forms.Label lblExamDateTime;
        private System.Windows.Forms.TextBox tbxExamDateTime;
        private System.Windows.Forms.Label lblExamDurationMinute;
        private System.Windows.Forms.TextBox tbxExamDurationMinute;
        private System.Windows.Forms.Label lblEroomIDFK;
        private System.Windows.Forms.TextBox tbxEroomIDFK;
        private System.Windows.Forms.Label lblExamIDFK;
        private System.Windows.Forms.TextBox tbxExamIDFK;
        private System.Windows.Forms.GroupBox gbxAdd4;
        private System.Windows.Forms.Button btnAdd4;
        private System.Windows.Forms.GroupBox gbxUpdate4;
        private System.Windows.Forms.Button btnUpdate4;
        private System.Windows.Forms.Label lblExamDateTimeUpdate;
        private System.Windows.Forms.TextBox tbxExamDateTimeUpdate;
        private System.Windows.Forms.Label lblExamDurationMinuteUpdate;
        private System.Windows.Forms.TextBox tbxExamDurationMinuteUpdate;
        private System.Windows.Forms.Button btnRemove4;
    }
}

