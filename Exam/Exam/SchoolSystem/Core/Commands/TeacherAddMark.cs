namespace SchoolSystem.Core.Commands
{
    using System.Collections.Generic;
    using Contracts;

    internal class TeacherAddMark : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            var studentId = int.Parse(parameters[0]);
            var teacherId = int.Parse(parameters[1]);

            var student = Engine.Students[teacherId];
            var teacher = Engine.Teachers[studentId];
            teacher.AddMark(student, float.Parse(parameters[2]));
            return string.Format(
                "Teacher {0} {1} added mark {2} to student {3} {4} in {5}.",
                teacher.FirstName,
                teacher.LastName,
                float.Parse(parameters[2]),
                student.FirstName,
                student.LastName,
                teacher.Subject);
        }
    }
}
