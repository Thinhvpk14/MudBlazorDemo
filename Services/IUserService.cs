using MudBlazor.Entities;

    public interface IUserService
    {
        List<User> GetUsers();
        User GetUserById(int id);
        void SaveUser(User user);
        void DeleteUser(int id);
    }
