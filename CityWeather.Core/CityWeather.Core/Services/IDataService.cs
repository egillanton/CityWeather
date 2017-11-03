using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CityWeather.Core.Services
{
    interface IDataService
    {
        Task<JContainer> GetDataFromService(string queryString);
    }
}
