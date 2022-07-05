using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Models
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public string FirsName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirsName} {LastName}";


    }
}
