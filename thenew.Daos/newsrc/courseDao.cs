using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using thenew.Daos.Interfaces.newsrc;
using thenew.Entities.newsrc;

namespace thenew.Daos.newsrc
{
	public class courseDao:CommonObjectDao<thenew.Entities.newsrc.course>,thenew.Daos.Interfaces.newsrc.IcourseDao
	{
		public class courseSqlBuilder : ObjectSqlBuilder
		{
			public courseSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"course")
			{
				this.SqlInsert = "INSERT INTO course(CourseName,CourseNumber," + this.SqlBaseFieldInsertFront + ") VALUES (@CourseName,@CourseNumber," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE course SET CourseName=@CourseName,CourseNumber=@CourseNumber," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}
		
		public class courseResultHandler : CommonObjectResultHandler<thenew.Entities.newsrc.course>
		{
			public override void GetColumnValues(IDataReader reader,course item)
			{
				base.GetColumnValues(reader, item);
				int ordinalCourseName = reader.GetOrdinal("CourseName");
				item.CourseName = reader.IsDBNull(ordinalCourseName) ? null : reader.GetString(ordinalCourseName);
				int ordinalCourseNumber = reader.GetOrdinal("CourseNumber");
				item.CourseNumber = reader.IsDBNull(ordinalCourseNumber) ? 0 : reader.GetInt32(ordinalCourseNumber);
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, course item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command,"CourseName",item.CourseName ?? (object)DBNull.Value);
				context.AddParameter(command,"CourseNumber",item.CourseNumber);
			}
		}
		
		public courseDao(SqlDialect sqlDialect) : base(new courseSqlBuilder(sqlDialect), new courseResultHandler())
		{
		}
	}
}
