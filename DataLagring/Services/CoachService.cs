using DataLagring.Entities;
using DataLagring.Repositories;



namespace DataLagring.Services
{
    internal class CoachService
    {
        private readonly CoachRepository _coachRepository;

        public CoachService(CoachRepository coachRepository)
        {
            _coachRepository = coachRepository;

        }

        public CoachEntity CreateCoach(string coachName)
        {
            var coachEntity = _coachRepository.Get(x => x.CoachName == coachName);
            coachEntity ??= _coachRepository.Create(new CoachEntity { CoachName = coachName });

            return coachEntity;
        }

        public CoachEntity GetCoachByCoachName(string coachName)
        {
            var coachEntity = _coachRepository.Get(x => x.CoachName == coachName);
            return coachEntity;

        }

        public IEnumerable<CoachEntity>GetCoaches()
        {
            var coaches = _coachRepository.GetAll();
            return coaches;
        }

        public CoachEntity UpdateCoach(CoachEntity coachEntity)
        {
            var updatedCoachEntity = _coachRepository.Update(x => x.Id == coachEntity.Id, coachEntity);
            return updatedCoachEntity;
        }

        public void DeleteCoach(int id)
        {
            _coachRepository.Delete(x => x.Id == id);
        }
    }
}
