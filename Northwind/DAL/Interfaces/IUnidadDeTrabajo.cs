using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnidadDeTrabajo : IDisposable
    {
        IShippersDAL _shippersDAL { get; }
        ISupplierDAL _supplierDAL { get; }  
        bool Complete();
    }
}
