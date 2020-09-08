using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using thenew.Entities.newsrc;
using thenew.Services.Interfaces.newsrc;
using thenew.Daos.Interfaces.newsrc;

namespace thenew.Services.newsrc
{
	public class Student1Service:Service<thenew.Entities.newsrc.Student1>,IStudent1Service
	{
		public Student1Service() : base(typeof(IStudent1Dao))
		{
		}
		public List<Student1> SelectAllWithReferenceData(List<Student1> items)                {                    if (items != null && items.Count > 0)                    {                        return this.SelectBy(items, this.CreateReferenceInfoAggregation());                    }                    return items;                }
		
		private ServiceAggregationInfo CreateReferenceInfoAggregation()
		{
		    ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(thenew.Entities.newsrc.Student1),typeof(thenew.Daos.Interfaces.newsrc.IStudent1Dao));
		
		    return aggregation;
		}
	}
}
