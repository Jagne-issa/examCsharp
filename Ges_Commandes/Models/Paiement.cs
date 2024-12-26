namespace Ges_Commandes.Models
 {
    public class Paiement
{
    public int Id { get; set; }
    public string Type { get; set; } // OM, Wave, Chèque, etc.
    public decimal Montant { get; set; }
    public string Reference { get; set; }
    public DateTime Date { get; set; }
}

}