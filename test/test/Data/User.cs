using System;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;


namespace test.Data
{
    public class User
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public DateTime DOB;
        public long CardNum;
        public int Pin;
        public List<Tuple<DateTime, Book>> DueDates = new List<Tuple<DateTime, Book>>();


        //class constructor
        public User(string First, string Last, string Mail, DateTime Birth, int PinNum)
        {
            //for creating random card number
            Random RandNum = new Random();
            string CardString = string.Empty;

            for (int i = 0; i < 14; i++)
            {
                CardString = String.Concat(CardString, RandNum.Next(10).ToString());

            }

            CardNum = Convert.ToInt64(CardString);

            FirstName = First;
            LastName = Last;
            Email = Mail;
            DOB = Birth;
            Pin = PinNum;

        }

        public void addSignedOutBook(DateTime Due, Book BookSignedOut)
        {
            DueDates.Add(new Tuple<DateTime, Book>(Due, BookSignedOut));
        }

    }

}
