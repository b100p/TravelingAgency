namespace TravelingAgency
{
    partial class CancelTickets
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tktId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelDate = new System.Windows.Forms.DateTimePicker();
            this.flightCode = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(683, 214);
            this.dataGridView1.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(305, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 36);
            this.label5.TabIndex = 72;
            this.label5.Text = "Cancillation List";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(394, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 36);
            this.label8.TabIndex = 62;
            this.label8.Text = "Date";
            // 
            // cancelId
            // 
            this.cancelId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cancelId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelId.Location = new System.Drawing.Point(215, 114);
            this.cancelId.Name = "cancelId";
            this.cancelId.Size = new System.Drawing.Size(151, 24);
            this.cancelId.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(59, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 36);
            this.label7.TabIndex = 59;
            this.label7.Text = "Flight Code";
            // 
            // tktId
            // 
            this.tktId.FormattingEnabled = true;
            this.tktId.Location = new System.Drawing.Point(550, 118);
            this.tktId.Name = "tktId";
            this.tktId.Size = new System.Drawing.Size(151, 28);
            this.tktId.TabIndex = 58;
            this.tktId.SelectedIndexChanged += new System.EventHandler(this.tktId_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(394, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 36);
            this.label4.TabIndex = 56;
            this.label4.Text = "Ticket Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(59, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 36);
            this.label3.TabIndex = 55;
            this.label3.Text = "Cancelled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(305, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 36);
            this.label2.TabIndex = 54;
            this.label2.Text = "Ticket Booking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(305, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 53;
            this.label1.Text = "Traveling Agency";
            // 
            // cancelDate
            // 
            this.cancelDate.Location = new System.Drawing.Point(503, 168);
            this.cancelDate.Name = "cancelDate";
            this.cancelDate.Size = new System.Drawing.Size(250, 27);
            this.cancelDate.TabIndex = 74;
            // 
            // flightCode
            // 
            this.flightCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flightCode.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flightCode.Location = new System.Drawing.Point(215, 177);
            this.flightCode.Name = "flightCode";
            this.flightCode.Size = new System.Drawing.Size(151, 24);
            this.flightCode.TabIndex = 75;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Location = new System.Drawing.Point(503, 227);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 45);
            this.btnLogin.TabIndex = 76;
            this.btnLogin.Text = "Cancel Ticket";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(701, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 45);
            this.button1.TabIndex = 77;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelBookingTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.flightCode);
            this.Controls.Add(this.cancelDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancelId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tktId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancelBookingTbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelBookingTbl";
            this.Load += new System.EventHandler(this.CancelBookingTbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label5;
        private Label label8;
        private TextBox cancelId;
        private Label label7;
        private ComboBox tktId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker cancelDate;
        private TextBox flightCode;
        private Button btnLogin;
        private Button button1;
    }
}