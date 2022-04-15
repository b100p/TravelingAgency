namespace TravelingAgency
{
    partial class AddTickets
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
            this.ticketCode = new System.Windows.Forms.TextBox();
            this.passengerId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flightCode = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.passportNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.passNationlity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.passAge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.amnt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketCode
            // 
            this.ticketCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ticketCode.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketCode.Location = new System.Drawing.Point(168, 117);
            this.ticketCode.Name = "ticketCode";
            this.ticketCode.Size = new System.Drawing.Size(151, 24);
            this.ticketCode.TabIndex = 39;
            // 
            // passengerId
            // 
            this.passengerId.FormattingEnabled = true;
            this.passengerId.Location = new System.Drawing.Point(168, 180);
            this.passengerId.Name = "passengerId";
            this.passengerId.Size = new System.Drawing.Size(151, 28);
            this.passengerId.TabIndex = 38;
            this.passengerId.SelectedIndexChanged += new System.EventHandler(this.passengerId_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(12, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 36);
            this.label7.TabIndex = 37;
            this.label7.Text = "Passnger Id";
            // 
            // flightCode
            // 
            this.flightCode.FormattingEnabled = true;
            this.flightCode.Location = new System.Drawing.Point(503, 121);
            this.flightCode.Name = "flightCode";
            this.flightCode.Size = new System.Drawing.Size(151, 28);
            this.flightCode.TabIndex = 33;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Location = new System.Drawing.Point(125, 307);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 45);
            this.btnLogin.TabIndex = 32;
            this.btnLogin.Text = "Issue Ticket";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(347, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 36);
            this.label4.TabIndex = 31;
            this.label4.Text = "Flight Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 36);
            this.label3.TabIndex = 29;
            this.label3.Text = "TicketCode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(258, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 36);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ticket Booking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Traveling Agency";
            // 
            // passName
            // 
            this.passName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passName.Location = new System.Drawing.Point(503, 172);
            this.passName.Name = "passName";
            this.passName.Size = new System.Drawing.Size(151, 24);
            this.passName.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(347, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 36);
            this.label8.TabIndex = 41;
            this.label8.Text = "Name";
            // 
            // passportNumber
            // 
            this.passportNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passportNumber.Location = new System.Drawing.Point(174, 234);
            this.passportNumber.Name = "passportNumber";
            this.passportNumber.Size = new System.Drawing.Size(151, 24);
            this.passportNumber.TabIndex = 44;
            this.passportNumber.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(18, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 36);
            this.label9.TabIndex = 43;
            this.label9.Text = "Passport";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // passNationlity
            // 
            this.passNationlity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passNationlity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passNationlity.Location = new System.Drawing.Point(503, 230);
            this.passNationlity.Name = "passNationlity";
            this.passNationlity.Size = new System.Drawing.Size(151, 24);
            this.passNationlity.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(347, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 36);
            this.label10.TabIndex = 45;
            this.label10.Text = "Nationality";
            // 
            // passAge
            // 
            this.passAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passAge.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passAge.Location = new System.Drawing.Point(174, 277);
            this.passAge.Name = "passAge";
            this.passAge.Size = new System.Drawing.Size(151, 24);
            this.passAge.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(18, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 36);
            this.label11.TabIndex = 47;
            this.label11.Text = "Age";
            // 
            // amnt
            // 
            this.amnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amnt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amnt.Location = new System.Drawing.Point(503, 277);
            this.amnt.Name = "amnt";
            this.amnt.Size = new System.Drawing.Size(151, 24);
            this.amnt.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(347, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 36);
            this.label12.TabIndex = 49;
            this.label12.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(309, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 36);
            this.label5.TabIndex = 51;
            this.label5.Text = "Booking";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(683, 214);
            this.dataGridView1.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(387, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 45);
            this.button1.TabIndex = 53;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amnt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.passAge);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.passNationlity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.passportNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.passName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ticketCode);
            this.Controls.Add(this.passengerId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flightCode);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox ticketCode;
        private ComboBox passengerId;
        private Label label7;
        private ComboBox flightCode;
        private Button btnLogin;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox passName;
        private Label label8;
        private TextBox passportNumber;
        private Label label9;
        private TextBox passNationlity;
        private Label label10;
        private TextBox passAge;
        private Label label11;
        private TextBox amnt;
        private Label label12;
        private Label label5;
        private DataGridView dataGridView1;
        private Button button1;
    }
}