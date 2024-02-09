
using System.ComponentModel.DataAnnotations;

namespace DataLagring.Entities
{
    internal class StadiumEntity
    {
        [Key]
        public int Id { get; set; }

        public string StadiumName { get; set; } = null!;

    }
}
