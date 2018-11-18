using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Text;

namespace TODO_App
{
    class Task
    {
        public System.String Name { get; set; }
        public System.String FilePath { get; set; }
        private List<string> taskList = new List<string>();
        public int NumberOfTask { get; set; }
        
        public void ListTask()
        {
            if (NumberOfTask > 0)
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string tempStore = "";

                    while (tempStore != null)
                    {
                        tempStore = reader.ReadLine();
                        taskList.Add(tempStore);
                    }

                    int index = 1;

                    foreach (var task in taskList)
                    {
                        Console.WriteLine("{0} - {1}", index, task);
                        index++;
                    }
                }
            }
            else
            {
                Console.WriteLine("No todos for today! :)");
            }
        }


    }
}
