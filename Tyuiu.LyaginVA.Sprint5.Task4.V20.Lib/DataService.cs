using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LyaginVA.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round((Math.Pow((((Math.Pow((Convert.ToDouble(strX)), 2)) / (Math.Sin(Convert.ToDouble(strX))))), 3)),3);
            return res;
        }
    }
}
