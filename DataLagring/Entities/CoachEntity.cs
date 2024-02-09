using System.ComponentModel.DataAnnotations;


namespace DataLagring.Entities
{
    internal class CoachEntity
    {
        [Key]
        public int Id { get; set; }

        public string CoachName { get; set; } = null!;

    }
}
