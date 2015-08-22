using Endity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class PersonDAL:IDAL.IPersonDAL
    {
        public List<Person> GetPerson()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Name = "小明", Age = 12, Sex = true });
            persons.Add(new Person() { Name = "小杰", Age = 12, Sex = true });
            return persons;
        }
    }
}
