using System.Collections.Generic;
using System;

namespace Pack.Models
{
    public class PackItem
    {
        public int ID { get; }
        public string Name {get; set;}
        public string Size {get; set;}
        public bool Packed {get; set;}

        public static List<PackItem> PackList = new List<PackItem> { };
        public static int idAssigner { get; set;}

        public PackItem(string name, string size)
        {
            Name = name;
            Size = size;
            Packed = false;
            idAssigner++;
            ID = idAssigner;
            PackList.Add(this);
        }

        public void CheckOffItem(int id)
        {
            for (int i=0; i<PackList.Count; i++ )
            {
                if (PackList[i].ID == id)
                {
                    PackList[i].Packed = true;
                }
            }
        }

    }
}