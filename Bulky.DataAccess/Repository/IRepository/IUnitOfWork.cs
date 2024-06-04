using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepositoty Category { get; }
        IProductRepository Products { get; }
        ICompanyRepositoty Company { get; }
        void Save();
    }
}
