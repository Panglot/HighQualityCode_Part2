namespace SchoolSystem.Models
{
    using System;
    using Enumerations;

    public class Mark
    {
        private float value;
        private Subject subject;

        public Mark(float value, Subject subject)
        {
            this.Value = value;
            this.Subject = subject;
        }

        public float Value
        {
            get
            {
                return this.value;
            }

            private set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("School marks must be between 2 and 6.");
                }

                this.value = value;
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
    }
}
