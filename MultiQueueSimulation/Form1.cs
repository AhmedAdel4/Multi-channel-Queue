using System;
using System.Windows.Forms;
using MultiQueueModels;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        SimulationSystem system;
        SimulationSystem sys;
        public Form1()
        {
            system = new SimulationSystem();
            sys = new SimulationSystem();
            InitializeComponent();
        }
        // number of servers
        private void NumOfS_ValueChanged(object sender, EventArgs e)
        {
            system.NumberOfServers = (int)NumOfS.Value;
        }
        //stoping critiria
        private void StopC_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoppingNum.Enabled = true;
            system.StoppingCriteria = (Enums.StoppingCriteria)(StopC.SelectedIndex + 1);
        }
        // stopping number
        private void StoppingNum_ValueChanged(object sender, EventArgs e)
        {
            system.StoppingNumber = (int)StoppingNum.Value;
        }
        // selection method 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            system.SelectionMethod = (Enums.SelectionMethod)(comboBox1.SelectedIndex + 1);
        }
        // Submit button
        private  void Submit_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < InterAT.Rows.Count -1; rows++)
            {
                system.InterarrivalDistribution.Add(new TimeDistribution()
                {
                    Time = int.Parse((string)InterAT.Rows[rows].Cells[0].Value) ,
                    Probability = decimal.Parse((string)InterAT.Rows[rows].Cells[1].Value)
                });
            }
            Submit.Text = "Running...";
            Submit.Enabled = false;
            operation.start_simulation(system);
            foreach (SimulationCase c in system.SimulationTable)
            {
                this.dataGridView2.Rows.Add(c.CustomerNumber.ToString(), c.RandomInterArrival.ToString(), c.InterArrival.ToString(), c.ArrivalTime.ToString(), c.RandomService.ToString(), c.ServiceTime.ToString(), c.AssignedServer.ID.ToString(), c.StartTime.ToString(), c.EndTime.ToString(), c.TimeInQueue.ToString());
            }
            this.panel1.Visible = true;
           
          
        }

        // Read  From File button
        private void read_from_file_Click(object sender, EventArgs e)
        {
            operation.ReadFromFile(sys);
            operation.start_simulation(sys);
            foreach (SimulationCase c in sys.SimulationTable)
            {
                this.dataGridView2.Rows.Add(c.CustomerNumber.ToString(), c.RandomInterArrival.ToString(), c.InterArrival.ToString(), c.ArrivalTime.ToString(), c.RandomService.ToString(), c.ServiceTime.ToString(), c.AssignedServer.ID.ToString(), c.StartTime.ToString(), c.EndTime.ToString(), c.TimeInQueue.ToString());
            }
            this.panel1.Visible = true;
        }
        int i = 1;
        //next server button
        private void NextServer_Click(object sender, EventArgs e)
        {
            NumOfS.Enabled = false;
            Server server = new Server();
            server.ID = i;
            
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                server.TimeDistribution.Add(new TimeDistribution()
                {
                    Time = int.Parse((string)dataGridView1.Rows[rows].Cells[0].Value),
                    Probability = decimal.Parse((string)dataGridView1.Rows[rows].Cells[1].Value)
                });
            }
            dataGridView1.Rows.Clear();
            i++;
            system.Servers.Add(server);
            if(i==system.NumberOfServers)
            {
                NextServer.Text = "Submit Server";
            }
            if(i == system.NumberOfServers+1)
            {
                NextServer.Enabled = false;
                dataGridView1.Enabled = false;
            }
            else
            {
                ServiceDistribution.Text = "Service Distribution : Server [ " + i + " ] ";
            }
        }

        // test butto
        private void TestButton_Click(object sender, EventArgs e)
        {
            //operation.ReadFromFile(sys);
            for (int rows = 0; rows < InterAT.Rows.Count - 1; rows++)
            {
                system.InterarrivalDistribution.Add(new TimeDistribution()
                {
                    Time = int.Parse((string)InterAT.Rows[rows].Cells[0].Value),
                    Probability = decimal.Parse((string)InterAT.Rows[rows].Cells[1].Value)
                });
            }
            TestButton.Text = "Testing...";
            TestButton.Enabled = false;
             operation.Test(system);
            TestButton.Text = "Automatic Testing";
            TestButton.Enabled = true;
           
        }

        private void ServiceDistribution_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // back button
        private void button2_Click(object sender, EventArgs e)
        {
            Submit.Text = "Submit";
            Submit.Enabled = true;
            this.panel1.Visible = false;
        }

      
    }
}