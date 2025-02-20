using Bogus;
using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_UCI_automation_template.Helpers
{
    /// <summary>
    /// Generates a random string of given length
    /// </summary>
    public class RandomGenerator
    {
        #region Properties

        private readonly Random random = new Random();

        #endregion Properties

        #region Methods

        /// <summary>
        /// Generate a random string of given length
        /// </summary>
        /// <param name="length">lenght of the string</param>
        /// <returns></returns>
        public string GetRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Generage a random
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string GetRandomPhoneNumber()
        {               
            var faker = new Faker("en");
            return faker.Phone.PhoneNumber("###-###-####");
        }

        #endregion Methods
    }
}
