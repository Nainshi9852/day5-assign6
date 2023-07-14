using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_assign6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array called studentScores
            int[][] studentScores = new int[4][];

            // Initialize the studentScores array with scores
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };
            studentScores[3] = new int[] { 60, 55, 86 };

            // Print the scores of each student using nested loops
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.WriteLine("Scores for Student " + (i + 1) + ":");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.WriteLine("Score " + (j + 1) + ": " + studentScores[i][j]);
                }
                Console.WriteLine();
            }

            // Calculate the average score for each student and print the results
            for (int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }
                double average = (double)sum / studentScores[i].Length;
                Console.WriteLine("Average score for Student " + (i + 1) + ": " + average);
            }

            // Calculate the average score for all the students combined
            int totalSum = 0;
            int totalElements = 0;

            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalElements++;
                }
            }

            double totalAverage = (double)totalSum / totalElements;
            Console.WriteLine("Average score for all students: " + totalAverage);

            Console.ReadKey();
        }
    }
}
