using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieDownloaderApp.Contracts
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetOne(object id);
        Task<bool> Create(T model);
        Task<bool> Update(object id, T model);
        Task<bool> Delete(object id);
    }
}
