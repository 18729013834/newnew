using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace thenew.Entities.newsrc
{
	public class course : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public string CourseName{get; set;}
		
		[DataMember]
		public int CourseNumber{get; set;}
		
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
