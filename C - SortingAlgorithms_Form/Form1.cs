using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C___SortingAlgorithms_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_SelectionSort_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 10, 0, 5, 12, 2 };

            SelectSort(arr);
        }

        private void button_InsertionSort_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 2, 23, 14, 6, 27, 0 };

            InsertSort(arr);

        }

        private void button_MergeSort_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 13, 10, 3, 8, 6 };
            MergeSort(arr);
        }

        private void button_BinarySearch_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 2, 23, 14, 6, 27, 0 };
            InsertSort(arr);
            BinarySearch(arr, 14);
        }

        private void BinarySearch(int[] sortedSource, int searchValue)
        {
            label_BinarySearch.Text = "Searching for '" + searchValue + "' in array " + Print(sortedSource) + "\r\n"; ;

            int low = 0;                        // Start at the beginning index of 0	
            int high = sortedSource.Length - 1;   // Start with the end index at last element
            int mid = (low + high) / 2;         // Calculates middle position
            int index = -1;                     // Initialize the index to -1 indicating that the search value was not found

            do
            {
                if (searchValue == sortedSource[mid])       // Determine if the middle position contains the search value
                {
                    index = mid;
                }
                else if (searchValue < sortedSource[mid])   //sets subarray if searchVal < mid
                {
                    high = mid - 1;
                }
                else if (searchValue > sortedSource[mid]) //sets subarray if searchVal > mid    
                {
                    low = mid + 1;
                }

                mid = (low + high) / 2;                     // Recalculate middle value
            } while ((low <= high) && (index == -1));       // Continues loop while not found

            if (index != -1)
            {
                label_BinarySearch.Text += "Found '" + searchValue + "' at index position " + index;
            }
            else
            {
                label_BinarySearch.Text += "Value not found.";
            }
        }

        private void MergeSort(int[] source)
        {
            label_MergeSort.Text = "Start: " + Print(source) + "\r\n";

            MergeSort(source, 0, source.Length - 1);

            label_MergeSort.Text += "End: " + Print(source) + "\r\n";
        }

        private void MergeSort(int[] source, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;                // Separate the array into two separate parts

                label_MergeSort.Text += "Sorting: " + Print(source, start, mid) + "\r\n";
                MergeSort(source, start, mid);              // Recursively sort the first half of the current array

                label_MergeSort.Text += "Sorting: " + Print(source, mid + 1, end) + "\r\n";
                MergeSort(source, mid + 1, end);            // Recursively sort the second half of the current array

                SortAndMerge(source, start, mid, end);      // Sort and merge both array parts by comparing the current elements
            }
        }

        private void SortAndMerge(int[] source, int start, int mid, int end)
        {
            int first = start;
            int second = mid + 1;

            int[] ar = new int[end - start + 1];
            int tempIndex = 0;

            for (int i = start; i <= end; i++)
            {
                if (first > mid)                                // Determine if evaluating the first part is at an end
                {
                    ar[tempIndex++] = source[second++];
                }
                else if (second > end)                          // Determine if evaluating the second part is at an end
                {
                    ar[tempIndex++] = source[first++];
                }
                else if (source[first] < source[second])        // Determine which of the two values has smaller element
                {
                    ar[tempIndex++] = source[first++];
                }
                else
                {
                    ar[tempIndex++] = source[second++];
                }
            }

            label_MergeSort.Text += "Merging: " + Print(ar) + "\r\n";

            for (int i = 0, j = start; i < tempIndex; i++, j++)
            {
                // Assign the values of the temporary array to the source array at the starting position specified
                // by the 'start' parameter

                source[j] = ar[i];
            }
        }

        private void SelectSort(int[] arr)
        {
            if (null == arr || arr.Length < 2)
            {
                //if array is null or contains less than two elements nothing to sort
                return;
            }

            label_SelectionSort.Text = "Start: " + Print(arr) + "\r\n";

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        SwapValues(arr, i, j);
                        label_SelectionSort.Text += "Swapping: " + Print(arr) + "\r\n";
                    }
                }
            }

            label_SelectionSort.Text += "End: " + Print(arr) + "\r\n";
        }

        private void InsertSort(int[] arr)
        {
            if (null == arr || arr.Length < 2)
            {
                //if array is null or contains less than two elements nothing to sort
                return;
            }

            label_InsertionSort.Text = "Start: " + Print(arr) + "\r\n";

            for (int i = 1; i < arr.Length; i++)
            {
                SortFromPosition(arr, i);
            }

            label_InsertionSort.Text += "End: " + Print(arr) + "\r\n";
        }

        private void SortFromPosition(int[] arr, int index)
        {
            if (index > 0)
            {
                if (arr[index] < arr[index - 1])
                {
                    SwapValues(arr, index, index - 1);

                    label_InsertionSort.Text += "Insert: " + Print(arr) + "\r\n";

                    SortFromPosition(arr, index - 1);
                }
            }
        }

        private void SwapValues(int[] arr, int first, int second)
        {
            int val = arr[first];
            arr[first] = arr[second];
            arr[second] = val;
        }

        private string Print(int[] arr)
        {
            return Print(arr, 0, arr.Length - 1);
        }

        private string Print(int[] arr, int start, int end)
        {
            string ret = "{";

            for (int i = start; i <= end; i++)
            {
                if (ret.Length > 1)
                {
                    ret += ",";
                }
                ret += arr[i];
            }

            ret += "}";
            return ret;
        }
    }
}
