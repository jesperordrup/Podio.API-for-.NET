using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public class OrganizationMember 
	{


		[DataMember(Name = "profile", IsRequired=false)]
		public Podio.API.Utils.JSONVariableData Profile { get; set; }


		[DataMember(Name = "admin", IsRequired=false)]
		public bool Admin { get; set; }


		[DataMember(Name = "employee", IsRequired=false)]
		public bool Employee { get; set; }


		[DataMember(Name = "space_memberships", IsRequired=false)]
		public int? SpaceMemberships { get; set; }


		[DataMember(Name = "user", IsRequired=false)]
		public User User { get; set; }


		[DataMember(Name = "contact", IsRequired=false)]
		public Contact Contact { get; set; }


	}
}

