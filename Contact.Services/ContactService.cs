using Contact.Infrastructure;
using Contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int Id)
        {
            return new ContactDTO()
            {
                FirsName = "Recep",
                LastName = "Çelimli",
                Id = Id
            };
        }
    }
}
