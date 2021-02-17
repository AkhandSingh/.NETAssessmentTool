using ProjectAssementAPIBAL.Interface;
using ProjectAssessmentCommonEntities;
using System;
using System.Collections.Generic;

using Microsoft.Build.Construction;

namespace ProjectAssementAPIBAL.Implementation
{
   public class Project: IProject
    {
        public List<ProjectModel> GetProjects(string solutonFile)
        {
            List<ProjectModel> projectModels = new List<ProjectModel>();
            var solution = SolutionFile.Parse(solutonFile);
            foreach(var project in solution.ProjectsInOrder)
            {
                var proj = new ProjectModel();
                proj.ProjectName = project.ProjectName;
                proj.ProjectType = project.ProjectType.ToString();
                proj.ProjectPath = project.RelativePath;
                projectModels.Add(proj);
            }
            return projectModels;
        }

        public List<dynamic> GetProjectDetails(string projectFile)
        {
            return new List<dynamic>();
        }
    }
}
