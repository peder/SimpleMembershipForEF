using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace WebMatrix.WebData.Entities.Map
{
	public class UserProfileMap : EntityTypeConfiguration<UserProfile>
	{
		public UserProfileMap()
		{
			// Primary Key
			this.HasKey(t => t.UserId);

			// Properties
			// Table & Column Mappings
			this.ToTable("UserProfile");
			this.Property(t => t.UserId).HasColumnName("UserId");
			this.Property(t => t.UserName).HasColumnName("UserName");
			this.Property(t => t.Email).HasColumnName("Email");
			this.Property(t => t.FirstName).HasColumnName("FirstName");
			this.Property(t => t.LastName).HasColumnName("LastName");
			this.Property(t => t.DomainName).HasColumnName("DomainName");
			this.Property(t => t.Middle).HasColumnName("Middle");
			this.Property(t => t.Title).HasColumnName("Title");
			this.Property(t => t.Institution).HasColumnName("Institution");
			this.Property(t => t.FirstName).HasColumnName("FirstName");
		}
	}
}
