using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using thenew.Daos.Interfaces.newsrc;
using thenew.Entities.newsrc;

namespace thenew.Daos.newsrc
{
	public class studyDao:CommonObjectDao<thenew.Entities.newsrc.study>,thenew.Daos.Interfaces.newsrc.IstudyDao
	{
		public class studySqlBuilder : ObjectSqlBuilder
		{
			public studySqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"study")
			{
				this.SqlInsert = "INSERT INTO study(courseid,studentid," + this.SqlBaseFieldInsertFront + ") VALUES (@courseid,@studentid," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE study SET courseid=@courseid,studentid=@studentid," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}
		
		public class studyResultHandler : CommonObjectResultHandler<thenew.Entities.newsrc.study>
		{
			public override void GetColumnValues(IDataReader reader,study item)
			{
				base.GetColumnValues(reader, item);
				int ordinalcourse = reader.GetOrdinal("courseId");
				item.course = reader.IsDBNull(ordinalcourse) ?null : reader.GetInt32(ordinalcourse) == 0?null:new thenew.Entities.newsrc.course{ Id=reader.GetInt32(ordinalcourse)};
				int ordinalstudent = reader.GetOrdinal("studentId");
				item.student = reader.IsDBNull(ordinalstudent) ?null : reader.GetInt32(ordinalstudent) == 0?null:new thenew.Entities.newsrc.Student1{ Id=reader.GetInt32(ordinalstudent)};
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, study item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command,"courseid",item.course== null? (object) DBNull.Value:item.course.Id);
				context.AddParameter(command,"studentid",item.student== null? (object) DBNull.Value:item.student.Id);
			}
		}
		
		public studyDao(SqlDialect sqlDialect) : base(new studySqlBuilder(sqlDialect), new studyResultHandler())
		{
		}
	}
}
