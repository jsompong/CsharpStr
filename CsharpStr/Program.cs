using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
//public void DrawImage(System.Drawing.Image image, float x, float y, float width, float height);
//public static string Left(this string str, int count)
//{  if (string.IsNullOrEmpty(str) || count < 1)
//    return string.Empty;
//else
//  return str.Substring(0, Math.Min(count, str.Length));
//}
//private string left(string inString, int inInt)
//{
//  if (inInt > inString.Length)
//    inInt = inString.Length;
//return inString.Substring(0, inInt);
//}
public static class DataTypeExtensions
{
    #region Methods

    public static string Left(this string str, int length)
    {
        str = (str ?? string.Empty);
        return str.Substring(0, Math.Min(length, str.Length));
    }

    public static string Right(this string str, int length)
    {
        str = (str ?? string.Empty);
        return (str.Length >= length)
            ? str.Substring(str.Length - length, length)
            : str;
    }

    #endregion
}
namespace CsharpStr
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
