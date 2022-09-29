using System;
using System.Text.RegularExpressions;

namespace DesafioIntermediario01
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
        
            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            for ( int i = 0; i < num.Length; i++ )
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(MajorityElement(num));    
        }

        public static int MajorityElement(int[] nums)
        {
            int major = nums[0];
            int count = 1;
            int newCount = 1;
            int majority = major;
            for ( int i = 0; i < nums.Length; i++ )
            {   
                count = 1; 
                major = nums[i];
                for ( int j = 0; j < nums.Length; j++ )
                {
                    if ( major == nums[j] )
                    {
                        count++;
                    }      
                }
                
                if (count > newCount)
                {
                    newCount = count;
                    majority = nums[i];
                }
            }
            return   majority;
        }
    }
}