
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace PomodoroTimerDominio.Models
{

using System;
    using System.Collections.Generic;
    
public partial class TipoSessao
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TipoSessao()
    {

        this.Sessao = new HashSet<Sessao>();

    }


    public int Id { get; set; }

    public string Tipo { get; set; }

    public int Duracao { get; set; }

    public int TempoEstudo { get; set; }

    public int TempoDescanso { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Sessao> Sessao { get; set; }

}

}
