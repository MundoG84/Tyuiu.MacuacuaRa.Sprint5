using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MacuacuaRa.Sprint5.Task7.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
            // Чтение содержимого файла
            string fileContent = File.ReadAllText(path);

            // Паттерн для поиска слов длиной 2 символа
            string pattern = @"\b\w{2}\b";

            // Замена найденных слов на "XY"
            string modifiedContent = Regex.Replace(fileContent, pattern, "XY");

            // Сохранение измененного содержимого в новый файл
            string outputDirectory = Path.GetTempPath();
            string outputFileName = "OutPutDataFileTask7V26.txt";
            string outputFilePath = Path.Combine(outputDirectory, outputFileName);
            File.WriteAllText(outputFilePath, modifiedContent);

            // Возвращение пути к выходному файлу
            return outputFilePath;
        }

    }
}
