using Operations.Interfaces;

namespace Operations.Classes
{
    public class Person : IBase
    {
        public int Identifier { get; set; }
        public int Id => Identifier;
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
