using MudBlazor.Entities;

    public class UserService : IUserService
    {
        private readonly MyDbContext _db;

        public UserService(MyDbContext db)
        {
            _db = db;
        }

        public void DeleteUser(int id)
        {
            var usertoDelete = _db.Users.FirstOrDefault(x => x.Id == id);
            if (usertoDelete!= null)
            {
                _db.Users.Remove(usertoDelete);
                _db.SaveChanges();
            }
        }

        public User GetUserById(int id)
        {
            var user = _db.Users.SingleOrDefault(x => x.Id == id);
            return user;
        }

        public List<User> GetUsers()
        {
            return _db.Users.ToList();
        }

        public void SaveUser(User user)
        {
            if (user.Id == 0) _db.Users.Add(user);
            else _db.Users.Update(user);
            _db.SaveChanges();
        }

       
    }