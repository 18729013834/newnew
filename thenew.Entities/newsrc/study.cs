using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace thenew.Entities.newsrc
{
	public class study : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public thenew.Entities.newsrc.course course{get; set;}
		
		[DataMember]
		public thenew.Entities.newsrc.Student1 student{get; set;}
		
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
