using Ges_Commandes.Database;
using Ges_Commandes.Models;

namespace Ges_Commandes.Services
{

public interface IClientService
{
    void CreerCommande(Commande commande);
    List<Commande> GetCommandesByClient(int clientId);
    void AjouterPaiement(Paiement paiement);
        string? GetCommandes();
        string? GetCommandeById(int id);
        void EnregistrerPaiement(Paiement paiement);
        // void CreerCommande(Commande commande);
    }


}

