using System.Data.Entity;

namespace BackEndAplication.Models.TerminalDBModel
{
    public class DbTerminalCustomInitializer : IDatabaseInitializer<DbTerminalContext>
    {
        #region Implementation of IDatabaseInitializer<in DBTerminalContext>

        public void InitializeDatabase(DbTerminalContext context)
        {
            if (!context.Database.Exists())
            {
                context.Database.Create();
            }
        }

        #endregion
    }
}