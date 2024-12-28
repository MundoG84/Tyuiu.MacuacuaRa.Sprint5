using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MacuacuaRa.Sprint5.Task1.V12.Lib
{
    public class DataService : ISprint5Task1V12
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            StringBuilder output = new StringBuilder();
            string resultString = "";
            for (int i = startValue; i <= stopValue; i++)
            {
                double numerator = 5 * i + 2.5;
                double denominator = Math.Sin(i) - 2;

                if (denominator == 0)
                {
                    output.Append("0");
                }
                else
                {
                    output.Append($"{Math.Round((numerator / denominator) + 2, 2)}");
                }

                if (i < stopValue)
                {
                    output.Append("\n");
                }
                resultString = output.ToString();

            }
            return resultString;
        }
    }
}
