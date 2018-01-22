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
        int sortOrder = 1;

        public Form1()
        {
            InitializeComponent();
            GenerateArray();
        }

        private void GenerateArray()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            SortArray = null;
            //Array size max 250,000 - Set in designer
            SortArray = new int[(int)ArraySize.Value];
            for (int i = 0; i < SortArray.Length; i++)
            {
                //Random # 0 through 1 million
                SortArray[i] = r.Next(0, 1000000);
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
            if (sortOrder == 1)
            {
                INSASC();
            }
            else if (sortOrder == 2)
            {
                INSDSC();
            }
        }
        
        private void INSASC()
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

        private void INSDSC()
        {
            for (int i = 0; i < SortArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    comparisons++;
                    if (SortArray[j] > SortArray[j - 1])
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
            if (sortOrder == 1)
            {
                SELASC();
            }
            else if (sortOrder == 2)
            {
                SELDSC();
            }
        }

        private void SELASC()
        {
            bool set;
            int smallestNumberIndex;
            for (int i = 1; i < SortArray.Length - 1; i++)
            {
                smallestNumberIndex = i - 1;
                set = false;
                for (int j = i; j < SortArray.Length; j++)
                {
                    comparisons++;
                    if (SortArray[j] < SortArray[smallestNumberIndex])
                    {
                        set = true;
                        smallestNumberIndex = j;
                    }
                }
                if (set)
                {
                    swaps++;
                    int key = SortArray[smallestNumberIndex];
                    SortArray[smallestNumberIndex] = SortArray[i - 1];
                    SortArray[i - 1] = key;
                }
            }
        }

        private void SELDSC()
        {
            bool set;
            int largestNumberIndex;
            for (int i = 1; i < SortArray.Length - 1; i++)
            {
                largestNumberIndex = i - 1;
                set = false;
                for (int j = i; j < SortArray.Length; j++)
                {
                    comparisons++;
                    if (SortArray[j] > SortArray[largestNumberIndex])
                    {
                        set = true;
                        largestNumberIndex = j;
                    }
                }
                if (set)
                {
                    swaps++;
                    int key = SortArray[largestNumberIndex];
                    SortArray[largestNumberIndex] = SortArray[i - 1];
                    SortArray[i - 1] = key;
                }
            }
        }

        private void DoBubbleSort()
        {
            if (sortOrder == 1)
            {
                BUBASC();
            }
            else if (sortOrder == 2)
            {
                BUBDSC();
            }
        }

        private void BUBASC()
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

        private void BUBDSC()
        {
            for (int i = SortArray.Length; i > -1; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    comparisons++;
                    if (SortArray[j] < SortArray[j + 1])
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Ascending
            sortOrder = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Descending
            sortOrder = 2;
        }
    }
}
