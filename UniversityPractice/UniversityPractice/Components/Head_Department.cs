//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityPractice.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class Head_Department
    {
        public int Id_head_department { get; set; }
        public Nullable<int> Id_employee { get; set; }
        public int Experience { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
