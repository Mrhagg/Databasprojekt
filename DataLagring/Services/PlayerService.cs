using DataLagring.Entities;
using DataLagring.Repositories;


namespace DataLagring.Services
{
    internal class PlayerService
    {
        private readonly PlayerRepository _playerRepository;

        public PlayerService(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        
        public PlayerEntity CreatePlayer(string playerName, string positionName)
        {
            var playerEntity = _playerRepository.Get(x => x.PlayerName == playerName && x.PositionName == positionName);
            playerEntity ??= _playerRepository.Create(new PlayerEntity { PlayerName = playerName, PositionName = positionName });

            return playerEntity;
        }

        public PlayerEntity GetPlayerById(int id)
        {
            var playerEntity = _playerRepository.Get(x => x.Id == id);
            return playerEntity;

        }

        public IEnumerable<PlayerEntity> GetPlayers()
        {
            var players = _playerRepository.GetAll();
            return players;
        }

        public PlayerEntity UpdatePlayer(PlayerEntity playerEntity)
        {
            var updatedPlayerEntity = _playerRepository.Update(x => x.Id == playerEntity.Id, playerEntity);
            return updatedPlayerEntity;
        }

        public void DeletePlayer(int id)
        {
            _playerRepository.Delete(x => x.Id == id);
        }
    }
}
