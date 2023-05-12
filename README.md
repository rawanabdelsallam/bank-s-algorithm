# bank-s-algorithm
Banker's Algorithm Implementation in C#
This code is an implementation of the Banker's algorithm, which is a deadlock avoidance algorithm used in operating systems.
The algorithm is used to determine if granting a resource request from a process will result in a safe state or an unsafe state in a multi-process system. The code is written in C# and uses Windows Forms to create a GUI where the user can input the necessary data for running the algorithm.
Overview
The GUI consists of several text boxes and data grids for inputting and displaying the data. The user inputs the following:
•	Number of processes and resources
•	Maximum needs of each process
•	Current allocation of resources to each process
•	Total resources available
•	Process number, resource type, and request amount for a specific process
The algorithm reads all the input data, calculates the available resources based on the current allocation, and then checks if the requested resource can be granted without resulting in an unsafe state.
If the request can be granted, the algorithm pretends to allocate the requested resource to the process and checks if the new state is safe by simulating the allocation of resources to all the processes. If the new state is safe, the algorithm outputs a message indicating that the request can be granted along with the safe sequence of processes. Otherwise, it outputs a message indicating that the request cannot be granted.
If the request cannot be granted due to insufficient resources, the algorithm outputs a message indicating that there are not enough resources available.
Code
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        
        private void button1_Click(object sender, EventArgs e)
        {
            // Read input values
            int numProcesses = Convert.ToInt32(txtNumProcesses.Text);
            int numResources = Convert.ToInt32(txtNumResources.Text);
            int numRows = Convert.ToInt32(txtNumProcesses.Text);
            int numCols = Convert.ToInt32(txtNumResources.Text);


            int[,] maxNeeds = new int[numRows, numCols];
            int[,] currentAllocation = new int[numRows, numCols];
            int[] totalResources = new int[numCols];
            int[] availableResources = new int[numCols];


            // Read the maximum needs of each process
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    try
                    {
                        maxNeeds[i, j] = Convert.ToInt32(maxNeedsTab.Rows[i].Cells[j].Value);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
         

           


            // Read the current allocation of resources to each process
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    try
                    {
                        currentAllocation[i, j] = Convert.ToInt32(currentAllocationTab.Rows[i].Cells[j].Value);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            

           

            // Read the total resources available
            for (int j = 0; j < numCols; j++)
            {
                try
                {
                    totalResources[j] = Convert.ToInt32(totalRecsTab.Rows[0].Cells[j].Value);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            // Read the process number and resource request
            int process = Convert.ToInt32(txtProcessNumber.Text) - 1;
            int resource = Convert.ToInt32(txtResourceType.Text) - 1;
            int request = Convert.ToInt32(txtRequestAmount.Text);

            // Calculate the available resources
            for (int j = 0; j < numResources; j++)
            {
                int allocated = 0;
                for (int i = 0; i < numProcesses; i++)
                {
                    allocated += currentAllocation[i, j];
                }
                availableResources[j] = totalResources[j] - allocated;
            }

            // Create a new DataTable for the totalRecsTab table
            DataTable totalRecsTable = new DataTable();
            for (int j = 0; j < numCols; j++)
            {
                totalRecsTable.Columns.Add($"Resource {j + 1}", typeof(int));
            }
            totalRecsTable.Rows.Add(totalResources);

            // Bind the DataTable to the totalRecsDataGridView
            totalRecsDataGridView.DataSource = totalRecsTable;

            // Create a new DataTable for the availablRecsTab table
            DataTable availablRecsTable = new DataTable();
            for (int j = 0; j < numCols; j++)
            {
                availablRecsTable.Columns.Add($"Resource {j + 1}", typeof(int));
            }
            availablRecsTable.Rows.Add(availableResources);

            // Bind the DataTable to the availablRecsDataGridView
            availablRecsDataGridView.DataSource = availablRecsTable;


            // Check if the request can be granted
            if (request <= availableResources[resource])
            {
                // Pretend to allocate resources to the requesting process
                availableResources[resource] -= request;
                currentAllocation[process, resource] += request;
                maxNeeds[process, resource] -= request;

                // Check if the state is safe
                bool[] finish = new bool[numProcesses];
                int[] work = new int[numResources];
                Array.Copy(availableResources, work, numResources);

                List<int> safeSequence = new List<int>();
                int count = 0;

                while (count < numProcesses)
                {
                    bool found = false;
                    for (int i = 0; i < numProcesses; i++)
                    {
                        if (!finish[i])
                        {
                            int j;
                            for (j = 0; j < numResources; j++)
                            {
                                if (maxNeeds[i, j] - currentAllocation[i, j] > work[j])
                                {
                                    break;
                                }
                            }
                            if (j == numResources)
                            {
                                for (int k = 0; k < numResources; k++)
                                {
                                    work[k] += currentAllocation[i, k];
                                }
                                finish[i] = true;
                                safeSequence.Add(i);
                                count++;
                                found = true;
                            }
                        }
                    }
                    if (!found)
                    {
                        break;
                    }
                }

                // Restore original values
                availableResources[resource] += request;
                currentAllocation[process, resource] -= request;
                maxNeeds[process, resource] += request;

                // Print result
                if (count == numProcesses)
                {
                    MessageBox.Show("Request can be granted. Safe sequence: " + string.Join(", ", safeSequence.Select(x => $"P{x + 1}")));
                }
                else
                {
                    MessageBox.Show("Request cannot be granted.");
                }
            }
            else
            {
                MessageBox.Show("Not enough resources available.");
            }





        }
    }
}

The code is organized into a Form1 class, which is the main form of the Windows application. It contains a series of event handlers that respond to user input and perform the necessary calculations.
Overall, this code provides a useful implementation of the Banker's algorithm that can be easily utilized within a Windows application.

