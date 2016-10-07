namespace SchoolSystemTests
{
    using NUnit.Framework;
    using SchoolSystem.Enumerations;
    using SchoolSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    class StudentTests
    {
        // Correct student values
        string studentFirstName = "Ivan";
        string studentLastName = "Ivanov";
        Grade studentGrade = Grade.Seventh;

        [Test]
        public void PassingCorrectParametersToConstructor_ExpectObjectToBeCorrectlyCreated()
        {
            var testStudent = new Student(studentFirstName, studentLastName, studentGrade);

            Assert.AreEqual(studentFirstName, testStudent.FirstName);
            Assert.AreEqual(studentLastName, testStudent.LastName);
            Assert.AreEqual(studentGrade, testStudent.Grade);
        }

        [Test]
        public void PassingCorrectParametersToConstructor_ExpectStudentMarksToBeEmpty()
        {
            var testStudent = new Student(studentFirstName, studentLastName, studentGrade);

            Assert.AreEqual(testStudent.Marks.Count, 0);
        }

        [Test]
        public void PassingNullParametersToConstructor_ExpectNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => new Student(null, null, studentGrade));
        }

        [Test]
        public void PassingTooShortFirstName_ExpectArgumentOutOfRangeException()
        {
            var incorrectName = "a";

            Assert.Throws<ArgumentOutOfRangeException>(() => new Student(incorrectName, studentLastName, studentGrade));
        }

        [Test]
        public void PassingTooShortSecondName_ExpectArgumentOutOfRangeException()
        {
            var incorrectName = "a";

            Assert.Throws<ArgumentOutOfRangeException>(() => new Student(studentFirstName, incorrectName, studentGrade));
        }

        [Test]
        public void PassingTooLongFirstName_ExpectArgumentOutOfRangeException()
        {
            var incorrectName = new String('a', 35);

            Assert.Throws<ArgumentOutOfRangeException>(() => new Student(incorrectName, studentLastName, studentGrade));
        }

        [Test]
        public void PassingTooLongLastName_ExpectArgumentOutOfRangeException()
        {
            var incorrectName = new String('a', 35);

            Assert.Throws<ArgumentOutOfRangeException>(() => new Student(studentFirstName, incorrectName, studentGrade));
        }

        [Test]
        public void AddMark_CorrectValue_ExpectValidMarkToBeAdded()
        {
            var testStudent = new Student(studentFirstName, studentLastName, studentGrade);
            var testMarkValue = 3.2f;
            var testMarkSubject = Subject.Programming;
            var testMark = new Mark(testMarkValue, testMarkSubject);

            testStudent.AddMark(testMark);

            Assert.AreEqual(testStudent.Marks[testStudent.Marks.Count - 1].Value, testMarkValue);
            Assert.AreEqual(testStudent.Marks[testStudent.Marks.Count - 1].Subject, testMarkSubject);
        }

        [Test]
        public void AddMark_AddingMoreThan20Marks_ExpectOverFlowException()
        {
            var testStudent = new Student(studentFirstName, studentLastName, studentGrade);
            var testMark = new Mark(3.2f, Subject.Programming);

            for (int i = 0; i < 20; i++)
            {
                testStudent.AddMark(testMark);
            }

            Assert.Throws<OverflowException>(() => testStudent.AddMark(testMark));
        }
        
        [Test]
        public void ListMarks_NoMarksAdded_ExpectCorrectMessage()
        {
            var testStudent = new Student(studentFirstName, studentLastName, studentGrade);
            var expectedMessage = "This student has no marks.";

            Assert.AreEqual(testStudent.ListMarks(), expectedMessage);
        }

        [Test]
        public void ListMarks_CorrectlyAddedMarks_ExpectCorrectOutput()
        {
            var testStudent = new Student(studentFirstName, studentLastName, studentGrade);
            var testMarkOne = new Mark(5.1f, Subject.Bulgarian);
            var testMarkTwo = new Mark(3.4f, Subject.Math);
            var expectedOutput = "The student has these marks:\n" +
                "Bulgarian => 5.1\n" +
                "Math => 3.4\n";

            testStudent.AddMark(testMarkOne);
            testStudent.AddMark(testMarkTwo);

            Assert.AreEqual(testStudent.ListMarks(), expectedOutput);
        }
    }
}
