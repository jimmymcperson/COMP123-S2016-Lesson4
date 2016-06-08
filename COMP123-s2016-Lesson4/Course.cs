using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson4
    {
    /** <summary>
    * This is class defines a generic course.  We are using this as a custom data type for
    * our Teacher and Student classes.
    * </summary>
    *
    * @class Course
    */
    class Course
        {

        // PRIVATE INSTANCE VARIABLES =========================================================

        private string _code;
        private string _description;

        // PUBLIC PROPERTIES =========================================================

        /** <summary>
        * This is a property for our _code field.
        * </summary>
        *
        * @property {string} Code
        */
        public string Code
            {
            get
                {
                return this._code;
                }
            set
                {
                this._code = value;
                }
            }

        /** <summary>
        * This is a property for our _description field.
        * </summary>
        *
        * @property {string} Description
        */
        public string Description
            {
            get
                {
                return this._description;
                }
            set
                {
                this._description = value;
                }
            }

        // CONSTRUCTORS =========================================================

        /** <summary>
        * This constructor takes two parameters: code and description
        * </summary>
        *
        * @constructor Person
        * @param {string} code
        * @param {string} description
        */
        public Course(string code, string description)
            {
            this.Code = code;
            this.Description = description;
            }

        // PRIVATE METHODS =========================================================
        // PUBLIC METHODS =========================================================
        }
    }
