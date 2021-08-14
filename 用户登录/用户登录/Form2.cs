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
	public partial class Form2 : Form
	{
		string SID;
		public Form2(string uid)
		{
			SID = uid;
			InitializeComponent();
			toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
			toolStripStatusLabel1.Text = "欢迎" + SID + "用户登录";
			timer1.Start();
			Table();
		}
		public void Table()
		{
			dataGridView1.Rows.Clear();
			string sql = "select * from IFTable";//查询表；
			Demo demo = new Demo();
			IDataReader dr = demo.reader(sql);
			while (dr.Read())
			{
				string a, b, c, d,e,f;
				a = dr["Name"].ToString();
				b = dr["Place"].ToString();
				c = dr["Time"].ToString();
				d = dr["LatitudeAndLongitude"].ToString();
				e = dr["Path"].ToString();
				f = dr["Matter"].ToString();
				string[] str = { a, b, c, d,e,f };
				dataGridView1.Rows.Add(str);

			}
			dr.Close();//关闭连接
		}



		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void toolStripStatusLabel3_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void 添加信息ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form21 form21 = new Form21(this);//this
			form21.ShowDialog();
		}

		private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[3].Value.ToString(), dataGridView1.SelectedCells[4].Value.ToString(), dataGridView1.SelectedCells[5].Value.ToString() };
			//string sql = "select * from Information";
			//Demo demo = new Demo();
			//IDataReader dr = demo.reader(sql);
			//dr.Read();
			//while (dr.Read())
			//{
			//string a, b, c, d;
			//a = dr["Name"].ToString();
			//b = dr["Place"].ToString();
			//c = dr["Time"].ToString();
			//d = dr["Matter"].ToString();
			//string[] str = { a, b, c, d };
			//dataGridView1.Rows.Add(str);
			//}
			//dr.Close();//关闭连接
			Form21 form21 = new Form21(str,this);
			form21.ShowDialog();
		}

		private void 删除信息ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OKCancel);
			if (r == DialogResult.OK)
			{
				string tName = dataGridView1.SelectedCells[0].Value.ToString();//获取选中的单元格的集合；
				string tPlace = dataGridView1.SelectedCells[1].Value.ToString();
				string sql = "delete from IFTable where Name='" + tName + "'and Place='" + tPlace + "'";
				Demo demo = new Demo();
				int i = demo.Excute(sql);
				if (i > 0)
				{
					MessageBox.Show("删除成功");
				}
			}
			Table();
		}

		private void 刷新信息ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Table();
		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{

		}
	}
}
