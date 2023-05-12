using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProyectoTallerPOO.Models.dbModels;

[Table("detalle_ev", Schema = "farmacia")]
[Index("TurnEmpl", Name = "IX_detalle_ev_turn_empl")]
public partial class DetalleEv
{
    [Key]
    [Column("id_vent")]
    public int IdVent { get; set; }

    [Column("fech_vent", TypeName = "date")]
    public DateTime FechVent { get; set; }

    [Column("id_empl")]
    public int IdEmpl { get; set; }

    [Column("turn_empl")]
    public int TurnEmpl { get; set; }

    [ForeignKey("IdVent")]
    [InverseProperty("DetalleEv")]
    public virtual Ventum IdVentNavigation { get; set; } = null!;

    [ForeignKey("TurnEmpl")]
    [InverseProperty("DetalleEvs")]
    public virtual Turno TurnEmplNavigation { get; set; } = null!;
}
