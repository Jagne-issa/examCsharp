using Microsoft.AspNetCore.Mvc;
using Ges_Commandes.Models;
using Ges_Commandes.Services;

namespace Ges_Commandes.Controllers
{
    public class RSController : Controller
    {
        private readonly IProduitService _produitService;

        public RSController(IProduitService produitService)
        {
            _produitService = produitService;
        }

        // Affiche la liste des produits
        public IActionResult ListeProduits()
        {
            var produits = _produitService.GetAllProduits();
            return View(produits);
        }

        // Affiche le formulaire pour créer un nouveau produit
        public IActionResult Create()
        {
            return View();
        }

        // Enregistre un produit
        [HttpPost]
        public IActionResult Create(Produit produit)
        {
            if (ModelState.IsValid)
            {
                _produitService.AddProduit(produit);
                return RedirectToAction("ListeProduits");
            }
            return View(produit);
        }

        // Affiche le formulaire pour modifier un produit
        public IActionResult Edit(int id)
        {
            var produit = _produitService.GetProduitById(id);
            if (produit == null)
            {
                return NotFound();
            }
            return View(produit);
        }

        // Modifie un produit
        [HttpPost]
        public IActionResult Edit(Produit produit)
        {
            if (ModelState.IsValid)
            {
                _produitService.UpdateProduit(produit);
                return RedirectToAction("ListeProduits");
            }
            return View(produit);
        }

        // Supprime un produit
        public IActionResult Delete(int id)
        {
            var produit = _produitService.GetProduitById(id);
            if (produit == null)
            {
                return NotFound();
            }
            _produitService.DeleteProduit(id);
            return RedirectToAction("ListeProduits");
        }
    }
}
