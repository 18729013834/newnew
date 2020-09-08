using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Web.Utilities.Mvc.Foundation;

namespace thenew.Web.Models.newsrc
{
	public class courseModel: CommonModel<thenew.Entities.newsrc.course>
	{
		
		public override void PopulateFrom(thenew.Entities.newsrc.course entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
			this.CourseName = entity.CourseName;
			this.CourseNumber = entity.CourseNumber;
		}
		
		public override void PopulateTo(thenew.Entities.newsrc.course entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
			entity.CourseName = this.CourseName;
			entity.CourseNumber = this.CourseNumber;
		}
	}
}
