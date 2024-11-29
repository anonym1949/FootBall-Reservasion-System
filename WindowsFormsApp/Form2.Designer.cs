namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonMatchesManagement = new System.Windows.Forms.Button();
            this.buttonReserved = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextMatchTime = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.comboBoxIndex = new System.Windows.Forms.ComboBox();
            this.radioButtonBank = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxdate = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxReserved = new System.Windows.Forms.GroupBox();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.MatchListDate = new System.Windows.Forms.MaskedTextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonSaveClient = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonIcon = new System.Windows.Forms.Button();
            this.buttonminimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonZoom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListFirst_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListStadium = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelHeader.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxReserved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.panelHeader.Controls.Add(this.buttonIcon);
            this.panelHeader.Controls.Add(this.labelName);
            this.panelHeader.Controls.Add(this.buttonminimize);
            this.panelHeader.Controls.Add(this.buttonClose);
            this.panelHeader.Controls.Add(this.buttonZoom);
            this.panelHeader.Location = new System.Drawing.Point(1, -2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1040, 42);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(48, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(245, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Football Reservations system";
            // 
            // buttonMatchesManagement
            // 
            this.buttonMatchesManagement.BackColor = System.Drawing.Color.Transparent;
            this.buttonMatchesManagement.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.buttonMatchesManagement.FlatAppearance.BorderSize = 2;
            this.buttonMatchesManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatchesManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMatchesManagement.ForeColor = System.Drawing.Color.White;
            this.buttonMatchesManagement.Location = new System.Drawing.Point(12, 80);
            this.buttonMatchesManagement.Name = "buttonMatchesManagement";
            this.buttonMatchesManagement.Size = new System.Drawing.Size(141, 48);
            this.buttonMatchesManagement.TabIndex = 4;
            this.buttonMatchesManagement.Text = "Add Match";
            this.buttonMatchesManagement.UseVisualStyleBackColor = false;
            this.buttonMatchesManagement.MouseEnter += new System.EventHandler(this.buttonMatchesManagement_MouseEnter);
            this.buttonMatchesManagement.MouseLeave += new System.EventHandler(this.buttonMatchesManagement_MouseLeave);
            // 
            // buttonReserved
            // 
            this.buttonReserved.BackColor = System.Drawing.Color.Transparent;
            this.buttonReserved.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.buttonReserved.FlatAppearance.BorderSize = 2;
            this.buttonReserved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReserved.ForeColor = System.Drawing.Color.White;
            this.buttonReserved.Location = new System.Drawing.Point(553, 80);
            this.buttonReserved.Name = "buttonReserved";
            this.buttonReserved.Size = new System.Drawing.Size(226, 48);
            this.buttonReserved.TabIndex = 10;
            this.buttonReserved.Text = "Show Reserved Matchs";
            this.buttonReserved.UseVisualStyleBackColor = false;
            this.buttonReserved.Click += new System.EventHandler(this.buttonReserved_Click);
            this.buttonReserved.MouseEnter += new System.EventHandler(this.buttonReserved_MouseEnter);
            this.buttonReserved.MouseLeave += new System.EventHandler(this.buttonReserved_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Match Time";
            // 
            // maskedTextMatchTime
            // 
            this.maskedTextMatchTime.BackColor = System.Drawing.Color.Chartreuse;
            this.maskedTextMatchTime.Location = new System.Drawing.Point(138, 200);
            this.maskedTextMatchTime.Mask = "00:00";
            this.maskedTextMatchTime.Name = "maskedTextMatchTime";
            this.maskedTextMatchTime.Size = new System.Drawing.Size(123, 20);
            this.maskedTextMatchTime.TabIndex = 4;
            this.maskedTextMatchTime.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stadium Index";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Match Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Payment Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Name";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.BackColor = System.Drawing.Color.Chartreuse;
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(138, 122);
            this.maskedTextBoxPhone.Mask = "00-00-00-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(123, 20);
            this.maskedTextBoxPhone.TabIndex = 2;
            // 
            // textBoxFN
            // 
            this.textBoxFN.BackColor = System.Drawing.Color.Chartreuse;
            this.textBoxFN.Location = new System.Drawing.Point(138, 23);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(123, 20);
            this.textBoxFN.TabIndex = 0;
            // 
            // textBoxLN
            // 
            this.textBoxLN.BackColor = System.Drawing.Color.Chartreuse;
            this.textBoxLN.Location = new System.Drawing.Point(138, 74);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(123, 20);
            this.textBoxLN.TabIndex = 1;
            // 
            // comboBoxIndex
            // 
            this.comboBoxIndex.BackColor = System.Drawing.Color.Chartreuse;
            this.comboBoxIndex.FormattingEnabled = true;
            this.comboBoxIndex.Items.AddRange(new object[] {
            "Stadium (A)",
            "Stadium (B)",
            "Stadium (C)"});
            this.comboBoxIndex.Location = new System.Drawing.Point(138, 278);
            this.comboBoxIndex.Name = "comboBoxIndex";
            this.comboBoxIndex.Size = new System.Drawing.Size(123, 21);
            this.comboBoxIndex.TabIndex = 6;
            // 
            // radioButtonBank
            // 
            this.radioButtonBank.AutoSize = true;
            this.radioButtonBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBank.ForeColor = System.Drawing.Color.White;
            this.radioButtonBank.Location = new System.Drawing.Point(229, 323);
            this.radioButtonBank.Name = "radioButtonBank";
            this.radioButtonBank.Size = new System.Drawing.Size(60, 22);
            this.radioButtonBank.TabIndex = 8;
            this.radioButtonBank.TabStop = true;
            this.radioButtonBank.Text = "Bank";
            this.radioButtonBank.UseVisualStyleBackColor = true;
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCash.ForeColor = System.Drawing.Color.White;
            this.radioButtonCash.Location = new System.Drawing.Point(158, 323);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(61, 22);
            this.radioButtonCash.TabIndex = 7;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Match Date";
            // 
            // maskedTextBoxdate
            // 
            this.maskedTextBoxdate.BackColor = System.Drawing.Color.Chartreuse;
            this.maskedTextBoxdate.Location = new System.Drawing.Point(138, 160);
            this.maskedTextBoxdate.Mask = "00/00/0000";
            this.maskedTextBoxdate.Name = "maskedTextBoxdate";
            this.maskedTextBoxdate.Size = new System.Drawing.Size(123, 20);
            this.maskedTextBoxdate.TabIndex = 3;
            this.maskedTextBoxdate.ValidatingType = typeof(System.DateTime);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxAdd.Controls.Add(this.numericUpDown1);
            this.groupBoxAdd.Controls.Add(this.maskedTextBoxdate);
            this.groupBoxAdd.Controls.Add(this.label8);
            this.groupBoxAdd.Controls.Add(this.radioButtonCash);
            this.groupBoxAdd.Controls.Add(this.radioButtonBank);
            this.groupBoxAdd.Controls.Add(this.buttonSaveClient);
            this.groupBoxAdd.Controls.Add(this.comboBoxIndex);
            this.groupBoxAdd.Controls.Add(this.textBoxLN);
            this.groupBoxAdd.Controls.Add(this.textBoxFN);
            this.groupBoxAdd.Controls.Add(this.maskedTextBoxPhone);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.label7);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Controls.Add(this.label3);
            this.groupBoxAdd.Controls.Add(this.label6);
            this.groupBoxAdd.Controls.Add(this.label4);
            this.groupBoxAdd.Controls.Add(this.maskedTextMatchTime);
            this.groupBoxAdd.Controls.Add(this.label5);
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 124);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(312, 415);
            this.groupBoxAdd.TabIndex = 9;
            this.groupBoxAdd.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Chartreuse;
            this.numericUpDown1.Location = new System.Drawing.Point(138, 239);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 29;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxReserved
            // 
            this.groupBoxReserved.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxReserved.Controls.Add(this.listView1);
            this.groupBoxReserved.Controls.Add(this.buttonRemoveAll);
            this.groupBoxReserved.Controls.Add(this.label9);
            this.groupBoxReserved.Controls.Add(this.MatchListDate);
            this.groupBoxReserved.Controls.Add(this.buttonSearch);
            this.groupBoxReserved.Controls.Add(this.buttonRemove);
            this.groupBoxReserved.Location = new System.Drawing.Point(341, 124);
            this.groupBoxReserved.Name = "groupBoxReserved";
            this.groupBoxReserved.Size = new System.Drawing.Size(680, 415);
            this.groupBoxReserved.TabIndex = 10;
            this.groupBoxReserved.TabStop = false;
            this.groupBoxReserved.Visible = false;
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveAll.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveAll.Location = new System.Drawing.Point(386, 14);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(119, 27);
            this.buttonRemoveAll.TabIndex = 32;
            this.buttonRemoveAll.Text = "Remove";
            this.buttonRemoveAll.UseVisualStyleBackColor = false;
            this.buttonRemoveAll.MouseEnter += new System.EventHandler(this.buttonRemoveAll_MouseEnter);
            this.buttonRemoveAll.MouseLeave += new System.EventHandler(this.buttonRemoveAll_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(11, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Enter Date";
            // 
            // MatchListDate
            // 
            this.MatchListDate.BackColor = System.Drawing.Color.Chartreuse;
            this.MatchListDate.Location = new System.Drawing.Point(92, 19);
            this.MatchListDate.Mask = "00/00/0000";
            this.MatchListDate.Name = "MatchListDate";
            this.MatchListDate.Size = new System.Drawing.Size(123, 20);
            this.MatchListDate.TabIndex = 30;
            this.MatchListDate.ValidatingType = typeof(System.DateTime);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(221, 14);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 27);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            this.buttonSearch.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.buttonSearch.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(522, 14);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(137, 27);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "Remove Selected";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.MouseEnter += new System.EventHandler(this.buttonRemove_MouseEnter);
            this.buttonRemove.MouseLeave += new System.EventHandler(this.buttonRemove_MouseLeave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-person-30.png");
            this.imageList1.Images.SetKeyName(1, "icons8-phone-30.png");
            this.imageList1.Images.SetKeyName(2, "icons8-time-30.png");
            this.imageList1.Images.SetKeyName(3, "icons8-hourglass,-antique-stopwatch-timer-measurement-sandclock-device-30.png");
            this.imageList1.Images.SetKeyName(4, "icons8-stadium-30.png");
            this.imageList1.Images.SetKeyName(5, "icons8-delete-35.png");
            // 
            // buttonSaveClient
            // 
            this.buttonSaveClient.BackColor = System.Drawing.Color.Lime;
            this.buttonSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveClient.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_38;
            this.buttonSaveClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveClient.Location = new System.Drawing.Point(55, 371);
            this.buttonSaveClient.Name = "buttonSaveClient";
            this.buttonSaveClient.Size = new System.Drawing.Size(172, 38);
            this.buttonSaveClient.TabIndex = 9;
            this.buttonSaveClient.Text = "Save";
            this.buttonSaveClient.UseVisualStyleBackColor = false;
            this.buttonSaveClient.Click += new System.EventHandler(this.buttonSaveClient_Click);
            this.buttonSaveClient.MouseEnter += new System.EventHandler(this.buttonSaveClient_MouseEnter);
            this.buttonSaveClient.MouseLeave += new System.EventHandler(this.buttonSaveClient_MouseLeave);
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.football_stadium_sky_night_wallpaper_preview;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListFirst_Name,
            this.ListPhone,
            this.ListDate,
            this.ListDuration,
            this.ListStadium,
            this.ListPayment});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(680, 370);
            this.listView1.TabIndex = 34;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // buttonIcon
            // 
            this.buttonIcon.FlatAppearance.BorderSize = 0;
            this.buttonIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIcon.Image = global::WindowsFormsApp1.Properties.Resources.soccer_ball_variant_removebg_preview1;
            this.buttonIcon.Location = new System.Drawing.Point(0, 3);
            this.buttonIcon.Name = "buttonIcon";
            this.buttonIcon.Size = new System.Drawing.Size(42, 37);
            this.buttonIcon.TabIndex = 1;
            this.buttonIcon.UseVisualStyleBackColor = true;
            // 
            // buttonminimize
            // 
            this.buttonminimize.FlatAppearance.BorderSize = 0;
            this.buttonminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonminimize.Image = global::WindowsFormsApp1.Properties.Resources.icons8_minimize_26;
            this.buttonminimize.Location = new System.Drawing.Point(916, 0);
            this.buttonminimize.Name = "buttonminimize";
            this.buttonminimize.Size = new System.Drawing.Size(37, 37);
            this.buttonminimize.TabIndex = 2;
            this.buttonminimize.UseVisualStyleBackColor = true;
            this.buttonminimize.Click += new System.EventHandler(this.buttonminimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonClose.Image = global::WindowsFormsApp1.Properties.Resources.icons8_close_37_removebg_preview1;
            this.buttonClose.Location = new System.Drawing.Point(1002, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(37, 37);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // buttonZoom
            // 
            this.buttonZoom.FlatAppearance.BorderSize = 0;
            this.buttonZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoom.Image = global::WindowsFormsApp1.Properties.Resources.icons8_square_37_removebg_preview;
            this.buttonZoom.Location = new System.Drawing.Point(959, 0);
            this.buttonZoom.Name = "buttonZoom";
            this.buttonZoom.Size = new System.Drawing.Size(37, 37);
            this.buttonZoom.TabIndex = 1;
            this.buttonZoom.UseVisualStyleBackColor = true;
            this.buttonZoom.Click += new System.EventHandler(this.buttonZoom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.wallpaperflare_com_wallpaper;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1040, 588);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ListFirst_Name
            // 
            this.ListFirst_Name.Text = "First Name";
            this.ListFirst_Name.Width = 126;
            // 
            // ListPhone
            // 
            this.ListPhone.Text = "Phone";
            this.ListPhone.Width = 143;
            // 
            // ListDate
            // 
            this.ListDate.Text = "Time";
            this.ListDate.Width = 102;
            // 
            // ListDuration
            // 
            this.ListDuration.Text = "Duration";
            this.ListDuration.Width = 85;
            // 
            // ListStadium
            // 
            this.ListStadium.Text = "Stadium";
            this.ListStadium.Width = 124;
            // 
            // ListPayment
            // 
            this.ListPayment.Text = "Payment";
            // 
            // Form2
            // 
            this.AcceptButton = this.buttonSaveClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 589);
            this.Controls.Add(this.groupBoxReserved);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.buttonReserved);
            this.Controls.Add(this.buttonMatchesManagement);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxReserved.ResumeLayout(false);
            this.groupBoxReserved.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonIcon;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonminimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonZoom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMatchesManagement;
        private System.Windows.Forms.Button buttonReserved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextMatchTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.ComboBox comboBoxIndex;
        private System.Windows.Forms.Button buttonSaveClient;
        private System.Windows.Forms.RadioButton radioButtonBank;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxdate;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.GroupBox groupBoxReserved;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox MatchListDate;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ListFirst_Name;
        private System.Windows.Forms.ColumnHeader ListPhone;
        private System.Windows.Forms.ColumnHeader ListDate;
        private System.Windows.Forms.ColumnHeader ListDuration;
        private System.Windows.Forms.ColumnHeader ListStadium;
        private System.Windows.Forms.ColumnHeader ListPayment;
    }
}