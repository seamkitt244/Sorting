using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
namespace Sorting
{
    public partial class Form1 : Form
    {
        int[] originalArray;
        int[] sortedArray;
        int[] selectionArray; 
        int[] bubbleArray; 
        int[] insertionArray;
        Random randGen = new Random();
        int randValue;
        int loopCounter;
        int comparisonCounter;
        int shiftCounter;
        Stopwatch stopWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }
        private void sortButton_Click(object sender, EventArgs e)
        {
            originalOutput.Text = sortedOutput.Text = selectionOutput.Text = bubbleOutput.Text = insertionOutput.Text = sortedOutput.Text = "";

            #region value radios checked
            int howMany = 0;
            if (tenButton.Checked)
            {
                howMany = 10;
            }
            else if (hundredButton.Checked)
            {
                howMany = 100;
            }
            else if (thousandButton.Checked)
            {
                howMany = 200;
            }
            else if (fiveThousandButton.Checked)
            {
                howMany = 5000;
            }
            #endregion
            originalArray = new int[howMany];
            sortedArray = new int[howMany];
            selectionArray = new int[howMany];
            bubbleArray = new int[howMany]; 
            insertionArray = new int[howMany];

            for (int i = 0; i < originalArray.Length; i++)
            {
                randValue = randGen.Next(-1000, 1001);
                originalArray[i] = randValue;
                originalOutput.Text += Convert.ToInt32(originalArray[i]) + " \n";
                originalOutput.Text +="\n";
            }
            // The 0 parameter indicates what index value in the sorted array
            // to start adding the sorted values to. 
            originalArray.CopyTo(sortedArray, 0);
            originalArray.CopyTo(selectionArray, 0); 
            originalArray.CopyTo(bubbleArray, 0);
            originalArray.CopyTo(insertionArray, 0);
            // uncomment whichever sort method you want to test
            loopCounter = comparisonCounter = shiftCounter = 0;
            stopWatch.Start();
            selection(selectionArray);
            selectionOutput.Text = loopCounter + "\n\n" + comparisonCounter + "\n\n" + shiftCounter+ "\n\n" + stopWatch.Elapsed.TotalMilliseconds.ToString("0.0000");
            loopCounter = comparisonCounter = shiftCounter = 0;
            stopWatch.Restart();
            stopWatch.Start();
            bubble(bubbleArray);
            stopWatch.Stop();
            bubbleOutput.Text = loopCounter + "\n\n" + comparisonCounter + "\n\n" + shiftCounter + "\n\n" + stopWatch.Elapsed.TotalMilliseconds.ToString("0.0000");
            loopCounter = comparisonCounter = shiftCounter = 0;
            stopWatch.Restart();
            stopWatch.Start();
            insertion(insertionArray);
            stopWatch.Stop();
            insertionOutput.Text = loopCounter + "\n\n" + comparisonCounter + "\n\n" + shiftCounter + "\n\n" + stopWatch.Elapsed.TotalMilliseconds.ToString("0.0000");
            insertion(sortedArray);

            foreach (int i in sortedArray)
            {
                sortedOutput.Text += i + " \n";//the next line doesn't work for single didgets?
            }
        }
        #region selection sort
        public void selection(int[] tempArray)
        {
            stopWatch.Start();
            int temp;
            for (int i = 0; i < tempArray.Length; i++)
            {
                loopCounter++;
                comparisonCounter++;
                for (int j = i + 1; j < tempArray.Length; j++)
                {
                    loopCounter++;
                    comparisonCounter++;
                    if (tempArray[j] < tempArray[i])
                    {
                        comparisonCounter++;
                        temp = tempArray[i];
                        tempArray[i] = tempArray[j];
                        tempArray[j] = temp;
                        shiftCounter++;
                    }
                }
            }
            sortTimer.Stop();
        }
        #endregion
        #region bubble sort
        public void bubble(int[] tempArray)
        {
            int bottom = tempArray.Length - 1;
            int temp;
            Boolean swap = true;
            while (swap == true)
            {
                swap = false;
                for (int j = 0; j < bottom; j++)
                {
                    loopCounter++;
                    comparisonCounter++;
                    if (tempArray[j] > tempArray[j + 1])
                    {
                        swap = true;
                        temp = tempArray[j];
                        tempArray[j] = tempArray[j + 1];
                        tempArray[j + 1] = temp;
                        comparisonCounter++;
                        shiftCounter++;
                    }
                }
                bottom--;
                loopCounter++;
            }
            loopCounter++;
        }
        #endregion
        #region insertion sort
        public void insertion(int[] tempArray)
        { 
            int temp, j;

            for (int n = 0; n < tempArray.Length; n++)
            {
                loopCounter ++;
                temp = tempArray[n];
                j = n - 1;

                while (j >= 0 && tempArray[j] > temp)
                {
                    tempArray[j + 1] = tempArray[j];
                    j--;
                    shiftCounter++;
                    loopCounter++;
                }
                tempArray[j + 1] = temp;
                shiftCounter++;
            }
        }
        #endregion
    }
}
