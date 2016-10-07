namespace SchoolSystem.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Contracts;
    using Models;

    public class Engine
    {
        internal static Dictionary<int, Teacher> Teachers { get; set; } = new Dictionary<int, Teacher>();

        internal static Dictionary<int, Student> Students { get; set; } = new Dictionary<int, Student>();

        public void Run()
        {
            while (true)
            {
                try
                {
                    var input = Console.ReadLine();
                    if (input == "End")
                    {
                        break;
                    }

                    var commandName = input.Split(' ')[0];

                    var assembly = this.GetType().GetTypeInfo().Assembly;
                    var typeInfo = assembly.DefinedTypes
                        .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
                        .Where(type => type.Name.ToLower().Contains(commandName.ToLower()))
                        .FirstOrDefault();
                    if (typeInfo == null)
                    {
                        throw new ArgumentException("The passed command is not found!");
                    }

                    var command = Activator.CreateInstance(typeInfo) as ICommand;
                    var parameters = input.Split(' ').ToList();
                    parameters.RemoveAt(0);
                    Console.WriteLine(command.Execute(parameters));
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
