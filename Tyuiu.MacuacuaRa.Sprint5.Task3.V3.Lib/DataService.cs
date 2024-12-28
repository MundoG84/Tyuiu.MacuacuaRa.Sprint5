using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MacuacuaRa.Sprint5.Task3.V3.Lib
{
    public class DataService : ISprint5Task3V3
    {
        public string SaveToFileTextData(int x)
        {
            double calculation = Math.Round(x * Math.Sqrt(x+3), 3);
            byte[] byteArray = BitConverter.GetBytes(calculation);
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllBytes(tempFilePath, byteArray);
            return tempFilePath;
        }
    }
}
