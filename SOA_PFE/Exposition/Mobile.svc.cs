using core_queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOA_PFE.DAO.datasets;
using SOA_PFE.DAO.datasets.messagesTableAdapters;
using SOA_PFE.Services;
namespace SOA_PFE.Exposition
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Mobile" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Mobile.svc ou Mobile.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Mobile : IMobile
    {
        public string pushMessage(Message Message)
        {
            sender sender = new sender();
            MessageDaoService msgDaoService = new MessageDaoService();
            String messageString = msgDaoService.convertMessageForQueu(Message);

            sender.Sender(messageString, "Admin");
            var creation = msgDaoService.creerMessage(Message);
            
            if(creation)
            {
                return "Ok";
            }
            else
            {
                return "Problème dans la création du message.";
            }
        }

        public string getLastMessage()
        {
            return "cette fonctionnalité n'est pas implémentée";
        }
    }
}
