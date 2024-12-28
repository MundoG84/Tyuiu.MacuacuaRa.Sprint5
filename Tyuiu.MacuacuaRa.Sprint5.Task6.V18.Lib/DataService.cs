using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MacuacuaRa.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            // Чтение содержимого файла
            string fileContent = File.ReadAllText(path);

            // Подсчет одноразрядных чисел
            int count = 0;
            foreach (char c in fileContent)
            {
                if (char.IsDigit(c) && int.Parse(c.ToString()) >= 0 && int.Parse(c.ToString()) <= 9)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
