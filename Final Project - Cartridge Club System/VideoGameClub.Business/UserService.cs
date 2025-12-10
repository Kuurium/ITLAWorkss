using VideoGameClub.Data;
using VideoGameClub.Entities;

namespace VideoGameClub.Business
{
    public class UserService
    {
        private readonly UserRepository _repository = new UserRepository();

        public bool Login(string username, string password)
        {
            return _repository.ValidateUser(username, password);
        }

        public void Register(string username, string password)
        {
            var newUser = new User { Username = username, Password = password };
            _repository.RegisterUser(newUser);
        }
    }
}