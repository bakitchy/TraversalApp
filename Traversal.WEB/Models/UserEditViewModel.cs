﻿namespace Traversal.WEB.Models
{
	public class UserEditViewModel
	{
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public IFormFile Image { get; set; }
    }
}
