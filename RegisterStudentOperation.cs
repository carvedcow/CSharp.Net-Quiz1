using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Net_Quiz1
{
    class RegisterStudentOperation
    {
        //8- (Bonus) Use Event/Func/Action/delegate with 2 classes (student, RegisterStudentOperation). If
        //the student graduates, notifies the RegisterStudentOperation and Prints a message in the
        //console.

        Student s = new Student();
        void start()
        {
            s.Event += graduation;
        }

        void graduation()
        {
            Console.WriteLine("Student has graduated");
            s.Event -= graduation;
        }

    }
}
