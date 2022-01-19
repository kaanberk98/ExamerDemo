using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CalendarRecordDal _calendarRecordDal = new CalendarRecordDal();
        EroomDal _eroomDal = new EroomDal();
        ExamDal _examDal = new ExamDal();
        CourseDal _courseDal = new CourseDal();



        private void LoadCalendarRecord()
        {


            dgwCalendarRecord.DataSource = _calendarRecordDal.GetAll();


        }

        private void LoadEroom()
        {

            dgwEroom.DataSource = _eroomDal.GetAll();


        }

        private void LoadExam()
        {
            dgwExam.DataSource = _examDal.GetAll();

        }

        private void LoadCourse()
        {

            dgwCourse.DataSource = _courseDal.GetAll();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {


            LoadCalendarRecord();
            LoadEroom();
            LoadCourse();
            LoadExam();
                
        }


        
        ///// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _courseDal.Add(new Course
            {

                CourseID = tbxCourseID.Text,
                CourseName = tbxCourseName.Text,
                CourseInfo = tbxCourseInfo.Text,

            }) ;

            LoadCourse();
            MessageBox.Show("CourseAdded!");
        }




        private void dgwCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxCourseNameUpdate.Text = dgwCourse.CurrentRow.Cells[1].Value.ToString();

            tbxCourseInfoUpdate.Text = dgwCourse.CurrentRow.Cells[2].Value.ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Course course = new Course() 
            
            { 
                CourseID = dgwCourse.CurrentRow.Cells[0].Value.ToString(),
                CourseName = tbxCourseNameUpdate.Text,
                CourseInfo = tbxCourseInfoUpdate.Text,

        };

            _courseDal.Update(course);
            LoadCourse();
            MessageBox.Show("Updated!");

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            String courseID = dgwCourse.CurrentRow.Cells[0].Value.ToString();

            _courseDal.Delete(courseID);
            LoadCourse();
            MessageBox.Show("Removed!");
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void btnAdd2_Click(object sender, EventArgs e)
        {

            _examDal.Add(new Exam
            {

                ExamID = tbxExamID.Text,
                CourseID = tbxCourseIDFK.Text,
                ExamName = tbxExamName.Text,
                ExamInfo = tbxExamInfo.Text,

            });

            LoadExam();
            MessageBox.Show("CourseAdded!");

        }



        private void dgwExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxExamNameUpdate.Text = dgwExam.CurrentRow.Cells[2].Value.ToString();
            tbxExamInfoUpdate.Text = dgwExam.CurrentRow.Cells[3].Value.ToString();
        }



        private void btnUpdate2_Click(object sender, EventArgs e)
        {

            Exam exam = new Exam()

            {
                ExamID = dgwExam.CurrentRow.Cells[0].Value.ToString(),
                CourseID = dgwExam.CurrentRow.Cells[1].Value.ToString(),
                ExamName = tbxExamNameUpdate.Text,
                ExamInfo = tbxExamInfoUpdate.Text,

            };

            _examDal.Update(exam);
            LoadExam();
            MessageBox.Show("Updated!");




        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {

            String examID = dgwExam.CurrentRow.Cells[0].Value.ToString();

            _examDal.Delete(examID);
            LoadExam();
            MessageBox.Show("Removed!");

        }
       
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void btnAdd3_Click(object sender, EventArgs e)
        {

            _eroomDal.Add(new Eroom { 
            
                EroomID = tbxEroomID.Text,
                EroomCapacity = Convert.ToInt32(tbxEroomCapacity.Text),
                EroomInfo = tbxEroomInfo.Text,
            
            });

            LoadEroom();
            MessageBox.Show("Eroom Added!");

        }

        

        private void dgwEroom_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxEroomCapacityUpdate.Text = dgwEroom.CurrentRow.Cells[1].Value.ToString();
            tbxEroomInfoUpdate.Text = dgwEroom.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate3_Click(object sender, EventArgs e)
        {

            Eroom eroom = new Eroom { 
            
                EroomID = dgwEroom.CurrentRow.Cells[0].Value.ToString(),
                EroomCapacity = Convert.ToInt32(tbxEroomCapacityUpdate.Text),
                EroomInfo = tbxEroomInfoUpdate.Text,



        };


            _eroomDal.Update(eroom);
            LoadEroom();
            MessageBox.Show("Updated!");
        }

        private void btnRemove3_Click(object sender, EventArgs e)
        {

            String EroomID = dgwEroom.CurrentRow.Cells[0].Value.ToString();

            _eroomDal.Delete(EroomID);
            LoadEroom();
            MessageBox.Show("Deleted!");
        }

        
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void btnAdd4_Click(object sender, EventArgs e)
        {

            _calendarRecordDal.Add(new CalendarRecord { 
            
                ExamDateTime = tbxExamDateTime.Text,
                ExamDurationMinute = Convert.ToInt32(tbxExamDurationMinute.Text),
                EroomID = tbxEroomIDFK.Text,
                ExamID = tbxExamIDFK.Text,
            
            
            
            
            
            });

            LoadCalendarRecord();
            MessageBox.Show("Record Added!");

        }

        

        private void dgwCalendarRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxExamDateTimeUpdate.Text = dgwCalendarRecord.CurrentRow.Cells[1].Value.ToString();
            tbxExamDurationMinuteUpdate.Text = dgwCalendarRecord.CurrentRow.Cells[2].Value.ToString();


            
        }

        private void btnUpdate4_Click(object sender, EventArgs e)
        {

            CalendarRecord calendarRecord = new CalendarRecord
            {

                RecordNo = Convert.ToInt32(dgwCalendarRecord.CurrentRow.Cells[0].Value),
                ExamDateTime = tbxExamDateTimeUpdate.Text,
                ExamDurationMinute = Convert.ToInt32(tbxExamDurationMinuteUpdate.Text),
                EroomID = dgwCalendarRecord.CurrentRow.Cells[3].Value.ToString(),
                ExamID = dgwCalendarRecord.CurrentRow.Cells[4].Value.ToString(),



            };


            _calendarRecordDal.Update(calendarRecord);
            LoadCalendarRecord();
            MessageBox.Show("Updated!");




        }

        private void btnRemove4_Click(object sender, EventArgs e)
        {

            String RecordNo = dgwCalendarRecord.CurrentRow.Cells[0].Value.ToString();

            _calendarRecordDal.Delete(RecordNo);
            LoadCalendarRecord();
            MessageBox.Show("Deleted!");





        }
    }
}
