using DataLagring.Entities;
using DataLagring.Repositories;

namespace DataLagring.Services
{
    internal class StadiumService
    {
        private readonly StadiumRepository _stadiumRepository;

        public StadiumService(StadiumRepository stadiumRepository)
        {
            _stadiumRepository = stadiumRepository;
        }

     
        public StadiumEntity CreateStadium (string stadiumName)
        {
            var stadiumEntity = _stadiumRepository.Get(x => x.StadiumName == stadiumName);
            stadiumEntity ??= _stadiumRepository.Create(new StadiumEntity { StadiumName = stadiumName });

            return stadiumEntity;
        }

        public StadiumEntity GetStadiumByStadiumName(string stadiumName)
        {
            var stadiumEntity = _stadiumRepository.Get(x => x.StadiumName == stadiumName);
            return stadiumEntity;

        }

        public IEnumerable<StadiumEntity> GetAllStadiums()
        {
            var coaches = _stadiumRepository.GetAll();
            return coaches;
        }

        public StadiumEntity UpdateStadium(StadiumEntity stadiumEntity)
        {
            var updatedStadiumEntity = _stadiumRepository.Update(x => x.Id == stadiumEntity.Id, stadiumEntity);
            return updatedStadiumEntity;
        }

        public void DeleteStadium(int id)
        {
            _stadiumRepository.Delete(x => x.Id == id);
        }
    }
}
