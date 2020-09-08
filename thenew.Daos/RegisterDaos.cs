using System;
using MetaShare.Common.Core.Daos;
/*add customized code between this region*/
/*add customized code between this region*/

namespace thenew.Daos
{
	public class RegisterDaos
	{
		public static void RegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, true,sqlDialect,sqlDialectVersion);
		}
		
		public static void UnRegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, false,sqlDialect,sqlDialectVersion);
		}
		
		public static void Register(DaoFactory factory, bool isRegister, Type sqlDialect, Type sqlDialectVersion)
		{
			factory.Register(typeof(thenew.Daos.Interfaces.newsrc.IstudyDao), new thenew.Daos.newsrc.studyDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(thenew.Daos.Interfaces.newsrc.IStudent1Dao), new thenew.Daos.newsrc.Student1Dao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(thenew.Daos.Interfaces.newsrc.IcourseDao), new thenew.Daos.newsrc.courseDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
