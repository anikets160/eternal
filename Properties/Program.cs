using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class PropertiesConcept
    {
        private int _id;
        private string _name;   
        
        public int ID
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }

        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }

        }
        
        public object PrintIDAndName()
        {
            return _id + "  " + _name;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            PropertiesConcept propertiesConcept = new PropertiesConcept();
            propertiesConcept.ID=1;
            propertiesConcept.Name = "Aniket";
            Console.WriteLine(propertiesConcept.PrintIDAndName());
            Console.ReadKey();
        }
    }
}
