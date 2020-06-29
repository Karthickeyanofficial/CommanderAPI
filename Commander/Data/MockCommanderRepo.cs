using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Model;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id=1,HowTo="Boil",Line="boil",Platform="Windows"},
                new Command { Id=2,HowTo="Cut Bread",Line="cutbread",Platform="Windows"},
                new Command { Id=3,HowTo="Make cup of tea",Line="maketea",Platform="Windows"}

            };
            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command { Id=1,HowTo="Boil",Line="boil",Platform="Windows"};
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
