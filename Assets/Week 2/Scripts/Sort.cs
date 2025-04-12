using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort : MonoBehaviour
{
    public int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] randomArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            randomArray[i] = Random.Range(minValue, maxValue);
        }
        return randomArray;
    }
    // 1. Bubble Sort (Sắp xếp nổi bọt)
    void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    // 2. Selection Sort (Sắp xếp chọn)
    void SelectionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                    minIndex = j;
            }
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    // 3. Insertion Sort (Sắp xếp chèn)
    void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }

    // 4. Merge Sort (Sắp xếp trộn)
    void MergeSort(int[] array)
    {
        MergeSortRecursive(array, 0, array.Length - 1);
    }

    void MergeSortRecursive(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortRecursive(array, left, mid);
            MergeSortRecursive(array, mid + 1, right);
            Merge(array, left, mid, right);
        }
    }

    void Merge(int[] array, int left, int mid, int right)
    {
        int[] leftArray = new int[mid - left + 1];
        int[] rightArray = new int[right - mid];

        for (int i = 0; i < leftArray.Length; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < rightArray.Length; j++)
            rightArray[j] = array[mid + 1 + j];

        int iLeft = 0, iRight = 0, k = left;

        while (iLeft < leftArray.Length && iRight < rightArray.Length)
        {
            if (leftArray[iLeft] <= rightArray[iRight])
                array[k++] = leftArray[iLeft++];
            else
                array[k++] = rightArray[iRight++];
        }

        while (iLeft < leftArray.Length)
            array[k++] = leftArray[iLeft++];
        while (iRight < rightArray.Length)
            array[k++] = rightArray[iRight++];
    }

    // 5. Quick Sort (Sắp xếp nhanh)
    void QuickSort(int[] array)
    {
        QuickSortRecursive(array, 0, array.Length - 1);
    }

    void QuickSortRecursive(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(array, low, high);
            QuickSortRecursive(array, low, pi - 1);
            QuickSortRecursive(array, pi + 1, high);
        }
    }

    int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        int swap = array[i + 1];
        array[i + 1] = array[high];
        array[high] = swap;

        return i + 1;
    }

    //-----------------------Edit above -----------------------

    public void ReadArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element " + i + ": " + array[i]);
        }
    }
    void Start()
    {
        int[] randomNumbers = GenerateRandomArray(10, 1, 100);
        //----------------------Edit below --------------------
        // BubbleSort(randomNumbers);
        // SelectionSort(randomNumbers);
        InsertionSort(randomNumbers);
        // MergeSort(randomNumbers);
        //QuickSort(randomNumbers);
        //----------------------Edit above --------------------
        ReadArray(randomNumbers);
    }
}
