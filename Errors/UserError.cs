using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }

    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return ("You tried to use a numeric input in a text only field. This fired an error!");
        }
    }

    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return ("You tried to use a text input in a numericonly field. This fired an error!");
        }
    }

    public class ArrayElementError : UserError
    {
        public override string UEMessage()
        {
            return ("You tried to place a variable that is not matching the data type of the string. This fired an error!");
        }
    }

    public class ObjectArgumentError : UserError
    {
        public override string UEMessage()
        {
            return ("You used the wrong data type for one or more arguments when creating an object. This fired an error!");
        }
    }

    public class MethodCallError : UserError
    {
        public override string UEMessage()
        {
            return ("You did not match the arguments with the method parameters when calling a method. This fired an error!");
        }
    }
}
