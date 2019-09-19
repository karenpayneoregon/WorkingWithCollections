using System;
using Operations.Interfaces;

namespace Operations.Classes
{
    public class Customer : IBase
    {
        public int Id { get; }
        public int CustomerIdentifier { get; set; }
        public string CompanyName { get; set; }
        public int? ContactIdentifier { get; set; }
        public int? ContactTypeIdentifier { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int? CountryIdentfier { get; set; }
        public string Phone { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? InUse { get; set; }

    }

}
