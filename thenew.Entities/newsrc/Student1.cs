using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
Public string Name {get;set;}
/*add customized code between this region*/

namespace thenew.Entities.newsrc
{
	public class Student1 : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public int StudentNUM{get; set;}
		
		[DataMember]
		public string StudentName{get; set;}
		
		/*add customized code between this region*/
		<add key="mqttUserName" value="admin"/>
		/*add customized code between this region*/
	}
}
