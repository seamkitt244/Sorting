using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting
{
    public partial class Form1 : Form
    {
        int[] originalArray = { 3, 6, 1, 8, 5, 2 };
        int[] sortedArray = new int[6];

        public Form1()
        {
            InitializeComponent();

            // The 0 parameter indicates what index value in the sorted array
            // to start adding the sorted values to. 
            originalArray.CopyTo(sortedArray, 0);

            //uncomment whichever sort method you want to test
            selection(sortedArray);
            //bubble(sortedArray);
            //insertion(sortedArray);

            originalOutput.Text = sortedOutput.Text = "";

            foreach (int i in originalArray)
            {
                originalOutput.Text += i + "\n";
            }

            foreach (int i in sortedArray)
            {
                sortedOutput.Text += i + "\n";
            }
        }

        public void selection(int[] tempArray)
        {
            int temp;

            for (int i = 0; i < tempArray.Length; i++)
            {
                for (int j = i + 1; j < tempArray.Length; j++)
                {
                    if (tempArray[j] < tempArray[i])
                    {
                        temp = tempArray[i];
                        tempArray[i] = tempArray[j];
                        tempArray[j] = temp;
                    }
                }
            }
        }


        public void bubble(int[] tempArray)
        {
            int bottom = tempArray.Length-1;
            int temp;
            Boolean sw = true;

            while (sw == true)
            {
                sw = false;

                for (int j = 0; j < bottom; j++)
                {
                    if (tempArray[j] > tempArray[j + 1])
                    {
                        sw = true;
                        temp = tempArray[j];
                        tempArray[j] = tempArray[j + 1];
                        tempArray[j + 1] = temp;
                    }
                }
                bottom--;
            }
        }



        public void insertion(int[] tempArray)
        {
            int temp, j;

            for (int n = 0; n < tempArray.Length; n++)
            {
                temp = tempArray[n];
                j = n - 1;
                
                    while (j >= 0 && tempArray[j] > temp)
                    {
                        tempArray[j + 1] = tempArray[j];
                        j--;
                    }
                
                tempArray[j + 1] = temp;
            }
        }
    }
}
