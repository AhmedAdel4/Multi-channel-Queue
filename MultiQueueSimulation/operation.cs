using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;

namespace MultiQueueSimulation
{
    static class operation
    {
        static int SimulationTime = 0;
        static Random randomNum = new Random();
        static private void FillDist(List<TimeDistribution> Distribution)
        {
            if (Distribution.Count != 0)
            {
                for (int i = 0; i < Distribution.Count; i++)
                {
                    
                        if (i == 0)
                        {
                            Distribution[i].CummProbability = Distribution[i].Probability;
                            Distribution[i].MinRange = 1;
                        }
                        else
                        {
                            Distribution[i].CummProbability = Distribution[i].Probability + Distribution[i - 1].CummProbability;
                            Distribution[i].MinRange = Distribution[i - 1].MaxRange + 1;
                        }
                        Distribution[i].MaxRange = (int)(Distribution[i].CummProbability * 100);
                      
                    
                }
            }
            else
            {
                throw new Exception("you must enter a distribution");
            }
        }


        static private int GetRandomValue(List<TimeDistribution> Distribution, int RandomValue)
        {
            int x = -1;
            for (int i = 0; i < Distribution.Count; i++)
            {

                if (RandomValue <= Distribution[i].MaxRange && RandomValue >= Distribution[i].MinRange)
                {
                    x = Distribution[i].Time;
                }
            }
            return x;     
        }

