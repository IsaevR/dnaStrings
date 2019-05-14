using System;
using System.Collections;
using System.Collections.Generic;
namespace dnaStrings
{
    class Program
    {
        static void Main(string[] args)
        {   
            string dna = "ATCG";
            Console.WriteLine("DNA string is "+  dna);
            Console.WriteLine(" The complementary side is: " + MakeComplement(dna));
            List<int> ages = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55 };

        }

        public static string MakeComplement(string dna)
        {
            string result = "";
            //char[] dnaArr = dna.ToCharArr();
            for(int i = 0; i < dna.Length; i++)
            {
                switch(dna[i])
                {
                    case 'A': result += 'T';
                        break;
                    case 'T': result += 'A';
                        break;
                    case 'C': result += 'G';
                        break;
                    case 'G': result += 'C';
                        break;  
                    default:  break;  
                }            
            }
            return result;
        }

        
    }
    
    
}   

