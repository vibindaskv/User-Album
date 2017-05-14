using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Albums.Utilities
{
    public interface IHttpUtility
    {
        Task<T> GetData<T>(string baseUrl, T listType);
    }
}
