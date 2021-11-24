using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Document
    {
        public string Text { get; set; }
        public delegate int SendDoc();

        public void ReportSendingResult(SendDoc sendingDelegate)
        {
            if (sendingDelegate() == 0)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Unable to send!!!");
            }
        }
    }
}
