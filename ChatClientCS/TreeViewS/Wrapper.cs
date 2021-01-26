using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using TreeViewS;

namespace ChatClientCS.TreeViewS
{
    public class Wrapper
    {
        public object Item { get; set; }

        public string Name
        {
            get
            {
                Type t = Item.GetType();
                PropertyInfo pi = t.GetProperty("Name");
                return pi.GetValue(Item, null).ToString();
            }
        }

        public List<Wrapper> Children
        {
            get
            {
                List<Wrapper> list = new List<Wrapper>();
                if (Item is Project)
                {
                    list.Add(
                        new Wrapper() { Item = (Item as Project).types }
                        );
                    list.Add(
                        new Wrapper() { Item = (Item as Project).instances }
                        );
                }
                if (Item is Types)
                {
                    foreach (var item in (Item as Types).projectType)
                    {
                        list.Add(
                        new Wrapper() { Item = item }
                        );
                    }
                }
                if (Item is Instances)
                {
                    foreach (var item in (Item as Instances).projectInstance)
                    {
                        list.Add(
                        new Wrapper() { Item = item }
                        );
                    }
                }
                return list;
            }
        }
    }
}
