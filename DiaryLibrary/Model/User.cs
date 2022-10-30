using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryLibrary.Model
{
    /// <summary>
    /// User's field 
    /// </summary>
    class User
    {
        #region fields
        public string Name { get; }
        public DateTime BirthDate { get; }
        public Gender Gender { get; }
        public double Weight { get; set; }
        #endregion
        /// <summary>
        /// Construction for creating new User
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="birthDate"></param>
        /// <param name="weight"></param>
        public User(string name,Gender gender, DateTime birthDate, double weight)
        {
            #region checking conditions
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name should be not null.", nameof(name));
            }
            if (gender == null )
            {
                throw new ArgumentNullException("Gender is not defination.", nameof(gender));
            }
            if (birthDate < DateTime.Parse("01.01.1900") && birthDate >= DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("Age out of range.", nameof(birthDate));
            }
            if (weight <= 0)
            {
                throw new ArgumentOutOfRangeException("Weight can not be 0 or smaller.", nameof(weight));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;

        }
    }
}
