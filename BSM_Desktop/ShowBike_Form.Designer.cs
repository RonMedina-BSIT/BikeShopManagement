namespace BSM_Desktop
{
    partial class ShowBike_Form
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
            ShowBikeTable = new DataGridView();
            Showbtn = new Button();
            pictureBox1 = new PictureBox();
            Exitbtn = new Button();
            groupBox1 = new GroupBox();
            Frametxtfld = new TextBox();
            Wheeltxtfld = new TextBox();
            GroupsetTxtfld = new TextBox();
            Pricetxtfld = new TextBox();
            Brandtxtfld = new TextBox();
            Typetxtfld = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            UpdateBtn = new Button();
            Addbtn = new Button();
            Deletebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ShowBikeTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ShowBikeTable
            // 
            ShowBikeTable.AllowUserToOrderColumns = true;
            ShowBikeTable.BackgroundColor = Color.Silver;
            ShowBikeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowBikeTable.Location = new Point(12, 28);
            ShowBikeTable.Name = "ShowBikeTable";
            ShowBikeTable.RowHeadersWidth = 51;
            ShowBikeTable.Size = new Size(802, 395);
            ShowBikeTable.TabIndex = 0;
            ShowBikeTable.CellClick += ShowBikeTable_CellContentClick;
            ShowBikeTable.CellContentClick += ShowBikeTable_CellContentClick;
            // 
            // Showbtn
            // 
            Showbtn.BackColor = Color.LightGray;
            Showbtn.Cursor = Cursors.Hand;
            Showbtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Showbtn.Location = new Point(720, 439);
            Showbtn.Name = "Showbtn";
            Showbtn.Size = new Size(94, 29);
            Showbtn.TabIndex = 1;
            Showbtn.Text = "Show";
            Showbtn.UseVisualStyleBackColor = false;
            Showbtn.Click += Showbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Plain_Background;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1376, 546);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = Color.LightGray;
            Exitbtn.Cursor = Cursors.Hand;
            Exitbtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exitbtn.Location = new Point(29, 508);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(94, 29);
            Exitbtn.TabIndex = 3;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.Click += Backbtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(Frametxtfld);
            groupBox1.Controls.Add(Wheeltxtfld);
            groupBox1.Controls.Add(GroupsetTxtfld);
            groupBox1.Controls.Add(Pricetxtfld);
            groupBox1.Controls.Add(Brandtxtfld);
            groupBox1.Controls.Add(Typetxtfld);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(902, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 466);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bike Info";
            // 
            // Frametxtfld
            // 
            Frametxtfld.Location = new Point(146, 151);
            Frametxtfld.Multiline = true;
            Frametxtfld.Name = "Frametxtfld";
            Frametxtfld.Size = new Size(262, 82);
            Frametxtfld.TabIndex = 12;
            // 
            // Wheeltxtfld
            // 
            Wheeltxtfld.Location = new Point(146, 344);
            Wheeltxtfld.Multiline = true;
            Wheeltxtfld.Name = "Wheeltxtfld";
            Wheeltxtfld.Size = new Size(262, 93);
            Wheeltxtfld.TabIndex = 11;
            // 
            // GroupsetTxtfld
            // 
            GroupsetTxtfld.Location = new Point(146, 241);
            GroupsetTxtfld.Multiline = true;
            GroupsetTxtfld.Name = "GroupsetTxtfld";
            GroupsetTxtfld.Size = new Size(262, 93);
            GroupsetTxtfld.TabIndex = 10;
            // 
            // Pricetxtfld
            // 
            Pricetxtfld.Location = new Point(146, 118);
            Pricetxtfld.Name = "Pricetxtfld";
            Pricetxtfld.Size = new Size(262, 27);
            Pricetxtfld.TabIndex = 8;
            // 
            // Brandtxtfld
            // 
            Brandtxtfld.Location = new Point(146, 77);
            Brandtxtfld.Name = "Brandtxtfld";
            Brandtxtfld.Size = new Size(262, 27);
            Brandtxtfld.TabIndex = 7;
            // 
            // Typetxtfld
            // 
            Typetxtfld.Location = new Point(146, 38);
            Typetxtfld.Name = "Typetxtfld";
            Typetxtfld.Size = new Size(262, 27);
            Typetxtfld.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 181);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "FrameSet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 380);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 4;
            label5.Text = "WheelSet:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 278);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 3;
            label4.Text = "GroupSet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 121);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 81);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Brand:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Type:";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.LightGray;
            UpdateBtn.Cursor = Cursors.Hand;
            UpdateBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(1085, 508);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 29);
            UpdateBtn.TabIndex = 5;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.LightGray;
            Addbtn.Cursor = Cursors.Hand;
            Addbtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Addbtn.Location = new Point(902, 508);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(94, 29);
            Addbtn.TabIndex = 6;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.LightGray;
            Deletebtn.Cursor = Cursors.Hand;
            Deletebtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Deletebtn.Location = new Point(1255, 508);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(94, 29);
            Deletebtn.TabIndex = 7;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // ShowBike_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 549);
            Controls.Add(Deletebtn);
            Controls.Add(Addbtn);
            Controls.Add(UpdateBtn);
            Controls.Add(groupBox1);
            Controls.Add(Exitbtn);
            Controls.Add(Showbtn);
            Controls.Add(ShowBikeTable);
            Controls.Add(pictureBox1);
            Name = "ShowBike_Form";
            Text = "ShowBike_Form";
            ((System.ComponentModel.ISupportInitialize)ShowBikeTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ShowBikeTable;
        private Button Showbtn;
        private PictureBox pictureBox1;
        private Button Exitbtn;
        private GroupBox groupBox1;
        private TextBox Wheeltxtfld;
        private TextBox GroupsetTxtfld;
        private TextBox Pricetxtfld;
        private TextBox Brandtxtfld;
        private TextBox Typetxtfld;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button UpdateBtn;
        private TextBox Frametxtfld;
        private Button Addbtn;
        private Button Deletebtn;
    }
}