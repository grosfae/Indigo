//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Indigo.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeedBack
    {
        public int Id { get; set; }
        public string Advantage { get; set; }
        public string Disadvantages { get; set; }
        public string Comment { get; set; }
        public int GeneralStars { get; set; }
        public int UserId { get; set; }
        public int ComputerCaseId { get; set; }
        public System.DateTime DateOfReview { get; set; }
        public Nullable<System.DateTime> DateOfAddition { get; set; }
        public string Addition { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        public virtual ComputerCase ComputerCase { get; set; }
        public virtual User User { get; set; }
    }
}
