using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{


    public class Student 
    {
        private string name;
        private int score;

        private List<int> studentscores = new List<int>();

               
        public Student(string name, int score, int score2, int score3)
        {
            this.name = name;

            addNewStudentScore(score);
            addNewStudentScore(score2);
            addNewStudentScore(score3);


        }

        public Student(string name, List<int> studentscores)
        {
            this.name = name;
            this.studentscores = studentscores;

            //studentscores.Add(97);

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public int ScoreStudentScoresSum
        {
            get
            {
                return studentscores.Sum();
            }
        }

        public int ScoreStudentScoresCount
        {
            get
            {
                return studentscores.Count;
            }
        }

        public int ScoreStudentScoresAverage
        {
            get
            {


                return Convert.ToInt32(studentscores.Average());

            }
        }


        public List<int> StudentScores
        {
            get
            {
                return studentscores;
            }


            set
            {
                studentscores = value;
            }
        }


        public void addNewStudentScore(int score)
        {

            studentscores.Add(score);

        }


        public string GetDisplayText()
        {
            StringBuilder output = new StringBuilder(name + ": |");

            //String output = name + ":";
            foreach (int s in studentscores)
            {
                //studentscores.Add(s);
                output.Append(s + "|");
            }

            return output.ToString();
        }


    }
}
