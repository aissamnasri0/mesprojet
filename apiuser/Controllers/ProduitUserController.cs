using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apiuser.Controllers;
[Authorize]
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class ProduitUserController : ControllerBase
{


    public UserContext _Context;
    public ProduitUserController(UserContext context)
    {
        _Context = context;


    }
  
    
    [HttpGet]
    [Route("{id}")]
    public List<Produit> Get(int id)
    {
        return _Context.produits.Where(p=>p.IdUserNavigator==id).ToList();
    }
}