using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1
{
    class Student
    {
        int userName;
        string name;
        double score;
        char nationality;

        public Student(int userName, string name, double score, char nationality)
        {
            this.userName = userName;
            this.name = name;
            this.score = score;
            this.nationality = nationality;
        }

        #region propriété
        public int UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Score { get;  set; }

        public char Nationality
        {
            get { return this.nationality; }
            set { this.nationality = value; }
        }
        #endregion propriété

        public void DisplayDetails()
        {
            Console.WriteLine("UserName : " + this.userName + "\nName : " + this.name + "\nScore : " + this.score + "\nNationality : " + this.nationality);
        }

        public void AddScord (double add)
        {
            Score += add;
        }
    }
}
