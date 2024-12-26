using Ges_Commandes.Models;
using System.Collections.Generic;

namespace Ges_Commandes.Services
{
    public interface IPaiementService
    {
        IEnumerable<Paiement> GetPaiements();
        void EnregistrerPaiement(Paiement paiement);
    }
}
