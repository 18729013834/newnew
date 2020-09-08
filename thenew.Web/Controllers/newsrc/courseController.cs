using System.Collections.Generic;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using Web.Utilities.Mvc.Foundation;

namespace thenew.Web.Controllers.newsrc
{
	public class courseController: CommonController<thenew.Entities.newsrc.course,thenew.Services.Interfaces.newsrc.IcourseService,thenew.Web.Models.newsrc.courseModel>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "newsrc/course";
		}
		
		protected override List<thenew.Entities.newsrc.course> GetPagerData(Pager pager)
		{
			return this.Service.SelectAllWithReferenceData(this.Service.SelectAll(pager));
		}
		
		protected override List<thenew.Entities.newsrc.course> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<thenew.Entities.newsrc.course> lists = this.Service.SelectBy(pagerSearchModel.Pager,new thenew.Entities.newsrc.course { Name = pagerSearchModel.Name }, course => course.Name.Contains(pagerSearchModel.Name));
			return this.Service.SelectAllWithReferenceData(lists);
		}
		
		protected override thenew.Entities.newsrc.course GetEntity(int id)
		{
			return this.Service.SelectById(new thenew.Entities.newsrc.course { Id = id }, true);
		}
		
		protected override void LoadViewReferenceData(thenew.Web.Models.newsrc.courseModel model)
		{
			if (model == null) return;
			base.LoadViewReferenceData(model);
			
		}
	}
}
