
namespace 用户登录
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.我的记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添加信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.修改信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.删除信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.刷新信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.添加信息 = new System.Windows.Forms.ToolStripButton();
			this.修改信息 = new System.Windows.Forms.ToolStripButton();
			this.删除信息 = new System.Windows.Forms.ToolStripButton();
			this.刷新信息 = new System.Windows.Forms.ToolStripButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我的记录ToolStripMenuItem,
            this.信息管理ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(814, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 我的记录ToolStripMenuItem
			// 
			this.我的记录ToolStripMenuItem.Name = "我的记录ToolStripMenuItem";
			this.我的记录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.我的记录ToolStripMenuItem.Text = "我的记录";
			// 
			// 信息管理ToolStripMenuItem
			// 
			this.信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加信息ToolStripMenuItem,
            this.修改信息ToolStripMenuItem,
            this.删除信息ToolStripMenuItem,
            this.刷新信息ToolStripMenuItem});
			this.信息管理ToolStripMenuItem.Name = "信息管理ToolStripMenuItem";
			this.信息管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.信息管理ToolStripMenuItem.Text = "信息管理";
			// 
			// 添加信息ToolStripMenuItem
			// 
			this.添加信息ToolStripMenuItem.Name = "添加信息ToolStripMenuItem";
			this.添加信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.添加信息ToolStripMenuItem.Text = "添加信息";
			this.添加信息ToolStripMenuItem.Click += new System.EventHandler(this.添加信息ToolStripMenuItem_Click);
			// 
			// 修改信息ToolStripMenuItem
			// 
			this.修改信息ToolStripMenuItem.Name = "修改信息ToolStripMenuItem";
			this.修改信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.修改信息ToolStripMenuItem.Text = "修改信息";
			this.修改信息ToolStripMenuItem.Click += new System.EventHandler(this.修改信息ToolStripMenuItem_Click);
			// 
			// 删除信息ToolStripMenuItem
			// 
			this.删除信息ToolStripMenuItem.Name = "删除信息ToolStripMenuItem";
			this.删除信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.删除信息ToolStripMenuItem.Text = "删除信息";
			this.删除信息ToolStripMenuItem.Click += new System.EventHandler(this.删除信息ToolStripMenuItem_Click);
			// 
			// 刷新信息ToolStripMenuItem
			// 
			this.刷新信息ToolStripMenuItem.Name = "刷新信息ToolStripMenuItem";
			this.刷新信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.刷新信息ToolStripMenuItem.Text = "刷新信息";
			this.刷新信息ToolStripMenuItem.Click += new System.EventHandler(this.刷新信息ToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加信息,
            this.修改信息,
            this.删除信息,
            this.刷新信息});
			this.toolStrip1.Location = new System.Drawing.Point(0, 25);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(814, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// 添加信息
			// 
			this.添加信息.Checked = true;
			this.添加信息.CheckState = System.Windows.Forms.CheckState.Checked;
			this.添加信息.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.添加信息.Image = global::用户登录.Properties.Resources.下载;
			this.添加信息.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.添加信息.Name = "添加信息";
			this.添加信息.Size = new System.Drawing.Size(23, 22);
			this.添加信息.Text = "toolStripButton1";
			this.添加信息.ToolTipText = "添加信息";
			this.添加信息.Click += new System.EventHandler(this.添加信息ToolStripMenuItem_Click);
			// 
			// 修改信息
			// 
			this.修改信息.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.修改信息.Image = global::用户登录.Properties.Resources.下载__1_;
			this.修改信息.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.修改信息.Name = "修改信息";
			this.修改信息.Size = new System.Drawing.Size(23, 22);
			this.修改信息.Text = "toolStripButton2";
			this.修改信息.ToolTipText = "修改信息";
			this.修改信息.Click += new System.EventHandler(this.修改信息ToolStripMenuItem_Click);
			// 
			// 删除信息
			// 
			this.删除信息.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.删除信息.Image = global::用户登录.Properties.Resources._3;
			this.删除信息.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.删除信息.Name = "删除信息";
			this.删除信息.Size = new System.Drawing.Size(23, 22);
			this.删除信息.Text = "toolStripButton3";
			this.删除信息.ToolTipText = "删除信息";
			this.删除信息.Click += new System.EventHandler(this.删除信息ToolStripMenuItem_Click);
			// 
			// 刷新信息
			// 
			this.刷新信息.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.刷新信息.Image = global::用户登录.Properties.Resources._4;
			this.刷新信息.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.刷新信息.Name = "刷新信息";
			this.刷新信息.Size = new System.Drawing.Size(23, 22);
			this.刷新信息.Text = "toolStripButton4";
			this.刷新信息.ToolTipText = "刷新信息";
			this.刷新信息.Click += new System.EventHandler(this.刷新信息ToolStripMenuItem_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowDrop = true;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column4});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.Location = new System.Drawing.Point(0, 50);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(814, 478);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "姓名";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "地点";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "时间";
			this.Column3.Name = "Column3";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "经纬度";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "文件路径";
			this.Column6.Name = "Column6";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "内容";
			this.Column4.Name = "Column4";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
			this.statusStrip1.Location = new System.Drawing.Point(0, 506);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(814, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
			this.toolStripStatusLabel1.Text = "欢迎使用";
			this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(707, 17);
			this.toolStripStatusLabel2.Spring = true;
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(36, 17);
			this.toolStripStatusLabel3.Text = "Time";
			this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 528);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "用户中心";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.Click += new System.EventHandler(this.添加信息ToolStripMenuItem_Click);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 我的记录ToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton 添加信息;
		private System.Windows.Forms.ToolStripButton 修改信息;
		private System.Windows.Forms.ToolStripButton 删除信息;
		private System.Windows.Forms.ToolStripButton 刷新信息;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem 信息管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添加信息ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 修改信息ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 删除信息ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 刷新信息ToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
	}
}