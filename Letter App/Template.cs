using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Letter_App
{
    public class Template
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public Template() 
        {
            Name = string.Empty;
            Content = string.Empty;
        }
        public Template(string name, string content) {  Name = name; Content = content; }


        public void Exported_Template(Person person)
        {
            MessageBox.Show(this.Content);
        }

    }


}
