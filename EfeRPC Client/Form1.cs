using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace EfeRPC_Client
{
    public partial class Form1 : Form
    {
        private void roundButton_Paint(object sender,
        System.Windows.Forms.PaintEventArgs e)
        {

            System.Drawing.Drawing2D.GraphicsPath buttonPath =
                new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = roundButton.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -10);

            // Draw the button's border.
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            buttonPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            roundButton.Region = new System.Drawing.Region(buttonPath);

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.efeborazan.tk/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox1.Visible == false)
            {
                textBox1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox1.Text = "EfeRPC";
                button2.Visible = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Windows\Temp\state.txt"))
            {
                File.Delete(@"C:\Windows\Temp\state.txt");
            }
            string path = @"C:\Windows\Temp\state.txt";

            // The line below will create a text file, my_file.txt, in 
            // the Text_Files folder in D:\ drive.
            // The CreateText method that returns a StreamWriter object
            using (StreamWriter sw = File.CreateText(path)) ;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Windows\Temp\state.txt", true))
            {

                file.WriteAsync(textBox1.Text);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                textBox2.Visible = true;
                button3.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
                textBox2.Text = "EfeRPC";
                button3.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Visible == false)
            {
                textBox3.Visible = true;
                button4.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
                textBox3.Text = "EfeRPC";
                button4.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox4.Visible == false)
            {
                textBox4.Visible = true;
                button5.Visible = true;
            }
            else
            {
                textBox4.Visible = false;
                textBox4.Text = "EfeRPC";
                button5.Visible = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox5.Visible == false)
            {
                textBox5.Visible = true;
                button6.Visible = true;
            }
            else
            {
                textBox5.Visible = false;
                textBox5.Text = "EfeRPC";
                button6.Visible = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox6.Visible == false)
            {
                textBox6.Visible = true;
                button7.Visible = true;
            }
            else
            {
                textBox6.Visible = false;
                textBox6.Text = "EfeRPC";
                button7.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Windows\Temp\detail.txt"))
            {
                File.Delete(@"C:\Windows\Temp\detail.txt");
            }
            string path = @"C:\Windows\Temp\detail.txt";

            // The line below will create a text file, my_file.txt, in 
            // the Text_Files folder in D:\ drive.
            // The CreateText method that returns a StreamWriter object
            using (StreamWriter sw = File.CreateText(path)) ;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Windows\Temp\detail.txt", true))
            {

                file.WriteAsync(textBox2.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string path = @"C:\Windows\Temp\largeimagekey.txt";

            // The line below will create a text file, my_file.txt, in 
            // the Text_Files folder in D:\ drive.
            // The CreateText method that returns a StreamWriter object
            using (StreamWriter sw = File.CreateText(path)) ;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Windows\Temp\largeimagekey.txt", true))
            {

                file.WriteAsync(textBox3.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Windows\Temp\largeimagetext.txt"))
            {
                File.Delete(@"C:\Windows\Temp\largeimagetext.txt");
            }
            string path = @"C:\Windows\Temp\largeimagetext.txt";

            // The line below will create a text file, my_file.txt, in 
            // the Text_Files folder in D:\ drive.
            // The CreateText method that returns a StreamWriter object
            using (StreamWriter sw = File.CreateText(path)) ;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Windows\Temp\largeimagetext.txt", true))
            {

                file.WriteAsync(textBox4.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Windows\Temp\smallimagekey.txt"))
            {
                File.Delete(@"C:\Windows\Temp\smallimagekey.txt");
            }
            string path = @"C:\Windows\Temp\smallimagekey.txt";

            // The line below will create a text file, my_file.txt, in 
            // the Text_Files folder in D:\ drive.
            // The CreateText method that returns a StreamWriter object
            using (StreamWriter sw = File.CreateText(path)) ;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Windows\Temp\smallimagekey.txt", true))
            {

                file.WriteAsync(textBox5.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Windows\Temp\smallimagetext.txt"))
            {
                File.Delete(@"C:\Windows\Temp\smallimagetext.txt");
            }
            string path = @"C:\Windows\Temp\smallimagetext.txt";

            // The line below will create a text file, my_file.txt, in 
            // the Text_Files folder in D:\ drive.
            // The CreateText method that returns a StreamWriter object
            using (StreamWriter sw = File.CreateText(path)) ;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Windows\Temp\smallimagetext.txt", true))
            {

                file.WriteAsync(textBox6.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Windows\Temp\clientid.txt"))
            {
                File.Delete(@"C:\Windows\Temp\clientid.txt");
            }
            string path = @"C:\Windows\Temp\clientid.txt";

            // The line below will create a text file, my_file.txt, in 
            // the Text_Files folder in D:\ drive.
            // The CreateText method that returns a StreamWriter object
            using (StreamWriter sw = File.CreateText(path)) ;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Windows\Temp\clientid.txt", true))
            {

                file.WriteAsync(textBox7.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Process.Start(@"C:\Windows\Temp\clientid.txt");

            button9.Enabled = false;
            button9.BackColor = Color.Black;

            button10.Enabled = true;
            button10.BackColor = Color.Red;

        }

        private void button10_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("cmd.exe", "/c taskkill /F /IM node.exe /T");

            button9.Enabled = true;
            button9.BackColor = Color.Green;

            button10.Enabled = false;
            button10.BackColor = Color.Black;
        }
    }
}
