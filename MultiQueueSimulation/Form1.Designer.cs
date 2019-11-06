namespace MultiQueueSimulation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ServersNum = new System.Windows.Forms.Label();
            this.StopingNum = new System.Windows.Forms.Label();
            this.StoppingCriteria = new System.Windows.Forms.Label();
            this.InterarrivalDistribution = new System.Windows.Forms.Label();
            this.SelectionMethod = new System.Windows.Forms.Label();
            this.NumOfS = new System.Windows.Forms.NumericUpDown();
            this.StoppingNum = new System.Windows.Forms.NumericUpDown();
            this.StopC = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.InterAT = new System.Windows.Forms.DataGridView();
            this.TimeC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDistribution = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Submit = new System.Windows.Forms.Button();
            this.NextServer = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.read_from_file = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoppingNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ServersNum
            // 
            this.ServersNum.AutoSize = true;
            this.ServersNum.BackColor = System.Drawing.Color.Transparent;
            this.ServersNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServersNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServersNum.Location = new System.Drawing.Point(383, 37);
            this.ServersNum.Name = "ServersNum";
            this.ServersNum.Size = new System.Drawing.Size(173, 20);
            this.ServersNum.TabIndex = 0;
            this.ServersNum.Text = "Number of Servers : ";
            // 
            // StopingNum
            // 
            this.StopingNum.AutoSize = true;
            this.StopingNum.BackColor = System.Drawing.Color.Transparent;
            this.StopingNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StopingNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopingNum.Location = new System.Drawing.Point(383, 125);
            this.StopingNum.Name = "StopingNum";
            this.StopingNum.Size = new System.Drawing.Size(163, 20);
            this.StopingNum.TabIndex = 1;
            this.StopingNum.Text = "Stopping Number : ";
            // 
            // StoppingCriteria
            // 
            this.StoppingCriteria.AutoSize = true;
            this.StoppingCriteria.BackColor = System.Drawing.Color.Transparent;
            this.StoppingCriteria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StoppingCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoppingCriteria.Location = new System.Drawing.Point(387, 83);
            this.StoppingCriteria.Name = "StoppingCriteria";
            this.StoppingCriteria.Size = new System.Drawing.Size(159, 20);
            this.StoppingCriteria.TabIndex = 2;
            this.StoppingCriteria.Text = "Stopping Criteria : ";
            // 
            // InterarrivalDistribution
            // 
            this.InterarrivalDistribution.AutoSize = true;
            this.InterarrivalDistribution.BackColor = System.Drawing.Color.Transparent;
            this.InterarrivalDistribution.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InterarrivalDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterarrivalDistribution.Location = new System.Drawing.Point(24, 34);
            this.InterarrivalDistribution.Name = "InterarrivalDistribution";
            this.InterarrivalDistribution.Size = new System.Drawing.Size(207, 20);
            this.InterarrivalDistribution.TabIndex = 3;
            this.InterarrivalDistribution.Text = "Interarrival Distribution : ";
            // 
            // SelectionMethod
            // 
            this.SelectionMethod.AutoSize = true;
            this.SelectionMethod.BackColor = System.Drawing.Color.Transparent;
            this.SelectionMethod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SelectionMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionMethod.Location = new System.Drawing.Point(377, 170);
            this.SelectionMethod.Name = "SelectionMethod";
            this.SelectionMethod.Size = new System.Drawing.Size(169, 20);
            this.SelectionMethod.TabIndex = 4;
            this.SelectionMethod.Tag = "";
            this.SelectionMethod.Text = "Selection Method  : ";
            // 
            // NumOfS
            // 
            this.NumOfS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfS.Location = new System.Drawing.Point(562, 37);
            this.NumOfS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumOfS.Name = "NumOfS";
            this.NumOfS.Size = new System.Drawing.Size(65, 20);
            this.NumOfS.TabIndex = 5;
            this.NumOfS.ValueChanged += new System.EventHandler(this.NumOfS_ValueChanged);
            // 
            // StoppingNum
            // 
            this.StoppingNum.Enabled = false;
            this.StoppingNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoppingNum.Location = new System.Drawing.Point(562, 128);
            this.StoppingNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StoppingNum.Name = "StoppingNum";
            this.StoppingNum.Size = new System.Drawing.Size(65, 20);
            this.StoppingNum.TabIndex = 6;
            this.StoppingNum.ValueChanged += new System.EventHandler(this.StoppingNum_ValueChanged);
            // 
            // StopC
            // 
            this.StopC.FormattingEnabled = true;
            this.StopC.Items.AddRange(new object[] {
            "Number of Customers ",
            "Simulation End Time"});
            this.StopC.Location = new System.Drawing.Point(552, 85);
            this.StopC.Name = "StopC";
            this.StopC.Size = new System.Drawing.Size(121, 21);
            this.StopC.TabIndex = 9;
            this.StopC.SelectedIndexChanged += new System.EventHandler(this.StopC_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Highest Priority",
            "Random ",
            "Least Utilization"});
            this.comboBox1.Location = new System.Drawing.Point(552, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // InterAT
            // 
            this.InterAT.AllowUserToResizeColumns = false;
            this.InterAT.AllowUserToResizeRows = false;
            this.InterAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InterAT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.InterAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InterAT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeC,
            this.Probability});
            this.InterAT.Location = new System.Drawing.Point(28, 83);
            this.InterAT.Name = "InterAT";
            this.InterAT.Size = new System.Drawing.Size(241, 190);
            this.InterAT.TabIndex = 11;
            // 
            // TimeC
            // 
            this.TimeC.HeaderText = "Time";
            this.TimeC.Name = "TimeC";
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            // 
            // ServiceDistribution
            // 
            this.ServiceDistribution.AutoSize = true;
            this.ServiceDistribution.BackColor = System.Drawing.Color.Transparent;
            this.ServiceDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDistribution.Location = new System.Drawing.Point(24, 303);
            this.ServiceDistribution.Name = "ServiceDistribution";
            this.ServiceDistribution.Size = new System.Drawing.Size(267, 20);
            this.ServiceDistribution.TabIndex = 12;
            this.ServiceDistribution.Text = "Service Distribution : Server [ 1 ]";
            this.ServiceDistribution.Click += new System.EventHandler(this.ServiceDistribution_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.Location = new System.Drawing.Point(28, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 190);
            this.dataGridView1.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Probability";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(361, 358);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(156, 36);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // NextServer
            // 
            this.NextServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextServer.Location = new System.Drawing.Point(285, 478);
            this.NextServer.Name = "NextServer";
            this.NextServer.Size = new System.Drawing.Size(113, 32);
            this.NextServer.TabIndex = 15;
            this.NextServer.Text = "Next Server ";
            this.NextServer.UseVisualStyleBackColor = true;
            this.NextServer.Click += new System.EventHandler(this.NextServer_Click);
            // 
            // TestButton
            // 
            this.TestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestButton.Location = new System.Drawing.Point(611, 478);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(184, 32);
            this.TestButton.TabIndex = 16;
            this.TestButton.Text = "Automatic testing";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 510);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10});
            this.dataGridView2.Location = new System.Drawing.Point(3, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(935, 456);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CustomerNum";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RandomNumArrival";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "InterArrival";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ArrivalTime";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "RandomServiceTime";
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ServiceTime";
            this.Column8.Name = "Column8";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ServerNum";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "StartTime";
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "EndTime";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "TimeInQueue";
            this.Column10.Name = "Column10";
            // 
            // read_from_file
            // 
            this.read_from_file.Location = new System.Drawing.Point(632, 358);
            this.read_from_file.Name = "read_from_file";
            this.read_from_file.Size = new System.Drawing.Size(264, 36);
            this.read_from_file.TabIndex = 2;
            this.read_from_file.Text = "Read From File";
            this.read_from_file.UseVisualStyleBackColor = true;
            this.read_from_file.Click += new System.EventHandler(this.read_from_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.read_from_file);
            this.Controls.Add(this.NextServer);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ServiceDistribution);
            this.Controls.Add(this.InterAT);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.StopC);
            this.Controls.Add(this.StoppingNum);
            this.Controls.Add(this.NumOfS);
            this.Controls.Add(this.SelectionMethod);
            this.Controls.Add(this.InterarrivalDistribution);
            this.Controls.Add(this.StoppingCriteria);
            this.Controls.Add(this.StopingNum);
            this.Controls.Add(this.ServersNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Multi Queue Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.NumOfS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoppingNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServersNum;
        private System.Windows.Forms.Label StopingNum;
        private System.Windows.Forms.Label StoppingCriteria;
        private System.Windows.Forms.Label InterarrivalDistribution;
        private System.Windows.Forms.Label SelectionMethod;
        private System.Windows.Forms.NumericUpDown NumOfS;
        private System.Windows.Forms.NumericUpDown StoppingNum;
        private System.Windows.Forms.ComboBox StopC;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView InterAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.Label ServiceDistribution;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button NextServer;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button read_from_file;
    }
}

