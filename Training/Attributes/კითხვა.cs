using System;

namespace Training.Attributes
{
    class კითხვა : Attribute
    {
        public string Question { get; }
        public კითხვა(string question)
        {
            Question = question;
        }
    }
}
