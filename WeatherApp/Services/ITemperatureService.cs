using System.Threading.Tasks;

namespace WeatherApp.ViewModels
{
    public interface ITemperatureService
    {
        Task<TemperatureModel> GetTempAsync();
        void SetLocation(string city);
    }
}