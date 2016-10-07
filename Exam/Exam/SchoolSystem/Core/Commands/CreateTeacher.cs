namespace SchoolSystem.Core.Commands
{
    using System.Collections.Generic;
    using Contracts;
    using Enumerations;
    using Models;

    internal class CreateTeacher : ICommand
    {
        private static int id = 0;

        public string Execute(IList<string> parameters)
        {
            Engine.Teachers.Add(id, new Teacher(parameters[0], parameters[1], (Subject)int.Parse(parameters[2])));
            return string.Format(
                "A new teacher with name {0} {1}, subject {2} and ID {3} was created.",
                parameters[0],
                parameters[1],
                (Subject)int.Parse(parameters[2]),
                id++);
        }
    }
}
