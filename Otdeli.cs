//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KURSOVAYA____
{
    using System;
    using System.Collections.Generic;
    
    public partial class Otdeli
    {
        public Otdeli()
        {
            this.Sotrudniki = new HashSet<Sotrudniki>();
        }
    
        public int Id_otdela { get; set; }
        public string Namenovanie_otdela { get; set; }
        public string Rukovoditel_otdela { get; set; }
        public string Contactnie_dannie { get; set; }
    
        public virtual ICollection<Sotrudniki> Sotrudniki { get; set; }
    }
}
