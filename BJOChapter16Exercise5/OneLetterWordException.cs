using System;


namespace BJOChapter16Exercise5
{
    class OneLetterWordException : Exception
    {
        public OneLetterWordException()
            : base("Phrase must use words with 2 or more characters")
        {
        }

    }
}
