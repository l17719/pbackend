using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConnectorService.Model.PHCModel
{
    [Table("fltcl")]
    public class PFiltrosClientes
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de stamp nao pode ter mais que 25 caracteres")]
        [Column("fltclstamp", TypeName = "varchar", Order = 0)]
        public string TbFiltroClientesStamp { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de titulo nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de stamp nao pode ter mais que 50 caracteres")]
        [Column("ftitulo", TypeName = "varchar", Order = 1)]
        public string FiltroClientesTitulo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de texto nao pode ser nulo")]
        [Column("texto", TypeName = "text", Order = 2)]
        public string FiltroClientesTexto { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo xbase nao pode ser nulo")]
        [Column("xbase", TypeName = "text", Order = 3)]
        public string FiltroClientesXbase { get; set; }

        [Key]
        [Column("stamp", TypeName = "varchar", Order = 4)]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais do que 25 caracteres")]
        public string FiltroClientesStamp { get; set; }

        [Required]
        [Column("temvar", TypeName = "bit", Order = 5)]
        public bool FiltroClientesTemVar { get; set; }

        [Required]
        [Column("privado", TypeName = "bit", Order = 6)]
        public bool FiltroClientesPrivado { get; set; }

        [Required]
        [Column("altera", TypeName = "bit", Order = 7)]
        public bool FiltroClientesAltera { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo ousrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo ousrinis nao pode ter mais do que 30 caracteres")]
        [Column("ousrinis", TypeName = "varchar", Order = 8)]
        public string FiltroClientesOusrinis { get; set; }

        [Required]
        [Column("ousrdata", TypeName = "datetime",Order = 9)]
        public DateTime FiltroClientesOusrdata { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo ousrhora nao pode ser nulo")]
        [Column("ousrhora", TypeName = "varchar", Order = 10)]
        [MaxLength(8, ErrorMessage = "o campo ousrhora nao pode ter mais do que 8 caracteres")]
        public string FiltroClientesousrhora { get; set; }

       
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo usrinis nao pode ter mais do que 30 caracteres")]
        [Column("usrinis", TypeName = "varchar", Order = 11)]
        public string FiltroClientesusrinis { get; set; }

        [Required]
        [Column("usrdata", TypeName = "datetime", Order = 12)]
        public DateTime FiltroClientesusrdata { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usrhora nao pode ser nulo")]
        [Column("usrhora", TypeName = "varchar", Order = 13)]
        [MaxLength(8, ErrorMessage = "o campo usrhora nao pode ter mais do que 8 caracteres")]
        public string FiltroClientesusrhora { get; set; }

        [Required]
        [Column("marcada", TypeName = "bit", Order = 14)]
        public bool FiltroClientesMarcada { get; set; }

        public virtual ICollection<PFiltrosClientes> PhcFiltrosClientes { get; set; }
    }
}
