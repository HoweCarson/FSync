using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using FSync;

namespace FSync
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		        [StructLayout(LayoutKind.Sequential)]
public struct DEV_BROADCAST_VOLUME
{
  public int dbcv_size;
  public int dbcv_devicetype;
  public int dbcv_reserved;
  public int dbcv_unitmask;
}
    
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
                switch (mes.Msg)
                {
                    //If system devices change…
                    case WM_DEVICECHANGE:
                        switch (mes.WParam.ToInt32())
                        {
                            //If there is a new device…
                            case DBT_DEVICEARRIVAL:
                                {
                                    int devType = Marshal.ReadInt32(mes.LParam, 4);
                                    //…and is a Logical Volume (A storage device)
                                    if (devType == DBT_DEVTYP_VOLUME)
                                    {
                                        DEV_BROADCAST_VOLUME vol;
                                        vol = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(mes.LParam, typeof(DEV_BROADCAST_VOLUME));
                                        MessageBox.Show("A storage device has been inserted, drive letter " + UnitName(vol.dbcv_unitmask));
                                        check(UnitName(vol.dbcv_unitmask).ToString());
                                    }
                                }
                                break;
                            case DBT_DEVICEREMOVECOMPLETE:
                                MessageBox.Show(" A Device has been removed from the system.");
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
                char[] units = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                int i = 0;
                //Convert the mask in an array, and search
                //the index for the first occurrenc (the unit’s name)
                System.Collections.BitArray bac = new
              System.Collections.BitArray(System.BitConverter.GetBytes(unitmaskname));
                foreach (bool vars in bac)
                {
                    if (vars == true)
                        break;
                    i++;
                }
                return units[i];
}
private void check(string Drive)
{
	if(System.IO.Directory.Exists(Drive + ":/Music"))
	{MessageBox.Show("Your Directory Is accessible!");}
	else{MessageBox.Show("This Directory doesn't exist!");}
}
		void Button1Click(object sender, EventArgs e)
		{
			label1.Text = "Running...";

try {
				
				backgroundWorker1.RunWorkerAsync();
	
} catch (Exception) {
				MessageBox.Show("This is already Running!!!");
}
			
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			Rectangle workingArea = Screen.GetWorkingArea(this);
this.Location = new Point(workingArea.Right - Size.Width, 
                          workingArea.Bottom - Size.Height);
			this.WindowState = FormWindowState.Minimized;
			this.Opacity = 0;
			try {
				
			
			textBox1.Text = File.ReadAllText(Application.StartupPath + "/from.dat");
			//richTextBox1.Text = File.ReadAllText(Application.StartupPath + "/selections.dat");
			//richTextBox1.Text = richTextBox1.Text.Trim();
			foreach (var location in File.ReadAllLines(Application.StartupPath + "/selections.dat")) {
				listBox2.Items.Add(location);
			}
			
			backgroundWorker1.RunWorkerAsync();
			label1.Text = "Running...";
                pictureBox1.Image = Properties.Resources.greenDot__1_;
		} catch (Exception) {
				
				
			}
			}
		void BackgroundWorker1DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
	string[] DriveList = Environment.GetLogicalDrives();
			foreach (string Drive in DriveList) {
					//MessageBox.Show(Drive + " Is available!");
				//
				foreach (string destinationPath1 in listBox2.Items) {
					if(destinationPath1 != "" || destinationPath1 != "\n" || destinationPath1 != " ")
					{
					try {
						
			string sourcePath = textBox1.Text;
        //string destinationPath = @"H:\Music";
        string destinationPath = Drive + destinationPath1;
        System.IO.DirectoryInfo dir1 = new System.IO.DirectoryInfo(sourcePath);
        System.IO.DirectoryInfo dir2 = new System.IO.DirectoryInfo(destinationPath);
		
        IEnumerable<System.IO.FileInfo> list1 = dir1.GetFiles("*.*",
        System.IO.SearchOption.AllDirectories);

        IEnumerable<System.IO.FileInfo> list2 = dir2.GetFiles("*.*",
        System.IO.SearchOption.AllDirectories);

        bool IsInDestination = false;
        bool IsInSource = false;

        foreach (System.IO.FileInfo s in list1)
        {
            IsInDestination = true;

            foreach (System.IO.FileInfo s2 in list2)
            {
                if (s.Name == s2.Name)
                {
                    IsInDestination = true;
                    break;
                }
                else
                {
                    IsInDestination = false;
                }
            }

            if (!IsInDestination)
            {
                System.IO.File.Copy(s.FullName, System.IO.Path.Combine(destinationPath, s.Name), true);
                listBox1.Items.Add(s.Name);
            }
        }

        list1 = dir1.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

        list2 = dir2.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

        bool areIdentical = list1.SequenceEqual(list2, new FileCompare());

        if (!areIdentical)
        {
            foreach (System.IO.FileInfo s in list2)
            {
                IsInSource = true;

                foreach (System.IO.FileInfo s2 in list1)
                {
                    if (s.Name == s2.Name)
                    {
                        IsInSource = true;
                        break;
                    }
                    else
                    {
                        IsInSource = false;
                    }
                }

                if (!IsInSource)
                {
                    System.IO.File.Copy(s.FullName, System.IO.Path.Combine(sourcePath, s.Name), true);
                    listBox1.Items.Add(s.Name);
                }
            }
        }
					} 
					catch (Exception) {
			}
					}
				}
		
		}
	Thread.Sleep(5000);
	}
		void BackgroundWorker1RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			backgroundWorker1.RunWorkerAsync();
		}
		void Button2Click(object sender, EventArgs e)
		{
	FolderBrowserDialog fbd = new FolderBrowserDialog();
 DialogResult result = fbd.ShowDialog();
 textBox1.Text = fbd.SelectedPath;
 File.WriteAllText(Application.StartupPath + "/from.dat", fbd.SelectedPath);
		}
		void Button3Click(object sender, EventArgs e)
		{
			string savedata = "";
		foreach (var item in listBox2.Items)
			{
                    savedata = savedata + (item.ToString() + Environment.NewLine);
				}
		File.WriteAllText(Application.StartupPath + "/selections.dat",savedata);
		}
		
	void Button4Click(object sender, EventArgs e)
		{
		FolderBrowserDialog fbd = new FolderBrowserDialog();
 		DialogResult result = fbd.ShowDialog();
 		string removing = fbd.SelectedPath.Remove(fbd.SelectedPath.IndexOf(':'));
 		listBox2.Items.Add(fbd.SelectedPath.Replace(removing + ":", ""));
 		string savedata = "";
		foreach (var item in listBox2.Items)
			{
                    savedata = savedata + (item.ToString() + Environment.NewLine);
				}
		File.WriteAllText(Application.StartupPath + "/selections.dat",savedata);
			}
		void Button5Click(object sender, EventArgs e)
		{
			panel2.Visible = false;
			panel1.Visible = true;
			button5.BackColor = Color.FromArgb(26, 188, 156);
			button6.BackColor = Color.FromArgb(34,34,34);
		}
		void Button6Click(object sender, EventArgs e)
		{
			panel2.Visible = true;
			panel1.Visible = false;
			button6.BackColor = Color.FromArgb(26, 188, 156);
			button5.BackColor = Color.FromArgb(34,34,34);
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
	 if (e.Button == MouseButtons.Left)
    {
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
			this.WindowState = FormWindowState.Normal;
			this.Opacity = .95;
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
	}
}
