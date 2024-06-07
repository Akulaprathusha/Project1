using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        Logging logging1;
        public Person(Logging logging)
        {

            logging1 = logging;
        }

        public void LogM()
        {
            logging1.Log($"{Id},{Name}");
        }
    }
}
