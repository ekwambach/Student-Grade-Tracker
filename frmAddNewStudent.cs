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

    public partial class frmAddNewStudent : Form
    {
        String name; //string for student name
        List<int> studentScores = new List<int>(); // declare student score list
        Boolean addStudent; // declare boolean addStudent for adding students


        public frmAddNewStudent()
        {
            InitializeComponent();
        }

        private void FormAddNewStudent_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxScore_KeyPress(object sender, KeyPressEventArgs e) // key press event for txtBoxScore
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // allow for numbers in txtBoxSore

        }
        private void BtnAddScore_Click(object sender, EventArgs e) //event for adding a new score to btnAddScore
        {
            String input = txtBoxScore.Text; //declare input for the text in txtBoxScore

            try // try-catch to check for input
            {
                if (Double.Parse(input) >= 0 && Double.Parse(input) <= 100) //if input is >= 0 and <= 100
                {
                    if (input != null && input != "") //if the txtBoxScore is not null
                    {
                        studentScores.Add(Convert.ToInt32(txtBoxScore.Text));   // Add score to studentscores
                        Fillstudentscores();                                        // Update studentscores textbox
                        txtBoxScore.Clear();                                    // Clear previous score from textbox
                        txtBoxScore.Focus();
                    }
                }
                else if (Double.Parse(input) > 100) // error for if input is over 100
                {
                    MessageBox.Show("Grades must be a value of 0 to 100."); //error message
                    txtBoxScore.Clear(); //clear the text box
                    txtBoxScore.Focus(); //focus on text box
                }
            }
            catch (Exception) // error catch for if there is no input
            {
                MessageBox.Show("Please enter in a grade."); //error message
                txtBoxScore.Clear(); //clear the text box
                txtBoxScore.Focus(); //focus on text box
            }

        }

        private void BtnOK_Click(object sender, EventArgs e) //event for adding a new student for btnOk
        {
            name = txtBoxName.Text; //string for student name

            if (name != null && name != "" && studentScores.Any()) //if the name and grade inputs are not empty
            {
                addStudent = true; // addStudent is true                         
                this.Visible = false;                                                   // Make Form inVisable
            }
            else //if either name or grade inputs are empty
            {
                MessageBox.Show("This form requires a student name and at least one grade entered."); //error message
                txtBoxName.Focus();
            }
        }

        private void Fillstudentscores()
        {
            StringBuilder output = new StringBuilder();     // Create output stringbuilder
            txtTotalScores.Clear();                         // Clear studentscores textbox
            foreach (int i in studentScores)                // Loop to add scores to output StringBuilder
            {
                output.Append(i + ",");                     // Add spaces between scores
            }
            txtTotalScores.Text = output.ToString();  // Set studentscores textbox as output string

        }

        public Student returnStudent()
        {
            Student newStudent = new Student(txtBoxName.Text, studentScores);   // Create new Student
            return newStudent;                                                      // Return newStudent
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            studentScores.Clear();  // Clear studentscores textbox
            Fillstudentscores();    // Fill studentscores textbox
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            addStudent = false;   // Set doAddStudent to False
            this.Close();           // Close Form
        }

        public Boolean DoAddStudent()
        {
            return addStudent;    // return doAddStudent
        }
        
    }

}
