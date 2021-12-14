using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carcass.CodeAnalysis.Parser.Expressions
{
    internal class CallExpression
    {
        string fnName;
        List<Expression> args;

        public CallExpression(string fncName, List<Expression> _args)
        {
            this.fnName = fncName;
            this.args = _args;
        }
    }
}
