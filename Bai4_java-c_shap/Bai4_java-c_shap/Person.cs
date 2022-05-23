using System;

namespace Bai4_java_c_shap
{
    class Person
    {
        private String name;
        private int age;
        private String job;
        private String passport;

        public Person(String name, int age, String job, String passport)
        {
            this.Name = name;
            this.Age = age;
            this.Job = job;
            this.Passport = passport;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Job { get => job; set => job = value; }
        public string Passport { get => passport; set => passport = value; }

        public String toString()
        {
            return "Person{" +
                    "name='" + name + '\'' +
                    ", age=" + age +
                    ", job='" + job + '\'' +
                    ", passport='" + passport + '\'' +
                    '}';
        }
    }
}
