using System.Threading.Tasks;
using System.Web.Mvc;
using User_Albums.Business;

namespace User_Albums.Controllers
{
    public class UserAlbumController : Controller
    {
        private readonly IUserAlbumService _albumService ;
        public UserAlbumController(IUserAlbumService albumService)
        {
            _albumService = albumService;
        }
        public async Task <ActionResult> Index()
        {
            var service =  _albumService.GetAllUsers();
            var users = await service;
            return View("Index", users);
        }
        public async Task<ActionResult> ViewAlbums(int Id)
        {
            var service =  _albumService.GetUserAlbums(Id);
            var albums = await service;
            return View("ViewAlbums", albums);
        }
        public async Task<ActionResult> ViewAlbumPhotos(int Id)
        {
            var service = _albumService.GetAlbumPhotos(Id);
            var photos = await service;
            return View("ViewAlbumPhotos", photos);
        }

    }
}