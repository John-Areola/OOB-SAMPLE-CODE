using System;

namespace OOP_SAMPLE_CODE
{
    public abstract class Employment{
        private bool  _isNigerian;
        private bool _isSecondupperAndAbove;
        private bool _isAgeAboveEighteen;
        private bool _isGradeAboveSeventy;
        public bool IsNigerian { 
            get { return _isNigerian; } 
            
            set { _isNigerian = value; } 
        }
        public bool IsSecondUpperAndAbove { 
            get { return _isSecondupperAndAbove; } 
            set { _isSecondupperAndAbove = value; }
        }
        public bool IsAgeaboveEighteen { 
            get { return _isAgeAboveEighteen; } 
            set { _isAgeAboveEighteen = value; } 
        }
        public bool IsGradeAboveSeventy
        {
            get { return _isGradeAboveSeventy; }
            set { _isGradeAboveSeventy = value; }
        }
        public bool Age(string age)
        {
            if (age == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Grade(string grade)
        {
            if (grade == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Score(string score)
        {
            if (score == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Nationality(string nationality)
        {
            if (nationality == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract void Employ();

    }

    public class Candidate:Employment
    {//Candidate is inheriting the features of employment

        public override void Employ()
        {
            if (IsSecondUpperAndAbove && IsNigerian  && IsAgeaboveEighteen && IsGradeAboveSeventy)
            {
                Console.WriteLine("Congratulations on the succesful completed of your programme");
            }
            else
            {
                Console.WriteLine("Sorry, we regret to inform you that we will not be proceeding with your application.");
            }
        }

    }
}
