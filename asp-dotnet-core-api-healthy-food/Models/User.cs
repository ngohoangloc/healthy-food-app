namespace asp_dotnet_core_api_healthy_food.Models
{
    public class UserDto
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public class User : UserDto
    {
        public Guid id { get; set; }
    }
}
