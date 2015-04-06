using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOA_PFE.Exposition
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IAdministrationService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IAdministrationService
    {
        [OperationContract]
        bool CreateUser(User u);
        bool EnvoyerMessage(String idUserToSend, String Message);
    }

    [DataContract]
    public class User
    {
        String username = "";
        String password = "";

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


    }
}
