namespace SchoolSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using Enumerations;

    public class Student
    {
        private string firstName;
        private string lastName;
        private Grade grade;
        private List<Mark> marks;

        public Student(string firstName, string lastName, Grade grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            this.Marks = new List<Mark>();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (value.Length < 2 || value.Length > 31)
                {
                    throw new ArgumentOutOfRangeException("First name must have more than 2 and less than 31 symbols.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (value.Length < 2 || value.Length > 31)
                {
                    throw new ArgumentOutOfRangeException("Last name must have more than 2 and less than 31 symbols.");
                }

                this.lastName = value;
            }
        }

        public Grade Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < (Grade)1 || value > (Grade)12)
                {
                    throw new ArgumentOutOfRangeException("Grade must be between first(1) and twelfth(12).");
                }

                this.grade = value;
            }
        }

        public List<Mark> Marks
        {
            get
            {
                return this.marks;
            }

            private set
            {
                this.marks = value;
            }
        }

        public void AddMark(Mark markToBeAdded)
        {
            if (this.Marks.Count >= 20)
            {
                throw new OverflowException("Single student cannot have more than 20 marks.");
            }

            this.Marks.Add(markToBeAdded);
        }

        public string ListMarks()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            var marksAsList = this.Marks.Select(mark => string.Format("{0} => {1}", mark.Subject, mark.Value)).ToList();
            if (marksAsList.Count == 0)
            {
                var messageEmpty = "This student has no marks.";
                return messageEmpty;
            }

            var messageLeadingTheMarks = "The student has these marks:\n";
            var marksAsString = messageLeadingTheMarks + string.Join("\n", marksAsList) + "\n";
            return marksAsString;
        }
    }
}
