using System;


namespace Kartik.MathTools
{
	public class PrimeFactors{
	public static void Main(){
		int x = getInt();
		if(isPrime(x)){
			Console.WriteLine("This number is prime itself and thus doesn't have any Prime Factors.");
		}
		else{
			Console.WriteLine("Prime Factors are listed below - ");
			for(int i = x-1; i>1; i--){
				if(isPrime(i)){
					if(x%i==0){
						Console.WriteLine(i);
					}
				}
			}
		}
		
	}

	public static int getInt(){
		Console.WriteLine("Enter the number for which to find Prime Factors - ");
		int x;
		int.TryParse(Console.ReadLine(),out x);
		return x;
	}

	public static bool isPrime(int n){
		for(int i=2;i<n;i++){
			if(n%i==0) return false;
		}
		return true;
	}
}
}
