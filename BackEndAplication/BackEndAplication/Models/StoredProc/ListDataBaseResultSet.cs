using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BackEndAplication.Models.StoredProc
{
    public class ListDataBaseResultSet
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo DATABASE_NAME nao pode ser vazio")]
        [Column("DATABASE_NAME", TypeName = "varchar", Order = 0)]
        [MaxLength(30, ErrorMessage = "O campo DATABASE_NAME nao pode ter mais que 30 caracteres")]
        [StoredProcAttributes.Direction(ParameterDirection.Output)]
        [StoredProcAttributes.Name("DATABASE_NAME")]
        [StoredProcAttributes.ParameterType(SqlDbType.VarChar)]
        public string DbName { get; set; }

        [Required(ErrorMessage = "O campo DATABASE_SIZE nao pode ser nulo")]
        [Column("DATABASE_SIZE", TypeName = "int", Order = 1)]
        [StoredProcAttributes.Direction(ParameterDirection.Output)]
        [StoredProcAttributes.Name("DATABASE_SIZE")]
        [StoredProcAttributes.ParameterType(SqlDbType.Int)]
        public int DbSize { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo REMARKS nao pode ser nulo")]
        [Column("REMARKS", TypeName = "varchar", Order = 3)]
        [StoredProcAttributes.Direction(ParameterDirection.Output)]
        [MaxLength(254, ErrorMessage = "O campo REMARKS nao pode ter mais que 254 caracteres")]
        [StoredProcAttributes.Name("REMARKS")]
        [StoredProcAttributes.ParameterType(SqlDbType.VarChar)]
        public string DbObs { get; set; }
    }
}