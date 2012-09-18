using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public class ContractUser 
	{


		[DataMember(Name = "subtotal", IsRequired=false)]
		public float Subtotal { get; set; }


		[DataMember(Name = "items", IsRequired=false)]
		public Podio.API.Utils.JSONVariableData[] Items { get; set; }


	}
}

