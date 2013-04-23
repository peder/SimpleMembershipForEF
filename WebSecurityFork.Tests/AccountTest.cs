using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebMatrix.WebData;

namespace WebSecurityFork.Tests
{
	[TestClass]
	public class Account
	{
		[TestClass]
		public class Create
		{
			[TestInitialize]
			public void Init()
			{
				if (!WebMatrix.WebData.WebSecurity.Initialized)
					WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection("DefaultConnectionMDF",
						"UserProfile", "UserId", "UserName", autoCreateTables: true);
			}

			[TestMethod]
			public void CanCreateAccount()
			{
				var simpleMembershipProvider = new SimpleMembershipProvider();

				simpleMembershipProvider.CreateAccount("Test1", "notAPassword1");
			}

			[TestMethod]
			public void CanDeleteAccount()
			{
				var simpleMembershipProvider = new SimpleMembershipProvider();

				simpleMembershipProvider.DeleteAccount("Test1");
			}
		}
	}
}