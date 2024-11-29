using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Red;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Transparent;

        }

        private void buttonZoom_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) 
            {
                this.WindowState = FormWindowState.Normal;
                buttonZoom.Image = Properties.Resources.icons8_square_37_removebg_preview;


                return;
            }
            this.WindowState = FormWindowState.Maximized;
            buttonZoom.Image = Properties.Resources.icons8_minimize_sign_32_removebg_preview;


        }

        private void buttonminimize_Click(object sender, EventArgs e)
        {
            this.WindowState |= FormWindowState.Minimized;
        }

        public Point mouseLocation;

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);       
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelUserName.Parent = pictureBox1;
            labelPassWord.Parent = pictureBox1;

            labelUserName.BackColor = Color.Transparent;
            labelPassWord.BackColor = Color.Transparent;

            buttonLogin.Enabled = false;

            textBoxUserName.Focus();
        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != "" || textBoxPassWord.Text != "")
            {
                buttonLogin.Enabled = true;
                return;
            }
            if (textBoxUserName.Text == "" || textBoxPassWord.Text == "")
            {
                buttonLogin.Enabled = false;
            }

        }

        string AdminsFile = @"F:\Projects\FootBall Project\Users\Admins.txt";

        struct StAdmins
        {
            public string Username;
            public string Password;
            public byte   Permission;
        }
        
        private List<string> SplitString(string Text , string Delim="#//#")
        {
            int pos = 0;
            string Word = "";
            List<string> Mylist = new List<string>();

            while((pos = Text.IndexOf(Delim)) !=-1)
            {
                Word = Text.Substring(0, pos);
                Mylist.Add(Word);

               
                Text = Text.Remove(0, pos + Delim.Length);
            }
            if(Text!="")
            {
               
                Mylist.Add(Text.ToString());              
            }
            return Mylist;

        }

        private StAdmins LoadDataFromListToStructure(List<string> AdminList)
        {
            StAdmins AdminData = new StAdmins();

            AdminData.Username = AdminList[0];
           
            AdminData.Password = AdminList[1];

            AdminData.Permission = Convert.ToByte(AdminList[2]);

            return AdminData;
        }

        private bool CheckUserExist(StAdmins AdminDataStruct)
        {
            if(textBoxUserName.Text.ToLower() == AdminDataStruct.Username.ToLower()  && 
                textBoxPassWord.Text.ToLower() == AdminDataStruct.Password.ToLower())
            {
                return true;
            }
            return false;
        }

        private bool Login()
        {

            string[] Content = File.ReadAllLines(AdminsFile);


            List<string> AdminList = new List<string>();

            StAdmins AdminDataStruct = new StAdmins();


            for (int i=0;i<Content.Length; i++)
            {
                

                AdminList = SplitString(Content[i]);
                AdminDataStruct = LoadDataFromListToStructure(AdminList);

                if(CheckUserExist(AdminDataStruct))
                {
                    AdminList.Clear();
                    return true;              
                }

            }
            return false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                MessageBox.Show("Succes");
                this.Hide();

                Form Newform = new Form2();
                Newform.Show();
            }
            else 
            { 
                MessageBox.Show("Wrong UserName Or PassWord");
            }
        }

    }
}
