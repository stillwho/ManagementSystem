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
	public partial class Form31 : Form
	{
		Form3 form31;
		string[] str = new string[4];
		//添加数据；
		public Form31(Form3 form3)
		{
			InitializeComponent();
			this.form31 = form3;
			
		}
		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = null;
			textBox1.Text = null;
			textBox1.Text = null;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
			{

				MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				string sql = "Insert into UserTable values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
				Demo demo = new Demo();
				int i = demo.Excute(sql);
				if (i > 0)
				{
					MessageBox.Show("添加成功");
					textBox1.Text = null;
					textBox2.Text = null;
					textBox3.Text = null;
				}
				form31.Table();
			}
		}
	}
}
