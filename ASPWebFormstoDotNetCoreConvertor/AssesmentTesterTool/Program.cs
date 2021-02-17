using Microsoft.Build.Evaluation;
using ProjectAssementAPIBAL;
using ProjectAssementAPIBAL.Interface;
using System;

namespace AssesmentTesterTool
{
    class Program
    {
        static void Main(string[] args)
        {
            //if(args == null || args.Length == 0)
            //{
            //    Console.WriteLine("Enter Project Solution Path");
            //}

            var folder = @"D:\Dot Net\ToolConvertASPtoMVC\ToolConvertASPtoMVC.sln";

            IProject project = new ProjectAssementAPIBAL.Implementation.Project();

           var i = project.GetProjects(folder);

            Console.ReadLine();

        }
    }
}
