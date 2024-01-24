using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ShippersDALImpl : DALGenerioImpl<Shippers>, IShippersDAL
    {
        NorthwindContext _context;

        public ShippersDALImpl(NorthwindContext context): base(context)
        {
            _context = context;
        }
    }   
}
