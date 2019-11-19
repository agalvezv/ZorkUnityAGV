using System;
using System.Collections.Generic;
using System.Text;
using Zork.Common;

namespace Zork.Game
{
    class ConsoleOutputService : IOutputService
    {
        //special note, when Paul showed us how to make this class, he had us click on ctrl . or click to bulb to the left and clicked on implement which added all below.
        //Commented out to 

        public void Clear()
        {
            Console.Clear();
            /*throw new NotImplementedException();*/
        }

        public void Write(string value)
        {
            //throw new NotImplementedException();
            Console.Write(value);
        }

        public void Write(object value)
        {
            //throw new NotImplementedException();
            Write(value.ToString());
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
            //throw new NotImplementedException();
        }

        public void WriteLine(object value)
        {
            WriteLine(value.ToString());
           // throw new NotImplementedException();
        }
    }
}
