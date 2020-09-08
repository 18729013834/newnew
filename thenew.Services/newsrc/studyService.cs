using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using thenew.Entities.newsrc;
using thenew.Services.Interfaces.newsrc;
using thenew.Daos.Interfaces.newsrc;

namespace thenew.Services.newsrc
{
	public class studyService:Service<thenew.Entities.newsrc.study>,IstudyService
	{
		public studyService() : base(typeof(IstudyDao))
		{
		}
		public List<study> SelectAllWithReferenceData(List<study> items)                {                    if (items != null && items.Count > 0)                    {                        return this.SelectBy(items, this.CreateReferenceInfoAggregation());                    }                    return items;                }
		
		private ServiceAggregationInfo CreateReferenceInfoAggregation()
		{
		    ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(thenew.Entities.newsrc.study),typeof(thenew.Daos.Interfaces.newsrc.IstudyDao));
		
		    aggregation.AddReferenceChild("course",typeof(thenew.Entities.newsrc.course),typeof(thenew.Daos.Interfaces.newsrc.IcourseDao));
		    aggregation.AddReferenceChild("student",typeof(thenew.Entities.newsrc.Student1),typeof(thenew.Daos.Interfaces.newsrc.IStudent1Dao));
		    return aggregation;
		}
	}
}
