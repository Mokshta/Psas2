using Moksh.PSAS.Common;
using Moksh.PSAS.DataAdapter.EDMX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moksh.PSAS.DataAdapter.Repository
{
    public class PeopleRepository
    {


        /// <summary>
        /// Method to check n get the userID, if user exists in database
        /// </summary>
        /// <param name="userLoginData"></param>
        /// <returns></returns>
        public LoginModel GetUserByDetails(string userEmail,string password)
        {
            LoginModel retVal= null;

            // Create a context object to access the database
            PSAS_DBEntities psas_dbContextObj = new PSAS_DBEntities();
            //{
                // access the entity to check if the user exists of not
                people_master people = psas_dbContextObj.people_master.Where(x => x.EmployeeEmailID == userEmail && x.Password == password).FirstOrDefault();

                if (people != null)
                {
                    retVal = new LoginModel();
                    retVal.Email = people.EmployeeEmailID;
                    retVal.Password = people.Password;
                    retVal.PeopleID = people.peopleid;
                }
            //}
                

            return retVal;
        }
    }
}
