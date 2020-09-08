using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Web.Utilities.Mvc.Foundation;

namespace thenew.Web.Models.newsrc
{
	public class Student1Model: CommonModel<thenew.Entities.newsrc.Student1>
	{
		
		public override void PopulateFrom(thenew.Entities.newsrc.Student1 entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
			this.StudentNUM = entity.StudentNUM;
			this.StudentName = entity.StudentName;
		}
		
		public override void PopulateTo(thenew.Entities.newsrc.Student1 entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
			entity.StudentNUM = this.StudentNUM;
			entity.StudentName = this.StudentName;
		}
	}
}
