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

    public partial class frmUpdateScore : Form
    {
        private Boolean doUpdate; //delcare boolean for doUpdate
        public int updatedScore; //declare int for updatedScore

        public frmUpdateScore()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, EventArgs e) //event for clicking update button
        {
            String input = txtBoxScore.Text; //declare input for the text in txtBoxSc
            try
            {
                if (Double.Parse(input) >= 0 && Double.Parse(input) <= 100) //if input is >= 0 and <= 100
                {
                    if (input != null && input != "") //if the txtBoxScore is not null
                    {
                        doUpdate = true; //set doUpdate to true     
                        this.Visible = false; //set form visibility to false
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
            doUpdate = false; //set doUpdate to false                        
            this.Visible = false;  //set form visibility to false
        }
        public Boolean DoUpdate()
        {
            return doUpdate; // return doUpdate
        }

        public int newScore
        {
            get
            {
                updatedScore = Convert.ToInt32(txtBoxScore.Text);
                return updatedScore;
            }
            set
            {
                updatedScore = value;
            }
        }

        private void txtBoxScore_KeyPress(object sender, KeyPressEventArgs e) //keypress event for txtBoxScore
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // allow for numbers in txtBoxSore
        }
    }
}
