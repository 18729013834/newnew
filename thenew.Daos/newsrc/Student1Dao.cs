using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using thenew.Daos.Interfaces.newsrc;
using thenew.Entities.newsrc;

namespace thenew.Daos.newsrc
{
	public class Student1Dao:CommonObjectDao<thenew.Entities.newsrc.Student1>,thenew.Daos.Interfaces.newsrc.IStudent1Dao
	{
		public class Student1SqlBuilder : ObjectSqlBuilder
		{
			public Student1SqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Student1")
			{
				this.SqlInsert = "INSERT INTO Student1(StudentNUM,StudentName," + this.SqlBaseFieldInsertFront + ") VALUES (@StudentNUM,@StudentName," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE Student1 SET StudentNUM=@StudentNUM,StudentName=@StudentName," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}
		
		public class Student1ResultHandler : CommonObjectResultHandler<thenew.Entities.newsrc.Student1>
		{
			public override void GetColumnValues(IDataReader reader,Student1 item)
			{
				base.GetColumnValues(reader, item);
				int ordinalStudentNUM = reader.GetOrdinal("StudentNUM");
				item.StudentNUM = reader.IsDBNull(ordinalStudentNUM) ? 0 : reader.GetInt32(ordinalStudentNUM);
				int ordinalStudentName = reader.GetOrdinal("StudentName");
				item.StudentName = reader.IsDBNull(ordinalStudentName) ? null : reader.GetString(ordinalStudentName);
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, Student1 item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command,"StudentNUM",item.StudentNUM);
				context.AddParameter(command,"StudentName",item.StudentName ?? (object)DBNull.Value);
			}
		}
		
		public Student1Dao(SqlDialect sqlDialect) : base(new Student1SqlBuilder(sqlDialect), new Student1ResultHandler())
		{
		}
	}
}
