using SOA_PFE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace SOA_PFE.Exposition
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "AdministrationService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez AdministrationService.svc ou AdministrationService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class AdministrationService : IAdministrationService
    {

        UtilisateurService userService = new UtilisateurService();

        public bool CreateUser(User u)
        {
            bool success = userService.createUser(u.Username, u.Password);

            return success;
        }
    }
}
