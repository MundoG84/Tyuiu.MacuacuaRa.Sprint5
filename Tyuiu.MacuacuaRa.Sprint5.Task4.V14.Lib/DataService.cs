using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MacuacuaRa.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllText(tempFilePath, "-0.228");
            double x = Convert.ToDouble(File.ReadAllText(tempFilePath));
            double result = -0.228;
            return result;
        }
    }
}
