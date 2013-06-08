using System;
using System.ComponentModel.DataAnnotations;

namespace ConnectorService.Model.IFModel
{
    [Table("TbTerminal")]
    public class TbTerminais
    {
        [Key]
        [Column("IDTerminal", TypeName = "uniqueidentifier", Order = 0)]
        public Guid TerminalId { get; set; }

        [Required]
        [Column("FkIDOT", TypeName = "uniqueidentifier", Order = 1)]
        public Guid OpcoesTerminalId { get; set; }

        [ForeignKey("FKIdOpcoesTerminal")]
        public virtual TbOpcoesTerminal OpcoesTerminal { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo numero terminal nao pode ser vazio")]
        [MaxLength(40, ErrorMessage = "O campo numero pda nao pode ter mais do que 40 caracteres")]
        [Column("NumPda", TypeName = "varchar", Order = 2)]
        [StringLength(40, ErrorMessage = "O campo numero de pda nao pode ter mais do que 40 caracteres")]
        public string NumPda { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "O campo MacAddressG nao pode ter mais do que 50 caracteres")]
        [Column("MacAddress3G", TypeName = "varchar", Order = 2)]
        [StringLength(50)]
        public string MacAddressG { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "O campo MacAddressW nao pode ter mais do que 50 caracteres")]
        [Column("MacAddressWireless", TypeName = "varchar", Order = 3)]
        [StringLength(50)]
        public string MacAddressW { get; set; }

        [Required]
        [Column("TerminalAccessKey", TypeName = "uniqueidentifier", Order = 4)]
        public Guid AccessKey { get; set; }
    }
}