using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace FrontEnd.Helpers.Implementations
{
    public class ShippersHelper : IShippersHelper
    {
        IServiceRepository ServiceRepository;

        public ShippersHelper(IServiceRepository serviceRepository)
        {
            ServiceRepository = serviceRepository;
        }

        public ShippersViewModel AddShippers(ShippersViewModel shippers)
        {
            throw new NotImplementedException();
        }

        ShippersViewModel Convertir(Shippers shippers)
        {
            return new ShippersViewModel
            {
                ShipperId = shippers.ShipperId,
                CompanyName = shippers.CompanyName,
                Phone = shippers.Phone
            };
        }
        Shippers Convertir(ShippersViewModel shippers)
        {
            return new Shippers
            {
                ShipperId = shippers.ShipperId,
                CompanyName = shippers.CompanyName,
                Phone = shippers.Phone
            };
        }

        public ShippersViewModel DeleteShippers(int id)
        {
            throw new NotImplementedException();
        }

        public ShippersViewModel GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ShippersViewModel> GetShippers()
        {
            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/shippers");
            List<Shippers> resultado = new List<Shippers>();
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                resultado = JsonConvert.DeserializeObject<List<Shippers>>(content);
            }
            List<ShippersViewModel> lista = new List<ShippersViewModel>();
            if (resultado != null && resultado.Count > 0)
            {
                foreach (var item in resultado)
                {
                    lista.Add(Convertir(item));
                }
            }
            return lista;

        }

        public ShippersViewModel GetShippers(int id)
        {
            throw new NotImplementedException();
        }

        public ShippersViewModel UpdateShippers(ShippersViewModel shippers)
        {
            throw new NotImplementedException();
        }
    }
}
