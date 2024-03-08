using ServiceContracts;

namespace Services
{
    public class CitiesService : ICitiesService
    {
        private Guid _ServiceInstanceID;
        public Guid ServiceInstanceID
        {
            get
            {
                return _ServiceInstanceID;
            }
        }
        private List<string> _cities;

        public CitiesService()
        {

            _ServiceInstanceID = Guid.NewGuid();
            _cities = new List<string>() {
        "London",
        "Paris",
        "New York",
        "Tokyo",
        "Rome"
            };
        }



        public List<string> GetCities()
        {
            return _cities;
        }

        public List<string> GetCountries()
        {
            throw new NotImplementedException();
        }
    }
}
