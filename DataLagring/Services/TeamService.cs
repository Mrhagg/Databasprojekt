

using DataLagring.Entities;
using DataLagring.Repositories;

namespace DataLagring.Services
{
    internal class TeamService
    {
        private readonly TeamRepository _teamRepository;
        private readonly PlayerService _playerService;
        private readonly CoachService _coachService;
        private readonly StadiumService _stadiumService;
        private readonly CountryService _countryService;    

        public TeamService(TeamRepository teamRepository, PlayerService playerService, CoachService coachService, StadiumService stadiumService, CountryService countryService)
        {
            _teamRepository = teamRepository;
            _playerService = playerService;
            _coachService = coachService;
            _stadiumService = stadiumService;
            _countryService = countryService;   
            
        }


        public TeamEntity CreateTeam(string teamName, string teamColor, string playerName, string positionName, string coachName, string countryName, string stadiumName)
        {
            var playerEntity = _playerService.CreatePlayer(playerName, positionName);
            var coachEntity = _coachService.CreateCoach(coachName);
            var countryEntity = _countryService.CreateCountry(countryName);
            var stadiumEntity = _stadiumService.CreateStadium(stadiumName);
            

            var teamEntity = new TeamEntity
            {
                TeamName = teamName,
                TeamColor = teamColor,
                PlayerId = playerEntity.Id,
                CoachId = coachEntity.Id,
                CountryId = countryEntity.Id,
                StadiumId = stadiumEntity.Id
            }; 

            teamEntity =  _teamRepository.Create(teamEntity);
            return teamEntity;


        }

        public TeamEntity GetTeamById(int id)
        {
            var TeamEntity = _teamRepository.Get(x => x.Id == id);
            return TeamEntity;
        }

        public IEnumerable<TeamEntity> GetTeams()
        {
            var teams = _teamRepository.GetAll();
            return teams;
        }

        public TeamEntity UpdateTeam(TeamEntity teamEntity)
        {
            var updatedTeamEntity = _teamRepository.Update(x => x.Id == teamEntity.Id, teamEntity);
            return updatedTeamEntity;
        }

        public void DeleteTeam(int id)
        {
            _teamRepository.Delete(x => x.Id == id);
        }

    }
}
