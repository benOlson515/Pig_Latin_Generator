using System;


namespace BJOChapter16Exercise5
{
    class ContainsPunctuationException : Exception
    {
        //default constructor
        public ContainsPunctuationException()
            : base("Phrase must not contain any punctuation")
        {
        }


    }
}
