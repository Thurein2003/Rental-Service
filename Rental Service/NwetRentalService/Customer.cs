/*
 * Created by SharpDevelop.
 * User: ohnma
 * Date: 02/01/2023
 * Time: 8:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RentalService
{
	/// <summary>
	/// Description of Customer.
	/// </summary>
	public class Customer:Person
	{
		public Customer()
		{
		}
		
		public Boolean Register(Person p)
		{
			//Insert into DB
			return true;
		}
		
		public override Boolean Login(string uname, string upass)
		{
			//Check from DB
			return true;
		}
	}
}
