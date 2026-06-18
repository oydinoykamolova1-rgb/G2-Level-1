namespace N17_HT2;

    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        // Yoshni hisoblash
        public int GetAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;

            if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
            {
                age--;
            }

            return age;
        }

        // Bugun tug'ilgan kunmi?
        public bool IsBirthdayToday()
        {
            return DateTime.Now.Month == BirthDate.Month &&
                   DateTime.Now.Day == BirthDate.Day;
        }
    }

