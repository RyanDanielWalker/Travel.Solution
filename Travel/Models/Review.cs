using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Travel.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    [Required]
    public int Rating { get; set; }
    [Required]
    public string Description { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    // public virtual Location Location { get; set; }

    // public int LocationId { get; set; }
  }
}