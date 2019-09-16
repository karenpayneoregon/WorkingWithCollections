using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operations.Interfaces;

namespace Operations.Classes
{
    public class Category : IBase
    {
        public int CategoryIdentifier { get; set; }
        public string Name { get; set; }
        public int Id => CategoryIdentifier;
    }
}
