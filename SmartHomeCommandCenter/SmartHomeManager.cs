using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeCommandCenter
{
    internal class SmartHomeManager
    {
        public readonly Stack<ICommand> history = new();

        public void ExecuteCommant(ICommand command)
        {
            command.Execute();
            history.Push(command);
        }
        public void Undo()
        {
            if (history.Count > 0)
            {
                var tmp = history.Pop();
                tmp.Undo();
            }
            else Console.WriteLine("Nothing to undo");
        }
    }
}
