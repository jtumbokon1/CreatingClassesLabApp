using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClassesLab
{
    // enumeration type for possible relationship
    public enum RelationshipType { Sister, Brother, Mother, Father }
    public class Relation
    {
        // private data
        private RelationshipType r;
        // public properties
        public RelationshipType R { get; set; }
        // constructor
        public Relation(RelationshipType r)
        {
            R = r;
        }
        // public methods
        public string ShowRelationship(Person person1, Person person2)
        {
            return $"Relationship between {person1.FirstName} and {person2.FirstName} is: {r}hood";
        }
    } // class
} // namespace
