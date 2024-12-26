using Microsoft.AspNetCore.Mvc;
using Ges_Commandes.Models;
using Ges_Commandes.Services;

namespace Ges_Commandes.Controllers
{
    public class ComptableController : Controller
    {
        private readonly IPaiementService _paiementService;

        public ComptableController(IPaiementService paiementService)
        {
            _paiementService = paiementService;
        }

        // Affiche l'historique des paiements
        public IActionResult Historique()
        {
            var paiements = _paiementService.GetPaiements();
            return View(paiements);
        }
    }
}
