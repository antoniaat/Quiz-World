using System;

namespace Quiz_MDI_Application.Models
{
    public class User
    {
        public string Username { get; set; }
        public UserRole Role { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
    }
}
