using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertText
{
    /// <summary>
    /// Clasă pentru convertirea unui string într-un numeral
    /// </summary>
    public class ConvertText
    {
        /// <summary>
        /// Funcție pentru convertirea unui string într-un decimal 
        /// </summary>
        /// <param name="input">String-ul ce urmează a fii convertit</param>
        /// <returns>Numărul sau zero în caz de string-ul nu poate fi convertit într-un decimal valid</returns>
        public static decimal ConvertToDecimal(string input)
        {
            try
            {
                return decimal.Parse(input);
            }
            catch (FormatException)
            {
                return 0;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }

        /// <summary>
        /// Funcție pentru convertirea unui string într-un integer 
        /// </summary>
        /// <param name="input">String-ul ce urmează a fii convertit</param>
        /// <returns>Numărul sau zero în caz de string-ul nu poate fi convertit într-un integer valid</returns>
        public static int ConvertToInt(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (FormatException)
            {
                return 0;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
