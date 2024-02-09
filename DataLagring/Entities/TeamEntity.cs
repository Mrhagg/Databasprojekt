using System.ComponentModel.DataAnnotations;

namespace DataLagring.Entities
{
    internal class TeamEntity
    {
        [Key]
        public int Id { get; set; }

        public string TeamName { get; set; } = null!;

        public string TeamColor { get; set; } = null!; 



        public int PlayerId { get; set; }
        public PlayerEntity Player { get; set; } = null!;

        
        public int CoachId { get; set; }
        public CoachEntity Coach { get; set; } = null!;



        public int StadiumId { get; set; }
        public StadiumEntity Stadium { get; set; } = null!;



        public int CountryId { get; set; }
        public CountryEntity Country { get; set; } = null!;
    }
}
