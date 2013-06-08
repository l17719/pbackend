using System.Data.Entity;
using BackEndAplication.Events;

namespace BackEndAplication.Models.PHCDBModel
{
    public class PdbCustomInitializer : IDatabaseInitializer<PdbContext>
    {
        #region Implementation of IDatabaseInitializer<in PDBContext>

        public void InitializeDatabase(PdbContext context)
        {
            if (!context.Database.Exists())
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro,
                                                                              "A base de dados nao existe"));
            }
        }

        #endregion
    }
}