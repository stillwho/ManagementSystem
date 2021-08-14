using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;

namespace 用户登录
{
	// 而为了能与JS交互，首先引入using System.Security.Permissions;，然后在namespace下必须加入两行：
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]//调用JS代码必要
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class Form4 : Form
	{
		
		public Form4()
		{
			InitializeComponent();
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			try
			{
				//string str_url = Application.StartupPath + "../HTMLPage1.html";// 添加自己添加的html文件名，注意使用相对路径的方法 HTMLPage1.html要复制到debug目录下
				string str_url = "C:/Users/未来时刻/source/repos/用户登录/用户登录/bin/Debug/地图调试31 - .html";// 添加自己添加的html文件名，注意使用相对路径的方法 HTMLPage1.html要复制到debug目录下
				Uri url = new Uri(str_url);
				webBrowser1.Url = url;         // WebBrowser控件显示的网页路径
				webBrowser1.ObjectForScripting = this;    // 将当前类设置为可由脚本访问

				textBox1.Text = str_url;


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//本地文件 MapWinForms\bin\Debug  
			//string url = Application.StartupPath + "\\HTMLPage1.html";
			//string url = "C:/Users/12606/Desktop/C#/map/map/HTMLPage1.html";
			//textBox1.Text = url;
			string url = textBox1.Text.ToString();

			//屏蔽js相关错误  
			webBrowser1.ScriptErrorsSuppressed = true;

			//导航显示本地HTML文件  
			webBrowser1.Navigate(url);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				string tag_lng = webBrowser1.Document.GetElementById("mouselng").InnerText;
				string tag_lat = webBrowser1.Document.GetElementById("mouselat").InnerText;
				double dou_lng, dou_lat;
				if (double.TryParse(tag_lng, out dou_lng) && double.TryParse(tag_lat, out dou_lat))
				{
					label2.Text = "当前坐标：" + dou_lng.ToString("F6") + "," + dou_lat.ToString("F6");//保留小数点后6位
				}
			}
			catch (Exception ee)
			{ MessageBox.Show(ee.Message); }
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (button2.Text == "开启实时坐标")
			{
				timer1.Enabled = true;
				button2.Text = "关闭实时坐标";
			}
			else
			{
				button2.Text = "开启实时坐标";
				timer1.Enabled = false;
			}
		}
		
	}
}
