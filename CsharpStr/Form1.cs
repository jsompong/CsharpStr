using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CsharpStr
{
   
    //public static class Utils
    //{
    //  public static string Left(this string str, int length)
    //{
    //  return str.Substring(0, Math.Min(length, str.Length));
    //}
    //}


    public partial class Form1 : Form
    {
        string essage = "983535646339641170436715078308064617372638777103985828497766009228957043915645541313496237574921856565850542432116202019706166328855616929396555094021043645333159523046582180694975287953070828010633034858450343439558517387393454344024501719901050538630983082349221596665286330073953382879728118393750664385979370342488321556520275629103367856920512959565363601551468503278339852954337188737592595518761102340182055231230470638634249423650422111008238014579611817897677128642563104773198984364198197177231880589691253364811131730152814583034985000345826544919262670988180473355917641686936199578724264";
        //string text = "The the quick brown fox  fox jumps over the lazy dog dog.";
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            SetStyle(ControlStyles.ResizeRedraw, true);

            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Text = "Fun with graphics";
            //this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
        }
        //public sealed class Graphics : MarshalByRefObject, IDisposable, System.Drawing.IDeviceContext
        //private string left(string inString, int inInt)
       

        private void Form1_(PaintEventArgs e)
        {

            // Create image.
            Image newImage = Image.FromFile("th.jpg");

            // Create point for upper-left corner of image.
            PointF ulCorner = new PointF(100.0F, 100.0F);

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, ulCorner);
        }
        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            // Make a big red pen.
            Pen p = new Pen(Color.Red, 7);
            g.DrawLine(p, 1, 1, 200, 200);

            // Create image.
            Image newImage = Image.FromFile("th.jpg");
             // Create point for upper-left corner of image.
            PointF ulCorner = new PointF(100.0F, 100.0F);
             // Draw image to screen.
            e.Graphics.DrawImage(newImage, ulCorner);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //string email = "feedback@abc.comm";
            //int index = email.IndexOf("@");
            //string user = (index > 0 ? email.Substring(0, index) : "");
            textBox2.Text = essage;
            string caption = "Detect  Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            int stringLength = essage.Length;
            //int stringLe = inString.Length;

            double numdiv = (double)stringLength / 50;
            //string myString = stringLength.ToString();
            string myString = numdiv.ToString();
            string message = myString;       // "You did not enter a server name. Cancel this operation?";
            MessageBox.Show(message, caption, buttons);
            //string left(string inString, int inInt);
        
            string s = essage;
            //s = s.PadRight(30).Substring(0, 30).Trim(); //"hello how are you"
            //textBox1.Text= s.PadRight(30).Substring(0, 30).Trim(); //"hello how are you"
            // s = s.PadRight(3).Substring(0, 3).Trim(); //"hel"
             string i = s.PadRight(6).Substring(0, 6).Trim(); //"hel"
             string truncat = s.Substring(6, stringLength-6); 
            ////= s.PadLeft(6).Substring(0, 6).Trim();
            textBox1.Text = i + "  " ;
           // int varilength = stringLength;
            // ------------------------------- 2 --------------------------------------------
            essage = truncat;
            stringLength = stringLength - 6;
            string s2 = essage;
            string i2 = s2.PadRight(6).Substring(0, 6).Trim();
            string truncat2 = s2.Substring(6, stringLength - 6);
            textBox1.Text = textBox1.Text  +  i2 + "  " ;
            // ------------------------------- 3 --------------------------------------------
            essage = truncat2;
            stringLength = stringLength - 6;
            string s3 = essage;
            string i3 = s3.PadRight(6).Substring(0, 6).Trim();
            string truncat3 = s3.Substring(6, stringLength - 6);
            textBox1.Text = textBox1.Text + i3 + "  " ;
            // ------------------------------- 4 --------------------------------------------
            essage = truncat3;
            stringLength = stringLength - 6;
            string s4 = essage;
            string i4 = s4.PadRight(6).Substring(0, 6).Trim();
            string truncat4 = s4.Substring(6, stringLength - 6);
            textBox1.Text = textBox1.Text + i4 + "  " + truncat4;

            //DrawImagePointF();
            // Create image.
            //Image newImage = Image.FromFile("th.jpg");
            // Create point for upper-left corner of image.
            //PointF ulCorner = new PointF(100.0F, 100.0F);
             // Draw image to screen.
            //Graphics.DrawImage(newImage, ulCorner);
            //     for (int  varilength = stringLength;  varilength > 18; varilength-- )
            //   {
            //varilength--;
            // varilength--;
            // varilength--;
            //varilength--;
            //varilength--;
            //string z = essage;
            //string y = z.PadRight(6).Substring(0, 6).Trim(); 
            //string truncatex = z.Substring(6, varilength - 6);
            //textBox1.Text = y + "  " + truncatex;
            //essage = truncatex;
            // }
            // string Left(this string str, int length);
        }
    }
}
