namespace apiuser;
public class Produit{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double prix { get; set; }
    [System.Text.Json.Serialization.JsonIgnore]
    public virtual User? User { get; set; }
    public int IdUserNavigator { get; set; }
    public Produit(string name, string description, double prix,int iduser){
     this.Name = name;
     this.Description = description;
     this.prix = prix;
     this.Id=0;
     this.IdUserNavigator=iduser;
    }
    public Produit(){}
}