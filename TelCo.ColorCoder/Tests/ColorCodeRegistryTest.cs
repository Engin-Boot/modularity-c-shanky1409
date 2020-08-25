using System;
using System.Diagnostics;

namespace TelCo.ColorCoder.Tests
{
    internal static class ColorCodeRegistryTest
    {
        /// <summary>
        /// Test code for the ColorCodeRegistry class
        /// </summary>
        /// <param name="args"></param>
        internal static void ToStringTest()
        {
            ColorCodeRegistry colorCodeRegistry = new ColorCodeRegistry();
            Console.WriteLine(colorCodeRegistry);
            ColorCodeRegistry colorCodeRegistry1 = new ColorCodeRegistry();
            Debug.Assert(colorCodeRegistry.ToString().Equals(colorCodeRegistry1.ToString()));
        }    
    }
}
