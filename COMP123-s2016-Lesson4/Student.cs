﻿using System;
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

        }
    }