using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using thenew.Entities.newsrc;

namespace thenew.Services.Interfaces.newsrc
{
	public interface IstudyService: IPagingService<thenew.Entities.newsrc.study>
	{
	    List<thenew.Entities.newsrc.study> SelectAllWithReferenceData(List<thenew.Entities.newsrc.study> items);
	}
}
