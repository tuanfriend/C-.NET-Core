using System;

namespace RandomPass.Models
{
    public class RandomString
    {
       public string Word;

       public string RandomWord()
       {
           var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
           var stringChars = new char[14];
           var random = new Random();

           for (int i = 0; i < stringChars.Length; i++)
           {
               stringChars[i] = chars[random.Next(chars.Length)];
           }
           var finalString = new String(stringChars);
           return finalString;
       }
    }

}