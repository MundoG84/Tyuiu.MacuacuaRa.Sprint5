using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MacuacuaRa.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            // Чтение содержимого файла
            string fileContent = File.ReadAllText(path);

            // Обработка данных: разделение, фильтрация и округление
            var values = fileContent
                .Split(new[] { ' ', '\n', '\r', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(val =>
                {
                    if (double.TryParse(val, out double doubleValue))
                    {
                        return Math.Round(doubleValue, 3); // Округление до 3 знаков
                    }
                    return (double?)null;
                })
                .Where(val => val.HasValue) // Исключаем null
                .Select(val => val.Value)
                .ToArray();

            // Находим максимальное целое число, делящееся на 3
            var maxInteger = values
                .Where(val => val == Math.Truncate(val) && val % 3 == 0) // Только целые числа, делящиеся на 3
                .Select(val => (int)val)
                .DefaultIfEmpty(0)
                .Max();

            // Вычисляем факториал
            long factorial = 1;
            for (int i = 2; i <= maxInteger; i++)
            {
                factorial *= i;
            }

            // Возвращаем факториал как результат
            return factorial;
        }

    }
}
