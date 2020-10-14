using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Rico!");

            int [] intergervalues= {-25,-65,40,65,2,13,41,0,96,-50};
            selectionSort(intergervalues);
            Console.WriteLine(string.Join(" =|=> ", intergervalues));

            int [] intergervaluesX = {12,3,9,6,76,30,15,-25,68,-35,40,50,-60,79};
            insertionSort(intergervaluesX);
            Console.WriteLine(string.Join(" ===>  ", intergervaluesX));
            
          
        }






        public static void selectionSort<T>(T[] array) where T: IComparable{


            for(int i = 0; i < array.Length - 1; i++){

                int minIndex = i;
                T minValue = array[i];

                for(int j = i +1; j < array.Length; j++){

                    if(array[j].CompareTo(minValue) < 0){

                        minIndex = j;
                        minValue = array[j];

                    }
                }
                Swap(array, i , minIndex);
            }
        }


        private static void Swap<T>(T[] array, int first, int second){

            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }



        public static void insertionSort<T>(T[] array) where T: IComparable{

            // this for loops iterates thru the array and setting the first element in that array to 1, AppDomain as long as it is below the length of the array then we increment and the loops keep iterating.

            for(int i =1; i < array.Length; i ++){

                int j = i;
                // here in our while , it just takes that element in the unsorted column or array and then compares it to the next column or array and if its lessthan element then we swap using our swap function
                while(j > 0 && array[j].CompareTo(array[j-1]) < 0){
                    Swap(array, j, j-1);
                    j--;
                }
            }
        }























    }


}
