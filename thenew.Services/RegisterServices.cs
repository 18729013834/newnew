using MetaShare.Common.Core.CommonService;
/*add customized code between this region*/
/*add customized code between this region*/

namespace thenew.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}
		
		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}
		
		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(thenew.Services.Interfaces.newsrc.IStudent1Service), new thenew.Services.newsrc.Student1Service(), isRegister);
			factory.Register(typeof(thenew.Services.Interfaces.newsrc.IcourseService), new thenew.Services.newsrc.courseService(), isRegister);
			factory.Register(typeof(thenew.Services.Interfaces.newsrc.IstudyService), new thenew.Services.newsrc.studyService(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
