#include <iostream>

using namespace std;

void Myswap(int& a, int& b)
{
	int temp = a;
	a = b;
	b = temp;
}


///In this Partition function we take the pivot as the last element in the array then sort every element smaller than the pivot to its left and larger element to the right
/// then we get the right position of the pivot element in the array
int Mypartition(int arr[], int first, int last)
{
	int pivot = arr[last]; /// Last element as the pivot
	int i= (first- 1);   /// Index of smaller element and indicates the right position of pivot found so far


	for (int j = first; j <= last - 1; j++) {
		/// If current element is smaller than the pivot
		if (arr[j] < pivot) {
			i++; /// increment index of smaller element to eventually find the pivot location in the array
			Myswap(arr[i], arr[j]);
		}
	}
	Myswap(arr[i + 1], arr[last]); /// at this step you swap between i+1 which is the pivot location and its current location at the end of the array
	return (i + 1);
}

/// The main function that implements QuickSort
///arr[] --> Array to be sorted,
///first --> Starting index,
///last --> Ending index */
void quickSort(int arr[], int first, int last)
{
	if (first < last) {
		 ///pi is partitioning index, arr[p] is now at right place
		int pi = Mypartition(arr, first, last);
		quickSort(arr, first, pi - 1);///Sort elements before pivot
		quickSort(arr, pi + 1, last); ///sort elements after pivot
	}
}


int main()
{
	int arr[] = { 10, 7, 8, 9, 1, 5 };
	quickSort(arr, 0, 6);
	cout << "Quick Sorted array: \n";
	for(int i=0;i<6;i++)
        cout<<arr[i]<<endl;
	return 0;
}
