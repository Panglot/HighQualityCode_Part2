using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public int Grade
    {
        get
        {
            return this.grade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Grade cannot be less than 0!");
            }

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("MinGrade cannot be less than 0!");
            }

            this.minGrade = value;
        }
    }

    public int MaxGrade { get; private set; }

    public string Comments
    {
        get
        {
            return this.comments;
        }
        private set
        {
            if( value == null)
            {
                throw new ArgumentNullException("Comments cannot be null!");
            }
            else if( value == "")
            {
                throw new ArgumentException("Comments cannot be empty string!");
            }

            this.comments = value;
        }
    }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("MinGrade cannot be greater or equal to MaxGrade");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
