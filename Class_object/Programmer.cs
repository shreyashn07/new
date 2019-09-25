using System;
namespace Class_object
{
    public class Programmer:Person
    {
        public int hoursOfSleep;
        public String favLanguage;
        public Programmer()
        {
        }
        public Programmer(int hours,String lan,String firstName,String lastName) : base(firstName,lastName)
        {
            this.hoursOfSleep = hours;
            this.favLanguage = lan;
        }
        public String getName()
        {
            return base.lastName;
        }
        public String getFavLanguage()
        {
            return favLanguage;
        }
    }
}
