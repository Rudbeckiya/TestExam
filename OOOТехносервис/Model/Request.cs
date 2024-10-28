//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOOТехносервис.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int RequestID { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public Nullable<int> RequestEquipmentID { get; set; }
        public Nullable<int> RequestProblemID { get; set; }
        public Nullable<int> RequestUserID { get; set; }
        public string RequestDescription { get; set; }
        public Nullable<int> RequestStatusID { get; set; }
        public Nullable<int> RequestTime { get; set; }
        public Nullable<int> RequestMasterID { get; set; }
        public Nullable<int> RequestPriorityID { get; set; }
        public Nullable<int> RequestStageID { get; set; }
        public string RequestComment { get; set; }
    
        public virtual Equipment Equipment { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Problem Problem { get; set; }
        public virtual Stage Stage { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
    }
}
