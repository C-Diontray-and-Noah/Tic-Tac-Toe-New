using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3T
{
    class Board
    {
        public static void TTTBoard(string[] placeHolders)
        {
           


            for (int i = 1; i < placeHolders.Length; i++)
            {
                if (i == 3 || i == 6 || i == 10)
                {
                   Console.Write(placeHolders[i] + " \n");
                    Console.Write("---------\n");
                }
                else if (i <= 8)
                {
                    Console.Write(placeHolders[i] + " | ");
                }
                else if (i == 9)
                {
                    Console.Write(placeHolders[i]);
                }
            }
            Console.WriteLine("");

        }
    }        
 }
            
    
