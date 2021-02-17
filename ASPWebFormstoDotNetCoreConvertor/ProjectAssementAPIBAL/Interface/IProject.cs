using ProjectAssessmentCommonEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAssementAPIBAL.Interface
{
    public interface IProject
    {
        List<ProjectModel> GetProjects(string solutonFile);

        List<dynamic> GetProjectDetails(string projectFile);
    }
}
