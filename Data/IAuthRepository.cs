using System.Threading.Tasks;
using DatingApp.API.Models;

//interface(?)
namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        //reg
        //log
        //does user exist
        Task<User> Register (User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);

    }
}