using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DateClass;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string Errors = "";
        Point mouseLocation;
        string MatchsFile = @"F:\Projects\FootBall Project\Reserved_Matchs\Matchs.txt";
        string Sep = "#//#";
        struct St_Match
        {
           public string FN;
           public string LN;
           public string Time;
           public string Date;
           public string Phone;
           public string Stadium;
           public int    Duration;
           public string Payment;
        }
        private void Form2_Load(object sender, EventArgs e) 
        {
            
            groupBoxAdd.Parent = pictureBox1;
            groupBoxAdd.BackColor = Color.Transparent;

            groupBoxReserved.Parent = pictureBox1;
            groupBoxReserved.BackColor = Color.Transparent;

            buttonMatchesManagement.Parent = pictureBox1;
            buttonMatchesManagement.BackColor = Color.Transparent;

            buttonReserved.Parent = pictureBox1;
            buttonReserved.BackColor = Color.Transparent;

          
            listView1.Parent = groupBoxReserved;
            //listView1.BackColor = Color.Transparent;


          
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

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);

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

        private void buttonminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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


        private void buttonMatchesManagement_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonMatchesManagement_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        
        private void buttonSaveClient_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonSaveClient_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonReserved_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonReserved_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

        }

        private void buttonRemove_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;

        }

        private void buttonRemove_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

        }

        private void buttonRemoveAll_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;

        }

        private void buttonRemoveAll_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

        }


        private bool CheckAllInfoAreOk()
        {
            if (textBoxFN.Text.Length <= 1 || textBoxFN.Text == "")
            {
                Errors += "First Name" + Environment.NewLine;
                //return 1;
            }

            if (textBoxLN.Text == "")
            {
                Errors += "last Name" + Environment.NewLine;
               // return 2;
            }

            if (maskedTextBoxPhone.Text.Length - 4 != 10)
            {
                Errors += "Phone Number" + Environment.NewLine;
               // return 3;
            }

            if (maskedTextBoxdate.Text.Length - 2 != 8)
            {
                Errors += "Match Date" + Environment.NewLine;
               // return 4;
            }

            if (maskedTextMatchTime.Text.Length - 1 != 4)
            {
                Errors += "Match Start Time" + Environment.NewLine;
               // return 5;
            }
       
            if (comboBoxIndex.SelectedItem == null)
            {
                Errors += "Stadium Index" + Environment.NewLine;
               // return 9;
            }

            if (radioButtonBank.Checked == false && radioButtonCash.Checked == false)
            {
                Errors += "Payment Method" + Environment.NewLine;
               // return 10;
            }

            if(Errors =="")
            {
                return true;
            }


            return false;
           
        }

        private List<string> SplitString(string Text, string Delim = "#//#")
        {
            int pos = 0;
            string Word = "";
            List<string> Mylist = new List<string>();

            while ((pos = Text.IndexOf(Delim)) != -1)
            {
                Word = Text.Substring(0, pos);
                Mylist.Add(Word);


                Text = Text.Remove(0, pos + Delim.Length);
            }
            if (Text != "")
            {

                Mylist.Add(Text.ToString());
            }
            return Mylist;

        }

        private bool CheckValidHour(int H)
        {
            int[] Arr = { 00, 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            for(int i=0;i<Arr.Length; i++)
            {
                if(H == Arr[i])
                {
                    return true;
                }

            }
            return false;
        }

        private bool CheckTimeStartLessThanEnd(string Start , string End)
        {
            List<string> StartTime = SplitString(Start, ":");
            List<string> EndTime = SplitString(End, ":");


            int IStart = Convert.ToUInt16(StartTime[0]);
            int IEnd = Convert.ToUInt16(EndTime[0]);

            if(IEnd ==00)
            {
                return true;
            }

            if(IStart >= IEnd)
            {
                Errors += "Cannot Be Match Start Time Be After Or Equal Match End Time" + Environment.NewLine;
                return false;
            }
            return true;
        }
        private bool CheckValidTime(string Time)
        {
            List<string> HourList = SplitString(Time, ":");
            int Hour = Convert.ToInt16(HourList[0]);
            int Minutes = Convert.ToInt16(HourList[1]);

            if (CheckValidHour(Hour) && Minutes ==0)
            {
                return true;
            }
            Errors += "Match Time Not Valid EXp:(10:00)" + Environment.NewLine;
            return false;
        }
        private bool CheckValidDate(string Date)
        {
            List<string>ListDate = SplitString(Date, "-");
            int Year, Month, Day;

            Day = Convert.ToInt16(ListDate[0]);
            Month = Convert.ToInt16(ListDate[1]);
            Year = Convert.ToInt16(ListDate[2]);

            Date date = new Date(Year, Month, Day);
            
           if( date.CheckValidDate() && !date.CheckDateIsPasse())
            {       
                return true; 
            }
            
            Errors += "Check Match Date (dd/mm/yyyy) Or Date Is Passe" + Environment.NewLine;
            return false;
        }

        private string PaymentMethod()
        {
            if(radioButtonCash.Checked)
            {
                return radioButtonCash.Text;
            }
            return radioButtonBank.Text;
        }
        private St_Match LoadMatchDataToStruct()
        {
            St_Match match = new St_Match();    

            match.FN = textBoxFN.Text;
            match.LN = textBoxLN.Text;
            match.Phone = maskedTextBoxPhone.Text;
            match.Time = maskedTextMatchTime.Text;
            match.Date = maskedTextBoxdate.Text;
            match.Duration = Convert.ToInt16(numericUpDown1.Value);
            match.Stadium = comboBoxIndex.SelectedItem.ToString();
            match.Payment = PaymentMethod();
            return match;
        }
        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            if (CheckAllInfoAreOk() == false)
            {
                MessageBox.Show("Please Fill All Columns ","Empty Column(s)", MessageBoxButtons.OK,MessageBoxIcon.Error);
                Errors = "";
                return;
            }

            CheckValidTime(maskedTextMatchTime.Text.ToString());
            CheckValidDate(maskedTextBoxdate.Text.ToString());


            if (Errors != "")
            {
                MessageBox.Show(("Please Check This Fields Are Valid :" + Environment.NewLine + Environment.NewLine + Errors),
                    "Invalid Information(s)", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Errors = "";
                return;
            }

            if (Errors == "")
            {
               DialogResult =  MessageBox.Show(("Are You Sure You Want To Confirm This Match :"),
                    "Match Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if(DialogResult == DialogResult.OK)
                {
                    MessageBox.Show(("Match Are Reserved SuccesFully To The System:) "),
                    "Match Added SuccesFully", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Errors = "";
                    St_Match match = LoadMatchDataToStruct();
                    File.AppendAllText(MatchsFile, match.FN + Sep + match.LN + Sep  + match.Phone + Sep + match.Date + Sep  + match.Time + Sep +
                        match.Duration + Sep + match.Stadium + Sep +  match.Payment + Environment.NewLine);

                }

            }

           

        }

        private bool CheckDateEqualDate(string Date1 , string Date2)
        {
            if(Date1 == Date2)
            {
                return true;
            }
            return false;
        }
        private St_Match LoadDataFromListToStruct(List<string>List_MatchData )
        {
            St_Match match = new St_Match();

            match.FN       = List_MatchData[0];
            match.LN       = List_MatchData[1];
            match.Phone    = List_MatchData[2];
            match.Date     = List_MatchData[3];
            match.Time     = List_MatchData[4];
            match.Duration =Convert.ToInt16(List_MatchData[5]);
            match.Stadium  = List_MatchData[6];
            match.Payment  = List_MatchData[7];
            return match;
        }
    
        
        private bool CheckMatchExist(ref St_Match st_Match)
        {
            string[] Arr_MatchsData = File.ReadAllLines(MatchsFile);

            if (Arr_MatchsData.Length==0)
            {
               
                return false;
            }

            for (int i = 0; i < Arr_MatchsData.Length ; i++)
            {
                List<string> List_MatchsData = SplitString(Arr_MatchsData[i]);

               St_Match St_MatchData = LoadDataFromListToStruct(List_MatchsData);
             
               if (MatchListDate.Text == St_MatchData.Date)
               {
                   st_Match = St_MatchData;
                   return true;
               }
           }

         return false;
        }

        private void ShowMatchsInformations()
        {

            St_Match St_MatchData = new St_Match();

                if (!CheckMatchExist(ref St_MatchData))
                {
                   MessageBox.Show(("No Match Exist In This Date :"+ MatchListDate.Text.ToString()),
                  "Matchs Not Sxist", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                  return;
                }


            ListViewItem MylistView = new ListViewItem( St_MatchData.FN);

            MylistView.SubItems.Add(St_MatchData.Phone);
            MylistView.SubItems.Add(St_MatchData.Time);
            MylistView.SubItems.Add(St_MatchData.Duration.ToString());
            MylistView.SubItems.Add(St_MatchData.Stadium);
            MylistView.SubItems.Add(St_MatchData.Payment);
            listView1.Items.Add(MylistView);

        }



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (MatchListDate.Text.Length - 2 != 8 || CheckValidDate(MatchListDate.Text)==false)
            {
                MessageBox.Show(("Please Enter A Valid Date :"),
                "Invalid Date", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Errors = "";
                return;
            }

            ShowMatchsInformations();    
        }

        private void buttonReserved_Click(object sender, EventArgs e)
        {
            if(groupBoxReserved.Visible == true)
            {

                groupBoxReserved.Visible = false;
                buttonReserved.Text = "Show Reserved Matchs";
                return;
            }
            groupBoxReserved.Visible = true;
            buttonReserved.Text = "Hide Reserved Matchs";

        }
    }
}
