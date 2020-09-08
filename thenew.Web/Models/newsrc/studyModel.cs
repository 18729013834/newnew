using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Web.Utilities.Mvc.Foundation;

namespace thenew.Web.Models.newsrc
{
	public class studyModel: CommonModel<thenew.Entities.newsrc.study>
	{
		public  thenew.Entities.newsrc.Student1 student { get; set; }
		public List<thenew.Entities.newsrc.Student1> students { get; set; }
		public  thenew.Entities.newsrc.course course { get; set; }
		public List<thenew.Entities.newsrc.course> courses { get; set; }
		
		public override void PopulateFrom(thenew.Entities.newsrc.study entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
			this.course = entity.course;
			this.student = entity.student;
		}
		
		public override void PopulateTo(thenew.Entities.newsrc.study entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
			entity.course = this.course;
			entity.student = this.student;
		}
	}
}
