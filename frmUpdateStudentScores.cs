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
{

    //Name: Emily Wambach
    //CITC 2311 Lab2

    public partial class frmUpdateStudentScores : Form
    {
        
        List<int> studentScores = new List<int>(); //declare list for student scores
        Boolean updateStudent; //declare boolean for updating student
        Student updatedStudent; //declare instance of update student in Student class
        List<int> updatedList; //declare list for updated list

        public Boolean DoUpdateStudent() //method for updating student
        {
            return updateStudent;    // return boolean updateStudent
        }

        public frmUpdateStudentScores() //initialize form
        {
            InitializeComponent();

        }

        private void FormUpdateStudentScores_Load(object sender, EventArgs e) //event for loading student name and scores
        {
            txtBoxName.Text = updatedStudent.Name;// txtBoxName is selected student's name

            updatedList = updatedStudent.StudentScores.ToList(); //add student scores to updated List
            FillListBoxScores(); //call methodd to iterate scores into list box
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e) //event to update selected score
        {
            if (listBoxScores.SelectedIndex != -1) //if the selected index of listbox is not -1
            { 
                frmUpdateScore updateScoreForm = new frmUpdateScore(); //declare instance of form update score
                updateScoreForm.newScore = updatedList[(listBoxScores.SelectedIndex)];
                updateScoreForm.Show(); //show form
                updateScoreForm.VisibleChanged += updateFormVisibleChanged; //change visibility to form update score
            }
        }

        private void updateFormVisibleChanged(object sender, EventArgs e) //method for frmUpdateScore visibility change
        {
            frmUpdateScore updateForm = (frmUpdateScore)sender; //declare instance of form update score
            if (!updateForm.Visible & updateForm.DoUpdate()) //declare new instance of frmUpdateScore 
            {
                updatedList[listBoxScores.SelectedIndex] = updateForm.newScore; //update the list with new score frmUpdateScore
                FillListBoxScores(); //call fill list box method
                updateForm.Dispose(); //dispose of the form
                this.Show();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e) //event for add button being clicked
        {
            frmAddScore newScore = new frmAddScore(); // declare new instace of frmAddScore
            newScore.Show(); //show new form
            newScore.VisibleChanged += addformVisibleChanged; //change visibility to form update score
        }

        private void addformVisibleChanged(object sender, EventArgs e) // Method for with the AddScore Form closes
        {
            frmAddScore addscore = (frmAddScore)sender; //declare new instance of frmAddScore 
            if (!addscore.Visible & addscore.DoAdd()) //if form is visible and do add is true
            {
                updatedList.Add(addscore.newScore); //update the list with new score frmAddScore
                FillListBoxScores(); //call fill list box score method
                addscore.Dispose(); //dispose of the form
                this.Show(); 
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e) //event for remove button being clicked
        {
            int i = listBoxScores.SelectedIndex; //for int i of selected index in listBoxScores
            if (i != -1) //if i is not -1
            {
                int score = (int)updatedList[i]; //declare the score in that list
                string message = "Are you sure you want to delete selected score"; //messages for confirmation box
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo); //dialog box
                if (button == DialogResult.Yes) //if yes is choosen
                {
                    updatedList.Remove(score); //remove that score
                    FillListBoxScores(); //call fill list box method
                }
            }
        }

        private void FillListBoxScores()   //method to fill List box with data for the list box
        {
            listBoxScores.Items.Clear(); //clear items
            foreach (int score in updatedList) // for each score in the updatedList 
            {
                listBoxScores.Items.Add(score); //add to the list box
            }
        }

        private void BtnOK_Click(object sender, EventArgs e) //event for OK button
        {
            updateStudent = true; // set updateStudent to true                    
            updatedStudent.StudentScores = updatedList.ToList(); //add student scores to updated list
            this.Visible = false; //visiblity set to false
        }

        

        private void BtnClearScores_Click(object sender, EventArgs e) //event for clearing scores
        {
            //confirmation for clearing grades
            string message = "Are you sure you want to delete selected student"; //declare sting message for dialog result
            DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo); //declare DialogResult
            if (button == DialogResult.Yes) //DialogResult button Yes was choosen
            {
                updatedList.Clear(); //clear list 
                FillListBoxScores(); //call fill list box method
            }         
        }

        private void BtnCancel_Click(object sender, EventArgs e) //event to cancel button being clicked
        {
            updateStudent = false; //set updateStudent to false
            listBoxScores.Items.Clear(); //clear item in list

            FillListBoxScores(); //call method
            this.Visible = false; //make form invisible
            
        }

        //Getters and Setters
        public List<int> StudentScores
        {
            get
            {
                return studentScores;
            }
            set
            {
                studentScores = value;
            }
        }


        public Student UpdateStudent
        {
            get
            {
                return updatedStudent;
            }
            set
            {
                updatedStudent = value;
            }
        }
    }
}
