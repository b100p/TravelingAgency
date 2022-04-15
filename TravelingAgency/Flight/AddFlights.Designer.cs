namespace TravelingAgency
{
    partial class AddFlights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlights));
            this.label6 = new System.Windows.Forms.Label();
            this.flightDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flightSrc = new System.Windows.Forms.ComboBox();
            this.addNewFlight = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flightDst = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flightCode = new System.Windows.Forms.TextBox();
            this.flightCapacity = new System.Windows.Forms.TextBox();
            this.viewFlightTable = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(58, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 36);
            this.label6.TabIndex = 22;
            this.label6.Text = "Date of flight";
            // 
            // flightDate
            // 
            this.flightDate.Location = new System.Drawing.Point(214, 313);
            this.flightDate.Name = "flightDate";
            this.flightDate.Size = new System.Drawing.Size(250, 27);
            this.flightDate.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // flightSrc
            // 
            this.flightSrc.FormattingEnabled = true;
            this.flightSrc.Items.AddRange(new object[] {
            "Lebanon",
            "Syria",
            "Canda",
            "America"});
            this.flightSrc.Location = new System.Drawing.Point(214, 212);
            this.flightSrc.Name = "flightSrc";
            this.flightSrc.Size = new System.Drawing.Size(151, 28);
            this.flightSrc.TabIndex = 18;
            // 
            // addNewFlight
            // 
            this.addNewFlight.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addNewFlight.Location = new System.Drawing.Point(143, 449);
            this.addNewFlight.Name = "addNewFlight";
            this.addNewFlight.Size = new System.Drawing.Size(162, 45);
            this.addNewFlight.TabIndex = 17;
            this.addNewFlight.Text = "Add new flight";
            this.addNewFlight.UseVisualStyleBackColor = false;
            this.addNewFlight.Click += new System.EventHandler(this.addNewFlight_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(58, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "Number of seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(58, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 36);
            this.label4.TabIndex = 16;
            this.label4.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(58, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Flight Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(226, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Recording a new flight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(251, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Traveling Agency";
            // 
            // flightDst
            // 
            this.flightDst.FormattingEnabled = true;
            this.flightDst.Items.AddRange(new object[] {
            "Canda",
            "Austria",
            "India",
            "Lebanon"});
            this.flightDst.Location = new System.Drawing.Point(214, 264);
            this.flightDst.Name = "flightDst";
            this.flightDst.Size = new System.Drawing.Size(151, 28);
            this.flightDst.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(58, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 36);
            this.label7.TabIndex = 23;
            this.label7.Text = "Destination";
            // 
            // flightCode
            // 
            this.flightCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flightCode.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flightCode.Location = new System.Drawing.Point(214, 154);
            this.flightCode.Name = "flightCode";
            this.flightCode.Size = new System.Drawing.Size(151, 24);
            this.flightCode.TabIndex = 25;
            // 
            // flightCapacity
            // 
            this.flightCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flightCapacity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flightCapacity.Location = new System.Drawing.Point(236, 372);
            this.flightCapacity.Name = "flightCapacity";
            this.flightCapacity.Size = new System.Drawing.Size(151, 24);
            this.flightCapacity.TabIndex = 26;
            // 
            // viewFlightTable
            // 
            this.viewFlightTable.BackColor = System.Drawing.Color.CornflowerBlue;
            this.viewFlightTable.Location = new System.Drawing.Point(329, 449);
            this.viewFlightTable.Name = "viewFlightTable";
            this.viewFlightTable.Size = new System.Drawing.Size(162, 45);
            this.viewFlightTable.TabIndex = 27;
            this.viewFlightTable.Text = "View Flights Table";
            this.viewFlightTable.UseVisualStyleBackColor = false;
            this.viewFlightTable.Click += new System.EventHandler(this.viewFlightTable_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Location = new System.Drawing.Point(513, 449);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 45);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.viewFlightTable);
            this.Controls.Add(this.flightCapacity);
            this.Controls.Add(this.flightCode);
            this.Controls.Add(this.flightDst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flightDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flightSrc);
            this.Controls.Add(this.addNewFlight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFlights";
            this.Text = "ViewFlights";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private DateTimePicker flightDate;
        private PictureBox pictureBox1;
        private ComboBox flightSrc;
        private Button addNewFlight;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox flightDst;
        private Label label7;
        private TextBox flightCode;
        private TextBox flightCapacity;
        private Button viewFlightTable;
        private Button btnBack;
    }
}