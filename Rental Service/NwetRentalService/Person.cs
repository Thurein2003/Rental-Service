
using System;

namespace RentalService
{
	/// <summary>
	/// Description of Person.
	/// </summary>
	public class Person
	{
		String name;
		String address;
		String email;
		String phone;
		String username;
		String password;
		
		
		public Person()
		{
		}
		
		public String Name{
			
			get
			{
				return name;
			}
			
			set
			{
				name=value;
			}
		}
		
		public String Address
		{
			
			get
			{
				return address;
			}
			set
			{
				address=value;
			}
		}
		public String Email{
			
			get
			{
				return email;
			}
			set
			{
				email=value;
				
			}
		}
		
		public String Phone
		{
			get
			{
				return phone;
				
			}
			set
			{
				phone=value;
			}
		}
		
		public String UserName
		{
			get
			{
				return username;
			}
			
			set
			{
				username=value;
			}
		}
		
		public String Password
		{
			get
			{
				return password;
			}
			set
			{
				password=value;
			}
		}
		
		public virtual Boolean Login(string uname, string upass)
		{
			if (uname==this.username && upass==this.password) return true;
			else return false;
		}
	}
}
