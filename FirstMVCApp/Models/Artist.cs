//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstMVCApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artist
    {
        public int ArtistID { get; set; }
        public int AlbumID { get; set; }
        public int ArtistName { get; set; }
    
        public virtual Album Album { get; set; }
    }
}
