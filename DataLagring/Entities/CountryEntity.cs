using System.ComponentModel.DataAnnotations;

namespace DataLagring.Entities
{
    internal class CountryEntity
    {
        [Key]
        public int Id { get; set; } 
         
        public string CountryName { get; set; } = null!;

    }
}
