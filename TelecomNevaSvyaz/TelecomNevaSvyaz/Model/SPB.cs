//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelecomNevaSvyaz.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SPB
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Ploshad { get; set; }
        public int Naselenie { get; set; }
        public int CountOfAnderground { get; set; }
        public int IDTypeOfBuilding { get; set; }
    
        public virtual TypeOfBuilding TypeOfBuilding { get; set; }
    }
}
