using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SimpleEncoding
{
    const int ZEROBYTE = 0x00000000b;

    public static string HexToUTF8(string src)
    {
        var dst = new byte[src.Length];
        for (var i = 0; i < src.Length; i++)
        {
            dst[i] = (byte)(ZEROBYTE ^ src[i]);
        }
        return Encoding.ASCII.GetString(dst);
    }

    public static string UTF8ToHex(string src)
    {
        var dst = new byte[src.Length];
        for (var i = 0; i < src.Length; i++)
        {
            dst[i] = (byte)(ZEROBYTE ^ src[i]);
        }
        return Encoding.ASCII.GetString(dst);
    }

}
