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

    public partial class frmAddScore : Form
    {
        private Boolean doAdd; //declare boolean for doAdd
        private int addedScore; //declare int for new added score

        public Boolean DoAdd()
        {
            return doAdd; // return doAdd
        }

        public int newScore //getters and setter for new score
        {
            get
            {
                addedScore = Convert.ToInt32(txtBoxScore.Text);
                return addedScore;
            }
            set
            {
                addedScore = value;
            }
        }

        public frmAddScore()
        {
            InitializeComponent();
        }

        private void BtnAddScore_Click(object sender, EventArgs e) //event for clicking add score button
        {
            String input = txtBoxScore.Text; //declare input for the text in txtBoxSc
            try
            {

                if (Double.Parse(input) >= 0 && Double.Parse(input) <= 100) //if input is >= 0 and <= 100
                {
                    if (input != null && input != "") //if the txtBoxScore is not null
                    {
                        doAdd = true; //set doAdd to true                       
                        this.Visible = false; //make form visibility to false 
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

        private void BtnCancel_Click(object sender, EventArgs e) //event for clicking cancel button
        {
            doAdd = false; //set doAdd to false                        
            this.Visible = false; //make form visibility to false
        }


        private void txtBoxScore_KeyPress(object sender, KeyPressEventArgs e) //keypress event for txtBoxScore
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // allow for numbers in txtBoxSore
        }

        private void frmAddScore_Load(object sender, EventArgs e)
        {

        }
    }
}
