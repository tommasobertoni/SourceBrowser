﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceBrowser.Generator.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkspaceModel : IProjectItem
    {
        public ICollection<IProjectItem> Children { get; set; }

        public string Name
        {
            get; private set;
        }

        //The WorkspaceModel has no parent. It is the top level item.
        public IProjectItem Parent
        {
            get
            {
                return null;
            }
        }

        public WorkspaceModel(string name)
        {
            Name = name;
            Children = new List<IProjectItem>();
        }

        public string GetPath()
        {
            return null;
        }
    }
}
