using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColorHelper;

namespace RGB2HEX
{
    class ConvertToHex
    {
        public void ConvertHex(byte r, byte g, byte b)
        {
            RGB rgb = new RGB(r, g, b);
            HEX hex = ColorConverter.RgbToHex(rgb);
            File.WriteAllText(@"C:\Windows\Hex.txt", "#" + hex.ToString());
        }
    }
}
