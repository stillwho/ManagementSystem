using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 用户登录
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
			toolStripStatusLabel2.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
			timer1.Start();
			Table();
		}
		public void Table()
		{
			dataGridView1.Rows.Clear();
			string sql = "select * from UserTable";
			Demo demo = new Demo();
			IDataReader dr = demo.reader(sql);
			while (dr.Read())
			{
				string a, b, c;
				a = dr["ID"].ToString();
				b = dr["Name"].ToString();
				c = dr["Password"].ToString();
				string[] str = { a, b, c };
				dataGridView1.Rows.Add(str);

			}
			dr.Close();//关闭连接
		}

		

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{

		}

		

		private void timer1_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabel2.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
		}

		private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form31 form31 = new Form31(this);//this
			form31.ShowDialog();
		}

		private void 删除用户ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OKCancel);
			if (r == DialogResult.OK)
			{
				string tID= dataGridView1.SelectedCells[0].Value.ToString();//获取选中的单元格的集合；
				string tName = dataGridView1.SelectedCells[1].Value.ToString();
				string sql = "delete from UserTable where ID='" + tID + "'and Name='" + tName + "'";
				Demo demo = new Demo();
				int i = demo.Excute(sql);
				if (i > 0)
				{
					MessageBox.Show("删除成功");
				}
			}
			Table();
		}
		private void Form3_Load(object sender, EventArgs e)
		{
			
		}
	}
}
