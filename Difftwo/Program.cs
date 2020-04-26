using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difftwo
{
    class Program
    {
        static void Main(string[] args)
        {
            const string findUpperLowerLetter = "N109908207i82      ´´12c3456k789l0    +!::a::>>#€%&s)=?`:>A>==n=)n))a) Pe?????ter";
            var results = IsUpperOrLowerCaseOrAlpha(findUpperLowerLetter);
            foreach (var item in results)
                Console.WriteLine(item);
            Console.ReadLine();
        }

        static List<string> IsUpperOrLowerCaseOrAlpha(string value)
        {
            var stringToCharArrray = value.ToCharArray();
            var list = new List<string>();

            for (int idx = 0; idx < stringToCharArrray.Length; idx++)
            {
                if (char.IsLetter(stringToCharArrray[idx]))
                {
                    list.Add($" Letter => ({stringToCharArrray[idx]})");
                    if (char.IsUpper(stringToCharArrray[idx]))
                        list.Add($" UPPERCASE => ({stringToCharArrray[idx]})");
                    else
                        list.Add($" lowercase => {stringToCharArrray[idx]}");
                }
            }
            return list;
        }
    }
}
