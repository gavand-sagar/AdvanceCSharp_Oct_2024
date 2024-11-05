using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class OnlyDisplayAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredAttribute : Attribute
    {

    }


    public class Person
    {

        [OnlyDisplay]
        public string City { get; set; }

        public string Phone { get; set; }

        [Required]
        public string Firstname { get; set; }

        public string LastName { get; set; }

        public Person(AppOrder order)
        {

        }
        public Person() { }
    }

    public class AppOrder
    {
        public int Id { get; set; }

        [OnlyDisplay]
        public string OrderNumber { get; set; }
    }
    public class ReflactionDemo : IExecutableClass
    {
        public void Execute()
        {

            Person p = new Person();
            p.Firstname = "Sagar";

            AppOrder appOrder = new AppOrder();
            appOrder.Id = 2;
            appOrder.OrderNumber = "O2024N123";

            Type type = typeof(Person);


            var result = ValidateObject(p);

            Console.WriteLine(result);

        }


        public bool ValidateObject<T>(T obj)
        {
            Type type = typeof(T);
            foreach (var prop in type.GetProperties())
            {
                bool isRequired = prop.GetCustomAttributes(typeof(RequiredAttribute), false).Any();
                if (isRequired)
                {
                    var value = prop.GetValue(obj);
                    if(value == null || (string)value == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void Display<T>(T obj)
        {
            Type type = typeof(T);

            foreach (var prop in type.GetProperties())
            {
                bool ShouldBeDisplayed = prop.GetCustomAttributes(typeof(OnlyDisplayAttribute), false).Any();
                if (ShouldBeDisplayed)
                {
                    Console.WriteLine($"{prop.Name} = {prop.GetValue(obj)}");
                }

            }

        }
    }
}
