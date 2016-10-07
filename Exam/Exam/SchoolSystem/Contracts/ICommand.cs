namespace SchoolSystem.Contracts
{
    using System.Collections.Generic;

    /// <summary>
    /// The class is a command and can be executed
    /// </summary>
    internal interface ICommand
    {
        /// <summary>
        /// Executes the command
        /// </summary>
        /// <param name="parameters">List of smaller commands</param>
        /// <returns>Report as string after the command is done</returns>
        string Execute(IList<string> parameters);
    }
}
