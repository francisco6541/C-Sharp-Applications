/*
Class:        ISTA220 Programming Fundamentals
Student:      Francisco Velazquez
Instructor:   Christine Lee
Date:         08/07/2020
Descrption:   This application demonstrates using constuctors and using static vs non static methods.
Revised:      
Revision By:  
Revision:     
*/

#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int i = 0;
            Console.WriteLine(i);
            Pass.value(ref i);
            Console.WriteLine(i);
            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
