using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MacuacuaRa.Sprint5.Task2.V12.Lib
{
    public class DataService : ISprint5Task2V12
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string output = "";

            // Процесс обработки массива
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // Заменить положительные элементы на 1, отрицательные на 0
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }

                    output += matrix[i, j];

                    // Добавить разделитель между элементами в строке
                    if (j < matrix.GetLength(1) - 1)
                    {
                        output += ";";
                    }
                }

                // Добавить символ новой строки между строками массива
                if (i < matrix.GetLength(0) - 1)
                {
                    output += "\n";
                }
            }

            // Сохранение результата в файл
            File.WriteAllText("OutPutFileTask2.csv", output);

            // Вывод результата на консоль
            Console.WriteLine(output);

            return output;
        }
    }
}
