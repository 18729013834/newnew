using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using thenew.Entities.newsrc;

namespace thenew.Services.Interfaces.newsrc
{
	public interface IcourseService: IPagingService<thenew.Entities.newsrc.course>
	{
	    List<thenew.Entities.newsrc.course> SelectAllWithReferenceData(List<thenew.Entities.newsrc.course> items);
	}
}
