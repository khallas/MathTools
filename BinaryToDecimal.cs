using System;
using System.IO;

namespace Kartik.MathTools
{
	public class BinaryToDecimal{
		public static void Main(){
			bool bin2dec = getConversionDirection();
			int binary; double dec;
			if(bin2dec){
				binary = getBinary();
				dec = toDecimal(binary);
				Console.WriteLine("decimal representation is - "+dec);
			}
			else{
				dec = getDecimal();
				binary = toBinary(dec);
				Console.WriteLine("binary representation is - "+binary);

			}

		}

		public static bool getConversionDirection(){
			bool loop=true;
			while(loop){
				Console.WriteLine("If you want to convert from binary to decimal, type 1. If you want to convert from decimal to binary, type 2.");
				int option;
				int.TryParse(Console.ReadLine(), out option);
				switch (option){
					case 1 : loop = false; return true; break;
					case 2 : loop = false; return false; break;
					default : Console.WriteLine("Incorrect choice."); break;
					}
			}
			return false;
		}
		
		public static int getBinary(){
			Console.WriteLine("Please enter a binary number -");
			int binary;
			int.TryParse(Console.ReadLine(), out binary);
			return binary;
		}
		public static double getDecimal(){
			Console.WriteLine("Please enter a decimal number -");
			double dec;
			double.TryParse(Console.ReadLine(), out dec);
			return dec;
		}
		public static double toDecimal(int binary){
			double dec=0; int powerCounter=0;
			while(binary >0){
				if(binary%10==1){
					dec = dec+ Math.Pow(2,powerCounter);
					binary = binary-1;
					binary=binary/10;
				}
				else{
					binary = binary/10;
				}
				powerCounter++;
			}

			return dec;
		}
		public static int toBinary(double dec){
			int powerCounter=0;
			int binary=0;
			while(dec >0){
				if(dec%2==1){
					binary = binary+ (int)Math.Pow(10,powerCounter);
					dec = dec-1;
					dec=dec/2;
				}
				else{
					dec = dec/2;
				}
				powerCounter++;
			}

			return binary;

		}
	}
}