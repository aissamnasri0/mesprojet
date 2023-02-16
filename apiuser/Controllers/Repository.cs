using Microsoft.EntityFrameworkCore;

namespace apiuser.Controllers;
    public class Repository<T> where T : class
    {
        private UserContext _ApiContext;
        internal DbSet<T> _dbSet;

        public Repository(UserContext ApiContext)
        {
            this._ApiContext = ApiContext;
            System.Console.WriteLine("repository created");
            _dbSet = _ApiContext.Set<T>();

        }
        public void add(T item)
        {
         
                    _ApiContext.Add<T>(item);
                    _ApiContext.SaveChanges();
                    

               
        }
        public T read(int id)
        {
            return _ApiContext.Find<T>(id);
        }
        public void delete(int id)
        {
           
                    _ApiContext.Remove<T>(read(id));
                    _ApiContext.SaveChanges();
                    
                

        }
        public void update(int id)
        {
           
                    _ApiContext.SaveChanges();
        }        
    }
