using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW4
{
    public class HWLINQ
    {
        public void Linq()
        {
            var contacts = new List<Contact>()
            {
                new Contact { Name = "Sergei", Phone = 654654, DateOfBirth = "15.03.1993" },
                new Contact { Name = "oleg", Phone = 6546, DateOfBirth = "18.09.1995" },
                new Contact { Name = "Sveta", Phone = 699994, DateOfBirth = "21.08.1997" },
                new Contact { Name = "Alex", Phone = 99495, DateOfBirth = "08.12.2000" },
                new Contact { Name = "Max", Phone = 99999, DateOfBirth = "30.05.1999" }
            };
            var loD = contacts.Where(w => w.Name.ToUpper().StartsWith("S")).LastOrDefault(o => o.Phone.ToString().StartsWith("6"));
            var foD = contacts.Where(w => w.Name.ToUpper().StartsWith("M")).FirstOrDefault();
            var rez = contacts.Where(w => w.Name.ToUpper().StartsWith("I")).OrderBy(o => o);
            var sel = contacts.Where(m => m.Name.ToUpper().StartsWith("M")).Select(o => new Contact() { Name = "Valera", Phone = 65464, DateOfBirth = "99595" });
            var rev = contacts.Where(m => m.Name.ToUpper().StartsWith("S")).Reverse();
            var coun = contacts.Where(m => m.Name.ToUpper().StartsWith("M")).Count();
        }
    }
}