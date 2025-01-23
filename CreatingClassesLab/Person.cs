using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClassesLab
{
    public class Person
    {
        // private data
        private int personId;
        private int age;

        // public properties
        public int PersonId
        {
            get { return personId; }
            set { personId = Math.Abs(value); }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColour { get; set; }
        public int Age
        {
            get { return age; }
            set { age = Math.Abs(value); }
        }
        public bool IsWorking { get; set; }
        // constructor
        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColour = favoriteColour;
            Age = age;
            IsWorking = isWorking;
        }
        // public methods
        public string DisplayPersonInfo()
        {
            return $"{personId}: {FirstName} {LastName}'s favorite colour is {FavoriteColour}";
        }
        public string ChangeFavoriteColour()
        {
            return FavoriteColour = "White";
        }
        public int GetAgeInTenYears()
        {
            return Age + 10;
        }
        public override string ToString()
        {
            return $"PersonId: {PersonId}\n" +
                $"FirstName: {FirstName}\n" +
                $"LastName: {LastName}\n" +
                $"FavoriteColour: {FavoriteColour}\n" +
                $"Age: {Age}\n" +
                $"IsWorking: {IsWorking}";
        }
    }
}
