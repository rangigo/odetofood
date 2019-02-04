namespace OdeToFood.Services
{
    using Microsoft.Extensions.Configuration;

    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private readonly IConfiguration _configuration;

        public Greeter(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
    
        public string GetMessageOfTheDay()
        { 
            return _configuration["Greeting"];
        }
    }
}