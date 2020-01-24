using System;
using System.Collections.Generic;

namespace classPractice {
    class Program {
        static public void Main () {

            List<Musician> band1Members = new List<Musician> ();
            band1Members.Add (new Musician ("Jimmy Page", "Guitar"));
            band1Members.Add (new Musician ("Robert Plant", "Vocals"));
            band1Members.Add (new Musician ("John Bonham", "Drums"));
            band1Members.Add (new Musician ("John Paul Jones", "Bass/Keyboard"));
            Band band1 = new Band (band1Members, "Led Zeppelin", 1969, "Classic Rock");

            Console.WriteLine(band1.getAllInfo());


        }
    }

    class Band {
        public Band (List<Musician> m, string n, int yS, string g) {
            _members = m;
            _name = n;
            _yearStarted = yS;
            _genre = g;
        }

        private List<Musician> _members;
        private string _name;
        private int _yearStarted;
        private string _genre;
        private string _memberString;
        public string getMembers () {
            foreach (Musician member in _members) {
                int memberIndex = _members.IndexOf(member);
                if( memberIndex == _members.Count-1) {
                    _memberString += member.getName () + " - " + member.getInstrument() + ".";
                }
                else {
                _memberString += member.getName () + " - " + member.getInstrument() + ", ";
                }
            }
            return _memberString;
        }

        public string getInfo() 
        {
            string infoString = "";
            infoString += _name + ", " + _genre + ", " + _yearStarted + ".";
            return infoString;
        }
        public string getAllInfo()
        {
            string allInfo = "";
            allInfo += getInfo() + " " + getMembers();
            return allInfo;
        }

    }

    class Musician {
        public Musician (string n, string i) {
            _instrument = i;
            _name = n;
        }
        private string _name;
        private string _instrument;

        public string getName () {
            return _name;
        }
        public string getInstrument () {
            return _instrument;
        }

    }
}