using Ges_Commandes.Models;

namespace Ges_Commandes.Model 
{
    public class Facture
{
    public int Id { get; set; }
    public int CommandeId { get; set; }
    public Commande Commande { get; set; }
    public decimal Montant { get; set; }
    public DateTime Date { get; set; }
}

}