namespace SchoolSystem.Models
{
    using System;
    using Enumerations;

    internal class Teacher
    {
        private string firstName;
        private string lastName;
        private Subject subject;

        public Teacher(string firstName, string lastName, Subject subject)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;
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

        public Subject Subject
        {
            get
            {
                return this.subject;
            }

            private set
            {
                this.subject = value;
            }
        }

        public void AddMark(Student studentToEvaluate, float markValue)
        {
            var mark = new Mark(markValue, this.Subject);
            studentToEvaluate.AddMark(mark);
        }
    }
}
