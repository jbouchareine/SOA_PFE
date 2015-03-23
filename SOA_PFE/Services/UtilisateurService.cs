using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOA_PFE.Services
{
    public class UtilisateurService
    {
        public bool createUser (String userName, String password)
        {
            SOA_User newUser = new SOA_User();
            newUser.password = password;
            newUser.username = userName;

            Model1 model = new Model1();

            model.SOA_User.Add(newUser);
            model.SaveChanges();
            
            return true;
        }
    }
}