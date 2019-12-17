using System;

namespace meny
{
    public struct hair
    {
        public string hairColor;
        public double hairLength;
    }

    class Person
    {

        private string gender;
        public string name;
        public string eyeColor;
        public DateTime birthday;
        public hair hair;
        

        public override string ToString()
        {   
            
            string returnstring = "";
            returnstring += "Personens namn är: " + name + ". ";
            returnstring += "Kön: " + gender + ". ";
            returnstring += "Ögonfärg: " + eyeColor + ". ";
            returnstring += "Hårfärg: " + hair.hairColor + ". ";
            returnstring += "Längden på håret: " + hair.hairLength + "cm. ";
            returnstring += "Födelsedag: " + birthday.ToString("MM/dd/yyyy");
            return returnstring;
        }
        public void SetHairLength(double hair)
        {
            this.hair.hairLength = hair; 
        }
        public void SetHairColor(string color)
        {
            this.hair.hairColor = color;
        }
        public string GetHairColor()
        {
            return hair.hairColor;
        }
        public double GetHairLength()
        {
            return hair.hairLength;
        }
        public void SetGender(string gender)
        {
            this.gender = gender;
        }
        public string Getgender()
        {
            return gender;
        }
    }
}


