using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Moq;
using User_Albums.Business;
using User_Albums.Controllers;
using User_Albums.Models;
using Xunit;

namespace User_Albums.UnitTest
{
    public class UserAlbumControllerTest
    {
        [Fact]
        public async Task Index_ReturnsViewResult_WithAListOfUsers()
        {
            //Arrange
            var moqUserService = new Mock<IUserAlbumService>();
            moqUserService.Setup(repo => repo.GetAllUsers()).Returns(Task.FromResult(GetTestUsers()));
            var controller=new UserAlbumController(moqUserService.Object);
            
            //Act
            var result = await controller.Index();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IList<User>>(
                viewResult.Model);
            Assert.Equal(viewResult.ViewName,"Index");
            Assert.Equal(3, model.Count());
        }

        [Fact]
        public async Task ViewAlbums_ReturnsViewResult_WithUserAlbums()
        {
            //Arrange
            var moqUserService = new Mock<IUserAlbumService>();
            moqUserService.Setup(repo => repo.GetUserAlbums(1)).Returns(Task.FromResult(GetTestUserAlbums()));
            var controller = new UserAlbumController(moqUserService.Object);

            //Act
            var result = await controller.ViewAlbums(1);

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IList<Album>>(
                viewResult.Model);
            Assert.Equal(viewResult.ViewName, "ViewAlbums");
            Assert.Equal(3, model.Count());
        }

        [Fact]
        public async Task ViewAlbumsPhotos_ReturnsViewResult_WithAlbumPhotos()
        {
            //Arrange
            var moqUserService = new Mock<IUserAlbumService>();
            moqUserService.Setup(repo => repo.GetAlbumPhotos(1)).Returns(Task.FromResult(GetTestAlbumPhotos()));
            var controller = new UserAlbumController(moqUserService.Object);

            //Act
            var result = await controller.ViewAlbumPhotos(1);

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IList<Photos>>(
                viewResult.Model);
            Assert.Equal(viewResult.ViewName, "ViewAlbumPhotos");
            Assert.Equal(3, model.Count());
        }


        private IList<User> GetTestUsers()
        {
            var users = new List<User>
            {
                new User
                {
                    Email = "Sincere@april.biz",
                    Id = 1,
                    Name = "Leanne Graham",
                    UserName = "Bret"
                },
                new User
                {
                    Email = "Shanna@melissa.tv",
                    Id = 2,
                    Name = "Ervin Howell",
                    UserName = "Antonette"
                },
                new User
                {
                    Email = "Nathan@yesenia.net",
                    Id = 3,
                    Name = "Clementine Bauch",
                    UserName = "Samantha"
                }

            };
            return users;
        }

        private IList<Album> GetTestUserAlbums()
        {
            var userAlbums = new List<Album>
            {
                new Album
                {
                    Id = 1,
                    Title = "quidem molestiae enim"
                },
                new Album
                {
                    Id = 2,
                    Title = "quidem molestiae enim"
                },
                new Album
                {
                    Id = 3,
                    Title = "omnis laborum odio"
                }

            };
            return userAlbums;
        }

        private IList<Photos> GetTestAlbumPhotos()
        {
            var albumPhotos = new List<Photos>
            {
                new Photos
                {
                    Id = 1,
                    Title = "accusamus beatae ad facilis cum similique qui sunt",
                    Url = "http://placehold.it/600/92c952",
                    ThumbnailUrl = "http://placehold.it/150/92c952"
                },
                new Photos
                {
                    Id = 2,
                    Title = "reprehenderit est deserunt velit ipsam",
                    Url = "http://placehold.it/600/771796",
                    ThumbnailUrl = "http://placehold.it/150/771796"
                },
                new Photos
                {
                    Id = 3,
                    Title = "officia porro iure quia iusto qui ipsa ut modi",
                    Url = "http://placehold.it/600/24f355",
                    ThumbnailUrl = "http://placehold.it/150/24f355"
                }
            };
            return albumPhotos;
        }
    }

}
