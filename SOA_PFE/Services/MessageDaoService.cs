using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SOA_PFE.DAO.datasets.messagesTableAdapters;
using SOA_PFE.Exposition;
using SOA_PFE.DAO.datasets;

namespace SOA_PFE.Services
{
    public class MessageDaoService
    {
        public bool creerMessage(Message message){
            var ds = new messages();
            var Ta = new SOA_MessagesTableAdapter();

            var newMsg = ds.SOA_Messages.NewSOA_MessagesRow();

            newMsg.lattitude = message.Lattitude;
            newMsg.longitute = message.Longitude;
            newMsg.msg = message.Msg;
            newMsg.idUser = message.IdUser;

            ds.SOA_Messages.AddSOA_MessagesRow(newMsg);
            Ta.Update(ds.SOA_Messages);
            ds.AcceptChanges();

            return true;
        }

        public string convertMessageForQueu(Message message)
        {
            return String.Format("user = {0}; message : {1}; longitude = {2}; lattitude = {3};",
                message.IdUser,
                message.Msg,
                message.Longitude,
                message.Lattitude);
        }
    }
}