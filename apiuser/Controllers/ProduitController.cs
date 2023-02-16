using Microsoft.AspNetCore.Mvc;

namespace apiuser.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class ProduitController : ControllerBase
{

    public Repository<Produit> _repository;
    public UserContext _Context;
    public ProduitController(UserContext context)
    {
        _Context = context;
        _repository = new Repository<Produit>(context);
        // _Context.produits.Add(new Produit("tv", "smart tv",500,1));
        // _Context.produits.Add(new Produit("iphone", "14 pro max",1200,2));
        // _Context.produits.Add(new Produit("pc", "dell 500g",2500,3));
        // _Context.SaveChanges();

    }
    [HttpGet]
    public List<Produit> Get()
    {
        return _Context.produits.ToList();
    }
    [HttpGet]
    [Route("{id}")]
    public Produit Get(int id)
    {
        return _repository.read(id);
    }
    [HttpPost]
    public List<Produit> post([FromBody] Produit produit)
    {
        _repository.add(produit);

        return _Context.produits.ToList();
    }
    [HttpPut]
    [Route("{id}")]
    public List<Produit> put(int id, Produit nouvauProduit)
    {
        var pro = _repository.read(id);
        pro.Name = nouvauProduit.Name;
        pro.Description = nouvauProduit.Description;
        pro.prix = nouvauProduit.prix;
        pro.User = nouvauProduit.User;
        _repository.update(id);
        return _Context.produits.ToList();
    }
    [HttpDelete]
    [Route("{id}")]
    public List<Produit> deleteProduit(int id)
    {
        _repository.delete(id);
        return _Context.produits.ToList();
    }

}
