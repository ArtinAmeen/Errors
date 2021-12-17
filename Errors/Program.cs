using System;
using System.Collections.Generic;

namespace Errors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<UserError> UserErrors = new List<UserError>();
            UserErrors.Add(new NumericInputError());
            UserErrors.Add(new NumericInputError());
            UserErrors.Add(new TextInputError());

            foreach (var error in UserErrors)
            {
                Console.WriteLine(error.UEMessage());
            }

            Console.WriteLine();

            UserErrors.Add(new ArrayElementError());
            UserErrors.Add(new ObjectArgumentError());
            UserErrors.Add(new MethodCallError());
            UserErrors.Add(new ArrayElementError());
            UserErrors.Add(new MethodCallError());

            // we will try to go through the UserErrors list again, this time with extra instances
            foreach (var error in UserErrors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
