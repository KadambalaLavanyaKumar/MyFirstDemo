using System.ComponentModel.DataAnnotations;

namespace MyFirstDemo.Api.Models.Dto
{
    public class LoginResponseDto
    {
        public string JwtToken { get; set; }
    }
}
