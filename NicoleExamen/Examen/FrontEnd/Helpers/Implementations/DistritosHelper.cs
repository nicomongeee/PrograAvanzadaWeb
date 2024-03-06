using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using FrontEnd.ApiModels;
using Newtonsoft.Json;
using BackEnd.Models;
using Entities.Entities;

namespace FrontEnd.Helpers.Implementations
{
    public class DistritosHelper : IDistritosHelper
    {
        IServiceRepository ServiceRepository;

        public DistritosHelper(IServiceRepository serviceRepository)
        {
            ServiceRepository = serviceRepository;
        }

        public DistritosViewModel AddDistritos(DistritosViewModel distrito)
        {
            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/distritos",
                                                                                Convertir(distrito));
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
            }
            return distrito;
        }

        private object Convertir(DistritosViewModel distrito)
        {
            throw new NotImplementedException();
        }

        DistritosModel Convertir(Distrito distritos)
        {
            return new DistritosModel
            {
                DistritoId = distritos.DistritoId,
                Nombre = distritos.Nombre
            };
        }

        Distrito Convertir(DistritosModel distritos)
        {
            return new Distrito
            {
                DistritoId = distritos.DistritoId,
                Nombre = distritos.Nombre
            };
        }


        public DistritosViewModel GetAll()
        {
            throw new NotImplementedException();
        }

        public List<DistritosViewModel> GetDistritos()
        {
            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/distritos");
            List<Distritos> distritos = new List<Distritos>();
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                distritos = JsonConvert.DeserializeObject<List<Distritos>>(content);
            }
            List<DistritosViewModel> lista = new List<DistritosViewModel>();
            if (distritos != null && distritos.Count > 0)
            {
                foreach (var item in distritos)
                {
                    lista.Add(Convertir(item));
                }
            }
            return lista;
        }

        public DistritosViewModel GetDistritos(int id)
        {
            DistritosViewModel distritos = new DistritosViewModel();
            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/distritos/" 
                + id.ToString());
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                distritos = Convertir(JsonConvert.DeserializeObject<Distritos>(content));
            }
            return distritos;
        }

        private DistritosViewModel Convertir(Distritos distritos)
        {
            throw new NotImplementedException();
        }
    }
}
