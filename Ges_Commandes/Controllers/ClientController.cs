using Microsoft.AspNetCore.Mvc;
using Ges_Commandes.Models;
using Ges_Commandes.Services;

namespace Ges_Commandes.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        // Affiche les commandes du client
        public IActionResult Commandes()
        {
            var commandes = _clientService.GetCommandes();
            return View(commandes);
        }

        // Affiche les détails d'une commande spécifique
        public IActionResult Details(int id)
        {
            var commande = _clientService.GetCommandeById(id);
            if (commande == null)
            {
                return NotFound();
            }
            return View(commande);
        }

        // Affiche le formulaire pour enregistrer un paiement
        public IActionResult PaiementForm()
        {
            return View();
        }

        // Enregistre le paiement
        [HttpPost]
        public IActionResult EnregistrerPaiement(Paiement paiement)
        {
            if (ModelState.IsValid)
            {
                _clientService.EnregistrerPaiement(paiement);
                return RedirectToAction("Commandes");
            }
            return View("PaiementForm");
        }
    }
}

















// using System.Diagnostics;
// using Ges_Commandes.Models;
// using Ges_Commandes.Services;
// using Microsoft.AspNetCore.Mvc;

// namespace Ges_Commandes.Controllers
// {
//     [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
//     public class ClientController : Controller
// {
//     private readonly IClientService _clientService;

//     public ClientController(IClientService clientService)
//     {
//         _clientService = clientService;
//     }

//     public IActionResult CreateCommande()
//     {
//         return View();
//     }

//     [HttpPost]
//         private string GetDebuggerDisplay()
//         {
//             return ToString();
//         }
//         // public IActionResult CreateCommande(Commande commande)
//         // {
//         //     _clientService.CreerCommande(commande);
//         //     return RedirectToAction("Index");
//         // }
//     }

// }