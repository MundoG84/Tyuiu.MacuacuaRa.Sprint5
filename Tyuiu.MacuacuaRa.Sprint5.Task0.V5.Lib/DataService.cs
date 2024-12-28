using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MacuacuaRa.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            double result = Math.Round(Math.Log((x+1)/(x+2)), 3);

            return result.ToString();
        }
    }
}
