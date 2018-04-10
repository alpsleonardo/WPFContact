using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFContact.Model
{
    public class Contact
    {
        public int Id { get; set; }
        public int ContactGroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public bool IsDeveloper { get; set; }
        //public Address Address { get; set; }
        //public List<ContactEmail> Emails { get; set; }
    }
}
