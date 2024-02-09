using System.ComponentModel.DataAnnotations;

namespace DataLagring.Entities
{
    internal class PlayerEntity
    {
        [Key]
        public int Id { get; set; }

        public string PlayerName { get; set; } = null!;

        public string PositionName { get; set; } = null!;
    }
}
