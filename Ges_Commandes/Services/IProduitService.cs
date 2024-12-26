using Ges_Commandes.Models;
using System.Collections.Generic;

namespace Ges_Commandes.Services
{
    public interface IProduitService
    {
        IEnumerable<Produit> GetAllProduits();
        Produit GetProduitById(int id);
        void AddProduit(Produit produit);
        void UpdateProduit(Produit produit);
        void DeleteProduit(int id);
    }
}
