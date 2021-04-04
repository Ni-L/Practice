using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;
namespace Practice
{
    class Coupons
    { 
        /// <summary>
        /// Read the input for finding the Coupons
       /// </summary>
        public static void ReadNumOfCoupons()
        {
            Console.WriteLine("Enter a number for distinct coupons");//Enter the number for coupons
            int couponNo = Convert.ToInt32(Console.ReadLine());//Convert the string into int
            FindOutRandomCount(couponNo);//calling private method FindOutRandomCount
        }
        private static void FindOutRandomCount(int couponNo)//Creating one private method
        {
            int distinct = 0; int count = 0;//initialized distinct and count
            bool[] isCollected = new bool[couponNo];//Create one instance variable
            while (distinct < couponNo) 
            {
                Random random = new Random();//Creating Random number 
                int newRandom = Convert.ToInt32(random.Next(0,couponNo));//Coverting Random value string to the int
                count++;//Incrementing count value
                if (!isCollected[newRandom])
                {
                    distinct++;
                    isCollected[newRandom] = true;
                }
        
            }
            Console.WriteLine("Total random number needed to have all distinct coupons: " + count);//Print the output
        }

    }
}
