using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace User_Albums.Utilities
{
    public static class Constants
    {
        public const string UsersListApi = "https://jsonplaceholder.typicode.com/users";
        public const string AlbumsListApi = "https://jsonplaceholder.typicode.com/albums?userId=";
        public const string PhotosListApi = "https://jsonplaceholder.typicode.com/photos?albumId=";
    }
}