using System.Drawing;

namespace TelCo.ColorCoder
{
    internal class ColorCodeRegistry
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        internal static Color[] colorMapMajor = { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
        /// <summary>
        /// Array of minor colors
        /// </summary>
        internal static Color[] colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray};
        public override string ToString()
        {
            string colorCode = "";
            int i = 1;
            foreach (var majorColor in ColorCodeRegistry.colorMapMajor)
            {
                foreach (var minorColor in ColorCodeRegistry.colorMapMinor)
                {
                    colorCode += $"MajorColor:{majorColor}, MinorColor:{minorColor}, PairNumber:{i++}\n";
                }
            }
            return colorCode;
        }
    }
}
