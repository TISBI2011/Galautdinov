//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Factory.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Furniture
    {
        public int FurnID { get; set; }
        public string Название { get; set; }
        public string Материал { get; set; }
        public Nullable<int> TypeID { get; set; }
        public string Стиль { get; set; }
        public Nullable<int> Кол_во_на_складе { get; set; }
    
        public virtual FType FType { get; set; }
    }
}