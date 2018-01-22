using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorts
{
    public partial class Form1 : Form
    {
        int[] SortArray;
        int comparisons;
        int swaps;
        public Form1()
        {
            InitializeComponent();
            GenerateArray();
        }

        private void GenerateArray()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            SortArray = null;
            SortArray = new int[(int)ArraySize.Value];
            for (int i = 0; i < SortArray.Length; i++)
            {
                SortArray[i] = r.Next(0, 100);
            }
            DisplayArray();
        }

        private void DisplayArray()
        {
            ArrayView.Items.Clear();
            for (int i = 0; i < SortArray.Length; i++)
            {
                ArrayView.Items.Add(SortArray[i]);
            }
        }

        private void DisplayStatistics()
        {
            swapsTXT.Text = swaps.ToString();
            comparisonsTXT.Text = comparisons.ToString();
        }

        private void DoInsertionSort()
        {
            for (int i = 0; i < SortArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    comparisons++;
                    if (SortArray[j] < SortArray[j - 1])
                    {
                        swaps++;
                        int key = SortArray[j - 1];
                        SortArray[j - 1] = SortArray[j];
                        SortArray[j] = key;
                    }
                }
            }
        }

        private void DoSelectionSort()
        {
            int smallestNumberIndex;
            for (int i = 0; i < SortArray.Length - 1; i++)
            {
                smallestNumberIndex = i;
                for (int j = i + 1; j < SortArray.Length; j++)
                {
                    comparisons++;
                    if (SortArray[j] < SortArray[smallestNumberIndex])
                    {
                        smallestNumberIndex = j;
                    }
                }
                comparisons++;
                if (smallestNumberIndex != i)
                {
                    swaps++;
                    int key = SortArray[smallestNumberIndex];
                    SortArray[smallestNumberIndex] = SortArray[i];
                    SortArray[i] = key;
                }
            }
        }

        private void DoBubbleSort()
        {
            for (int i = SortArray.Length; i > -1; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    comparisons++;
                    if (SortArray[j] > SortArray[j + 1])
                    {
                        swaps++;
                        int key = SortArray[j + 1];
                        SortArray[j + 1] = SortArray[j];
                        SortArray[j] = key;
                    }
                }
            }
        }

        private void ReadyStatistics()
        {
            comparisons = 0;
            swaps = 0;
        }

        private void InsertionSort_Click(object sender, EventArgs e)
        {
            ReadyStatistics();
            DoInsertionSort();
            DisplayArray();
            DisplayStatistics();
        }

        private void SelectionSort_Click(object sender, EventArgs e)
        {
            ReadyStatistics();
            DoSelectionSort();
            DisplayArray();
            DisplayStatistics();
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            ReadyStatistics();
            DoBubbleSort();
            DisplayArray();
            DisplayStatistics();
        }

        private void GenArray_Click(object sender, EventArgs e)
        {
            GenerateArray();
            ReadyStatistics();
            DisplayStatistics();
        }
    }
}
