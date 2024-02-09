using DataLagring.Entities;
using DataLagring.Repositories;

namespace DataLagring.Services
{
    internal class CountryService
    {
        private readonly CountryRepository _countryRepository;

        public CountryService(CountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public CountryEntity CreateCountry(string countryName)
        {
            var CountryEntity = _countryRepository.Get(x => x.CountryName == countryName);
            CountryEntity ??= _countryRepository.Create(new CountryEntity { CountryName = countryName });

            return CountryEntity;
        }

        public CountryEntity GetCountryByCountryName(string countryName)
        {
            var CountryEntity = _countryRepository.Get(x => x.CountryName == countryName);
            return CountryEntity;

        }

        public IEnumerable<CountryEntity> GetAllCountries()
        {
            var countries = _countryRepository.GetAll();
            return countries;
        }

        public CountryEntity UpdateCountry(CountryEntity countryEntity)
        {
            var updatedCountryEntity = _countryRepository.Update(x => x.Id == countryEntity.Id, countryEntity);
            return updatedCountryEntity;
        }

        public void DeleteCountry(int id)
        {
            _countryRepository.Delete(x => x.Id == id);
        }

    }
}
