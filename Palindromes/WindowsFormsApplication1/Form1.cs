using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Application to find the longest 3 palindromes in a string of characters
// Fiona Treveil  8th July 2016

namespace WindowsFormsApplication1
{
    public partial class Palindromes : Form
    {
        public Palindromes()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sInput = txtInput.Text;

            lblPalindrome1.Text = "";
            lblPalindrome2.Text = "";
            lblPalindrome3.Text = "";
            if (sInput.Length < 2)
            {
                lblError.Text = "Please enter a longer string";
            } 
            else
            {
                /*  Find palindrome: 
                for each character in input string
                  if this position might be the centre of a palindrome, then check it out by calling FindPalindrome
                    if palindrome is found then save it in a list
                end for

                function FindPalindrome(string back from position, string forwards from position)
                    for characters in both strings in reverse order
                      if characters are the same then OK -carry on
                      else {
                        if found at least 1 matching character then save return palidrome length
                        break
                      }
                    end for
                end function
                */
                List<Palin> allPalindromes = new List<Palin>();
                int currPos = 1;        //Start with the 2nd character in the string as the first cannot be a palindrome
                int maxPos = sInput.Length;
                Palin oPalin = null;
                int palinPos;
                while (currPos < maxPos-1)  //Stop before the end of the string
                {
                    if (sInput[currPos] == sInput[currPos+1])
                    {
                        palinPos = findPalindrome(sInput.Substring(0, currPos), sInput.Substring(currPos + 2), currPos);
                        if (palinPos > 0) oPalin = new Palin(sInput.Substring(currPos - palinPos, palinPos * 2 + 2), currPos - palinPos);
                        currPos = currPos + 2;
                    }
                    else if (sInput[currPos-1] == sInput[currPos+1])
                    {
                        palinPos = findPalindrome(sInput.Substring(0, currPos), sInput.Substring(currPos + 1), currPos);
                        if (palinPos > 0) oPalin = new Palin(sInput.Substring(currPos - palinPos, palinPos * 2 + 1), currPos - palinPos);
                        currPos = currPos + 1;
                    }
                    else
                    {
                        currPos = currPos + 1;
                    }
                    if (oPalin != null) allPalindromes.Add(oPalin);
                    oPalin = null;
                }
                List<Palin> sorted = allPalindromes.OrderByDescending(o => o.Length).ToList();
                if (sorted.Count > 0) lblPalindrome1.Text = showPalindrome(sorted[0]);
                if (sorted.Count > 1) lblPalindrome2.Text = showPalindrome(sorted[1]);
                if (sorted.Count > 2) lblPalindrome3.Text = showPalindrome(sorted[2]);
            }
        }

        public class Palin
        {
            private string sPalindrome;
            private int iPosition;
            public Palin(String palin, int pos)
            {
                this.sPalindrome = palin;
                this.iPosition = pos;
            }
            public string Palindrome
            {
                get { return sPalindrome; }
                set { sPalindrome = value; }
            }
            public int Position
            {
                get { return iPosition; }
                set { iPosition = value; }
            }
            public int Length
            {
                get { return sPalindrome.Length; }
            }
        }

        int findPalindrome(String sBack, String sFore, int lPos)
        {
            int lMax = Math.Min(sFore.Length, sBack.Length);
            int lBackLen = sBack.Length;
            int i;
            int oRet = 0;
            int bFound = 0;

            for (i=0; i< lMax; i++)
            {
                if (sBack[lBackLen - i - 1] != sFore[i])
                {
                    if (i >= 1)
                        oRet = i;
                    else
                        bFound = 0;
                    break;
                }
                else
                    bFound = i;
            }
            if (bFound > 0 && oRet == 0)  //Might have found a palindrome at the end of the string
            {
                oRet = bFound;
            }
            return oRet;
        }

        String showPalindrome(Palin oPalin)
        {
            return "Text: " + oPalin.Palindrome + " , Index: " + oPalin.Position + " , Length: " + oPalin.Length;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
