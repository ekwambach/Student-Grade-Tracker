using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_2

    //Name: Emily Wambach
    //CITC 2311 Lab2

{
    public partial class frmStudentScores : Form
    {
        List<Student> students = new List<Student>();


        public frmStudentScores()
        {
            InitializeComponent();
        }

        private void frmStudentScores_Load(object sender, EventArgs e) // event to load student entries to the list box
        {
            students.Add(new Student("Joel Murach", 99, 99, 100)); //test examples
            students.Add(new Student("Doug Lowel", 80, 75, 90));
            students.Add(new Student("Ann Boehm", 100, 100, 100));
            FillStudentListBox(); //call method to fill list box

        }

        private void ButtonAddNew_Click(object sender, EventArgs e) //event to add a new student
        {
            frmAddNewStudent newStudentForm = new frmAddNewStudent(); //declare instance of a new form frmAddNewStudent

            newStudentForm.Show(); //show the form
            this.Hide();
            newStudentForm.VisibleChanged += formVisibleChanged; //change visibility
        }

        private void formVisibleChanged(object sender, EventArgs e) // method for when frmAddNewStudent closes
        {
            frmAddNewStudent newStudentForm = (frmAddNewStudent)sender; //instance of frmAddNewStudent
            if (!newStudentForm.Visible & newStudentForm.DoAddStudent()) //if form is not visible and DoAddStudent is true
            {
                students.Add(newStudentForm.returnStudent()); //add new student from form to students list
                FillStudentListBox(); //call method to add new student to the list box
                newStudentForm.Dispose(); //delete the old form
                this.Show();//show
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e) //event for updating a student's score
        {
            if (lstBoxStudents.SelectedIndex != -1) //if the selected index of listbox is not -1
            {
                frmUpdateStudentScores updateStudentForm = new frmUpdateStudentScores(); //declare instance of frmUpdateStudentScores
                updateStudentForm.UpdateStudent = students[lstBoxStudents.SelectedIndex]; //upload stance of student from selected index
                updateStudentForm.Show(); //show form
                this.Hide(); //hide this form
                updateStudentForm.VisibleChanged += updateformVisibleChanged; //change visibility status to new form
            }
            
        }
        private void updateformVisibleChanged(object sender, EventArgs e) // event for when the form frmUpdateStudentScores closes
        {
            frmUpdateStudentScores updateStudentForm = (frmUpdateStudentScores)sender; //declare instance of that form
            if (!updateStudentForm.Visible) //if form is not visible
            {
                if (updateStudentForm.DoUpdateStudent()) //if action was updateStudent
                {
                    foreach (int i in updateStudentForm.StudentScores) //for every item in list StudentScores
                    {
                        students[lstBoxStudents.SelectedIndex].StudentScores.Add(i); //add new scores
                    }           
                    FillStudentListBox(); //call method to fill the list box
                }
                this.Show(); //show this form
                updateStudentForm.Dispose(); //dispose of update student form

            }
        }

        private void FillStudentListBox()   // method to fill the list box lstBoxStudents
        {
            lstBoxStudents.Items.Clear(); //clear the list box
            foreach (Student i in students) //for event student in the students list
            {
                lstBoxStudents.Items.Add(i.GetDisplayText()); //display list box from the students list
            }
        }

        private void clearscoretextboxesMF()
        {
            textBoxScoreTotal.Clear();       // Display Score total of selected Student
            textBoxScoreCount.Clear();       // Display Score Count of selected Student
            textBoxScoreAverage.Clear();     // Display Score Average of selected Student
        }

        private void BtnDelete_Click(object sender, EventArgs e) //event of deleting an instance of a student
        {            
            if (lstBoxStudents.SelectedIndex != -1) //if selected index is not less -1
            {
                Student student = (Student)students[lstBoxStudents.SelectedIndex]; //declare student as an instance of the selected student
                string message = "Are you sure you want to delete selected student"; //declare sting message for dialog result
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo); //declare DialogResult
                if (button == DialogResult.Yes) //DialogResult button Yes was choosen
                {
                    students.Remove(student); //remove the instance of that student
                    clearscoretextboxesMF(); //call method to clear score text boxes
                    FillStudentListBox(); //call method to fill list box
                }
            }
        }


        private void LstboxStudents_SelectedIndexChanged(object sender, EventArgs e) //event for text in lstBoxStudents
        {
            if (lstBoxStudents.SelectedIndex != -1) //if selected index is not less -1
            {
                if (students[lstBoxStudents.SelectedIndex].StudentScores.ToString() != " ") { 
                textBoxScoreTotal.Text = (students[lstBoxStudents.SelectedIndex].ScoreStudentScoresSum.ToString()); // display score total of selected Student
                textBoxScoreCount.Text = (students[lstBoxStudents.SelectedIndex].ScoreStudentScoresCount.ToString()); // display score count of selected Student
                textBoxScoreAverage.Text = (students[lstBoxStudents.SelectedIndex].ScoreStudentScoresAverage.ToString()); // display score average of selected Student
            }
            }
            else
            {
                textBoxScoreTotal.Clear(); // display score total of selected student
                textBoxScoreCount.Clear(); // display score count of selected student
                textBoxScoreAverage.Clear(); // display score average of selected student
            }
        }

        //List of Getters and Setters
        public List<Student> Students
        {
            get
            {
                return Students;
            }
            set
            {
                Students = value;
            }
        }

 

        private void BtnExit_Click(object sender, EventArgs e) // event to close entire application
        {
            this.Close();
        }

    }
}
