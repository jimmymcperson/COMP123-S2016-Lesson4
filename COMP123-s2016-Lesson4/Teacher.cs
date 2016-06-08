using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson4
    {

    /** <summary>
    * This is class defines a generic teacher.  It is derived from the Person class.
    * </summary>
    *
    * @class Teacher
    * @extends Person
    * @field {string} _employeeID
    */
    class Teacher : Person
        {

        // PRIVATE INSTANCE VARIABLES ===================================================================

        private string _employeeID;

        // PUBLIC PROPERTIES ===================================================================

        /**<summary>
        * This property includes a getter and setter for the private instance variable _employeeID.
        * </summary>
        *
        * @property {string} EmployeeID
        */
        public string EmployeeID
            {
            get
                {
                return this._employeeID;
                }
            set
                {
                this._employeeID = value;
                }
            }

        // CONSTRUCTORS ===================================================================

        /**<summary>
        * This constructor takes name, age, and employeeID.
        * </summary>
        *
        * @constructor Teacher
        * @param {string} name
        * @param {int} age
        * @param {string} employeeID
        */
        public Teacher(string name, int age, string employeeID)
            : base(name, age)
            {
            this.EmployeeID = _employeeID;
            }

        // PRIVATE METHODS ==================================================================



        // PUBLIC METHODS ==================================================================

        /**<summary>
        * This method enables the teaches behavior for the Teacher class.
        * </summary>
        *
        * @method Teaches
        * @returns {void}
        */
        public void Teaches()
            {
            Console.WriteLine(this.Name + " teaches");
            }

        }
    }
