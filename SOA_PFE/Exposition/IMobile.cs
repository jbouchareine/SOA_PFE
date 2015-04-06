using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOA_PFE.Exposition
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IMobile" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IMobile
    {
        [OperationContract]
        string getLastMessage();

        [OperationContract]
        string pushMessage(Message Message);

    }

    [DataContract]
    public class Message
    {
        long longitude;
        long lattitude;
        string msg;
        int idUser;

        [DataMember]
        public long Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        [DataMember]
        public long Lattitude
        {
            get { return lattitude; }
            set { lattitude = value; }
        }
        [DataMember]
        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
        [DataMember]
        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
    }
}
