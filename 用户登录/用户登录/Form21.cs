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
	public partial class Form21 : Form
	{
		Form2 form21;
		string[] str = new string[6];
		//添加数据；
		public Form21(Form2 form2)
		{
			InitializeComponent();
			this.form21 = form2;
			this.button3.Visible = false;
		}
		//修改
		public Form21(string[] str, Form2 form2)
		{
			InitializeComponent();
			this.form21 = form2;
			for (int i = 0; i < str.Length; i++)
			{
				this.str[i] = str[i];
			}
			textBox1.Text = str[0];
			textBox2.Text = str[1];
			textBox3.Text = str[2];
			textBox4.Text = str[3];
			textBox5.Text = str[4];
			richTextBox1.Text = str[5];
			this.button1.Visible = false;
		}
		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || richTextBox1.Text == "" )
			{

				MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				string sql = "Insert into IFTable values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + richTextBox1.Text + "')";
				Demo demo = new Demo();
				int i = demo.Excute(sql);
				if (i > 0)
				{
					MessageBox.Show("添加成功");
					textBox1.Text = null;
					textBox2.Text = null;
					textBox3.Text = null;
					textBox4.Text = null;
					textBox5.Text = null;
					richTextBox1.Text = null;
					
				}
				form21.Table();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = null;
			textBox2.Text = null;
			textBox3.Text = null;
			textBox4.Text = null;
			textBox5.Text = null;
			richTextBox1.Text = null;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || richTextBox1.Text == "")
			{
				MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				string sql = "delete from IFTable where Name='" + str[0] + "'and Place='" + str[1] + "'";
				string sql2 = "insert into IFTable values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + richTextBox1.Text + "')";
				Demo demo = new Demo();
				demo.Excute(sql);
				demo.Excute(sql2);
				form21.Table();
			}
		}

		private void Form21_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Form4 form4 = new Form4();//this
			form4.ShowDialog();
		}
		public static string SaveFilePathName(string fileName = null, string filter = null, string title = null)
		{
			string path = "";
			System.Windows.Forms.SaveFileDialog fbd = new System.Windows.Forms.SaveFileDialog();
			if (!string.IsNullOrEmpty(fileName))
			{
				fbd.FileName = fileName;
			}
			if (!string.IsNullOrEmpty(filter))
			{
				fbd.Filter = filter;// "Excel|*.xls;*.xlsx;";
			}
			if (!string.IsNullOrEmpty(title))
			{
				fbd.Title = title;// "保存为";
			}
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				path = fbd.FileName;
			}
			return path;
		}
		/// <summary>
		/// 选择一个文件
		/// </summary>
		/// <param name="filter">如果需要筛选txt文件（"Files (*.txt)|*.txt"）</param>
		/// <returns></returns>
		//private static string SelectFile(string filter = null)
		//{
		//    string path = string.Empty;
		//    var openFileDialog = new Microsoft.Win32.OpenFileDialog()
		//    {
		//        Filter = "Files (*.*)|*.*"//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
		//    };
		//    if (filter != null)
		//    {
		//        openFileDialog.Filter = filter;
		//    }
		//    var result = openFileDialog.ShowDialog();
		//    if (result == true)
		//    {
		//        path = openFileDialog.FileName;
		//    }
		//    return path;
		//}

		/// <summary>
		/// 选择一个路径
		/// </summary>
		/// <returns></returns>
		//public static string SelectPath()
		//{
		//    string path = string.Empty;
		//    System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
		//    if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
		//    {
		//        path = fbd.SelectedPath;
		//    }
		//    return path;
		//}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			//FilePathHelper filePathHelper = new FilePathHelper();
			//filePathHelper.ToString();
			//filePathHelper();
			SaveFilePathName();
			//SelectFile();
			//SelectPath();
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
