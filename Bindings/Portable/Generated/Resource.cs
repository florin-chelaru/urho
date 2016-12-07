// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Resource.cs
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

namespace Urho.Resources
{
	/// <summary>
	/// Base class for resources.
	/// </summary>
	public unsafe partial class Resource : UrhoObject
	{
		unsafe partial void OnResourceCreated ();

		[Preserve]
		public Resource (IntPtr handle) : base (handle)
		{
			OnResourceCreated ();
		}

		[Preserve]
		protected Resource (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnResourceCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Resource_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Resource_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Resource_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Resource_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Resource_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Resource));
			return new StringHash (Resource_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Resource_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Resource));
			return Marshal.PtrToStringAnsi (Resource_GetTypeNameStatic ());
		}

		[Preserve]
		public Resource () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Resource_Resource (IntPtr context);

		[Preserve]
		public Resource (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Resource));
			handle = Resource_Resource ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnResourceCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Resource_Load_File (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource synchronously. Call both BeginLoad()
		/// &
		/// EndLoad() and return true if both succeeded.
		/// </summary>
		public bool Load (File source)
		{
			Runtime.ValidateRefCounted (this);
			return Resource_Load_File (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Resource_Load_MemoryBuffer (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource synchronously. Call both BeginLoad()
		/// &
		/// EndLoad() and return true if both succeeded.
		/// </summary>
		public bool Load (MemoryBuffer source)
		{
			Runtime.ValidateRefCounted (this);
			return Resource_Load_MemoryBuffer (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Resource_BeginLoad_File (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource from stream. May be called from a worker thread. Return true if successful.
		/// </summary>
		public virtual bool BeginLoad (File source)
		{
			Runtime.ValidateRefCounted (this);
			return Resource_BeginLoad_File (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Resource_BeginLoad_MemoryBuffer (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource from stream. May be called from a worker thread. Return true if successful.
		/// </summary>
		public virtual bool BeginLoad (MemoryBuffer source)
		{
			Runtime.ValidateRefCounted (this);
			return Resource_BeginLoad_MemoryBuffer (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Resource_EndLoad (IntPtr handle);

		/// <summary>
		/// Finish resource loading. Always called from the main thread. Return true if successful.
		/// </summary>
		public virtual bool EndLoad ()
		{
			Runtime.ValidateRefCounted (this);
			return Resource_EndLoad (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Resource_Save_File (IntPtr handle, IntPtr dest);

		/// <summary>
		/// Save resource. Return true if successful.
		/// </summary>
		public virtual bool Save (File dest)
		{
			Runtime.ValidateRefCounted (this);
			return Resource_Save_File (handle, (object)dest == null ? IntPtr.Zero : dest.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Resource_Save_MemoryBuffer (IntPtr handle, IntPtr dest);

		/// <summary>
		/// Save resource. Return true if successful.
		/// </summary>
		public virtual bool Save (MemoryBuffer dest)
		{
			Runtime.ValidateRefCounted (this);
			return Resource_Save_MemoryBuffer (handle, (object)dest == null ? IntPtr.Zero : dest.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Resource_Load0 (IntPtr handle, string fileName);

		/// <summary>
		/// Load resource from file.
		/// </summary>
		public bool Load (string fileName)
		{
			Runtime.ValidateRefCounted (this);
			return Resource_Load0 (handle, fileName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Resource_Save1 (IntPtr handle, string fileName);

		/// <summary>
		/// Save resource to file.
		/// </summary>
		public virtual bool Save (string fileName)
		{
			Runtime.ValidateRefCounted (this);
			return Resource_Save1 (handle, fileName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Resource_SetName (IntPtr handle, string name);

		/// <summary>
		/// Set name.
		/// </summary>
		private void SetName (string name)
		{
			Runtime.ValidateRefCounted (this);
			Resource_SetName (handle, name);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Resource_SetMemoryUse (IntPtr handle, uint size);

		/// <summary>
		/// Set memory use in bytes, possibly approximate.
		/// </summary>
		private void SetMemoryUse (uint size)
		{
			Runtime.ValidateRefCounted (this);
			Resource_SetMemoryUse (handle, size);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Resource_ResetUseTimer (IntPtr handle);

		/// <summary>
		/// Reset last used timer.
		/// </summary>
		public void ResetUseTimer ()
		{
			Runtime.ValidateRefCounted (this);
			Resource_ResetUseTimer (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Resource_SetAsyncLoadState (IntPtr handle, AsyncLoadState newState);

		/// <summary>
		/// Set the asynchronous loading state. Called by ResourceCache. Resources in the middle of asynchronous loading are not normally returned to user.
		/// </summary>
		private void SetAsyncLoadState (AsyncLoadState newState)
		{
			Runtime.ValidateRefCounted (this);
			Resource_SetAsyncLoadState (handle, newState);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Resource_GetName (IntPtr handle);

		/// <summary>
		/// Return name.
		/// </summary>
		private string GetName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Resource_GetName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Resource_GetNameHash (IntPtr handle);

		/// <summary>
		/// Return name hash.
		/// </summary>
		private StringHash GetNameHash ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Resource_GetNameHash (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Resource_GetMemoryUse (IntPtr handle);

		/// <summary>
		/// Return memory use in bytes, possibly approximate.
		/// </summary>
		private uint GetMemoryUse ()
		{
			Runtime.ValidateRefCounted (this);
			return Resource_GetMemoryUse (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Resource_GetUseTimer (IntPtr handle);

		/// <summary>
		/// Return time since last use in milliseconds. If referred to elsewhere than in the resource cache, returns always zero.
		/// </summary>
		private uint GetUseTimer ()
		{
			Runtime.ValidateRefCounted (this);
			return Resource_GetUseTimer (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern AsyncLoadState Resource_GetAsyncLoadState (IntPtr handle);

		/// <summary>
		/// Return the asynchronous loading state.
		/// </summary>
		private AsyncLoadState GetAsyncLoadState ()
		{
			Runtime.ValidateRefCounted (this);
			return Resource_GetAsyncLoadState (handle);
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
		/// Return name.
		/// Or
		/// Set name.
		/// </summary>
		public string Name {
			get {
				return GetName ();
			}
			set {
				SetName (value);
			}
		}

		/// <summary>
		/// Return memory use in bytes, possibly approximate.
		/// Or
		/// Set memory use in bytes, possibly approximate.
		/// </summary>
		public uint MemoryUse {
			get {
				return GetMemoryUse ();
			}
			set {
				SetMemoryUse (value);
			}
		}

		/// <summary>
		/// Return the asynchronous loading state.
		/// Or
		/// Set the asynchronous loading state. Called by ResourceCache. Resources in the middle of asynchronous loading are not normally returned to user.
		/// </summary>
		public AsyncLoadState AsyncLoadState {
			get {
				return GetAsyncLoadState ();
			}
			set {
				SetAsyncLoadState (value);
			}
		}

		/// <summary>
		/// Return name hash.
		/// </summary>
		public StringHash NameHash {
			get {
				return GetNameHash ();
			}
		}

		/// <summary>
		/// Return time since last use in milliseconds. If referred to elsewhere than in the resource cache, returns always zero.
		/// </summary>
		public uint UseTimer {
			get {
				return GetUseTimer ();
			}
		}
	}
}
