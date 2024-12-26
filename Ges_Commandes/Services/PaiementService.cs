using Ges_Commandes.Database;
using Ges_Commandes.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ges_Commandes.Services
{
    public class PaiementService : IPaiementService
    {
        private readonly ApplicationDbContext _context;

        public PaiementService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Paiement> GetPaiements()
        {
            return _context.Paiements.ToList();
        }

        public void EnregistrerPaiement(Paiement paiement)
        {
            _context.Paiements.Add(paiement);
            _context.SaveChanges();
        }

        // string? IPaiementService.GetPaiements()
        // {
        //     throw new NotImplementedException();
        // }
    }

}
