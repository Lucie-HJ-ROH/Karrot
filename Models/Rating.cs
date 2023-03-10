using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Karrot.Models;

public class Rating
{
    public int RatingId { get; set; }

    public IdentityUser RatingUser { get; set; }

    public IdentityUser RatedSeller { get; set; }
    
    public int RatingValue { get; set; }
    
    [Display(Name = "Date")]
    public DateTime RatingCreated { get; set; }
}