using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Net_Quiz1
{
    class Student
    {
        //8- (Bonus) Use Event/Func/Action/delegate with 2 classes (student, RegisterStudentOperation). If
        //the student graduates, notifies the RegisterStudentOperation and Prints a message in the
        //console.

        public event Action Event;
    }
}
