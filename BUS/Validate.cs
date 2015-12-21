using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BUS
{
    public class Validate
    {
        /// <summary>
        /// trả về true nếu ptext là số. ngược lại trả về false
        /// </summary>
        /// <param name="pText">chuỗi cần validate</param>
        /// <returns></returns>
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"[0-9]");
            return regex.IsMatch(pText);
        }
        /// <summary>
        /// trả về true nếu ptext là email. ngược lại trả về false
        /// </summary>
        /// <param name="pText">chuỗi cần validate</param>
        /// <returns></returns>
        public bool IsEmail(string pText)
        {
            Regex regex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            return regex.IsMatch(pText);
        }
    }
}
