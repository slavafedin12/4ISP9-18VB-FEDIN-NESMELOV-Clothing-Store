//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _4ISP9_18VB_FEDIN_NESMELOV_Clothing_Store.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    
        public virtual AdminDescription AdminDescription { get; set; }
    }
}
