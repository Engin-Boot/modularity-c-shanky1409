using TelCo.ColorCoder.Tests;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            ColorsTest.GetColorFromPairNumberTest();
            ColorsTest.GetPairNumberFromColorTest();
            ColorCodeRegistryTest.ToStringTest();
        }
    }
}
