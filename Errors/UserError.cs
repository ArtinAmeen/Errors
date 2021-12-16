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
            return ("You tried to use a numeric inputin a text only field. This fired an error!");
        }
    }

    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return ("You tried to use a text input in a numericonly field. This fired an error!");
        }
}

}
