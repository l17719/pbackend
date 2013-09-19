// Type: System.Security.Principal.WindowsIdentity
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.Security.Principal
{
    /// <summary>
    /// Represents a Windows user.
    /// 
    /// </summary>
    [ComVisible(true)]
    [Serializable]
    public class WindowsIdentity : IIdentity, ISerializable, IDeserializationCallback, IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity"/> class for the user represented by the specified Windows account token.
        /// 
        /// </summary>
        /// <param name="userToken">The account token for the user on whose behalf the code is running.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="userToken"/> is 0.
        /// 
        ///                     -or-
        ///                 <paramref name="userToken"/> is duplicated and invalid for impersonation.
        ///                 </exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.
        /// 
        ///                     -or-
        /// 
        ///                     A Win32 error occurred.
        ///                 </exception>
        [SecuritySafeCritical]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
        public WindowsIdentity(IntPtr userToken);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity"/> class for the user represented by the specified Windows account token and the specified authentication type.
        /// 
        /// </summary>
        /// <param name="userToken">The account token for the user on whose behalf the code is running.
        ///                 </param><param name="type">The type of authentication used to identify the user.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="userToken"/> is 0.
        /// 
        ///                     -or-
        ///                 <paramref name="userToken"/> is duplicated and invalid for impersonation.
        ///                 </exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.
        /// 
        ///                     -or-
        /// 
        ///                     A Win32 error occurred.
        ///                 </exception>
        [SecuritySafeCritical]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
        public WindowsIdentity(IntPtr userToken, string type);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity"/> class for the user represented by the specified Windows account token, the specified authentication type, and the specified Windows account type.
        /// 
        /// </summary>
        /// <param name="userToken">The account token for the user on whose behalf the code is running.
        ///                 </param><param name="type">The type of authentication used to identify the user.
        ///                 </param><param name="acctType">One of the <see cref="T:System.Security.Principal.WindowsAccountType"/> values.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="userToken"/> is 0.
        /// 
        ///                     -or-
        ///                 <paramref name="userToken"/> is duplicated and invalid for impersonation.
        ///                 </exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.
        /// 
        ///                     -or-
        /// 
        ///                     A Win32 error occurred.
        ///                 </exception>
        [SecuritySafeCritical]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
        public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity"/> class for the user represented by the specified Windows account token, the specified authentication type, the specified Windows account type, and the specified authentication status.
        /// 
        /// </summary>
        /// <param name="userToken">The account token for the user on whose behalf the code is running.
        ///                 </param><param name="type">The type of authentication used to identify the user.
        ///                 </param><param name="acctType">One of the <see cref="T:System.Security.Principal.WindowsAccountType"/> values.
        ///                 </param><param name="isAuthenticated">true to indicate that the user is authenticated; otherwise, false.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="userToken"/> is 0.
        /// 
        ///                     -or-
        ///                 <paramref name="userToken"/> is duplicated and invalid for impersonation.
        ///                 </exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.
        /// 
        ///                     -or-
        /// 
        ///                     A Win32 error occurred.
        ///                 </exception>
        [SecuritySafeCritical]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
        public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity"/> class for the user represented by the specified User Principal Name (UPN).
        /// 
        /// </summary>
        /// <param name="sUserPrincipalName">The UPN for the user on whose behalf the code is running.
        ///                 </param><exception cref="T:System.UnauthorizedAccessException">Windows returned the Windows NT status code STATUS_ACCESS_DENIED.
        ///                 </exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.
        ///                 </exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.
        ///                 </exception>
        [SecuritySafeCritical]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
        public WindowsIdentity(string sUserPrincipalName);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity"/> class for the user represented by the specified User Principal Name (UPN) and the specified authentication type.
        /// 
        /// </summary>
        /// <param name="sUserPrincipalName">The UPN for the user on whose behalf the code is running.
        ///                 </param><param name="type">The type of authentication used to identify the user.
        ///                 </param><exception cref="T:System.UnauthorizedAccessException">Windows returned the Windows NT status code STATUS_ACCESS_DENIED.
        ///                 </exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.
        ///                 </exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.
        ///                 </exception>
        [SecuritySafeCritical]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
        public WindowsIdentity(string sUserPrincipalName, string type);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity"/> class for the user represented by information in a <see cref="T:System.Runtime.Serialization.SerializationInfo"/> stream.
        /// 
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> containing the account information for the user.
        ///                 </param><param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext"/> that indicates the stream characteristics.
        ///                 </param><exception cref="T:System.NotSupportedException">A <see cref="T:System.Security.Principal.WindowsIdentity"/> cannot be serialized across processes.
        ///                 </exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.
        /// 
        ///                     -or-
        /// 
        ///                     A Win32 error occurred.
        ///                 </exception>
        [SecuritySafeCritical]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
        public WindowsIdentity(SerializationInfo info, StreamingContext context);

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object with the logical context information needed to recreate an instance of this execution context.
        /// 
        /// </summary>
        /// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object containing the information required to serialize the <see cref="T:System.Collections.Hashtable"/>.
        ///                 </param><param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext"/> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Hashtable"/>.
        ///                 </param>
        [SecurityCritical]
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);

        /// <summary>
        /// Implements the <see cref="T:System.Runtime.Serialization.ISerializable"/> interface and is called back by the deserialization event when deserialization is complete.
        /// 
        /// </summary>
        /// <param name="sender">The source of the deserialization event.
        ///                 </param>
        void IDeserializationCallback.OnDeserialization(object sender);

        /// <summary>
        /// Returns a <see cref="T:System.Security.Principal.WindowsIdentity"/> object that represents the current Windows user.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Security.Principal.WindowsIdentity"/> object that represents the current user.
        /// 
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.
        ///                 </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPrincipal"/></PermissionSet>
        [SecuritySafeCritical]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
        public static WindowsIdentity GetCurrent();

        /// <summary>
        /// Returns a <see cref="T:System.Security.Principal.WindowsIdentity"/> object that represents the Windows identity for either the thread or the process, depending on the value of the <paramref name="ifImpersonating"/> parameter.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Security.Principal.WindowsIdentity"/> object that represents a Windows user.
        /// 
        /// </returns>
        /// <param name="ifImpersonating">true to return the <see cref="T:System.Security.Principal.WindowsIdentity"/> only if the thread is currently impersonating; false to return the <see cref="T:System.Security.Principal.WindowsIdentity"/>   of the thread if it is impersonating or the <see cref="T:System.Security.Principal.WindowsIdentity"/> of the process if the thread is not currently impersonating.
        ///                 </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPrincipal"/></PermissionSet>
        [SecuritySafeCritical]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
        public static WindowsIdentity GetCurrent(bool ifImpersonating);

        /// <summary>
        /// Returns a <see cref="T:System.Security.Principal.WindowsIdentity"/> object that represents the current Windows user, using the specified desired token access level.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Security.Principal.WindowsIdentity"/> object that represents the current user.
        /// 
        /// </returns>
        /// <param name="desiredAccess">A bitwise combination of the <see cref="T:System.Security.Principal.TokenAccessLevels"/> values.
        ///                 </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPrincipal"/></PermissionSet>
        [SecuritySafeCritical]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
        public static WindowsIdentity GetCurrent(TokenAccessLevels desiredAccess);

        /// <summary>
        /// Returns a <see cref="T:System.Security.Principal.WindowsIdentity"/> object that represents an anonymous user.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Security.Principal.WindowsIdentity"/> object that represents an anonymous user.
        /// 
        /// </returns>
        [SecuritySafeCritical]
        public static WindowsIdentity GetAnonymous();

        /// <summary>
        /// Impersonates the user represented by the <see cref="T:System.Security.Principal.WindowsIdentity"/> object.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Security.Principal.WindowsImpersonationContext"/> object that represents the Windows user prior to impersonation; this can be used to revert to the original user's context.
        /// 
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">An anonymous identity attempted to perform an impersonation.
        ///                 </exception><exception cref="T:System.Security.SecurityException">A Win32 error occurred.
        ///                 </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPrincipal"/></PermissionSet>
        [SecuritySafeCritical]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public virtual WindowsImpersonationContext Impersonate();

        /// <summary>
        /// Impersonates the user represented by the specified user token.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Security.Principal.WindowsImpersonationContext"/> object that represents the Windows user prior to impersonation; this object can be used to revert to the original user's context.
        /// 
        /// </returns>
        /// <param name="userToken">The handle of a Windows account token. This token is usually retrieved through a call to unmanaged code, such as a call to the Win32 API LogonUser function. For more information on calls to unmanaged code, see Consuming Unmanaged DLL Functions.
        ///                 </param><exception cref="T:System.UnauthorizedAccessException">Windows returned the Windows NT status code STATUS_ACCESS_DENIED.
        ///                 </exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.
        ///                 </exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.
        ///                 </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPrincipal"/></PermissionSet>
        [SecuritySafeCritical]
        [MethodImpl(MethodImplOptions.NoInlining)]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal | SecurityPermissionFlag.NoFlags | SecurityPermissionFlag.UnmanagedCode)]
        public static WindowsImpersonationContext Impersonate(IntPtr userToken);

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:System.Security.Principal.WindowsIdentity"/> and optionally releases the managed resources.
        /// 
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.
        ///                 </param>
        [ComVisible(false)]
        [SecuritySafeCritical]
        protected virtual void Dispose(bool disposing);

        /// <summary>
        /// Releases all resources used by the <see cref="T:System.Security.Principal.WindowsIdentity"/>.
        /// 
        /// </summary>
        [SecuritySafeCritical]
        [ComVisible(false)]
        public void Dispose();

        /// <summary>
        /// Gets the type of authentication used to identify the user.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The type of authentication used to identify the user.
        /// 
        /// </returns>
        public string AuthenticationType { [SecuritySafeCritical]
        get; }

        /// <summary>
        /// Gets the impersonation level for the user.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// One of the <see cref="T:System.Management.ImpersonationLevel"/> values.
        /// 
        /// </returns>
        [ComVisible(false)]
        public TokenImpersonationLevel ImpersonationLevel { [SecuritySafeCritical]
        get; }

        /// <summary>
        /// Gets a value indicating whether the user has been authenticated by Windows.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if the user was authenticated; otherwise, false.
        /// 
        /// </returns>
        public virtual bool IsAuthenticated { get; }

        /// <summary>
        /// Gets a value indicating whether the user account is identified as a <see cref="F:System.Security.Principal.WindowsAccountType.Guest"/> account by the system.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if the user account is a <see cref="F:System.Security.Principal.WindowsAccountType.Guest"/> account; otherwise, false.
        /// 
        /// </returns>
        public virtual bool IsGuest { [SecuritySafeCritical]
        get; }

        /// <summary>
        /// Gets a value indicating whether the user account is identified as a <see cref="F:System.Security.Principal.WindowsAccountType.System"/> account by the system.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if the user account is a <see cref="F:System.Security.Principal.WindowsAccountType.System"/> account; otherwise, false.
        /// 
        /// </returns>
        public virtual bool IsSystem { [SecuritySafeCritical]
        get; }

        /// <summary>
        /// Gets a value indicating whether the user account is identified as an anonymous account by the system.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if the user account is an anonymous account; otherwise, false.
        /// 
        /// </returns>
        public virtual bool IsAnonymous { [SecuritySafeCritical]
        get; }

        /// <summary>
        /// Gets the user's Windows logon name.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Windows logon name of the user on whose behalf the code is being run.
        /// 
        /// </returns>
        public virtual string Name { [SecuritySafeCritical]
        get; }

        /// <summary>
        /// Gets the security identifier (SID) for the token owner.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Security.Principal.SecurityIdentifier"/> object for the token owner.
        /// 
        /// </returns>
        [ComVisible(false)]
        public SecurityIdentifier Owner { [SecuritySafeCritical]
        get; }

        /// <summary>
        /// Gets the security identifier (SID) for the user.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Security.Principal.SecurityIdentifier"/> object for the user.
        /// 
        /// </returns>
        [ComVisible(false)]
        public SecurityIdentifier User { [SecuritySafeCritical]
        get; }

        /// <summary>
        /// Gets the groups the current Windows user belongs to.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Security.Principal.IdentityReferenceCollection"/> object representing the groups the current Windows user belongs to.
        /// 
        /// </returns>
        public IdentityReferenceCollection Groups { [SecuritySafeCritical]
        get; }

        /// <summary>
        /// Gets the Windows account token for the user.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The handle of the access token associated with the current execution thread.
        /// 
        /// </returns>
        public virtual IntPtr Token { [SecuritySafeCritical, SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        get; }
    }
}
