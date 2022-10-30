using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryLibrary.Model
{
    [Serializable]

    class Gender
    {
        public string Name { get; }

        /// <summary>
        /// Create new gender.
        /// </summary>
        /// <param name="name">name of gender</param>
        /// 
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Gender is not defination", nameof(name));
            }
            Name = name;
        }
    }
}
