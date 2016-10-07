namespace SchoolSystem.Core.Commands
{
    using System.Collections.Generic;
    using Contracts;
    using Enumerations;
    using Models;

    internal class CreateStudent : Command, ICommand
    {
        private static int id = 0;

        public override string Execute(IList<string> parameters)
        {
            Engine.Students.Add(id, new Student(parameters[0], parameters[1], (Grade)int.Parse(parameters[2])));
            return string.Format(
                "A new student with name {0} {1}, grade {2} and ID {3} was created.",
                parameters[0],
                parameters[1],
                (Grade)int.Parse(parameters[2]),
                id++);
        }
    }
}
