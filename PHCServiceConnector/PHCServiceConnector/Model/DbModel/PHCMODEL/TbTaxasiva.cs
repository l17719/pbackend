using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConnectorService.Model.PHCModel
{
    [Table("taxasiva")]
    public class TbTaxasiva
    {
        
        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de taxasivastamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de taxasivastamp nao pode ter mais que 25 caracteres")]
        [Column("taxasivastamp", TypeName = "char", Order = 0)]
        public string TbTaxasivataxasivastamp { get; set; }

        //key numeric
        [Key]
        [Column("codigo", TypeName = "numeric", Order = 1)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbTaxasivacodigo { get; set; }

        //key numeric
        [Key]
        [Column("taxa", TypeName = "numeric", Order = 2)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbTaxasivataxa { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ousrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de ousrinis nao pode ter mais que 30 caracteres")]
        [Column("ousrinis", TypeName = "varchar", Order = 3)]
        public string TbTaxasivaousrinis { get; set; }

        //datetime
        [Required]
        [Column("ousrdata", TypeName = "datetime", Order = 4)]
        public DateTime TbTaxasivaousrdata { get; set; }


        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ousrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de ousrhora nao pode ter mais que 8 caracteres")]
        [Column("ousrhora", TypeName = "varchar", Order = 5)]
        public string TbTaxasivaousrhora { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de usrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de usrinis nao pode ter mais que 30 caracteres")]
        [Column("usrinis", TypeName = "varchar", Order = 6)]
        public string TbTaxasivausrinis { get; set; }

        //datetime
        [Required]
        [Column("usrdata", TypeName = "datetime", Order = 7)]
        public DateTime TbTaxasivausrdata { get; set; }

        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de usrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de usrhora nao pode ter mais que 8 caracteres")]
        [Column("usrhora", TypeName = "varchar", Order = 8)]
        public string TbTaxasivausrhora { get; set; }

        //bit
        [Required]
        [Column("marcada", TypeName = "bit", Order = 9)]
        public bool TbTaxasivamarcada { get; set; }


        public ICollection<TbTaxasiva> TbTaxasivas { get; set; } 
    }
}
