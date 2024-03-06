using FrontEnd.Models;
using System.Collections.Generic;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IDistritosHelper
    {
        List<DistritosViewModel> GetDistritos();
        DistritosViewModel GetDistritos(int id);
        DistritosViewModel AddDistritos(DistritosViewModel distrito);
        DistritosViewModel GetAll();
    }
}
