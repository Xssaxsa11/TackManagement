namespace TackManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool justforprogramm = true;
            while (justforprogramm)
            {
                TaskManagement taskManagement = new TaskManagement();

                Console.WriteLine("Добавим задачу");
                Console.WriteLine("Введите имя задачи");

                string name = Console.ReadLine();

                taskManagement.AddTask(name, DateTime.Now.ToString());

                Console.WriteLine("Введите имя задачи");

                string name2 = Console.ReadLine();

                taskManagement.AddTask(name2, DateTime.Now.ToString());

                Console.WriteLine("Изменяем задачу 2");
                taskManagement.CompleteTask(2, DateTime.Now.ToString());//Номер задания как обычный человек ввводит
                taskManagement.ShowAllTasks();

            }

            
        }
    }
}