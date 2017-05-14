using System.Collections.Generic;
using System.Threading.Tasks;
using User_Albums.Models;
using User_Albums.Utilities;

namespace User_Albums.Business
{
    public class UserAlbumService : IUserAlbumService
    {
        private readonly IHttpUtility _httpUtility;
        public UserAlbumService(IHttpUtility httpUtility)
        {
            _httpUtility = httpUtility;
        }
        public async Task<IList<User>> GetAllUsers()
        {
            return await _httpUtility.GetData(Constants.UsersListApi, new List<User>());
        }
        public async Task<IList<Album>> GetUserAlbums(int Id)
        {
            return await _httpUtility.GetData(Constants.AlbumsListApi + Id, new List<Album>());
        }
        public async Task<IList<Photos>> GetAlbumPhotos(int Id)
        {
            return await _httpUtility.GetData(Constants.PhotosListApi + Id, new List<Photos>());
        }

    }
}