        static private void GetAssignedServer(SimulationCase Case, List<Server> Servers, Enums.SelectionMethod SelectionMethod)
        {
            List<Server> emptyServers = new List<Server>();
        
            int server_num = 0;
            int serverID;
            int minServiceTime = 100000;
            bool first_found = false;
            if (SelectionMethod == Enums.SelectionMethod.HighestPriority)
            {
                if (Case.CustomerNumber == 0)
                {
                    Case.AssignedServer = Servers[server_num];
                    Case.RandomService = randomNum.Next(1, 100);
                    Case.ServiceTime = GetRandomValue(Servers[server_num].TimeDistribution, Case.RandomService);
                    Case.StartTime = 0;
                    Case.EndTime = Case.ServiceTime;
                    Case.TimeInQueue = 0;
                    Servers[server_num].FinishTime = Case.ServiceTime;
                    minServiceTime = Servers[server_num].FinishTime;
                    Servers[server_num].TotalWorkingTime = Case.ServiceTime;
                    Servers[server_num].AverageServiceTime = Case.ServiceTime;
                    Servers[server_num].ServedCount++;
                }
                else
                {
                    for (int i = 0; i < Servers.Count; i++)
                    {
                        if (Servers[i].FinishTime <= Case.ArrivalTime)
                        {
                            server_num = i;
                            first_found = true;
                            break;
                        }

                    }
                    if (first_found == false)
                    {
                        for (int i = 0; i < Servers.Count; i++)
                        {
                            if (Servers[i].FinishTime < minServiceTime)
                            {
                                server_num = i;
                                minServiceTime = Servers[i].FinishTime;
                            }
                        }
                        
                    }
                    Case.AssignedServer = Servers[server_num];
                    Case.RandomService = randomNum.Next(1, 100);
                    Case.ServiceTime = GetRandomValue(Servers[server_num].TimeDistribution, Case.RandomService);
                    Case.StartTime = Math.Max(Servers[server_num].FinishTime, Case.ArrivalTime);
                    Case.EndTime = Case.StartTime + Case.ServiceTime;
                    Case.TimeInQueue = Case.StartTime - Case.ArrivalTime;
                    Servers[server_num].FinishTime = Case.StartTime + Case.ServiceTime;
                    Servers[server_num].TotalWorkingTime += Case.ServiceTime;
                    Servers[server_num].AverageServiceTime += Case.ServiceTime;
                    Servers[server_num].ServedCount++;
                }

            }

            else if (SelectionMethod == Enums.SelectionMethod.Random)
            {
                for (int i = 0; i < Servers.Count; i++)
                {
                    if (Servers[i].FinishTime <= Case.ArrivalTime)
                    {
                        emptyServers.Add(Servers[i]);
                    }
                }

                int serversCount = emptyServers.Count;
                int random;
                if(serversCount > 0)
                {
                    if (Case.CustomerNumber == 0)
                    {
                        random = randomNum.Next(0, serversCount - 1);

                        serverID = emptyServers[random].ID - 1;
                        Case.AssignedServer = Servers[serverID];
                        Case.RandomService = randomNum.Next(1, 100);
                        Case.ServiceTime = GetRandomValue(Servers[serverID].TimeDistribution, Case.RandomService);
                        Case.StartTime = 0;
                        Case.EndTime = Case.ServiceTime;
                        Case.TimeInQueue = 0;
                        Servers[serverID].FinishTime = Case.ServiceTime;
                        minServiceTime = Servers[serverID].FinishTime;
                        Servers[serverID].TotalWorkingTime = Case.ServiceTime;
                        Servers[serverID].AverageServiceTime = Case.ServiceTime;
                        Servers[serverID].ServedCount++;
                    }
                    else
                    {
                      
                        serversCount = emptyServers.Count;
                        random = randomNum.Next(0, serversCount - 1);
                        for(int i =0; i<Servers.Count; i++)
                        {
                            if(emptyServers[random].ID == Servers[i].ID)
                            {
                                server_num = i;
                                break;
                            }

                        }
                           
         
                        Case.AssignedServer = Servers[server_num];
                        Case.RandomService = randomNum.Next(1, 100);
                        Case.ServiceTime = GetRandomValue(Servers[server_num].TimeDistribution, Case.RandomService);
                        Case.StartTime = Math.Max(Servers[server_num].FinishTime, Case.ArrivalTime);
                        Case.EndTime = Case.StartTime + Case.ServiceTime;
                        Case.TimeInQueue = Case.StartTime - Case.ArrivalTime;
                        Servers[server_num].FinishTime = Case.StartTime + Case.ServiceTime;
                        Servers[server_num].TotalWorkingTime += Case.ServiceTime;
                        Servers[server_num].AverageServiceTime += Case.ServiceTime;
                        Servers[server_num].ServedCount++;
                    }
                }
                else
                {
                    for (int i = 0; i < Servers.Count; i++)
                    {
                        if (Servers[i].FinishTime < minServiceTime)
                        {
                            server_num = i;
                            minServiceTime = Servers[i].FinishTime;
                        }
                    }
                    Case.AssignedServer = Servers[server_num];
                    Case.RandomService = randomNum.Next(1, 100);
                    Case.ServiceTime = GetRandomValue(Servers[server_num].TimeDistribution, Case.RandomService);
                    Case.StartTime = Math.Max(Servers[server_num].FinishTime, Case.ArrivalTime);
                    Case.EndTime = Case.StartTime + Case.ServiceTime;
                    Case.TimeInQueue = Case.StartTime - Case.ArrivalTime;
                    Servers[server_num].FinishTime = Case.StartTime + Case.ServiceTime;
                    Servers[server_num].TotalWorkingTime += Case.ServiceTime;
                    Servers[server_num].AverageServiceTime += Case.ServiceTime;
                    Servers[server_num].ServedCount++;
                }
            }


            else if (SelectionMethod == Enums.SelectionMethod.LeastUtilization)
            {
                for(int i =0; i<Servers.Count;i++)
                {
                    if(Servers[i].FinishTime <= Case.ArrivalTime)
                    { 
                        emptyServers.Add(Servers[i]);
                    }
                }
                if (Case.CustomerNumber == 0)
                {

                    Case.AssignedServer = Servers[server_num];
                    Case.RandomService = randomNum.Next(1, 100);
                    Case.ServiceTime = GetRandomValue(Servers[server_num].TimeDistribution, Case.RandomService);
                    Case.StartTime = 0;
                    Case.EndTime = Case.ServiceTime;
                    Case.TimeInQueue = 0;
                    Servers[server_num].FinishTime = Case.ServiceTime;
                    minServiceTime = Servers[server_num].FinishTime;
                    Servers[server_num].TotalWorkingTime = Case.ServiceTime;
                    Servers[server_num].AverageServiceTime = Case.ServiceTime;
                    Servers[server_num].ServedCount++;
                }

                else
                {
                    int index = 0;
                    if(emptyServers.Count != 0)
                    {
                        decimal leastUT = 1000000;

                        for(int i =0; i< emptyServers.Count;i++)
                        {
                            if(emptyServers[i].TotalWorkingTime <leastUT)
                            {
                                leastUT = emptyServers[i].TotalWorkingTime;
                                index = i;
                              
                            }
                        }
                        
                        for(int i = 0; i<Servers.Count;i++)
                        {
                            if(Servers[i].ID == emptyServers[index].ID)
                            {
                                server_num = i;
                                break;
                            }
                        }
                    }

                    else
                    {
                        for (int i = 0; i < Servers.Count; i++)
                        {
                            if (Servers[i].FinishTime < minServiceTime)
                            {
                                server_num = i;
                                minServiceTime = Servers[i].FinishTime;
                            }
                        }
                    }
                    
                    Case.AssignedServer = Servers[server_num];
                    Case.RandomService = randomNum.Next(1, 100);
                    Case.ServiceTime = GetRandomValue(Servers[server_num].TimeDistribution, Case.RandomService);
                    Case.StartTime = Math.Max(Servers[server_num].FinishTime, Case.ArrivalTime);
                    Case.EndTime = Case.StartTime + Case.ServiceTime;
                    Case.TimeInQueue = Case.StartTime - Case.ArrivalTime;
                    Servers[server_num].FinishTime = Case.StartTime + Case.ServiceTime;
                    Servers[server_num].TotalWorkingTime += Case.ServiceTime;
                    Servers[server_num].AverageServiceTime += Case.ServiceTime;
                    Servers[server_num].ServedCount++;
                }
            }
        }

