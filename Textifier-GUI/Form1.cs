using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textifier_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String userMessage = messageBox.Text;
            String clipData = "";
            switch (effectSelectBox.Text)
            {
                case ("Random Capitalization"): clipData = RandCap(userMessage); break;
                case ("Regional Indicators"): clipData = RegInd(userMessage); break;
                default: clipData = "null"; break;
            }
            Clipboard.SetText(clipData);
        }

        private static String RandCap(String message)
        {
            Random rng = new Random();
            String processed = "";
            foreach (char c in message) {
                char newChar;
                // 2 in 5 prob
                if (Char.IsLetter(c) && Enumerable.Range(0, 2).Contains(rng.Next(6)))
                    newChar = Char.ToUpper(c);
                else
                    newChar = c;
                processed += newChar;
            }
            return processed;
        }

        private static String RegInd(String message)
        {
            String processed = "";
            foreach (char c in message) {
                int c1 = (int)c;
                String addc;
                // is letter?
                if ((c1 >= 65 && c1 <= 90) || (c1 >= 97 && c1 <= 122))
                    addc = String.Format(":regional_indicator_{0}:", Char.ToString(c));
                // is space?
                else if (c == 32)
                    addc = ":speech_left:";
                // is number?
                else if (c1 >= 0 && c1 <= 9)
                    addc = String.Format(":{0}:", Char.ToString(c));
                else addc = "";
                processed = String.Concat(processed, addc, " ");
            }
            return processed;
        }
    }
}
