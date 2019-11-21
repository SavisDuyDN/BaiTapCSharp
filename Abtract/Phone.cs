using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract
{
    public abstract class Phone
    {
        public abstract void InsertPhone(string name, string phone);
        public abstract void UpdatePhone(string name, string newPhone);
        public abstract void DeletePhone(string name);
        public abstract void SearchPhone(string name);

    }
}
