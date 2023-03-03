using eTickets.Data;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public string MovieID { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public double MoviePrice { get; set; }
        public string MovieImageURL { get; set; }
        public DateTime MovieStartDate { get; set; }
        public DateTime MovieEndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}
