using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Student
    {
        public Student(string fullName, string groupNo,int age)
        {
            this.FullName = fullName;
            this.GroupNo = groupNo;
            this.Age = age;
        }
        public int Age { get; set; }
        private string _fullName;
        public string FullName
        {
            get
            {
                return this._fullName;
            }

            set
            {
                if (CheckFullName(value))
                {
                    this._fullName = value;
                }
                    
            }
        }
        private string _groupNo;
        public string GroupNo
        {
            get
            {

                return this._groupNo; 
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    this._groupNo = value;
                }
            }
        }
        public static bool CheckGroupNo(string groupNo)
        {
            if(groupNo.Length==4 && char.IsUpper(groupNo[0]))
            {
                for (int i = 0; i < groupNo.Length; i++)
                {
                    if (!char.IsDigit(groupNo[i]))
                        return true;
                }
                return false;
            }
            return false;
        }
        public static bool CheckFullName(string fullName)
        {
            fullName=fullName.Trim();
            string[] words= fullName.Split('.');
            if (words.Length == 2)
            {
                foreach (string word in words)
                {
                    if (!char.IsUpper(word[0]))
                    {
                        return false;
                    }
                   

                }
                return true;

            }
            else
            {
                return false;
            }
        }
       
       


    }
}
