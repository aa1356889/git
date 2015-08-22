using Endity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class PersonBLL:IBLL.IPersonBLL
    {
       IDAL.IPersonDAL dal = null;
       public PersonBLL(IDAL.IPersonDAL dal)
       {
           this.dal = dal;
       }
        public List<Person> GetPerson()
        {
            return dal.GetPerson();
        }
    }
}
