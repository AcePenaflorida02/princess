
class Sorting{
    public static void Main(string[] args){
        int[] arr = {7, 11, -9, 12, 1};
        // Insertion.InsertionSort(arr, arr.Length);

        Quick.QuickSort(arr, 0, arr.Length-1);
        DisplayArr(arr);
    }



    public static void DisplayArr(int[] arr){
        // Console.WriteLine("Sorted Array: ");
        Console.WriteLine();
        foreach(int val in arr){
            Console.Write(val + " ");
        }
    }
}


class Bubble : Sorting{
    public static void BubbleSort(int[] arr){
        // ! {8, 9, 1, 2, -1}
        int size = arr.Length, temp;


        // for(int i = 0)

        // for(int i = 0; i < (size - 1); i++){
        //     for(int j = 0; j < (size - i - 1); j++){
        //         if(arr[j] > arr[j+1]){
        //             temp = arr[j+1];
        //             arr[j+1] = arr[j];
        //             arr[j] = temp;
        //         }
        //     }
        //     DisplayArr(arr);
        //     Console.WriteLine();
        // }       
    }
}


class Selection : Sorting{
    // ! {7, 1, -2, 8, 4}
    public static void SelectionSort(int[] arr, int size){
        int min_idx, temp;
        for(int step = 0; step < (size-1); step++){
            min_idx = step;
            for(int i = step+1; i < size; i++){
                if(arr[min_idx] > arr[i]){
                    min_idx = i;
                }
            }
            temp = arr[step];
            arr[step] = arr[min_idx];
            arr[min_idx] = temp;
            DisplayArr(arr);
            Console.WriteLine();
        }
    }
}


class Insertion : Sorting{
    public static void InsertionSort(int[] arr, int size){
        for(int step = 1; step < size; step++){
            int key = arr[step];
            int j = step - 1;

            while(j >= 0 && arr[j] > key){
                arr[j+1] = arr[j];
                j--;
            }

            arr[j+1] = key;
            DisplayArr(arr);
            Console.WriteLine();
        }
    }
}


class Quick : Sorting{

public static void Swap(int[] arr, int i, int j){
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
  }
  
  
  public static int Partition(int[] arr, int low, int high){
    int pivot = arr[low];
    int i = low + 1, j = high;
    
    while(i <= j){
      
      while(i <= j && arr[i] <= pivot)
        i++;
      
      while(i <= j && arr[j] >= pivot)
        j--;
      
      if(i <= j){
        Swap(arr, i, j);
        // DisplayArr(arr);
      }
      
    }
    
    Swap(arr, low, j);
    return j;
  }
  
  
  public static void QuickSort(int[] arr, int low, int high){
    if(low < high){
      int j = Partition(arr, low, high);
      Console.WriteLine(j);
      QuickSort(arr, low, j-1);
      QuickSort(arr, j+1, high);
    }
    
  }


    
}