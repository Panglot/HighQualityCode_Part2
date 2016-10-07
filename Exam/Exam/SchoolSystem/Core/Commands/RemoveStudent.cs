namespace SchoolSystem.Core.Commands
{
    using System.Collections.Generic;
    using Contracts;

    internal class RemoveStudent : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            Engine.Students.Remove(int.Parse(parameters[0]));
            return string.Format("Student with ID {0} was sucessfully removed.", int.Parse(parameters[0]));
        }
    }
}
