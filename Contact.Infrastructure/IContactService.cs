using Contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Infrastructure
{
    public interface IContactService
    {
        public ContactDTO GetContactById(int Id);
    }
}
