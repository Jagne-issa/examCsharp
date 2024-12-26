using Ges_Commandes.Database;
using Ges_Commandes.Models;

namespace Ges_Commandes.Services
{

public class RSService : IRSService
{
    private readonly ApplicationDbContext _dbContext;

    public RSService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AjouterProduit(Produit produit)
    {
        _dbContext.Produits.Add(produit);
        _dbContext.SaveChanges();
    }

    public void MettreAJourProduit(Produit produit)
{
    var existingProduit = _dbContext.Produits.FirstOrDefault(p => p.Id == produit.Id);
    if (existingProduit != null)
    {
        existingProduit.Libelle = produit.Libelle;
        existingProduit.QuantiteStock = produit.QuantiteStock;
        existingProduit.PrixUnitaire = produit.PrixUnitaire;
        existingProduit.QuantiteSeuil = produit.QuantiteSeuil;

        _dbContext.SaveChanges();
    }
    else
    {
        throw new Exception("Produit introuvable !");
    }
}


    public void PlanifierLivraison(Livraison livraison)
    {
        _dbContext.Livraisons.Add(livraison);
        _dbContext.SaveChanges();
    }
}

}