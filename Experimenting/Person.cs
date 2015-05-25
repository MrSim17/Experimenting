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

        /// <summary>
        /// Only available to inherited classes.
        /// </summary>
        protected void OnlyInherited() { }
    }

    internal sealed class Nathan : Person
    {
        /// <summary>
        /// Method hiding
        /// </summary>
        /// <returns></returns>
        new public string SayName()
        {
            OnlyInherited();
            return "Nathan";
        }

        /// <summary>
        /// Method overloading
        /// </summary>
        /// <param name="CommonName"></param>
        /// <returns></returns>
        public string SayName(bool CommonName)
        {
            return "Nathan";
        }

        public void ParseInt(string Input) { }
        public void ParseInt(byte Input) { }
        public void parseInt(string Input1, byte Input2) { }
    }
}
