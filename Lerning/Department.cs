using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lerning
{
    public class Department
    {
        public int Age { get; set; }
        public List<string> Names { get; set; }

        public Department(int Age)
        {
            this.Age = Age;
        }
        public override string ToString()
        {
            return $"Department{this.Age},{string.Join(", ",this.Names)}";
        }
    }
}
