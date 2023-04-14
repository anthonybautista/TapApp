using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TapApp
{
    public partial class MainPage : ContentPage
    {
        private string _dotsAndDashes1 = "";
        private string _dotsAndDashes2 = "";
        private string _converted1 = "";
        private string _converted2 = "";

        public MainPage()
        {
            InitializeComponent();
        }

        public void Add_Dot(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.ClassId == "Dot_1")
            {
                _dotsAndDashes1 += ".";
                Dots_Dashes_1.Text = _dotsAndDashes1;
            } else
            {
                _dotsAndDashes2 += ".";
                Dots_Dashes_2.Text = _dotsAndDashes2;
            }
        }

        public void Add_Dash(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.ClassId == "Dash_1")
            {
                _dotsAndDashes1 += "-";
                Dots_Dashes_1.Text = _dotsAndDashes1;
            }
            else
            {
                _dotsAndDashes2 += "-";
                Dots_Dashes_2.Text = _dotsAndDashes2;
            }
        }

        public void Convert(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.ClassId == "Space_1")
            {
                char decoded = Morse.MorseCoder(_dotsAndDashes1);

                _dotsAndDashes1 = "";
                Dots_Dashes_1.Text = _dotsAndDashes1;

                _converted1 += decoded;
                Converted_1.Text = _converted1;
            }
            else
            {
                char decoded = Morse.MorseCoder(_dotsAndDashes2);

                _dotsAndDashes2 = "";
                Dots_Dashes_2.Text = _dotsAndDashes2;

                _converted2 += decoded;
                Converted_2.Text = _converted2;
            }
        }

        public void Clear_Text(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.ClassId == "Delete_1")
            {
                _dotsAndDashes1 = "";
                Dots_Dashes_1.Text = _dotsAndDashes1;

                _converted1 = "";
                Converted_1.Text = _converted1;
            }
            else
            {
                _dotsAndDashes2 = "";
                Dots_Dashes_2.Text = _dotsAndDashes2;

                _converted2 = "";
                Converted_2.Text = _converted2;
            }
        }
    }
}
