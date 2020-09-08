using System.Collections.Generic;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using Web.Utilities.Mvc.Foundation;

namespace thenew.Web.Controllers.newsrc
{
	public class studyController: CommonController<thenew.Entities.newsrc.study,thenew.Services.Interfaces.newsrc.IstudyService,thenew.Web.Models.newsrc.studyModel>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "newsrc/study";
		}
		
		protected override List<thenew.Entities.newsrc.study> GetPagerData(Pager pager)
		{
			return this.Service.SelectAllWithReferenceData(this.Service.SelectAll(pager));
		}
		
		protected override List<thenew.Entities.newsrc.study> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<thenew.Entities.newsrc.study> lists = this.Service.SelectBy(pagerSearchModel.Pager,new thenew.Entities.newsrc.study { Name = pagerSearchModel.Name }, study => study.Name.Contains(pagerSearchModel.Name));
			return this.Service.SelectAllWithReferenceData(lists);
		}
		
		protected override thenew.Entities.newsrc.study GetEntity(int id)
		{
			return this.Service.SelectById(new thenew.Entities.newsrc.study { Id = id }, true);
		}
		
		protected override void LoadViewReferenceData(thenew.Web.Models.newsrc.studyModel model)
		{
			if (model == null) return;
			base.LoadViewReferenceData(model);
			
			thenew.Services.Interfaces.Inewsrc.Student1Service studentService = ServiceFactory.Instance.GetService <thenew.Services.Interfaces.Inewsrc.Student1Service> ();
			model.students = studentService.SelectAll();
			thenew.Services.Interfaces.Inewsrc.courseService courseService = ServiceFactory.Instance.GetService <thenew.Services.Interfaces.Inewsrc.courseService> ();
			model.courses = courseService.SelectAll();
		}
	}
}
