using Ges_Commandes.Database;
using Ges_Commandes.Models;

namespace Ges_Commandes.Services
{
public class ClientService : IClientService
{
    private readonly ApplicationDbContext _dbContext;

    public ClientService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void CreerCommande(Commande commande)
    {
        _dbContext.Commandes.Add(commande);
        _dbContext.SaveChanges();
    }

    public List<Commande> GetCommandesByClient(int clientId)
    {
        return _dbContext.Commandes.Where(c => c.ClientId == clientId).ToList();
    }

    public void AjouterPaiement(Paiement paiement)
    {
        _dbContext.Paiements.Add(paiement);
        _dbContext.SaveChanges();
    }

        public string? GetCommandes()
        {
            throw new NotImplementedException();
        }

        public string? GetCommandeById(int id)
        {
            throw new NotImplementedException();
        }

        public void EnregistrerPaiement(Paiement paiement)
        {
            throw new NotImplementedException();
        }
    }

}