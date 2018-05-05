using Moksh.PSAS.Common;
using Moksh.PSAS.DataAdapter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moksh.PSAS.Bussiness.Managers
{
    public class PeopleManager
    {
        public int CheckNGetUserID(string userEmailID, string password)
        {
            int retVal = 0; //what is retVal
            PeopleRepository peopleObj = new PeopleRepository();
            LoginModel loginObj= peopleObj.GetUserByDetails(userEmailID, password);

            if(loginObj!=null)
            {
                retVal = loginObj.PeopleID;
            }

            return retVal;

        }
    }
}
