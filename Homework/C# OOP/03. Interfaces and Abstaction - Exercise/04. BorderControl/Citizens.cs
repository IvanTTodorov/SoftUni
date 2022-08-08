using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizens : IIdentifiable
    {
        public Citizens(string name, int age, string id)
        {
            Name = name;
            this.age = age;
            Id = id;
        } 


        public string Name { get; set; }
        public int age { get; set; }
        public string Id { get;}
    }
}
        