        static public void start_simulation(SimulationSystem system)
        {
            FillDist(system.InterarrivalDistribution);
            for (int j = 0; j < system.Servers.Count; j++)
            {
                FillDist(system.Servers[j].TimeDistribution);
            }

            Queue<SimulationCase> waited_list = new Queue<SimulationCase>();
            
            int Total_TimeinQueue = 0;
            int Number_Of_Customers_Who_Waited = 0;
            int Max_QueueLength = 0;
            List<SimulationCase> All_customers = new List<SimulationCase>();
            if (system.StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers)
            {
                for (int i = 0; i < system.StoppingNumber; i++)
                {
                    SimulationCase customer = new SimulationCase();
                    customer.CustomerNumber = i;
                    customer.RandomInterArrival = randomNum.Next(1, 100);
                    
                    if (i == 0)
                    {
                        customer.InterArrival = 0;
                        customer.ArrivalTime = 0;
                    }
                    else
                    {
                        customer.InterArrival = GetRandomValue(system.InterarrivalDistribution, customer.RandomInterArrival);
                        customer.ArrivalTime = All_customers[i - 1].ArrivalTime + customer.InterArrival;
                    }
                    GetAssignedServer(customer, system.Servers, system.SelectionMethod);
                    
                    if (waited_list.Count > 0)
                    {
                        if (waited_list.Peek().StartTime <= customer.ArrivalTime)
                        {
                            waited_list.Dequeue();
                        }
                    }
                    if (customer.TimeInQueue > 0)
                    {
                        waited_list.Enqueue(customer);
                        Total_TimeinQueue += customer.TimeInQueue;
                        Number_Of_Customers_Who_Waited++;
                    }
                    Max_QueueLength = Math.Max(Max_QueueLength, waited_list.Count);
                    SimulationTime = Math.Max(SimulationTime, customer.EndTime);
                    All_customers.Add(customer);
                }
                system.SimulationTable = All_customers;
                system.PerformanceMeasures.AverageWaitingTime = ((decimal)Total_TimeinQueue / All_customers.Count);
                system.PerformanceMeasures.WaitingProbability = ((decimal)Number_Of_Customers_Who_Waited / All_customers.Count);
                system.PerformanceMeasures.MaxQueueLength = Max_QueueLength;
                system.SimulationTime = SimulationTime;
                for (int i = 0; i < system.Servers.Count; i++)
                {
                    if (system.Servers[i].ServedCount != 0)
                        system.Servers[i].AverageServiceTime /= system.Servers[i].ServedCount;
                    system.Servers[i].Utilization = (decimal)system.Servers[i].TotalWorkingTime / SimulationTime;
                }
            }

            else
            {
                int customer_num = 0;
                while (true)
                {
                    SimulationCase customer = new SimulationCase();
                    customer.CustomerNumber = customer_num;
                    customer.RandomInterArrival = randomNum.Next(1, 100);
                   
                    if (All_customers.Count == 0)
                    {
                        customer.InterArrival = 0;
                        customer.ArrivalTime = 0;
                    }
                    else
                    {
                        customer.InterArrival = GetRandomValue(system.InterarrivalDistribution, customer.RandomInterArrival);
                        customer.ArrivalTime = All_customers[All_customers.Count - 1].ArrivalTime + customer.InterArrival;
                    }
                    if (customer.ArrivalTime > system.StoppingNumber)
                    {
                        break;
                    }
                    GetAssignedServer(customer, system.Servers, system.SelectionMethod);
                    if(waited_list.Count > 0)
                    {
                        if (waited_list.Peek().StartTime <= customer.ArrivalTime)
                        {
                            waited_list.Dequeue();
                        }
                    }
                    if (customer.TimeInQueue > 0)
                    {
                        waited_list.Enqueue(customer);
                        Total_TimeinQueue += customer.TimeInQueue;
                        Number_Of_Customers_Who_Waited++;
                    }
                    SimulationTime = Math.Max(SimulationTime, customer.EndTime);
                    Max_QueueLength = Math.Max(Max_QueueLength, waited_list.Count);
                    customer_num++;
                    All_customers.Add(customer);
                }
                system.SimulationTable = All_customers;
                system.PerformanceMeasures.AverageWaitingTime = ((decimal)Total_TimeinQueue / All_customers.Count);
                system.PerformanceMeasures.WaitingProbability = ((decimal)Number_Of_Customers_Who_Waited / All_customers.Count);
                system.PerformanceMeasures.MaxQueueLength = Max_QueueLength;
                system.SimulationTime = SimulationTime;
                for (int i = 0; i < system.Servers.Count; i++)
                {
                    if (system.Servers[i].ServedCount != 0)
                        system.Servers[i].AverageServiceTime /= system.Servers[i].ServedCount;
                    system.Servers[i].Utilization = (decimal)system.Servers[i].TotalWorkingTime / SimulationTime;
                }
            }
        }

