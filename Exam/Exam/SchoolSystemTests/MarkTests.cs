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
    class MarkTests
    {
        [Test]
        public void PassValidParametersToConstructor_ExpectMarkToBeCreatedCorrectly()
        {
            var testMarkValue = 2.9f;
            var testMarkSubject = Subject.Programming;

            var testMark = new Mark(testMarkValue, testMarkSubject);

            Assert.AreEqual(testMark.Value, testMarkValue);
            Assert.AreEqual(testMark.Subject, testMarkSubject);
        }

        [Test]
        public void PassTooSmallGrade_ExpectArgumentException()
        {
            var testMarkValue = 1.2f;
            var testMarkSubject = Subject.Programming;

            Assert.Throws<ArgumentException>(() => new Mark(testMarkValue, testMarkSubject));
        }

        [Test]
        public void PassTooBigGrade_ExpectArgumentException()
        {
            var testMarkValue = 10.9f;
            var testMarkSubject = Subject.Programming;

            Assert.Throws<ArgumentException>(() => new Mark(testMarkValue, testMarkSubject));
        }
    }
}
