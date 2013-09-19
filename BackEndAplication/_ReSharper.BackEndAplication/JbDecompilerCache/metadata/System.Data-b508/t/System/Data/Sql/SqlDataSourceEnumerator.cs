// Type: System.Data.Sql.SqlDataSourceEnumerator
// Assembly: System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Data.dll

using System.Data;
using System.Data.Common;

namespace System.Data.Sql
{
    /// <summary>
    /// Provides a mechanism for enumerating all available instances of SQL Server within the local network.
    /// 
    /// </summary>
    public sealed class SqlDataSourceEnumerator : DbDataSourceEnumerator
    {
        /// <summary>
        /// Retrieves a <see cref="T:System.Data.DataTable"/> containing information about all visible SQL Server 2000 or SQL Server 2005 instances.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Returns a <see cref="T:System.Data.DataTable"/> containing information about the visible SQL Server instances.
        /// 
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence"/></PermissionSet>
        public override DataTable GetDataSources();

        /// <summary>
        /// Gets an instance of the <see cref="T:System.Data.Sql.SqlDataSourceEnumerator"/>, which can be used to retrieve information about available SQL Server instances.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Data.Sql.SqlDataSourceEnumerator"/>.
        /// 
        /// </returns>
        public static SqlDataSourceEnumerator Instance { get; }
    }
}
