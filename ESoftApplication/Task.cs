//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESoftApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Difficulty { get; set; }
        public int StatusId { get; set; }
        public int KindId { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> FinishTime { get; set; }
        public Nullable<System.DateTime> CompleteDate { get; set; }
        public Nullable<int> CompletePeriod { get; set; }
        public Nullable<int> CompleteTime { get; set; }
        public string Info { get; set; }
        public Nullable<int> ExecutorId { get; set; }
    
        public virtual Executor Executor { get; set; }
        public virtual Kind Kind { get; set; }
        public virtual Status Status { get; set; }
    }
}
