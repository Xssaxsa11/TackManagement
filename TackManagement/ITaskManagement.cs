using System;

namespace TackManagement
{
    public interface ITaskManagement
    {
        void AddTask(string taskName, string tasktime);
        
        void DeleteTask(int numoftask, string tasktime);//Будет хранится лист с удаленными задачами

        void CompletedTasks();//Вывод заданий

        void ShowAllTasks();

        void CompleteTask(int numoftask,string time);

        void ShowOnlyOneTask(int numoftask);

        void EditTask(int numoftask);

        event Action ShowCompletedTask;

        event Action ShowTaskUpdate;

    }
}
