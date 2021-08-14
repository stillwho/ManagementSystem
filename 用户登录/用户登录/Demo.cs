using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace 用户登录
{
	class Demo
	{
		public SqlConnection Connection()
		{
			string str = "Data Source=HUNAGLIFANG;Initial Catalog=Demo;Integrated Security=True";
			SqlConnection sc = new SqlConnection(str);
			sc.Open();//打开数据库的连接；
			return sc;
		}
		public SqlCommand command(string sql)
		{
			SqlCommand sc = new SqlCommand(sql, Connection());
			return sc;
		}
		//用于delete updata insert 返回受影响的行数
		public int Excute(string sql)
		{
			return command(sql).ExecuteNonQuery();
		}
		//用于select 返回SqlDataReader对象，包含select的数据
		public SqlDataReader reader(string sql)
		{
			return command(sql).ExecuteReader();
		}
	}
}

