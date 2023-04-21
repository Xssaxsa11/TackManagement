using System;

namespace TackManagement
{
    internal interface ITaskManagement
    {
        string AddTask(string taskName, string tasktime);
        
        void DeleteTask(int numoftask, string tasktime);//Будет хранится лист с удаленными задачами

        void CompletedTasks(int numoftask, int taskcompletetime);

        void ShowAllTasks();

        void ShowOnlyOneTask(int numoftask);

        event Action ShowCompletedTask;

        event Action ShowTaskUpdate;

    }
}
