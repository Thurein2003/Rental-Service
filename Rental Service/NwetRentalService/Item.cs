
using System;

namespace RentalService
{
	/// <summary>
	/// Description of Item.
	/// </summary>
	public class Item
	{
		int id;
		int categoryid;
		double fees; //one month hire fees
        String itemName;
        String description;
        String avilable;
        
		public Item()
		{
		}
		
		public int Id{
			
			get {
				
				 return id;
			    }
			set
			   {
				id=value;
			    }
		}
		
		public int CategoryId
		{
			get
			{
				return categoryid;
			}
			
			set
			{
				categoryid=value;
			}
			
		}
		
		public double Fees
		{
			get
			{
				return fees;
			}
			
			set
			{
				fees=value;
			}
		}
		
		public String ItemName
		{
			get
			{
				return itemName;
			}
			
			set
			{
				itemName=value;
			}
		}
		
		public String Description
		{
			get
			{
				return description;
			}
			
			set
			{
				description=value;
			}
		}
		
		public String Available
		{
			get
			{
				return avilable;
			}
			
			set
			{
				avilable=value;
			}
		}
		
	}
}
