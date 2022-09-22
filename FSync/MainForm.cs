using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using FSync;

namespace FSync
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
		[StructLayout(LayoutKind.Sequential)]
		public struct DEV_BROADCAST_VOLUME
		{
  public int dbcv_size;
  public int dbcv_devicetype;
  public int dbcv_reserved;
  public int dbcv_unitmask;
		}
		//
		private System.IO.FileSystemWatcher m_watcher;
		bool m_watcherFDEL = false;
		int m_count = 0;
		string mchanged;
		List<string> mchangings = new List<string>();
		        
		public List<string> dest1 = new List<string>();
		public string source1;
		//
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//Method to overwrite that manages the arrival of new storage units
		protected override void WndProc(ref Message mes)
		{
			//definitions are stored in “dbt.h” and “winuser.h”
			// There has been a change in the devices
			const int WM_DEVICECHANGE = 0X0219;
			// System detects a new device
			const int DBT_DEVICEARRIVAL = 0X8000;

			// The device has been succesfully removed from the system
			const int DBT_DEVICEREMOVECOMPLETE = 0X8004;
			// Logical Volume (A disk has been inserted, such a usb key or external HDD)
			const int DBT_DEVTYP_VOLUME = 0X00000002;
			switch (mes.Msg) {
			//If system devices change…
				case WM_DEVICECHANGE:
					switch (mes.WParam.ToInt32()) {
					//If there is a new device…
						case DBT_DEVICEARRIVAL:
							{
								int devType = Marshal.ReadInt32(mes.LParam, 4);
								//…and is a Logical Volume (A storage device)
								if (devType == DBT_DEVTYP_VOLUME) {
									DEV_BROADCAST_VOLUME vol;
									vol = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(mes.LParam, typeof(DEV_BROADCAST_VOLUME));
									// MessageBox.Show("A storage device has been inserted, drive letter " + UnitName(vol.dbcv_unitmask));
									check(UnitName(vol.dbcv_unitmask).ToString());
								}
							}
							break;
						case DBT_DEVICEREMOVECOMPLETE:
                                //MessageBox.Show(" A Device has been removed from the system.");
							break;
					}
					break;
			}
			//After the custom manager, we want to use the default system’s manager
			base.WndProc(ref mes);
            
		}

		//Method to detect the unit name (”D:”, “F:”, etc)
		char UnitName(int unitmaskname)
		{
			char[] units = {
				'A',
				'B',
				'C',
				'D',
				'E',
				'F',
				'G',
				'H',
				'I',
				'J',
				'K',
				'L',
				'M',
				'N',
				'O',
				'P',
				'Q',
				'R',
				'S',
				'T',
				'U',
				'V',
				'W',
				'X',
				'Y',
				'Z'
			};
			int i = 0;
			//Convert the mask in an array, and search
			//the index for the first occurrence (the unit’s name)
			System.Collections.BitArray bac = new
              System.Collections.BitArray(System.BitConverter.GetBytes(unitmaskname));
			foreach (bool vars in bac) {
				if (vars == true)
					break;
				i++;
			}
			return units[i];
		}
		private void check(string Drive)
		{
			//if(System.IO.Directory.Exists(Drive + ":/Music"))
			//{MessageBox.Show("Your Directory Is accessible!");}
			//else{MessageBox.Show("This Directory doesn't exist!");}
		}
		void Button1Click(object sender, EventArgs e)
		{
			//label1.Text = "Running...";

			try {
				
				backgroundWorker1.RunWorkerAsync();
				pictureBox1.Image = Properties.Resources.greenDot__1_;
				button2.BackgroundImage = Properties.Resources.greenDot__1_;
				
			} catch (Exception) {
				MessageBox.Show("This is already Running!!!");
			}
			
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			try {
				if (rkApp.GetValue("FSync") == null) {
					rkApp.SetValue("FSync", Application.ExecutablePath.ToString());
				} else {
					// The value exists, the application is set to run at startup
				}
			} catch (Exception) {
				
				
			}
			
			Rectangle workingArea = Screen.GetWorkingArea(this);
			this.Location = new Point(workingArea.Right - Size.Width, 
				workingArea.Bottom - Size.Height);
			//this.WindowState = FormWindowState.Minimized;
			FadebackgroundWorker.RunWorkerAsync();
			this.Opacity = 0;
			try {
				
			
				sourcefolderlabel.Text = File.ReadAllText(Application.StartupPath + "/from.dat");
				fileSystemWatcher1.Path = source1;
				source1 = File.ReadAllText(Application.StartupPath + "/from.dat");
				fileFolderList1.DefaultPath = source1;
				fileFolderList1.Load();
				//richTextBox1.Text = File.ReadAllText(Application.StartupPath + "/selections.dat");
				//richTextBox1.Text = richTextBox1.Text.Trim();
				foreach (var location in File.ReadAllLines(Application.StartupPath + "/selections.dat")) {
					listBox2.Items.Add(location);
					dest1.Add(location);
				}
				//File watcher for changes like deletion
				m_watcher = new System.IO.FileSystemWatcher();
				m_watcher.Filter = "*.*";
				m_watcher.Path = source1;
				m_watcher.IncludeSubdirectories = true;
				m_watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
				| NotifyFilters.FileName | NotifyFilters.DirectoryName;
				m_watcher.Changed += new FileSystemEventHandler(OnChanged);
				m_watcher.Deleted += new FileSystemEventHandler(OnChanged);
				m_watcher.Created += new FileSystemEventHandler(OnChanged);
				if (File.Exists(source1 + "\\changes")) {
					foreach (var name in File.ReadAllLines(source1 + "\\changes")) {
						mchangings.Add(name);
				}
			}
				//m_watcher.Renamed += new RenamedEventHandler(OnRenamed);
				m_watcher.EnableRaisingEvents = true;
				//Main File Sync
				backgroundWorker1.RunWorkerAsync();
				//label1.Text = "Running...";
				pictureBox1.Image = Properties.Resources.greenDot__1_;
				button2.BackgroundImage = Properties.Resources.greenDot__1_;
			} catch (Exception ex) {
				
				MessageBox.Show("There was an error! \n Set your paths and restart FSync");
			}
		}
		private void OnChanged(object sender, FileSystemEventArgs e)
		{
			if (!File.Exists(source1 + "\\changes")) {
				File.Create(source1 + "\\changes");
			}
			if (e.ChangeType.ToString().Contains("Delete")) {
				mchanged = "d," + e.Name;
				int deletedindex = mchangings.IndexOf("n,"+e.Name);
				if (deletedindex != -1) { mchangings.RemoveAt(deletedindex); mchangings.Insert(deletedindex, mchanged);
				m_watcherFDEL = true; listBox1.Items.Add(mchanged);
				File.WriteAllLines(source1 + "\\changes", mchangings);
				}
				else{
				m_watcherFDEL = true;
				m_count++;
				mchangings.Add(mchanged);
				listBox1.Items.Add(mchanged);
				File.WriteAllLines(source1 + "\\changes", mchangings);
				//MessageBox.Show(mchanged);
				}
			}
			else if (e.ChangeType.ToString().Contains("Create")) {
				mchanged = "n," + e.Name;
				 int deletedindex = mchangings.IndexOf("d,"+e.Name);
				 if (deletedindex != -1) { mchangings.RemoveAt(deletedindex); mchangings.Insert(deletedindex, mchanged); m_watcherFDEL = true;
				 listBox1.Items.Add(mchanged);
				File.WriteAllLines(source1 + "\\changes", mchangings);}
				 else{
				 m_watcherFDEL = true;
				m_count++;
				mchangings.Add(mchanged);
				listBox1.Items.Add(mchanged);
				File.WriteAllLines(source1 + "\\changes", mchangings);
				//MessageBox.Show(mchanged);}
			}
		}
		}
		void BackgroundWorker1DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			locationcheck(dest1, source1, mchangings);
		}
		void BackgroundWorker1RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			backgroundWorker1.RunWorkerAsync();
		}
		void Button2Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			DialogResult result = fbd.ShowDialog();
			sourcefolderlabel.Text = fbd.SelectedPath;
			File.WriteAllText(Application.StartupPath + "/from.dat", fbd.SelectedPath);
			fileFolderList1.DefaultPath = File.ReadAllText(Application.StartupPath + "/from.dat");
				fileFolderList1.Load();
		}
		void Button3Click(object sender, EventArgs e)
		{
			string savedata = "";
			foreach (var item in listBox2.Items) {
				savedata = savedata + (item.ToString() + Environment.NewLine);
			}
			File.WriteAllText(Application.StartupPath + "/selections.dat", savedata);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			DialogResult result = fbd.ShowDialog();
			string removing = fbd.SelectedPath.Remove(fbd.SelectedPath.IndexOf(':'));
			listBox2.Items.Add(fbd.SelectedPath.Replace(removing + ":", ""));
			string savedata = "";
			foreach (var item in listBox2.Items) {
				savedata = savedata + (item.ToString() + Environment.NewLine);
			}
			File.WriteAllText(Application.StartupPath + "/selections.dat", savedata);
		}
		void Button5Click(object sender, EventArgs e)
		{
			panel2.Visible = false;
			panel1.Visible = true;
			button5.BackColor = Color.FromArgb(26, 188, 156);
			button6.BackColor = Color.FromArgb(34, 34, 34);
		}
		void Button6Click(object sender, EventArgs e)
		{
			panel2.Visible = true;
			panel1.Visible = false;
			button6.BackColor = Color.FromArgb(26, 188, 156);
			button5.BackColor = Color.FromArgb(34, 34, 34);
		}
		void Button8Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Button7Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			this.Opacity = 0;
		}
		
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		void Panel5MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) {
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		void Removebutton1Click(object sender, EventArgs e)
		{
			listBox2.Items.Remove(listBox2.SelectedItem);
			button3.PerformClick();
		}
		void NotifyIcon1MouseDoubleClick(object sender, MouseEventArgs e)
		{
			//this.WindowState = FormWindowState.Normal;
			this.TopMost = true;
			this.Opacity = .95;
			this.TopMost = false;
		}
		
		void BackgroundWorker2DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
	
		}
		void BackgroundWorker3DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
	
		}
		void BackgroundWorker4DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
	
		}
		void BackgroundWorker5DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
	
		}
		void BackgroundWorker6DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
	
		}
		void BackgroundWorker7DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
	
		}
		void BackgroundWorker8DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
	
		}
		void BackgroundWorker9DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
	
		}
		void BackgroundWorker10DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
	
		}
		
		
		
		public void locationcheck(List<string> destinationlist, string sourcepath, List<string> changes)
		{
			string[] DriveList = Environment.GetLogicalDrives();
			foreach (string Drive in DriveList) {
				//MessageBox.Show(Drive + " Is available!");
				//
				foreach (string destinationPath1 in destinationlist) {
					if (destinationPath1 != "" || destinationPath1 != "\n" || destinationPath1 != " ") {
						try {
						
							string sourcePath = sourcepath;
							//string destinationPath = @"H:\Music";
							string destinationPath = Drive + destinationPath1;
							System.IO.DirectoryInfo dir1 = new System.IO.DirectoryInfo(sourcePath);
							System.IO.DirectoryInfo dir2 = new System.IO.DirectoryInfo(destinationPath);
		
							IEnumerable<System.IO.FileInfo> list1 = dir1.GetFiles("*.*",
								                                         System.IO.SearchOption.AllDirectories);
							//Checks to see if all files are accounted for
							IEnumerable<System.IO.FileInfo> list2 = dir2.GetFiles("*.*",
								                                         System.IO.SearchOption.AllDirectories);
							bool IsInDestination = false;
							bool IsInSource = false;
//string removing = fbd.SelectedPath.Remove(fbd.SelectedPath.IndexOf(':'));
			//listBox2.Items.Add(fbd.SelectedPath.Replace(removing + ":", ""));
							foreach (System.IO.FileInfo s in list1) {
								IsInDestination = true;

								foreach (System.IO.FileInfo s2 in list2) {
									string f;
									string f2;
									string cleaning = s2.FullName.Remove(s2.FullName.IndexOf(':'));
									f = s.FullName.Replace(sourcePath, "");
									f2 = s2.FullName.Replace(cleaning + ":" + destinationPath1, "");
									//MessageBox.Show(f2);
													//						MessageBox.Show(f + f2);
									if (f == f2) {
										//if (s.Name == s2.Name) {
										//MessageBox.Show(f + f2);
										IsInDestination = true;
										//From Defualt Directory to New
										if (s.LastWriteTime.CompareTo(s2.LastWriteTime) > 0 && s.LastWriteTime != s2.LastWriteTime) {
											if (!Directory.Exists(destinationPath + (s.DirectoryName.Replace(sourcePath.Replace(@"\\", @"\"), "")))) {
												DirectoryInfo di = Directory.CreateDirectory(destinationPath + (s.DirectoryName.Replace(sourcePath.Replace(@"\\", @"\"), "")));
											}
											//System.IO.File.Copy(s.FullName, System.IO.Path.Combine(destinationPath + (s.FullName.Replace(sourcePath)), s.Name), true);
											System.IO.File.Copy(s.FullName, destinationPath + (s.FullName.Replace(sourcePath.Replace(@"\\", @"\"), "")), true);
											File.SetLastWriteTime(s2.FullName, File.GetLastWriteTime(s.FullName));
											listBox1.Items.Add("Updated:" + s.Name);
											break;
										} else if (s.LastWriteTime.CompareTo(s2.LastWriteTime) < 0 && s.LastWriteTime != s2.LastWriteTime) {
											if (!Directory.Exists(sourcePath + (s2.DirectoryName.Replace(destinationPath.Replace(@"\\", @"\"), "")))) {
												DirectoryInfo di = Directory.CreateDirectory((sourcePath + (s2.DirectoryName.Replace(destinationPath.Replace(@"\\", @"\"), ""))));
											}
											//System.IO.File.Copy(s.FullName, System.IO.Path.Combine(sourcePath, s.Name), true);
											System.IO.File.Copy(s2.FullName, sourcePath + (s2.FullName.Replace(destinationPath.Replace(@"\\", @"\"), "")), true);  
											File.SetLastWriteTime(s.FullName, File.GetLastWriteTime(s2.FullName));
											listBox1.Items.Add("Updated:" + s2.Name);
											break;
                    
										}
										break;
									} else {
										IsInDestination = false;
									}
								}
                                int deletedindex = changes.IndexOf("d,"+s.Name);
                                bool deleted = false;
                                if (deletedindex != -1) {
                                		deleted = true;         	
                                }
                                int createdindex = changes.IndexOf("n,"+s.Name);
                                bool created = false;
                                if (createdindex != -1) {
                                		created = true;         	
                                }
								if (!IsInDestination && deleted != true) {
									if (!Directory.Exists(destinationPath + (s.DirectoryName.Replace(sourcePath.Replace(@"\\", @"\"), "")))) {
										DirectoryInfo di = Directory.CreateDirectory(destinationPath + (s.DirectoryName.Replace(sourcePath.Replace(@"\\", @"\"), "")));
									}
									//System.IO.File.Copy(s.FullName, System.IO.Path.Combine(destinationPath + (s.FullName.Replace(sourcePath)), s.Name), true);
									System.IO.File.Copy(s.FullName, destinationPath + (s.FullName.Replace(sourcePath.Replace(@"\\", @"\"), "")), true);
									//File.SetLastWriteTime((s.FullName.Replace(sourcePath.Replace(@"\\",@"\"), "")), File.GetLastWriteTime(s.FullName));
									listBox1.Items.Add("NEW:" + s.Name);
								}
                                else if (deleted == true && created == false)                       	
                                {System.IO.File.Delete(s.FullName); listBox1.Items.Add("Removed:" + s.Name);}
        
							}
							list1 = dir1.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

							list2 = dir2.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

							bool areIdentical = list1.SequenceEqual(list2, new FileCompare());
							//Client Folders
							if (!areIdentical) {
								foreach (System.IO.FileInfo s in list2) {
									IsInSource = true;
									
									foreach (System.IO.FileInfo s2 in list1) {
										string f;
									string f2;
									string cleaning = s.FullName.Remove(s.FullName.IndexOf(':'));
									f = s2.FullName.Replace(sourcePath, "");
									f2 = s.FullName.Replace(cleaning + ":" + destinationPath1, "");
										if (f == f2) {
											IsInSource = true;   

											if (s.LastWriteTime.CompareTo(s2.LastWriteTime) > 0 && s.LastWriteTime != s2.LastWriteTime){
												if (!Directory.Exists(sourcePath + (s.DirectoryName.Replace(destinationPath.Replace(@"\\", @"\"), "")))) {
													DirectoryInfo di = Directory.CreateDirectory((sourcePath + (s.DirectoryName.Replace(destinationPath.Replace(@"\\", @"\"), ""))));
												}
												//
										//System.IO.File.Copy(s.FullName, System.IO.Path.Combine(sourcePath, s.Name), true);
											System.IO.File.Copy(s.FullName, sourcePath + (s.FullName.Replace(destinationPath.Replace(@"\\", @"\"), "")), true);
											File.SetLastWriteTime(s2.FullName, File.GetLastWriteTime(s.FullName));
											listBox1.Items.Add("Updated:" + s.Name);
											}
											break;
										} else {
											IsInSource = false;
										}
									}
                                    int deletedindex = changes.IndexOf("d,"+s.Name);
                                bool deleted = false;
                                if (deletedindex != -1) {
                                		deleted = true;         	
                                }
                                int createdindex = changes.IndexOf("n,"+s.Name);
                                bool created = false;
                                if (createdindex != -1) {
                                	created = true;   }
									if (!IsInSource && deleted != true) {
										if (!Directory.Exists(sourcePath + (s.DirectoryName.Replace(destinationPath.Replace(@"\\", @"\"), "")))) {
											DirectoryInfo di = Directory.CreateDirectory((sourcePath + (s.DirectoryName.Replace(destinationPath.Replace(@"\\", @"\"), ""))));
										}
										//System.IO.File.Copy(s.FullName, System.IO.Path.Combine(sourcePath, s.Name), true);
										System.IO.File.Copy(s.FullName, sourcePath + (s.FullName.Replace(destinationPath.Replace(@"\\", @"\"), "")), true);
										//File.SetLastWriteTime((s.FullName.Replace(destinationPath.Replace(@"\\", @"\"), "")), File.GetLastWriteTime(s.FullName));
										listBox1.Items.Add("NEW:" + s.Name);
									}
                                else if (deleted == true && created == false)
                                {System.IO.File.Delete(s.FullName); listBox1.Items.Add("Removed:" + s.Name);}
								}
                                 
							
							}
							}
        
        
     
						catch (Exception ex) {
							//MessageBox.Show(ex.ToString());
						}
					}
				}
		
			}
			Thread.Sleep(5000);
		}
		void FileSystemWatcher1Changed(object sender, FileSystemEventArgs e)
		{
	
		}
		void FileFolderList1DoubleClick(object sender, EventArgs e)
		{
			if (File.Exists(fileFolderList1.SelectedPath)) {
				Process.Start(fileFolderList1.SelectedPath);
			}
			
		}
		void ContextMenuStrip1MouseClick(object sender, MouseEventArgs e)
		{
		
		}
		void ContextMenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
	ToolStripItem item = e.ClickedItem;
	//MessageBox.Show(item.ToString());
	switch (item.ToString()) {
			case "Open":
			if (File.Exists(fileFolderList1.SelectedPath)) {
				Process.Start(fileFolderList1.SelectedPath);
			}
			else
			{Process.Start(fileFolderList1.SelectedPath);}
			break;
			case "Delete":
			try {
			if (File.Exists(fileFolderList1.SelectedPath)) {
				File.Delete(fileFolderList1.SelectedPath);
			}
			else
			{Directory.Delete(fileFolderList1.SelectedPath);}
			} catch (Exception) {
				
				MessageBox.Show("An error occured while deleting this!");
			}
			break;
			case "Rename":
			/// <summary>
			/// This needs to be finnished! 2/27/2017
			/// </summary>
			MessageBox.Show("Not added yet!");
			break;
			case "Show in folder":
			if (File.Exists(fileFolderList1.SelectedPath)) {
				Process.Start(Path.GetDirectoryName(fileFolderList1.SelectedPath));
			}
			else
			{Process.Start(fileFolderList1.SelectedPath);}
			break;
			case "Copy location":
			Clipboard.SetText(fileFolderList1.SelectedPath);
			break;
	}
		}
		void Button10Click(object sender, EventArgs e)
		{
			FadebackgroundWorker.RunWorkerAsync();
		}
		void FadebackgroundWorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			try {
				Fade();
			} catch (Exception) {
				
			}
			
		}

private void Fade()
        {
            int spd = 10;
            if(this.BackColor != Color.FromArgb(255, 192, 255))
            {
            	//Fade Out
                this.Opacity = .9;
                Thread.Sleep(spd);
                this.Opacity = .8;
                Thread.Sleep(spd);
                this.Opacity = .7;
                Thread.Sleep(spd);
                this.Opacity = .6;
                Thread.Sleep(spd);
                this.Opacity = .5;
                Thread.Sleep(spd);
                this.Opacity = .4;
                Thread.Sleep(spd);
                this.Opacity = .3;
                Thread.Sleep(spd);
                this.Opacity = .2;
                Thread.Sleep(spd);
                this.Opacity = .1;
                Thread.Sleep(spd);
                this.Opacity = .0;
                Thread.Sleep(spd);
                this.BackColor = Color.FromArgb(255, 192, 255);
                ContainerPanel1.Visible = false;
                //
               // int width = panel1.Size.Width;
        		//int height = panel1.Size.Height;
        		int width = 200;
        		int height = 200;
        		Bitmap bm = new Bitmap(width, height);
        		panel1.DrawToBitmap(bm, new Rectangle(0, 0, width, height));
        		button10.BackgroundImage = bm;
                //noTabs1.SelectedTab = tabPage1;
                this.Opacity = .1;
                Thread.Sleep(spd);
                this.Opacity = .2;
                Thread.Sleep(spd);
                this.Opacity = .3;
                Thread.Sleep(spd);
                this.Opacity = .4;
                Thread.Sleep(spd);
                this.Opacity = .5;
                Thread.Sleep(spd);
                this.Opacity = .6;
                Thread.Sleep(spd);
                this.Opacity = .7;
                Thread.Sleep(spd);
                this.Opacity = .8;
                Thread.Sleep(spd);
                this.Opacity = .9;
                Thread.Sleep(spd);
                this.Opacity = .95;
                 
            }
            else
            {
            	//Fade in
                this.Opacity = .9;
                Thread.Sleep(spd);
                this.Opacity = .8;
                Thread.Sleep(spd);
                this.Opacity = .7;
                Thread.Sleep(spd);
                this.Opacity = .6;
                Thread.Sleep(spd);
                this.Opacity = .5;
                Thread.Sleep(spd);
                this.Opacity = .4;
                Thread.Sleep(spd);
                this.Opacity = .3;
                Thread.Sleep(spd);
                this.Opacity = .2;
                Thread.Sleep(spd);
                this.Opacity = .1;
                Thread.Sleep(spd);
                this.Opacity = .0;
                Thread.Sleep(spd);
                this.BackColor = Color.FromArgb(34, 34, 34);
                ContainerPanel1.Visible = true;
                button10.BackgroundImage = null;
                this.Opacity = .1;
                Thread.Sleep(spd);
                this.Opacity = .2;
                Thread.Sleep(spd);
                this.Opacity = .3;
                Thread.Sleep(spd);
                this.Opacity = .4;
                Thread.Sleep(spd);
                this.Opacity = .5;
                Thread.Sleep(spd);
                this.Opacity = .6;
                Thread.Sleep(spd);
                this.Opacity = .7;
                Thread.Sleep(spd);
                this.Opacity = .8;
                Thread.Sleep(spd);
                this.Opacity = .9;
                Thread.Sleep(spd);
                this.Opacity = .95;

                Thread.Sleep(spd);
 
            }
        }
		void Panel5Paint(object sender, PaintEventArgs e)
		{

		}
		void Button10MouseDown(object sender, MouseEventArgs e)
		{
FadebackgroundWorker.RunWorkerAsync();
			if (e.Button == MouseButtons.Left) {
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		void ContainerPanel1Paint(object sender, PaintEventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		class FileCompare : System.Collections.Generic.IEqualityComparer<System.IO.FileInfo>
		{
			public bool Equals(System.IO.FileInfo f1, System.IO.FileInfo f2)
			{
				return (f1.Name == f2.Name);
			}
			public int GetHashCode(System.IO.FileInfo fi)
			{
				string s = fi.Name;
				return s.GetHashCode();
			}
        
		}

        private void fileFolderList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
