/*
         Problem: https://www.hackerrank.com/challenges/array-left-rotation/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         - For any element in the array, its final position after the given rotations can be obtained by a simple mathematical formula.
            So, if there are n elements in the array, d is the number of rotations then: 
             Final position of an element at ith index = (i + (n - d)) % n


         Gotchas:
          <None>

         Time Complexity:  O(n) //Factually it is O(2n) ~ O(n)
         Space Complexity: O(n) //we're storing input array and output array in memory. Factually it is O(2n)
                
*/

using System;
class Solution
{
    static void Main(string[] args)
    {
        var userInput = Console.ReadLine();
        var userInputSplits = userInput.Split(' ');
        //No need to capture the size of array. We can use array's length property instead.
        var numberOfRotations = int.Parse(userInputSplits[1]);
        userInput = Console.ReadLine();
        userInputSplits = userInput.Split(' ');
        var finalOutput = new string[userInputSplits.Length];
        for (var i = 0; i < finalOutput.Length; i++)
            finalOutput[(i + (finalOutput.Length - numberOfRotations)) % finalOutput.Length] = userInputSplits[i];

        for (var i = 0; i < finalOutput.Length; i++)
            Console.Write(finalOutput[i] + " ");
    }
}