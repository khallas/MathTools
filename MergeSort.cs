using System;

namespace Kartik.MathTools
{
	public class MergeSort{
		public static void Main(){
			int[] initialArray = getArray();
			int[] sortedArray = sortArray(initialArray);
			printArray(sortedArray);
		}

		public static int[] getArray(){
			Console.WriteLine("How many numbers are there in your array?");
			int length;
			int.TryParse(Console.ReadLine(),out length);
			int[] initialArray = new int[length];
			Console.WriteLine("Enter your array, every element on a separate line - ");
			for (int i=0; i<length; i++){
				int.TryParse(Console.ReadLine(),out initialArray[i]);
			}
			return initialArray;
		}

		public static int[] sortArray(int[] initialArray){
			int sortingSize = 2;
			for (int i = 0; i<initialArray.length; i=i+sortingSize){
				int blocks = initialArray.length/sortingSize; //number of blocks which are composed of elements of the sorting size.
				for(int j=0; j<blocks;j++){
					for(int k=0; k<sortingSize; k++){
						
					}
				}
			}
			return initialArray;
		}

		public static void printArray(int[] sortArray){

		}
		public static int[] copyArray(int[] originalArray){
			int[] copy = new int[originalArray.length];
			for (int i = 0; i<originalArray.length; i++){
				copy[i]=originalArray[i];
			}
			return copy;
		}
	}
}