        static public void ReadFromFile(SimulationSystem system1)
        {
            

            List<string> lines = new List<string>();

            FileStream file = new FileStream("TestCase.txt", FileMode.Open);
            StreamReader read = new StreamReader(file);
            try
            {
                while (read.Peek() != -1)
                {
                    lines.Add(read.ReadLine());
                }
                system1.NumberOfServers = int.Parse(lines[1]);
                system1.StoppingNumber = int.Parse(lines[3]);
                system1.StoppingCriteria = (Enums.StoppingCriteria)int.Parse(lines[5]);
                system1.SelectionMethod = (Enums.SelectionMethod)int.Parse(lines[7]);
                int count = int.Parse(lines[9]);
                string[] temp;
                int i = 10;
                for (int j = 0; j < count; j++)
                {

                    temp = lines[i].Split(',');
                    system1.InterarrivalDistribution.Add(new TimeDistribution
                    {
                        Time = int.Parse(temp[0]),
                        Probability = Convert.ToDecimal(temp[1])

                    });
                    i++;
                }
                i++;
                count = int.Parse(lines[i]);
                Server server = new Server();
                server.ID = 1;
                i++;
                for (int j = 0; j < count; j++)
                {

                    temp = lines[i].Split(',');
                    server.TimeDistribution.Add(new TimeDistribution
                    {
                        Time = int.Parse(temp[0]),
                        Probability = Convert.ToDecimal(temp[1])

                    });
                    i++;
                }
                system1.Servers.Add(server);
                i++;
                count = int.Parse(lines[i]);
                i++;
                server = new Server();
                server.ID = 2;
                for (int j = 0; j < count; j++)
                {

                    temp = lines[i].Split(',');
                    server.TimeDistribution.Add(new TimeDistribution
                    {
                        Time = int.Parse(temp[0]),
                        Probability = Convert.ToDecimal(temp[1])

                    });
                    i++;
                }
                system1.Servers.Add(server);
                file.Close();
            }
            catch
            {
                MessageBox.Show("error in file fun");
            }
           
        }

        static public void Test(SimulationSystem system)
        {
            start_simulation(system);
            string testingMessage = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(testingMessage);
        }
    }
       
          
}
