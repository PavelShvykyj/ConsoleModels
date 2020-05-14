using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleModels.Models.References
{
    public interface IReferenceBase<T> : IBase where T : class
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Boolean IsFolder { get; set; }
        public Boolean IsDeleted { get; set; }
        public Boolean IsPredefined { get; set; }
        public Guid? ParentID { get; set; }
        public virtual T Parent { get => Parent; set { Parent = value; } }
        public virtual IEnumerable<T> Children { get { return Children; } set { Children = value; } }


    }

    public class BaseReference<T> : Base , IReferenceBase<T> where T: class
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Boolean IsFolder { get; set; }
        public Boolean IsDeleted { get; set; }
        public Boolean IsPredefined { get; set; }
        public Guid? ParentID { get; set; }
        
        public virtual T Parent { get; set; }
        public virtual IEnumerable<T> Children  { get; set; }
    }
}
