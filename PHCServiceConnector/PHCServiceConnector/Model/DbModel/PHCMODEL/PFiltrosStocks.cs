using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConnectorService.Model.PHCModel
{
    [Table("fltst")]
    public class PFiltrosStocks
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de stamp nao pode ter mais que 25 caracteres")]
        [Column("fltststamp", TypeName = "varchar", Order = 0)]
        public string TbFiltroStocksStamp { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de titulo nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de stamp nao pode ter mais que 50 caracteres")]
        [Column("ftitulo", TypeName = "varchar", Order = 1)]
        public string FiltroStocksTitulo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de texto nao pode ser nulo")]
        [Column("texto", TypeName = "text", Order = 2)]
        public string FiltroStocksTexto { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo xbase nao pode ser nulo")]
        [Column("xbase", TypeName = "text", Order = 3)]
        public string FiltroStocksXbase { get; set; }

        [Key]
        [Column("stamp", TypeName = "varchar", Order = 4)]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais do que 25 caracteres")]
        public string FiltroStocksStamp { get; set; }

        [Required]
        [Column("temvar", TypeName = "bit", Order = 5)]
        public bool FiltroStocksTemVar { get; set; }

        [Required]
        [Column("privado", TypeName = "bit", Order = 6)]
        public bool FiltroStocksPrivado { get; set; }

        [Required]
        [Column("altera", TypeName = "bit", Order = 7)]
        public bool FiltroStocksAltera { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo ousrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo ousrinis nao pode ter mais do que 30 caracteres")]
        [Column("ousrinis", TypeName = "varchar", Order = 8)]
        public string FiltroStocksOusrinis { get; set; }

        [Required]
        [Column("ousrdata", TypeName = "datetime", Order = 9)]
        public DateTime FiltroStocksOusrdata { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo ousrhora nao pode ser nulo")]
        [Column("ousrhora", TypeName = "varchar", Order = 10)]
        [MaxLength(8, ErrorMessage = "o campo ousrhora nao pode ter mais do que 8 caracteres")]
        public string FiltroStocksousrhora { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo usrinis nao pode ter mais do que 30 caracteres")]
        [Column("usrinis", TypeName = "varchar", Order = 11)]
        public string FiltroStocksusrinis { get; set; }

        [Required]
        [Column("usrdata", TypeName = "datetime", Order = 12)]
        public DateTime FiltroStocksusrdata { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usrhora nao pode ser nulo")]
        [Column("usrhora", TypeName = "varchar", Order = 13)]
        [MaxLength(8, ErrorMessage = "o campo usrhora nao pode ter mais do que 8 caracteres")]
        public string FiltroStocksusrhora { get; set; }

        [Required]
        [Column("marcada", TypeName = "bit", Order = 14)]
        public bool FiltroStocksMarcada { get; set; }

        public virtual ICollection<PFiltrosStocks> PhcFiltrosStocks { get; set; }
    }
}
