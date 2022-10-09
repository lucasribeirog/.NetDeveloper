using EcommerceAPI.Domain.Enumerators;

namespace EcommerceAPI.Application.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public EnumsEcommerce.UserStatus Status { get; set; }
        public string Address { get; set; }
    }
}