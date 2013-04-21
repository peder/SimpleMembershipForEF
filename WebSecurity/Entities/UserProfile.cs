using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebMatrix.WebData.Entities
{
	public class UserProfile
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string FirstName { get; internal set; }
		public string Middle { get; internal set; }
		public string LastName { get; internal set; }
		public string DomainName { get; internal set; }
		public string Title { get; internal set; }
		public string Institution { get; internal set; }
		public string Email { get; internal set; }
	}
}
