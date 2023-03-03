using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaID { get; set; }
        public string CinemaLogo { get; set; }
        public string CinemaName { get; set; }
        public string CinemaDescription { get; set; }

        // Relationships
        public List<Movie> Movies { get; set; }
    }
}
