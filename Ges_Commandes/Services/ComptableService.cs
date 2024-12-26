using Ges_Commandes.Database;
using Ges_Commandes.Model;
using Ges_Commandes.Models;

namespace Ges_Commandes.Services 
{
    public interface IComptableService
{
    Facture GenererFacture(int commandeId);
    List<Paiement> GetHistoriquePaiements();
}

public class ComptableService : IComptableService
{
    private readonly ApplicationDbContext _dbContext;

    public ComptableService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Facture GenererFacture(int commandeId)
    {
        var commande = _dbContext.Commandes.Find(commandeId);
        var facture = new Facture
        {
            CommandeId = commandeId,
            Montant = commande.Montant,
            Date = DateTime.Now
        };
        _dbContext.Factures.Add(facture);
        _dbContext.SaveChanges();
        return facture;
    }

    public List<Paiement> GetHistoriquePaiements()
    {
        return _dbContext.Paiements.ToList();
    }
}

}