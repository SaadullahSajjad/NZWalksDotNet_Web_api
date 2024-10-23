using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.DTO
{
    public class UpdateRegionRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Code had to be minimum of 3 characters long")]
        [MaxLength(3, ErrorMessage = "Code had to be maximum of 3 characters long")]
        public string Code { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Name has to be maximum of 3 characters long")]
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
        /*public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }*/
    }
}
