﻿using DiaryLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DiaryLibrary.Controller
{
    class UserController
    {
        public User User { get; }
        public UserController(string userName,string genderName, DateTime birthday, double weight)
        {
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthday, weight);
           
        }
        /// <summary>
        /// Date of user saving 
        /// </summary>
        public void Save()
        {
            //not sure about that, will come back
            var formatter = new BinaryFormatter();
            using(var fs = new FileStream("User.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        ///  Date of user loading
        /// </summary>
        /// <returns>User app</returns>
        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("User.dat", FileMode.OpenOrCreate))
            {
                if( formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                
            }
        }
    }
}
