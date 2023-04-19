using System.ComponentModel.DataAnnotations;

namespace MyFirstDemo.Api.Models.RegionDto
{
    public class UpdateRegionRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "code has to be minimum of 3 character")]
        [MaxLength(3, ErrorMessage = "code has to be maximum of 3 character")]
        public string Code { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "max length cannot exceed 100 charater")]
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
