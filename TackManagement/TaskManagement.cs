using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TackManagement
{
    public class TaskManagement : ITaskManagement
    {
        public event Action ShowCompletedTask;

        public event Action ShowTaskUpdate;

        List<List<string>> TasksList = new List<List<string>>();
        List<List<string>> CompletedTasksList = new List<List<string>>();


        public TaskManagement()
        {
            
        }

        public void AddTask(string taskname, string tasktime)
        {
            if (string.IsNullOrEmpty(tasktime)|| string.IsNullOrEmpty(taskname))
            {
                Console.WriteLine("Значение не может быть пустым");
            }

            TasksList.Add(new List<string> { taskname, tasktime});
                       
            }

        public void CompletedTasks()
        {
            
        }

        public void CompleteTask(int numoftask, string time)
        {
            if (string.IsNullOrWhiteSpace(time)|| numoftask - 1 > TasksList.Count)//Надо добавлять проверку выбора ячейки в самое программе
            {
                Console.WriteLine("Неправильный ввод");
            }
            else
            {
                CompletedTasksList.Add( TasksList[numoftask-1]);
                TasksList.RemoveAt(numoftask-1);

            }

        }
        public void DeleteTask(int numoftask, string tasktime)
        {
            throw new NotImplementedException();
        }

        public void ShowAllTasks()
        {
            for (int i = 0; i < TasksList.Count; i++)
            {
                Console.WriteLine($"N{i+1} {TasksList[i][0]},       время:{TasksList[i][1]} ,       Статус: Невыполнено");
            }
            for (int i = 0; i < CompletedTasksList.Count; i++)
            {
                Console.WriteLine($"N{i+1} {CompletedTasksList[i][0]},        время завершения задания:{CompletedTasksList[i][1]},        Статус: Выполнено ");
            }
        }

        public void ShowOnlyOneTask(int numoftask)
        {
            throw new NotImplementedException();
        }

        public void EditTask(int numoftask)
        {
            throw new NotImplementedException();
        }

        
    }
}
