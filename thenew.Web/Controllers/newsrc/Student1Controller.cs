using System.Collections.Generic;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using Web.Utilities.Mvc.Foundation;

namespace thenew.Web.Controllers.newsrc
{
	public class Student1Controller: CommonController<thenew.Entities.newsrc.Student1,thenew.Services.Interfaces.newsrc.IStudent1Service,thenew.Web.Models.newsrc.Student1Model>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "newsrc/Student1";
		}
		
		protected override List<thenew.Entities.newsrc.Student1> GetPagerData(Pager pager)
		{
			return this.Service.SelectAllWithReferenceData(this.Service.SelectAll(pager));
		}
		
		protected override List<thenew.Entities.newsrc.Student1> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<thenew.Entities.newsrc.Student1> lists = this.Service.SelectBy(pagerSearchModel.Pager,new thenew.Entities.newsrc.Student1 { Name = pagerSearchModel.Name }, Student1 => Student1.Name.Contains(pagerSearchModel.Name));
			return this.Service.SelectAllWithReferenceData(lists);
		}
		
		protected override thenew.Entities.newsrc.Student1 GetEntity(int id)
		{
			return this.Service.SelectById(new thenew.Entities.newsrc.Student1 { Id = id }, true);
		}
		
		protected override void LoadViewReferenceData(thenew.Web.Models.newsrc.Student1Model model)
		{
			if (model == null) return;
			base.LoadViewReferenceData(model);
			
		}
	}
}
