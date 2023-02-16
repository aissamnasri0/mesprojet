namespace apiuser;

public class User
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    [System.Text.Json.Serialization.JsonIgnore]
    public virtual ICollection<Produit> produit { get; set; }
    public User(string lastName, string firstName, string email, string password)
    {
        this.Id = 0;
        this.LastName = lastName;
        this.FirstName = firstName;
        this.Email = email;
        this.Password = password;
    }
    public User() { 
        this.Id = 0;
        this.LastName ="";
        this.FirstName ="";
        this.Email = "";
        this.Password = "";

    }

}
