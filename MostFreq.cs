namespace Assignment2;

public class MostFreq
{
    public int MostFreqNum(int[] arr, int n)
    {
        
         
        int maxcount = 0; 
        int element_max = 0; 
        for (int i = 0; i < n; i++) { 
            int count = 0; 
            for (int j = 0; j < n; j++) { 
                if (arr[i] == arr[j]) { 
                    count++; 
                } 
            } 
  
            if (count > maxcount) { 
                maxcount = count; 
                element_max = arr[i]; 
            } 
        } 
  
        return element_max; 
    } 
    }