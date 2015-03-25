using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOA_PFE
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class QueueService : IQueueService
    {
        static List<Queue> listQueue;
        public string getLastMessage()
        {
            Queue lastMsg = listQueue.Last();
            listQueue.Remove(listQueue.Last());

            return lastMsg.Message;
        }

        public string setMessage(String Message)
        {
            if (listQueue == null)
            {
                listQueue = new List<Queue>();
            }
            Queue message = new Queue(Message);
            listQueue.Add(message);

            if (listQueue.Last() == message)
            {
                return "message ajouté à la file !";
            }
            else
            {
                return "le message n'a pas été ajouté à la file.";
            }
        }
    }
}
