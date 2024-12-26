using Ges_Commandes.Model;
using Ges_Commandes.Models;
using Microsoft.EntityFrameworkCore;

namespace Ges_Commandes.Database
{

public class ApplicationDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Commande> Commandes { get; set; }
    public DbSet<Produit> Produits { get; set; }
    public DbSet<Paiement> Paiements { get; set; }
    public DbSet<Livraison> Livraisons { get; set; }
    public DbSet<Facture> Factures { get; set; }
    

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public static ApplicationDbContext Create(DbContextOptions<ApplicationDbContext> options)
{
    return new ApplicationDbContext(options);
}

}

    
}