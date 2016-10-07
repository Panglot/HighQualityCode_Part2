namespace SchoolSystemTests
{
    using NUnit.Framework;
    using SchoolSystem.Enumerations;
    using SchoolSystem.Models;
    using System;

    [TestFixture]
    public class TeacherTests
    {
        // Correct teacher values
        string teacherFirstName = "Ivan";
        string teacherLastName = "Ivanov";
        Subject teacherSubject = Subject.Bulgarian;

        [Test]
        public void PassingCorrectParametersToConstructor_ExpectObjectToBeCorrectlyCreated()
        {  
            var testTeacher = new Teacher(teacherFirstName, teacherLastName, teacherSubject);

            Assert.AreEqual(teacherFirstName, testTeacher.FirstName);
            Assert.AreEqual(teacherLastName, testTeacher.LastName);
            Assert.AreEqual(teacherSubject, testTeacher.Subject);
        }
        
        [Test]
        public void PassingNullParametersToConstructor_ExpectNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(()=> new Teacher(null, null, teacherSubject) );
        }

        [Test]
        public void PassingTooShortFirstName_ExpectArgumentOutOfRangeException()
        {
            var incorrectName = "a";

            Assert.Throws<ArgumentOutOfRangeException>(() => new Teacher(incorrectName, teacherLastName, teacherSubject));
        }

        [Test]
        public void PassingTooShortSecondName_ExpectArgumentOutOfRangeException()
        {
            var incorrectName = "a";

            Assert.Throws<ArgumentOutOfRangeException>(() => new Teacher(teacherFirstName, incorrectName, teacherSubject));
        }

        [Test]
        public void PassingTooLongFirstName_ExpectArgumentOutOfRangeException()
        {
            var incorrectName = new String('a', 35);

            Assert.Throws<ArgumentOutOfRangeException>(() => new Teacher(incorrectName, teacherLastName, teacherSubject));
        }

        [Test]
        public void PassingTooLongLastName_ExpectArgumentOutOfRangeException()
        {
            var incorrectName = new String('a', 35);

            Assert.Throws<ArgumentOutOfRangeException>(() => new Teacher(teacherFirstName, incorrectName, teacherSubject));
        }

        [Test]
        public void AddingMarkToStudent_ExpectCorrectMarkToBeAdded()
        {
            var testStudent = new Student("Kiro", "Kirov", Grade.Fourth);
            var testTeacher = new Teacher(teacherFirstName, teacherLastName, teacherSubject);
            var testMark = 4.6f;

            testTeacher.AddMark(testStudent, testMark);

            Assert.AreEqual(testStudent.Marks[testStudent.Marks.Count-1].Value, testMark);
            Assert.AreEqual(testStudent.Marks[testStudent.Marks.Count-1].Subject, testTeacher.Subject);
        }

    }
}
