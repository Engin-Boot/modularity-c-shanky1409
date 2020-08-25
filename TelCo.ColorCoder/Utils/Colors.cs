using System;
using TelCo.ColorCoder.Data;

namespace TelCo.ColorCoder.Utils
{
   class Colors
    {
        /// <summary>
        /// Given a pair number function returns the major and minor colors in that order
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns></returns>
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            if (pairNumber < 1 || pairNumber > ColorCodeRegistry.colorMapMinor.Length * ColorCodeRegistry.colorMapMajor.Length)
                throw new ArgumentOutOfRangeException(string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            ColorPair pair = new ColorPair() 
            {
                majorColor = ColorCodeRegistry.colorMapMajor[((pairNumber - 1) / (ColorCodeRegistry.colorMapMinor.Length))],
                minorColor = ColorCodeRegistry.colorMapMinor[((pairNumber - 1) % (ColorCodeRegistry.colorMapMinor.Length))]
            };
            return pair;
        }
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = -1, minorIndex = -1;
            for (int i = 0; i < ColorCodeRegistry.colorMapMajor.Length; i++)
                if (ColorCodeRegistry.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            for (int i = 0; i < ColorCodeRegistry.colorMapMinor.Length; i++)
                if (ColorCodeRegistry.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            if (majorIndex == -1 || minorIndex == -1)
                throw new ArgumentException(string.Format("Unknown Colors: {0}", pair.ToString()));
            return (majorIndex * ColorCodeRegistry.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}