// using System.ComponentModel.DataAnnotations;
// using System.Collections.Generic;

// namespace Travel.Models
// {
//   public class Location
//   {
//     public Location()
//     {
//       this.Reviews = new HashSet<Review>();
//     }
//     public int LocationId { get; set; }
//     [Required]
//     public string Country { get; set; }
//     [Required]
//     public string City { get; set; }
//     // [Required]
//     // [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
//     // public int Rating { get; set; }
//     // // [Required]
//     //public string Review { get; set; }
//     public virtual ICollection<Review> Reviews { get; set; }
//   }
// }