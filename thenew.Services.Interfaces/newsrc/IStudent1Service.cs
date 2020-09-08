using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using thenew.Entities.newsrc;

namespace thenew.Services.Interfaces.newsrc
{
	public interface IStudent1Service: IPagingService<thenew.Entities.newsrc.Student1>
	{
	    List<thenew.Entities.newsrc.Student1> SelectAllWithReferenceData(List<thenew.Entities.newsrc.Student1> items);
	}
}
