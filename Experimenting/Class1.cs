using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimenting
{
    public class Person
    {
        public virtual string SayName()
        {
            return "I don't have one";
        }

        protected void OnlyInherited() { }
    }

    internal sealed class Nathan : Person
    {
        protected string SayName()
        {
            OnlyInherited();
            return "Nathan";
        }

        public string SayName(bool CommonName)
        {
            return "Nathan";
        }

        public void ParseInt(string Input) { }
        public void ParseInt(byte Input) { }
        public void parseInt(string Input1, byte Input2) { }
    }
}
