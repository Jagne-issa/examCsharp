using Ges_Commandes.Database;
using Ges_Commandes.Models;

namespace Ges_Commandes.Services
{
public interface IRSService
{
    void AjouterProduit(Produit produit);
    void MettreAJourProduit(Produit produit);
    void PlanifierLivraison(Livraison livraison);
}

}
