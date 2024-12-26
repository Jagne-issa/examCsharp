namespace Ges_Commandes.Models
{
    public class Produit
{
    public int Id { get; set; }
    public string Libelle { get; set; }
    public int QuantiteStock { get; set; }
    public decimal PrixUnitaire { get; set; }
    public int QuantiteSeuil { get; set; }
}

}