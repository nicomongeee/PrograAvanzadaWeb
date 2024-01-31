using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IShippersHelper
    {

        List<ShippersViewModel> GetShippers();
        ShippersViewModel GetShippers(int id);
        ShippersViewModel AddShippers(ShippersViewModel shippers);
        ShippersViewModel UpdateShippers(ShippersViewModel shippers);
        ShippersViewModel DeleteShippers(int id);
        ShippersViewModel GetAll();

    }
}
