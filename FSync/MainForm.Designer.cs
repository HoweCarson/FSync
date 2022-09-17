/*
 * Created by SharpDevelop.
 * User: S133007547
 * Date: 2/24/2016
 * Time: 7:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FSync
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button2;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button Removebutton1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.ComponentModel.BackgroundWorker backgroundWorker3;
		private System.ComponentModel.BackgroundWorker backgroundWorker4;
		private System.ComponentModel.BackgroundWorker backgroundWorker5;
		private System.ComponentModel.BackgroundWorker backgroundWorker6;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.ComponentModel.BackgroundWorker backgroundWorker7;
		private System.ComponentModel.BackgroundWorker backgroundWorker8;
		private System.ComponentModel.BackgroundWorker backgroundWorker9;
		private System.ComponentModel.BackgroundWorker backgroundWorker10;
		private System.Windows.Forms.Button buttons10;
		private System.Windows.Forms.Button buttons9;
		private System.Windows.Forms.Button buttons8;
		private System.Windows.Forms.Button buttons7;
		private System.Windows.Forms.Button buttons6;
		private System.Windows.Forms.Button buttons5;
		private System.Windows.Forms.Button buttons4;
		private System.Windows.Forms.Button buttons3;
		private System.Windows.Forms.Button buttons2;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label sourcefolderlabel;
		private FSync.FileFolderList fileFolderList1;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.ComponentModel.BackgroundWorker FadebackgroundWorker;
		private System.Windows.Forms.Panel ContainerPanel1;
		private System.Windows.Forms.Panel panel3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.fileFolderList1 = new FSync.FileFolderList();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.buttons10 = new System.Windows.Forms.Button();
			this.buttons9 = new System.Windows.Forms.Button();
			this.buttons8 = new System.Windows.Forms.Button();
			this.buttons7 = new System.Windows.Forms.Button();
			this.buttons6 = new System.Windows.Forms.Button();
			this.buttons5 = new System.Windows.Forms.Button();
			this.buttons4 = new System.Windows.Forms.Button();
			this.buttons3 = new System.Windows.Forms.Button();
			this.buttons2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button9 = new System.Windows.Forms.Button();
			this.Removebutton1 = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker8 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker9 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker10 = new System.ComponentModel.BackgroundWorker();
			this.sourcefolderlabel = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.FadebackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.ContainerPanel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.ContainerPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(3, 53);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(183, 29);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.ForeColor = System.Drawing.Color.White;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(3, 88);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(183, 260);
			this.listBox1.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.BackgroundImage = global::FSync.Properties.Resources.redDot__1_;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(3, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 40);
			this.button2.TabIndex = 3;
			this.button2.Text = "1";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1RunWorkerCompleted);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(192, 53);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(288, 29);
			this.button4.TabIndex = 5;
			this.button4.Text = "Add new Directory";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(390, 319);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 29);
			this.button3.TabIndex = 4;
			this.button3.Text = "Save";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
			this.panel1.Controls.Add(this.fileFolderList1);
			this.panel1.Location = new System.Drawing.Point(0, 58);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(485, 352);
			this.panel1.TabIndex = 7;
			// 
			// fileFolderList1
			// 
			this.fileFolderList1.ContextMenuStrip = this.contextMenuStrip1;
			this.fileFolderList1.DefaultPath = "C:\\";
			this.fileFolderList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileFolderList1.isSoloBrowser = true;
			this.fileFolderList1.Location = new System.Drawing.Point(0, 0);
			this.fileFolderList1.Name = "fileFolderList1";
			this.fileFolderList1.Size = new System.Drawing.Size(485, 352);
			this.fileFolderList1.TabIndex = 15;
			this.fileFolderList1.UseCompatibleStateImageBehavior = false;
			this.fileFolderList1.DoubleClick += new System.EventHandler(this.FileFolderList1DoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItem1,
			this.toolStripMenuItem5,
			this.toolStripSeparator1,
			this.toolStripMenuItem2,
			this.toolStripMenuItem3,
			this.toolStripMenuItem4});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(151, 120);
			this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStrip1ItemClicked);
			this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuStrip1MouseClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
			this.toolStripMenuItem1.Text = "Show in folder";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(150, 22);
			this.toolStripMenuItem5.Text = "Copy location";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
			this.toolStripMenuItem2.Text = "Open";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(150, 22);
			this.toolStripMenuItem3.Text = "Delete";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(150, 22);
			this.toolStripMenuItem4.Text = "Rename";
			// 
			// buttons10
			// 
			this.buttons10.BackColor = System.Drawing.Color.Transparent;
			this.buttons10.BackgroundImage = global::FSync.Properties.Resources.redDot__1_;
			this.buttons10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttons10.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.buttons10.FlatAppearance.BorderSize = 0;
			this.buttons10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttons10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttons10.ForeColor = System.Drawing.Color.White;
			this.buttons10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttons10.Location = new System.Drawing.Point(333, 3);
			this.buttons10.Name = "buttons10";
			this.buttons10.Size = new System.Drawing.Size(34, 26);
			this.buttons10.TabIndex = 14;
			this.buttons10.Text = "10";
			this.buttons10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttons10.UseVisualStyleBackColor = false;
			this.buttons10.Visible = false;
			// 
			// buttons9
			// 
			this.buttons9.BackColor = System.Drawing.Color.Transparent;
			this.buttons9.BackgroundImage = global::FSync.Properties.Resources.redDot__1_;
			this.buttons9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttons9.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.buttons9.FlatAppearance.BorderSize = 0;
			this.buttons9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttons9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttons9.ForeColor = System.Drawing.Color.White;
			this.buttons9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttons9.Location = new System.Drawing.Point(306, 3);
			this.buttons9.Name = "buttons9";
			this.buttons9.Size = new System.Drawing.Size(26, 26);
			this.buttons9.TabIndex = 13;
			this.buttons9.Text = "9";
			this.buttons9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttons9.UseVisualStyleBackColor = false;
			this.buttons9.Visible = false;
			// 
			// buttons8
			// 
			this.buttons8.BackColor = System.Drawing.Color.Transparent;
			this.buttons8.BackgroundImage = global::FSync.Properties.Resources.redDot__1_;
			this.buttons8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttons8.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.buttons8.FlatAppearance.BorderSize = 0;
			this.buttons8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttons8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttons8.ForeColor = System.Drawing.Color.White;
			this.buttons8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttons8.Location = new System.Drawing.Point(276, 3);
			this.buttons8.Name = "buttons8";
			this.buttons8.Size = new System.Drawing.Size(26, 26);
			this.buttons8.TabIndex = 12;
			this.buttons8.Text = "8";
			this.buttons8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttons8.UseVisualStyleBackColor = false;
			this.buttons8.Visible = false;
			// 
			// buttons7
			// 
			this.buttons7.BackColor = System.Drawing.Color.Transparent;
			this.buttons7.BackgroundImage = global::FSync.Properties.Resources.redDot__1_;
			this.buttons7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttons7.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.buttons7.FlatAppearance.BorderSize = 0;
			this.buttons7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttons7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttons7.ForeColor = System.Drawing.Color.White;
			this.buttons7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttons7.Location = new System.Drawing.Point(247, 3);
			this.buttons7.Name = "buttons7";
			this.buttons7.Size = new System.Drawing.Size(26, 26);
			this.buttons7.TabIndex = 11;
			this.buttons7.Text = "7";
			this.buttons7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttons7.UseVisualStyleBackColor = false;
			this.buttons7.Visible = false;
			// 
			// buttons6
			// 
			this.buttons6.BackColor = System.Drawing.Color.Transparent;
			this.buttons6.BackgroundImage = global::FSync.Properties.Resources.redDot__1_;
			this.buttons6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttons6.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.buttons6.FlatAppearance.BorderSize = 0;
			this.buttons6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttons6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttons6.ForeColor = System.Drawing.Color.White;
			this.buttons6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttons6.Location = new System.Drawing.Point(218, 3);
			this.buttons6.Name = "buttons6";
			this.buttons6.Size = new System.Drawing.Size(26, 26);
			this.buttons6.TabIndex = 10;
			this.buttons6.Text = "6";
			this.buttons6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttons6.UseVisualStyleBackColor = false;
			this.buttons6.Visible = false;
			// 
			// buttons5
			// 
			this.buttons5.BackColor = System.Drawing.Color.Transparent;
			this.buttons5.BackgroundImage = global::FSync.Properties.Resources.redDot__1_;
			this.buttons5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttons5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.buttons5.FlatAppearance.BorderSize = 0;
			this.buttons5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttons5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttons5.ForeColor = System.Drawing.Color.White;
			this.buttons5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttons5.Location = new System.Drawing.Point(189, 3);
			this.buttons5.Name = "buttons5";
			this.buttons5.Size = new System.Drawing.Size(26, 26);
			this.buttons5.TabIndex = 9;
			this.buttons5.Text = "5";
			this.buttons5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttons5.UseVisualStyleBackColor = false;
			this.buttons5.Visible = false;
			// 
			// buttons4
			// 
			this.buttons4.BackColor = System.Drawing.Color.Transparent;
			this.buttons4.BackgroundImage = global::FSync.Properties.Resources.redDot__1_;
			this.buttons4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttons4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.buttons4.FlatAppearance.BorderSize = 0;
			this.buttons4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttons4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttons4.ForeColor = System.Drawing.Color.White;
			this.buttons4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttons4.Location = new System.Drawing.Point(160, 3);
			this.buttons4.Name = "buttons4";
			this.buttons4.Size = new System.Drawing.Size(26, 26);
			this.buttons4.TabIndex = 8;
			this.buttons4.Text = "4";
			this.buttons4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttons4.UseVisualStyleBackColor = false;
			this.buttons4.Visible = false;
			// 
			// buttons3
			// 
			this.buttons3.BackColor = System.Drawing.Color.Transparent;
			this.buttons3.BackgroundImage = global::FSync.Properties.Resources.redDot__1_;
			this.buttons3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttons3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.buttons3.FlatAppearance.BorderSize = 0;
			this.buttons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttons3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttons3.ForeColor = System.Drawing.Color.White;
			this.buttons3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttons3.Location = new System.Drawing.Point(131, 3);
			this.buttons3.Name = "buttons3";
			this.buttons3.Size = new System.Drawing.Size(26, 26);
			this.buttons3.TabIndex = 7;
			this.buttons3.Text = "3";
			this.buttons3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttons3.UseVisualStyleBackColor = false;
			this.buttons3.Visible = false;
			// 
			// buttons2
			// 
			this.buttons2.BackColor = System.Drawing.Color.Transparent;
			this.buttons2.BackgroundImage = global::FSync.Properties.Resources.redDot__1_;
			this.buttons2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttons2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.buttons2.FlatAppearance.BorderSize = 0;
			this.buttons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttons2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttons2.ForeColor = System.Drawing.Color.White;
			this.buttons2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttons2.Location = new System.Drawing.Point(102, 3);
			this.buttons2.Name = "buttons2";
			this.buttons2.Size = new System.Drawing.Size(26, 26);
			this.buttons2.TabIndex = 6;
			this.buttons2.Text = "2";
			this.buttons2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttons2.UseVisualStyleBackColor = false;
			this.buttons2.Visible = false;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
			this.panel2.Controls.Add(this.button9);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.Removebutton1);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.listBox2);
			this.panel2.Controls.Add(this.listBox1);
			this.panel2.Controls.Add(this.buttons10);
			this.panel2.Controls.Add(this.buttons9);
			this.panel2.Controls.Add(this.buttons8);
			this.panel2.Controls.Add(this.buttons7);
			this.panel2.Controls.Add(this.buttons6);
			this.panel2.Controls.Add(this.buttons5);
			this.panel2.Controls.Add(this.buttons4);
			this.panel2.Controls.Add(this.buttons3);
			this.panel2.Controls.Add(this.buttons2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Location = new System.Drawing.Point(0, 58);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(485, 352);
			this.panel2.TabIndex = 8;
			// 
			// button9
			// 
			this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.ForeColor = System.Drawing.Color.White;
			this.button9.Location = new System.Drawing.Point(192, 319);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(91, 29);
			this.button9.TabIndex = 7;
			this.button9.Text = "Add";
			this.button9.UseVisualStyleBackColor = false;
			// 
			// Removebutton1
			// 
			this.Removebutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Removebutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Removebutton1.FlatAppearance.BorderSize = 0;
			this.Removebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Removebutton1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Removebutton1.ForeColor = System.Drawing.Color.White;
			this.Removebutton1.Location = new System.Drawing.Point(289, 319);
			this.Removebutton1.Name = "Removebutton1";
			this.Removebutton1.Size = new System.Drawing.Size(95, 29);
			this.Removebutton1.TabIndex = 4;
			this.Removebutton1.Text = "Remove";
			this.Removebutton1.UseVisualStyleBackColor = false;
			this.Removebutton1.Click += new System.EventHandler(this.Removebutton1Click);
			// 
			// listBox2
			// 
			this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox2.ForeColor = System.Drawing.Color.White;
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 20;
			this.listBox2.Location = new System.Drawing.Point(192, 88);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(288, 220);
			this.listBox2.TabIndex = 6;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(59, 24);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(63, 34);
			this.button5.TabIndex = 9;
			this.button5.Text = "Home";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.button6.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(124, 24);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(73, 34);
			this.button6.TabIndex = 10;
			this.button6.Text = "Settings";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.button8);
			this.panel5.Controls.Add(this.button7);
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(485, 23);
			this.panel5.TabIndex = 12;
			this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5Paint);
			this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel5MouseDown);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Silver;
			this.label3.Location = new System.Drawing.Point(153, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "FSync Folder Sync";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Click += new System.EventHandler(this.Label3Click);
			this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel5MouseDown);
			// 
			// button8
			// 
			this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button8.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.White;
			this.button8.Location = new System.Drawing.Point(450, 0);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(35, 25);
			this.button8.TabIndex = 4;
			this.button8.Text = "X";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
			this.button7.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Location = new System.Drawing.Point(416, 0);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(35, 25);
			this.button7.TabIndex = 4;
			this.button7.Text = "_";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = global::FSync.Properties.Resources.fileShare;
			this.notifyIcon1.Text = "View FSync";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1MouseDoubleClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::FSync.Properties.Resources.redDot__1_;
			this.pictureBox1.Location = new System.Drawing.Point(457, 416);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// backgroundWorker2
			// 
			this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2DoWork);
			// 
			// backgroundWorker3
			// 
			this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker3DoWork);
			// 
			// backgroundWorker4
			// 
			this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker4DoWork);
			// 
			// backgroundWorker5
			// 
			this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker5DoWork);
			// 
			// backgroundWorker6
			// 
			this.backgroundWorker6.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker6DoWork);
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher1Changed);
			// 
			// backgroundWorker7
			// 
			this.backgroundWorker7.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker7DoWork);
			// 
			// backgroundWorker8
			// 
			this.backgroundWorker8.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker8DoWork);
			// 
			// backgroundWorker9
			// 
			this.backgroundWorker9.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker9DoWork);
			// 
			// backgroundWorker10
			// 
			this.backgroundWorker10.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker10DoWork);
			// 
			// sourcefolderlabel
			// 
			this.sourcefolderlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.sourcefolderlabel.ForeColor = System.Drawing.SystemColors.Control;
			this.sourcefolderlabel.Location = new System.Drawing.Point(12, 416);
			this.sourcefolderlabel.Name = "sourcefolderlabel";
			this.sourcefolderlabel.Size = new System.Drawing.Size(317, 16);
			this.sourcefolderlabel.TabIndex = 14;
			this.sourcefolderlabel.Text = "label1";
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
			this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(116)))));
			this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(198)))), ((int)(((byte)(126)))));
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(0, 0);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(58, 58);
			this.button10.TabIndex = 15;
			this.button10.Text = "FS";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// FadebackgroundWorker
			// 
			this.FadebackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FadebackgroundWorkerDoWork);
			// 
			// ContainerPanel1
			// 
			this.ContainerPanel1.Controls.Add(this.panel5);
			this.ContainerPanel1.Controls.Add(this.button6);
			this.ContainerPanel1.Controls.Add(this.sourcefolderlabel);
			this.ContainerPanel1.Controls.Add(this.button5);
			this.ContainerPanel1.Controls.Add(this.pictureBox1);
			this.ContainerPanel1.Controls.Add(this.panel1);
			this.ContainerPanel1.Controls.Add(this.panel2);
			this.ContainerPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContainerPanel1.Location = new System.Drawing.Point(0, 0);
			this.ContainerPanel1.Name = "ContainerPanel1";
			this.ContainerPanel1.Size = new System.Drawing.Size(485, 436);
			this.ContainerPanel1.TabIndex = 16;
			this.ContainerPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.ContainerPanel1Paint);
			this.ContainerPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel5MouseDown);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.ClientSize = new System.Drawing.Size(485, 436);
			this.ControlBox = false;
			this.Controls.Add(this.button10);
			this.Controls.Add(this.ContainerPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Opacity = 0.95D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "FSync";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel5MouseDown);
			this.panel1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.ContainerPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		}
	}

