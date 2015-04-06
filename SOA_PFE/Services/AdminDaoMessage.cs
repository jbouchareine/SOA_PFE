using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SOA_PFE.DAO.datasets.messagesTableAdapters;
using SOA_PFE.Exposition;
using SOA_PFE.DAO.datasets;

namespace SOA_PFE.Services
{
    public class AdminDaoService
    {
        public bool creerUser(User user){
            var ds = new messages();
            var Ta = new SOA_MessagesTableAdapter();

            var newUser = ds.SOA_User.NewSOA_UserRow();

            newUser.password = user.Password;
            newUser.username = user.Username;

            ds.SOA_User.AddSOA_UserRow(newUser);
            Ta.Update(ds.SOA_Messages);
            ds.AcceptChanges();

            return true;
        }
    }
}