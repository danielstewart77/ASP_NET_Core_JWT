using System.ComponentModel.DataAnnotations;

namespace JwtWebApiTutorial.Models
{
	public class User
	{
		[Key]
		public Guid Id { get; set; }
		public string Username { get; set; } = string.Empty;
		public byte[] PasswordHash { get; set; }
		public byte[] PasswordSalt { get; set; }
		public string RefreshToken { get; set; } = string.Empty;
		public DateTime TokenCreated { get; set; }
		public DateTime TokenExpires { get; set; }
	}
}
