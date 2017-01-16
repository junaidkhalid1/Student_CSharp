using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2_Student
{
    public class Student: IComparable, IComparer
    {
        private string _name;
        private float _score;
        
        //Property for name
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Property for score
        public float score
        {
            get { return _score; }
            set { if(value>0 && value< 20) _score = value; }
        }

        public int Compare(object x, object y)
        {
            return (x as Student).name.CompareTo((y as Student).name);
        }

        //To compare for sorting
        public int CompareTo(object obj)
        {
            return (int)(this.score - (obj as Student).score);
        }

        public override string ToString()
        {
            return "Name = " + name + ", Score = " + score;
        }
    }
}
