using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOA_PFE
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IQueueService
    {
        [OperationContract]
        string getLastMessage();

        [OperationContract]
        string setMessage(String Message);

    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class Queue
    {
        String message = "";

        [DataMember]
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public Queue(String msg)
        {
            this.message = msg;
        }
    }
}
