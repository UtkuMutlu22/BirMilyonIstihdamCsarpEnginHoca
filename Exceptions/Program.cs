using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception);
                
            }
            
        }

        private static void Find()
        {
            List<string> students = new List<string>();
            students.Add("utku");
            students.Add("Arzu");
            students.Add("Fuat");
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
            HandleException(()=> { Find(); });
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

                throw;
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3]
            {
                "Utku","Arzu","Fuat"
            };
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.InnerException);
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
