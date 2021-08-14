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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (login())
			{
				timer1.Start();//启动计时器,图片开始移动；
				textBox1.Visible = false;
				textBox2.Visible = false;
				comboBox1.Visible = false;
				button1.Visible = false;
				button2.Visible = false;
				label1.Visible = false;
				label2.Visible = false;
				label3.Visible = false;

			}
			else
			{
				MessageBox.Show("用户或密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}
		private bool login()
		{
			if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
			{
				MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			else
			{
				if (comboBox1.Text == "用户")
				{
					string sql = "select *from UserTable where Name='" + textBox1.Text + "'and Password='" + textBox2.Text + "'";
					Demo demo = new Demo();
					IDataReader dr = demo.reader(sql);
					if (dr.Read())
					{
						return true;
					}

				}
				else
				{
					if (comboBox1.Text == "管理员")
					{
						string sql = "select *from UserAdministrator where Name='" + textBox1.Text + "'and Password='" + textBox2.Text + "'";
						Demo demo = new Demo();
						IDataReader dr = demo.reader(sql);
						if (dr.Read())
						{
							return true;
						}
						else
						{
							MessageBox.Show("用户或密码错误");
							return false;
						}
					}
				}
			}
			return false;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (pictureBox1.Location.X < 150)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
			}
			else
			{
				if (comboBox1.Text == "用户")
				{
					string sql = "select *from UserTable where Name='" + textBox1.Text + "'and Password='" + textBox2.Text + "'";
					Demo demo = new Demo();
					IDataReader dr = demo.reader(sql);
					dr.Read();
					string uid = dr["ID"].ToString();
					Form2 form2 = new Form2(uid);
					form2.Show();//显示这个窗体
					this.Hide();//隐藏这个窗体
					//this.Close();//关闭这个窗体
				}
				else
				{
					if (comboBox1.Text == "管理员")
					{
						Form3 form3 = new Form3();
						form3.Show();
						this.Hide();
					}
				}
				
			timer1.Stop();
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
