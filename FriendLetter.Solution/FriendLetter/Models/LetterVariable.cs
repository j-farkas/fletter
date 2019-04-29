using System;

namespace FriendLetter.Models
{
    public class LetterVariable
    {
        private string _recipient;
        private string _sender;


        public string GetRecipient()
        {
            return _recipient;
        }

        public void SetRecipient(string newRecipient)
        {
            _recipient = newRecipient;
        }

        public string GetSender()
        {
            return _sender;
        }

        public void SetSender(string newSender)
        {
            _sender = newSender;
        }

        public string GetRandomLocation()
        {
          string location = "";
          Random rnd = new Random();
          int rand = rnd.Next(1,3);
          if(rand == 1)
          {
            location = "Barcelona";
          }
          if(rand == 2)
          {
            location = "Baghdad";
          }
          if(rand == 3)
          {
            location = "The Vatican";
          }


          return location;
        }

        public string GetRandomSouv()
        {
          string source = "";
          Random rnd = new Random();
          int rand = rnd.Next(1,3);
          if(rand == 1)
          {
            source = "Life size statue";
          }
          if(rand == 2)
          {
            source = "suitcase of sand";
          }
          if(rand == 3)
          {
            source = "unknown snake";
          }


          return source;
        }
    }
}
