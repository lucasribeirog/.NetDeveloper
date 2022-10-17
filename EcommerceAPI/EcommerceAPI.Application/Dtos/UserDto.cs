using EcommerceAPI.Domain.Enumerators;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Application.Dtos
{
    public class UserDto
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public EnumsEcommerce.UserStatus Status { get; set; }
        public string Address { get; set; }
    }

    public class UserDtoRegister
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public EnumsEcommerce.UserStatus Status { get; set; }

        public string Address { get; set; }
    }

    public class UserDtoDelete
    {
        [Key]
        public int Id { get; set; }
    }
}