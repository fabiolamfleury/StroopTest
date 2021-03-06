﻿using System;
using System.Collections.Generic;
using System.IO;

namespace StroopTest.Models
{
    class StrList
    {
        private List<string> listContent = new List<string>();
        private String listName;

        public StrList(List<string> list, string name)
        {
            this.listContent = list;
            this.listName = name;
        }


        public List<string> ListContent
        {
            get { return listContent; }
            set
            {
                listContent = value;
            }
        }

        public string ListName
        {
            get { return listName; }
            set
            {
                listName = value;
            }
        }
 
        public bool save(string filePath)
        {
            StreamWriter wr = new StreamWriter(filePath);
            foreach (string item in listContent)
            {
                wr.Write(item + "\t");
            }
            wr.Close();
            return true;
        }

        public bool exists(string path)
        {
            if (File.Exists(path))
                return true;
            else
                return false;
        }
    }
}
