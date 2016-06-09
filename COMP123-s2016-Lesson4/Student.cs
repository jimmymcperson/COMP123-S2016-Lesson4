using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson4
    {

    /** <summary>
    * This is class defines a generic Person
    * </summary>
    *
    * @class Student
    * @extends Person
    * @field {string} _studentID
    */
    class Student : Person
        {

        // PRIVATE INSTANCE VARIABLES ===================================================================

        private string _studentID;
        private List<Course> _courses = new List<Course>();

        // PUBLIC PROPERTIES ===================================================================

        /**<summary>
        * This property includes a getter and setter for the private instance variable _studentID
        * </summary>
        *
        * @property {string} StudentID
        */
        public string StudentID
            {
            get
                {
                return this._studentID;
                }
            set
                {
                this._studentID = value;
                }
            }

        /**<summary>
        * 
        * </summary>
        *
        * @property
        */
        public List<Course> Courses
            {
            get
                {
                return this._courses;
                }
            set
                {
                this._courses = value;
                }
            }

        // CONSTRUCTORS ===================================================================

        /**<summary>
        * This constructor takes name, age, and studentID.
        * </summary>
        *
        * @constructor Student
        * @param {string} name
        * @param {int} age
        * @param {string} studentID
        */
        public Student(string name, int age, string studentID)
            : base(name, age)
            {
            this.StudentID = studentID;

            }

        // PRIVATE METHODS ==================================================================

        // PUBLIC METHODS ==================================================================

        /**<summary>
        * This method enables the Studies behavior for the Student class.
        * </summary>
        *
        * @method Studies
        * @returns {void}
        */
        public void Studies()
            {
            Console.WriteLine(this.Name + " studies");
            }

        /**
         * <summary>
         * This method lists all the courses the student is currently enrollled in.
         * </summary>
         * 
         * @method ShowCourses
         * @returns {void}
         */
        public void ShowCourses()
            {
            Console.WriteLine();
            Console.WriteLine("Course List");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            foreach (Course course in this.Courses)
                {
                Console.WriteLine("+ " + course.Code + " " + course.Description);
                }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            }
        }
    }
