// Nathan Booth, SprintTwo, Neutrino
// Date: 28/05/2025
// Version: 2.0
// Neutrino Data Form
// Program to generate neutrino obersvations and sort them in ascending or descending order.
// This program allows the user to add, edit, sort, and search for data points in a list of neutrino observations.
// The newest update adds the core measures of central tendency as calculation buttons as well as a sequential search function
// to find the index of a specific data point in the list without needing to sort and lose their positions.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SprintOne
{
    public partial class NeutrinoForm : Form
    {


        public NeutrinoForm()
        {
            InitializeComponent();
        }

        private int[] dataSet = new int[24];
        private int currentIndex = 0;

        private void BTNAddData_Click(object sender, EventArgs e)
        {
            int num1 = 0;

            if (!Int32.TryParse(DataInput.Text, out num1))
            {
                MessageBox.Show("Please enter an integer.");
                DataInput.Clear();
                return;
            }

            if (currentIndex >= dataSet.Length)
            {
                MessageBox.Show("Maximum of 24 entries reached.");
                DataInput.Clear();
                return;
            }

            dataSet[currentIndex] = num1;
            currentIndex++;

            DataInput.Clear();
            DataInput.Focus();

            // Refresh the list box to show current data
            DataListBox.Items.Clear();
            for (int i = 0; i < currentIndex; i++)
            {
                DataListBox.Items.Add(dataSet[i]);
            }
        }


        private void DataListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display the selected index of list box in dataEditInput
            if (DataListBox.SelectedIndex != -1)
            {
                DataEditInput.Text = DataListBox.SelectedItem.ToString();
            }

        }

        private void BTNEditData_Click(object sender, EventArgs e)
        {
            //function to edit the data point from the array at the selected index
            int selectedIndex = DataListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                int newValue;
                if (Int32.TryParse(DataEditInput.Text, out newValue))
                {
                    DataListBox.Items[selectedIndex] = newValue;
                    DataEditInput.Clear();
                    DataInput.Focus();
                }
                else
                {
                    MessageBox.Show("Please enter an integer.");
                    DataEditInput.Clear();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a data point to edit.");
            }
        }

        private void BTNSortAsc_Click(object sender, EventArgs e)
        {
            int temp = 0;

            //bubble sort the dataSet array onclick
            for (int i = 0; i < currentIndex - 1; i++)
            {
                for (int j = 0; j < currentIndex - i - 1; j++)
                {
                    if (dataSet[j] > dataSet[j + 1])
                    {
                        temp = dataSet[j];
                        dataSet[j] = dataSet[j + 1];
                        dataSet[j + 1] = temp;
                    }
                }
            }
            //clear the list box and add the sorted data
            DataListBox.Items.Clear();
            for (int i = 0; i < currentIndex; i++)
            {
                DataListBox.Items.Add(dataSet[i]);
            }
        }

        private void BTNSortDesc_Click(object sender, EventArgs e)
        {
            int temp = 0;

            //bubble sort the dataSet array onclick
            for (int i = 0; i < currentIndex - 1; i++)
            {
                for (int j = 0; j < currentIndex - i - 1; j++)
                {
                    if (dataSet[j] < dataSet[j + 1])
                    {
                        temp = dataSet[j];
                        dataSet[j] = dataSet[j + 1];
                        dataSet[j + 1] = temp;
                    }
                }
            }
            //clear the list box and add the sorted data
            DataListBox.Items.Clear();
            for (int i = 0; i < currentIndex; i++)
            {
                DataListBox.Items.Add(dataSet[i]);
            }
        }

        private void GenerateRandomData_Click(object sender, EventArgs e)
        {
            //function to generate and fill the dataSet with 24 random integers
            Random random = new Random();
            for (int i = 0; i < dataSet.Length; i++)
            {
                dataSet[i] = random.Next(10, 90); // Random number between 1 and 100
                currentIndex++;
            }

            //display the dataSet in the list box
            DataListBox.Items.Clear();
            for (int i = 0; i < dataSet.Length; i++)
            {
                DataListBox.Items.Add(dataSet[i]);
            }
            //clear the form
            DataSearch.Clear();
            DataInput.Clear();
            DataEditInput.Clear();
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            //function to search for a value in the dataSet array, sorting items asc first.
            int temp = 0;

            //bubble sort the dataSet array onclick
            for (int i = 0; i < currentIndex - 1; i++)
            {
                for (int j = 0; j < currentIndex - i - 1; j++)
                {
                    if (dataSet[j] > dataSet[j + 1])
                    {
                        temp = dataSet[j];
                        dataSet[j] = dataSet[j + 1];
                        dataSet[j + 1] = temp;
                    }
                }
            }
            //clear the list box and add the sorted data
            DataListBox.Items.Clear();
            for (int i = 0; i < currentIndex; i++)
            {
                DataListBox.Items.Add(dataSet[i]);
            }
            //binary search function
            int searchValue;
            if (Int32.TryParse(DataSearch.Text, out searchValue))
            {
                int left = 0;
                int right = currentIndex - 1;
                bool found = false;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (dataSet[mid] == searchValue)
                    {
                        MessageBox.Show("Value found at index: " + mid);
                        found = true;
                        break;
                    }
                    else if (dataSet[mid] < searchValue)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Value not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an integer.");
            }
        }

        private void meanBTN_Click(object sender, EventArgs e)
        {
            //function to calculate the mean of the dataSet array and display it in the meanOutput box
            if (currentIndex == 0)
            {
                MessageBox.Show("No data to calculate mean.");
                return;
            }
            else
            {
                double sum = 0;
                for (int i = 0; i < currentIndex; i++)
                {
                    sum += dataSet[i];
                }
                double mean = sum / currentIndex;
                meanDataOutput.Text = mean.ToString("F2");

            }

        }

        private void medianBTN_Click(object sender, EventArgs e)
        {
            //function to calculate the median of the dataSet array and display it in the medianDataOutput box
            if (currentIndex == 0)
            {
                MessageBox.Show("No data to calculate median.");
                return;
            }
            else
            {
                // Sort the array first
                Array.Sort(dataSet, 0, currentIndex);
                double median;
                if (currentIndex % 2 == 0)
                {
                    // If even number of elements, average the two middle elements
                    median = (dataSet[currentIndex / 2 - 1] + dataSet[currentIndex / 2]) / 2.0;
                }
                else
                {
                    // If odd number of elements, take the middle element
                    median = dataSet[currentIndex / 2];
                }
                medianDataOutput.Text = median.ToString("F2");
                //clear the list box and replace with sorted array
                DataListBox.Items.Clear();
                for (int i = 0; i < currentIndex; i++)
                {
                    DataListBox.Items.Add(dataSet[i]);
                }
            }
        }
    }
}
