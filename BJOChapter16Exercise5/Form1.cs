// Ben Olson
// Chapter 16 Exercise 5
// 9.11.2017




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJOChapter16Exercise5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        //                       *******When you click the encode button*******

        private void btEncode_Click(object sender, EventArgs e)
        {
            //declare variable
            
            string english = txtBxEnglish.Text; //gets text put in by user
            string pigLatin = ""; //resets pig latin variable to blank so it only appends the new one
            string[] englishWords; //array to hold each word from the input string
            try
            {
                //check if the input sentance contains punctuation
                if (punctuation(english) == true) //call method to check if it contains punctuation
                {
                    throw new ContainsPunctuationException(); //throws exception
                }
                
                //split english phrase into array of each word
                englishWords = english.Split(' ');

                //loop through each english word to translate and append to pigLatinString
                for (int i = 0; i < englishWords.Length; i++)
                {

                    //call method to check for one letter words
                    if (length(englishWords[i]) == true)
                    {
                        throw new OneLetterWordException(); //throws exception
                    }

                    //call method to encode word and add to pig latin string
                    pigLatin = pigLatin + GetPigLatin(englishWords[i]) + " ";
                }

                //output translated sentence to the pig latin box
                txtBxPigLatin.AppendText(pigLatin + Environment.NewLine);
                //add line to seperate new lines from previous
                txtBxPigLatin.AppendText(Environment.NewLine);

                
            }
            //                       *******Catches*******

            catch (ContainsPunctuationException)
            {
                //display error message for punctuation
                MessageBox.Show("Phrase can not contain any punctuation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand); 
            }
            catch (OneLetterWordException)
            {
                MessageBox.Show("Words used in phrase must be 2 characters or more", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
        }


        //                       *******method to encode in pig latin*******

        private string GetPigLatin(string e)
        {
            //variables used only in method
            string word = e;
            string pL = "";
            char first = ' '; //store first letter of each word
            string remaining = ""; //store the remaining letters of each word

            //get first letter
            first = word[0];
            //get remaining
            remaining = word.Substring(1);
            //construct the word in pig latin
            pL = remaining + first + "ay";
            
            //return phrase in pig latin
            return pL;
        }

        //                       *******method to check if it contains any puntuation*******

        private Boolean punctuation(string e)
        {
            if (e.IndexOfAny(new char[] { '.', ',', '!', '#', '\'', '/', '-', '_' }) != -1)
            {
                return true;
            }
            else
                return false;
        }

        //                       *******method to check if it contains any words less than two characters*******

        private Boolean length(string l)
        {
            if (l.Length < 2)
            {
                return true;
            }
            else
                return false;
        }



    }
}
