using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Entities
{
    public class contacts
    {
        public Guid id { get; set; }
        public string cName { get; set; }
        public string cSurname { get; set; }
        public string numberI { get; set; }
        public string numberII { get; set; }
        public string numberIII { get; set; }
        public string emailAdress { get; set; }
        public string webAdress { get; set; }
        public string adress { get; set; }
        public string info { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1}",cName,cSurname);
        }
    }
}
