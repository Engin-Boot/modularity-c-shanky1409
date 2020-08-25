using System;
using System.Diagnostics;
using System.Drawing;
using TelCo.ColorCoder.Utils;
using TelCo.ColorCoder;

namespace TelCo.ColorCoder.Tests
{
    internal static class ColorsTest
    {
        /// <summary>
        /// Test code for the Colors class
        /// </summary>
        /// <param name="args"></param>
        internal static void GetColorFromPairNumberTest()
        {
            int pairNumber = 4;
            ColorPair testPair1 = Colors.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.Brown);

            pairNumber = 5;
            testPair1 = Colors.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = Colors.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.Violet);
            Debug.Assert(testPair1.minorColor == Color.Green);
        }
        internal static void GetPairNumberFromColorTest()
        {
            ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            int pairNumber = Colors.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = Colors.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);
        }
    }
}
