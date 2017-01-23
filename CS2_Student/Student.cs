using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CS2_Student
{

    public class Student: IComparable<Student>, IComparer<Student>
    {
        private string _name;
        private float _score;

        //Property for name
        // Renaming the tag
        [XmlElement(ElementName = "NameAfterXML")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Property for score
        // Renaming the tag
        [XmlElement(ElementName = "ScoreAfterXML")]
        public float score
        {
            get { return _score; }
            set { if(value>0 && value< 20) _score = value; }
        }

        public int Compare(Student x, Student y)
        {
            return string.Compare((x as Student).name, (y as Student).name, StringComparison.Ordinal);
        }

        //To compare for sorting
        public int CompareTo(Student other)
        {
            return (int)(this.score - (other as Student).score);
        }

        public override string ToString()
        {
            return "Name = " + name + ", Score = " + score;
        }
    }
}
