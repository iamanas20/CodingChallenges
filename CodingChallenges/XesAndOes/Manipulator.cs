using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XesAndOes
{
    class Manipulator
    {
        /// <summary>
        /// Determines if the string has both x's and o's
        /// </summary>
        /// <param name="input">string to control</param>
        /// <returns>true if it got em, false if not (none or one of em)</returns>
        private static bool HasXandO(string input)
        {
            bool gotem = false;
            if (input.ToLower().Contains('x'))
            {
                if (input.ToLower().Contains('o'))
                {
                    gotem = true;
                }
            }
            return gotem;
        }
    }
}
