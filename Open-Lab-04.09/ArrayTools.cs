using NUnit.Framework;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            var pomocnik = new List<string>();
            for (int i = 0; i<strings.Length; i++)
            {
                if (pomocnik.Contains(strings[i]))
                {

                }
                else
                {
                    pomocnik.Add(strings[i]);
                }
            }               
            return pomocnik.ToArray();
        }
    }
}
