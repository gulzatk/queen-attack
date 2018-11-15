using System;
using System.Collections.Generic;

class Queen
{
    public int QueenX;
    public int QueenY;
    public int OtherX;
    public int OtherY;
    
    public Queen(int queenX, int queenY, int otherX, int otherY)
    {
       QueenX = queenX;
       QueenY = queenY;
       OtherX = otherX;
       OtherY = otherY;
    }
    }
    public class Program
    {
    public static void Main()
   {
        Console.WriteLine("Enter a cordinates for queen X");
        int queenX = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a cordinates for queen Y");
        int queenY = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a cordinates for other X");
        int otherX = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a cordinates for other Y");
        int otherY = int.Parse(Console.ReadLine());

        Queen newQueen = new Queen(queenX, queenY, otherX, otherY);

       

       
            if(newQueen.QueenX == newQueen.OtherX)
            {
               Console.WriteLine("The Queen can attack this piece horizontally.");
              
            }
            else if(newQueen.QueenY == newQueen.OtherY)
            {
               Console.WriteLine("The Queen can attack this piece vertically.");
               
            }

            for(int i=1; i<8; i++)
             if(newQueen.QueenX == newQueen.OtherX + i && newQueen.QueenY == newQueen.OtherY + i)
            {
               Console.WriteLine("The Queen can attack this piece diagonally.");
               break;
            }
             else if(newQueen.QueenX == newQueen.OtherX - i && newQueen.QueenY == newQueen.OtherY - i)
            {
                Console.WriteLine("The Queen can attack this piece diagonally.");
                break;
            }
            else
            {
                Console.WriteLine("The Queen cannot attack this piece.");
            }

        }
       
    }


    



