namespace TravelingAgency
{
    partial class AddPassenger
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
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.passId = new System.Windows.Forms.TextBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxNationality = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PassportNumb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PassAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.passngerAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phoneNumber
            // 
            this.phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.Location = new System.Drawing.Point(640, 271);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(151, 24);
            this.phoneNumber.TabIndex = 40;
            // 
            // passId
            // 
            this.passId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passId.Location = new System.Drawing.Point(267, 176);
            this.passId.Name = "passId";
            this.passId.Size = new System.Drawing.Size(151, 24);
            this.passId.TabIndex = 39;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(267, 307);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(151, 28);
            this.cbxGender.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(58, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 36);
            this.label7.TabIndex = 37;
            this.label7.Text = "Gender";
            // 
            // cbxNationality
            // 
            this.cbxNationality.FormattingEnabled = true;
            this.cbxNationality.Items.AddRange(new object[] {
            "Lebanese",
            "Syrian",
            "Austria",
            "Canada",
            "Malta"});
            this.cbxNationality.Location = new System.Drawing.Point(267, 259);
            this.cbxNationality.Name = "cbxNationality";
            this.cbxNationality.Size = new System.Drawing.Size(151, 28);
            this.cbxNationality.TabIndex = 33;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Location = new System.Drawing.Point(198, 388);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 45);
            this.btnLogin.TabIndex = 32;
            this.btnLogin.Text = "Add new passenger";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(431, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 36);
            this.label5.TabIndex = 30;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(58, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 36);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nationality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(58, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 36);
            this.label3.TabIndex = 29;
            this.label3.Text = "Passenger Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(298, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 36);
            this.label2.TabIndex = 28;
            this.label2.Text = "Recording a new flight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(323, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Traveling Agency";
            // 
            // PassName
            // 
            this.PassName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassName.Location = new System.Drawing.Point(267, 208);
            this.PassName.Name = "PassName";
            this.PassName.Size = new System.Drawing.Size(151, 24);
            this.PassName.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(58, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 36);
            this.label8.TabIndex = 41;
            this.label8.Text = "Passenger Name";
            // 
            // PassportNumb
            // 
            this.PassportNumb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassportNumb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassportNumb.Location = new System.Drawing.Point(640, 172);
            this.PassportNumb.Name = "PassportNumb";
            this.PassportNumb.Size = new System.Drawing.Size(151, 24);
            this.PassportNumb.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(431, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 36);
            this.label9.TabIndex = 43;
            this.label9.Text = "Passport Number";
            // 
            // PassAddress
            // 
            this.PassAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassAddress.Location = new System.Drawing.Point(640, 217);
            this.PassAddress.Name = "PassAddress";
            this.PassAddress.Size = new System.Drawing.Size(151, 24);
            this.PassAddress.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(431, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 36);
            this.label10.TabIndex = 45;
            this.label10.Text = "Passenger Address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 47;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Location = new System.Drawing.Point(384, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 45);
            this.button2.TabIndex = 48;
            this.button2.Text = "View passngers";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // passngerAge
            // 
            this.passngerAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passngerAge.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passngerAge.Location = new System.Drawing.Point(640, 320);
            this.passngerAge.Name = "passngerAge";
            this.passngerAge.Size = new System.Drawing.Size(151, 24);
            this.passngerAge.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(431, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 36);
            this.label6.TabIndex = 49;
            this.label6.Text = "Age";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(552, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 45);
            this.button3.TabIndex = 51;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 498);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.passngerAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PassAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PassportNumb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PassName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.passId);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxNationality);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPassenger";
            this.Load += new System.EventHandler(this.AddPassenger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox phoneNumber;
        private TextBox passId;
        private ComboBox cbxGender;
        private Label label7;
        private ComboBox cbxNationality;
        private Button btnLogin;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox PassName;
        private Label label8;
        private TextBox PassportNumb;
        private Label label9;
        private TextBox PassAddress;
        private Label label10;
        private Button button1;
        private Button button2;
        private TextBox passngerAge;
        private Label label6;
        private Button button3;
    }
}