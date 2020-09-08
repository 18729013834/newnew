using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using thenew.Entities.newsrc;
using thenew.Services.Interfaces.newsrc;
using thenew.Daos.Interfaces.newsrc;

namespace thenew.Services.newsrc
{
	public class courseService:Service<thenew.Entities.newsrc.course>,IcourseService
	{
		public courseService() : base(typeof(IcourseDao))
		{
		}
		public List<course> SelectAllWithReferenceData(List<course> items)                {                    if (items != null && items.Count > 0)                    {                        return this.SelectBy(items, this.CreateReferenceInfoAggregation());                    }                    return items;                }
		
		private ServiceAggregationInfo CreateReferenceInfoAggregation()
		{
		    ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(thenew.Entities.newsrc.course),typeof(thenew.Daos.Interfaces.newsrc.IcourseDao));
		
		    return aggregation;
		}
	}
}
