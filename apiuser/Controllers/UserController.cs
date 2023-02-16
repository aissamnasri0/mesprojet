using Microsoft.AspNetCore.Mvc;

namespace apiuser.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class UserController : ControllerBase
{


    public UserContext _Context;
    public Repository<User> _repository;
    public UserController(UserContext context)
    {
        _repository = new Repository<User>(context);
        _Context = context;
        // _Context.users.Add(new User("aissam", "nasri", "aissamnasri@gmail.com"));
        // _Context.users.Add(new User("chris", "loiser", "chrisloiser@gmail.com"));
        // _Context.users.Add(new User("jean", "julien", "jeanjulien@gmail.com"));
        // _Context.SaveChanges();




    }

    [HttpGet]
    public List<User> Get()
    {
        return _Context.users.ToList();
    }
    [HttpGet]
    [Route("{id}")]
    public User Get(int id)
    {
        return _repository.read(id);
    }
    [HttpPost]
    public List<User> post([FromBody] User userpost)
    {
        _repository.add(userpost);
        return _Context.users.ToList();
    }
    [HttpPut]
    [Route("{id}")]
    public List<User> put(int id, User nouvauUser)
    {
        var user = _repository.read(id);
        user.FirstName = nouvauUser.FirstName;
        user.LastName = nouvauUser.LastName;
        user.Email = nouvauUser.Email;
        _repository.update(id);
        return _Context.users.ToList();
    }
    [HttpDelete]
    [Route("{id}")]
    public List<User> delete(int id)
    {
        _repository.delete(id);
        return _Context.users.ToList();
    }
}
