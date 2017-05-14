using System.Collections.Generic;
using System.Threading.Tasks;
using User_Albums.Models;

namespace User_Albums.Business
{
    public interface IUserAlbumService
    {
        Task<IList<User>> GetAllUsers();
        Task<IList<Album>> GetUserAlbums(int Id);
        Task<IList<Photos>> GetAlbumPhotos(int Id);
    }
}
