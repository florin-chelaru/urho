// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// FileSystem.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.IO
{
	/// <summary>
	/// Subsystem for file and directory operations and access control.
	/// </summary>
	public unsafe partial class FileSystem : UrhoObject
	{
		unsafe partial void OnFileSystemCreated ();

		[Preserve]
		public FileSystem (IntPtr handle) : base (handle)
		{
			OnFileSystemCreated ();
		}

		[Preserve]
		protected FileSystem (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnFileSystemCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int FileSystem_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (FileSystem_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr FileSystem_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (FileSystem_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int FileSystem_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(FileSystem));
			return new StringHash (FileSystem_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr FileSystem_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(FileSystem));
			return Marshal.PtrToStringAnsi (FileSystem_GetTypeNameStatic ());
		}

		[Preserve]
		public FileSystem () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr FileSystem_FileSystem (IntPtr context);

		[Preserve]
		public FileSystem (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(FileSystem));
			handle = FileSystem_FileSystem ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnFileSystemCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool FileSystem_SetCurrentDir (IntPtr handle, string pathName);

		/// <summary>
		/// Set the current working directory.
		/// </summary>
		public bool SetCurrentDir (string pathName)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_SetCurrentDir (handle, pathName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool FileSystem_CreateDir (IntPtr handle, string pathName);

		/// <summary>
		/// Create a directory.
		/// </summary>
		public bool CreateDir (string pathName)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_CreateDir (handle, pathName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void FileSystem_SetExecuteConsoleCommands (IntPtr handle, bool enable);

		/// <summary>
		/// Set whether to execute engine console commands as OS-specific system command.
		/// </summary>
		private void SetExecuteConsoleCommands (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			FileSystem_SetExecuteConsoleCommands (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int FileSystem_SystemCommand (IntPtr handle, string commandLine, bool redirectStdOutToLog);

		/// <summary>
		/// Run a program using the command interpreter, block until it exits and return the exit code. Will fail if any allowed paths are defined.
		/// </summary>
		public int SystemCommand (string commandLine, bool redirectStdOutToLog)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_SystemCommand (handle, commandLine, redirectStdOutToLog);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint FileSystem_SystemCommandAsync (IntPtr handle, string commandLine);

		/// <summary>
		/// Run a program using the command interpreter asynchronously. Return a request ID or M_MAX_UNSIGNED if failed. The exit code will be posted together with the request ID in an AsyncExecFinished event. Will fail if any allowed paths are defined.
		/// </summary>
		public uint SystemCommandAsync (string commandLine)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_SystemCommandAsync (handle, commandLine);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool FileSystem_SystemOpen (IntPtr handle, string fileName, string mode);

		/// <summary>
		/// Open a file in an external program, with mode such as "edit" optionally specified. Will fail if any allowed paths are defined.
		/// </summary>
		public bool SystemOpen (string fileName, string mode)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_SystemOpen (handle, fileName, mode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool FileSystem_Copy (IntPtr handle, string srcFileName, string destFileName);

		/// <summary>
		/// Copy a file. Return true if successful.
		/// </summary>
		public bool Copy (string srcFileName, string destFileName)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_Copy (handle, srcFileName, destFileName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool FileSystem_Rename (IntPtr handle, string srcFileName, string destFileName);

		/// <summary>
		/// Rename a file. Return true if successful.
		/// </summary>
		public bool Rename (string srcFileName, string destFileName)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_Rename (handle, srcFileName, destFileName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool FileSystem_Delete (IntPtr handle, string fileName);

		/// <summary>
		/// Delete a file. Return true if successful.
		/// </summary>
		public bool Delete (string fileName)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_Delete (handle, fileName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void FileSystem_RegisterPath (IntPtr handle, string pathName);

		/// <summary>
		/// Register a path as allowed to access. If no paths are registered, all are allowed. Registering allowed paths is considered securing the Urho3D execution environment: running programs and opening files externally through the system will fail afterward.
		/// </summary>
		public void RegisterPath (string pathName)
		{
			Runtime.ValidateRefCounted (this);
			FileSystem_RegisterPath (handle, pathName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool FileSystem_SetLastModifiedTime (IntPtr handle, string fileName, uint newTime);

		/// <summary>
		/// Set a file's last modified time as seconds since 1.1.1970. Return true on success.
		/// </summary>
		public bool SetLastModifiedTime (string fileName, uint newTime)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_SetLastModifiedTime (handle, fileName, newTime);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr FileSystem_GetCurrentDir (IntPtr handle);

		/// <summary>
		/// Return the absolute current working directory.
		/// </summary>
		private string GetCurrentDir ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (FileSystem_GetCurrentDir (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool FileSystem_GetExecuteConsoleCommands (IntPtr handle);

		/// <summary>
		/// Return whether is executing engine console commands as OS-specific system command.
		/// </summary>
		private bool GetExecuteConsoleCommands ()
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_GetExecuteConsoleCommands (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool FileSystem_HasRegisteredPaths (IntPtr handle);

		/// <summary>
		/// Return whether paths have been registered.
		/// </summary>
		public bool HasRegisteredPaths ()
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_HasRegisteredPaths (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool FileSystem_CheckAccess (IntPtr handle, string pathName);

		/// <summary>
		/// Check if a path is allowed to be accessed. If no paths are registered, all are allowed.
		/// </summary>
		public bool CheckAccess (string pathName)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_CheckAccess (handle, pathName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint FileSystem_GetLastModifiedTime (IntPtr handle, string fileName);

		/// <summary>
		/// Returns the file's last modified time as seconds since 1.1.1970, or 0 if can not be accessed.
		/// </summary>
		public uint GetLastModifiedTime (string fileName)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_GetLastModifiedTime (handle, fileName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool FileSystem_FileExists (IntPtr handle, string fileName);

		/// <summary>
		/// Check if a file exists.
		/// </summary>
		public bool FileExists (string fileName)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_FileExists (handle, fileName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool FileSystem_DirExists (IntPtr handle, string pathName);

		/// <summary>
		/// Check if a directory exists.
		/// </summary>
		public bool DirExists (string pathName)
		{
			Runtime.ValidateRefCounted (this);
			return FileSystem_DirExists (handle, pathName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr FileSystem_GetProgramDir (IntPtr handle);

		/// <summary>
		/// Return the program's directory. If it does not contain the Urho3D default CoreData and Data directories, and the current working directory does, return the working directory instead.
		/// </summary>
		private string GetProgramDir ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (FileSystem_GetProgramDir (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr FileSystem_GetUserDocumentsDir (IntPtr handle);

		/// <summary>
		/// Return the user documents directory.
		/// </summary>
		private string GetUserDocumentsDir ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (FileSystem_GetUserDocumentsDir (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr FileSystem_GetAppPreferencesDir (IntPtr handle, string org, string app);

		/// <summary>
		/// Return the application preferences directory.
		/// </summary>
		public string GetAppPreferencesDir (string org, string app)
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (FileSystem_GetAppPreferencesDir (handle, org, app));
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		[Preserve]
		public static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return whether is executing engine console commands as OS-specific system command.
		/// Or
		/// Set whether to execute engine console commands as OS-specific system command.
		/// </summary>
		public bool ExecuteConsoleCommands {
			get {
				return GetExecuteConsoleCommands ();
			}
			set {
				SetExecuteConsoleCommands (value);
			}
		}

		/// <summary>
		/// Return the absolute current working directory.
		/// </summary>
		public string CurrentDir {
			get {
				return GetCurrentDir ();
			}
		}

		/// <summary>
		/// Return the program's directory. If it does not contain the Urho3D default CoreData and Data directories, and the current working directory does, return the working directory instead.
		/// </summary>
		public string ProgramDir {
			get {
				return GetProgramDir ();
			}
		}

		/// <summary>
		/// Return the user documents directory.
		/// </summary>
		public string UserDocumentsDir {
			get {
				return GetUserDocumentsDir ();
			}
		}
	}
}
