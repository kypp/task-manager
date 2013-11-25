using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TaskManager
{
    [Serializable()]
    public class ProgramState : ISerializable
    {
        public List<Task> Tasks;
        public List<TaskCategory> Categories;

        public static void LoadFromFile(string filename)
        {
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();

            instance = (ProgramState)bformatter.Deserialize(stream);
            stream.Close();
        }

        public static void SaveToFile(string filename)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            bformatter.Serialize(stream, Instance);
            stream.Close();
        }

        private ProgramState() {
            Tasks = new List<Task>();
            Categories = new List<TaskCategory>();
        }

        private static ProgramState instance;
        public static ProgramState Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProgramState();
                }
                return instance;
            }
        }


        public ProgramState(SerializationInfo info, StreamingContext context)
        {
            Tasks = (List<Task>)info.GetValue("TasksList", typeof(List<Task>));
            Categories = (List<TaskCategory>)info.GetValue("CategoriesList", typeof(List<TaskCategory>));

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("TasksList", Tasks);
            info.AddValue("CategoriesList", Categories);
        }
    }
}
