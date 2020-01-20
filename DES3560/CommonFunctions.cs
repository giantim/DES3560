using System;
using System.Windows.Forms;
using System.Drawing;

namespace DES3560
{
    public class CommonFunctions
    {
        public static void changePass(Label lbl)
        {
            lbl.ForeColor = Color.Blue;
            lbl.Text = "P";
        }
        public static void changeFail(Label lbl)
        {
            lbl.ForeColor = Color.Red;
            lbl.Text = "F";
        }
        public static int getSpaceIndex(string text, int index)
        {
            int i = 0;
            while (!text[index + i].Equals(' '))
                i = i + 1;
            return index + i;
        }
        public static int getNewLineIndex(string text, int index)
        {
            int i = 0;
            while (!text[index + i].Equals('\n'))
                i = i + 1;
            return index + i;
        }
        public static int jumpNonSpace(string text, int index)
        {
            int i = 0;
            while (text[index + i].Equals(' '))
                i = i + 1;
            return index + i;
        }
        public static int getSpaceOrNewLineIndex(string s)
        {
            int index = 0;
            foreach (char c in s)
            {
                if (!c.Equals(' ') && c != 10)
                    index = index + 1;
                else
                    break;
            }
            return index;
        }
        public static int getCommaIndex(string s)
        {
            int index = 0;
            foreach (char c in s)
            {
                if (!c.Equals(','))
                    index = index + 1;
                else
                    break;
            }
            return index;
        }
        public static int getParenthesisIndex(string s)
        {
            int index = 0;
            foreach (char c in s)
            {
                if (!c.Equals(')'))
                    index = index + 1;
                else
                    break;
            }
            return index;
        }
    }
}
