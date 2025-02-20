using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Dynamics365_UCI_automation_template.Helpers
{
    /// <summary>
    /// This class is used to save and retrive the data used in test scenarios
    /// </summary>
    public class DataHandler
    {
        /// <summary>
        /// Save data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="item"></param>
        public void SaveData<T>(string name, T item)
        {
            ScenarioContext.Current[name] = item;
        }

        /// <summary>
        /// Retrive the saved data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public T RetriveData<T>(string name) where T : class
        {
            return ScenarioContext.Current[name] as T;
        }
    }
}
