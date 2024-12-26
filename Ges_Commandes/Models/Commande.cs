namespace Ges_Commandes.Models
{

public class Commande
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Montant { get; set; }
    public string Etat { get; set; } // En attente, Validée, Livrée
    public int ClientId { get; set; }
    public Client Client { get; set; }
}

}