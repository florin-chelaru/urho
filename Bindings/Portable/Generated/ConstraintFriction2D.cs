// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// ConstraintFriction2D.cs
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

namespace Urho.Urho2D
{
	/// <summary>
	/// 2D friction constraint component.
	/// </summary>
	public unsafe partial class ConstraintFriction2D : Constraint2D
	{
		unsafe partial void OnConstraintFriction2DCreated ();

		[Preserve]
		public ConstraintFriction2D (IntPtr handle) : base (handle)
		{
			OnConstraintFriction2DCreated ();
		}

		[Preserve]
		protected ConstraintFriction2D (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnConstraintFriction2DCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ConstraintFriction2D_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (ConstraintFriction2D_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ConstraintFriction2D_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (ConstraintFriction2D_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ConstraintFriction2D_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(ConstraintFriction2D));
			return new StringHash (ConstraintFriction2D_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ConstraintFriction2D_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(ConstraintFriction2D));
			return Marshal.PtrToStringAnsi (ConstraintFriction2D_GetTypeNameStatic ());
		}

		[Preserve]
		public ConstraintFriction2D () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ConstraintFriction2D_ConstraintFriction2D (IntPtr context);

		[Preserve]
		public ConstraintFriction2D (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(ConstraintFriction2D));
			handle = ConstraintFriction2D_ConstraintFriction2D ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnConstraintFriction2DCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ConstraintFriction2D_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(ConstraintFriction2D));
			ConstraintFriction2D_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ConstraintFriction2D_SetAnchor (IntPtr handle, ref Urho.Vector2 anchor);

		/// <summary>
		/// Set anchor.
		/// </summary>
		private void SetAnchor (Urho.Vector2 anchor)
		{
			Runtime.ValidateRefCounted (this);
			ConstraintFriction2D_SetAnchor (handle, ref anchor);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ConstraintFriction2D_SetMaxForce (IntPtr handle, float maxForce);

		/// <summary>
		/// Set max force.
		/// </summary>
		private void SetMaxForce (float maxForce)
		{
			Runtime.ValidateRefCounted (this);
			ConstraintFriction2D_SetMaxForce (handle, maxForce);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ConstraintFriction2D_SetMaxTorque (IntPtr handle, float maxTorque);

		/// <summary>
		/// Set max torque.
		/// </summary>
		private void SetMaxTorque (float maxTorque)
		{
			Runtime.ValidateRefCounted (this);
			ConstraintFriction2D_SetMaxTorque (handle, maxTorque);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Vector2 ConstraintFriction2D_GetAnchor (IntPtr handle);

		/// <summary>
		/// Return anchor.
		/// </summary>
		private Urho.Vector2 GetAnchor ()
		{
			Runtime.ValidateRefCounted (this);
			return ConstraintFriction2D_GetAnchor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float ConstraintFriction2D_GetMaxForce (IntPtr handle);

		/// <summary>
		/// Set max force.
		/// </summary>
		private float GetMaxForce ()
		{
			Runtime.ValidateRefCounted (this);
			return ConstraintFriction2D_GetMaxForce (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float ConstraintFriction2D_GetMaxTorque (IntPtr handle);

		/// <summary>
		/// Set max torque.
		/// </summary>
		private float GetMaxTorque ()
		{
			Runtime.ValidateRefCounted (this);
			return ConstraintFriction2D_GetMaxTorque (handle);
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
		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return anchor.
		/// Or
		/// Set anchor.
		/// </summary>
		public Urho.Vector2 Anchor {
			get {
				return GetAnchor ();
			}
			set {
				SetAnchor (value);
			}
		}

		/// <summary>
		/// Set max force.
		/// Or
		/// Set max force.
		/// </summary>
		public float MaxForce {
			get {
				return GetMaxForce ();
			}
			set {
				SetMaxForce (value);
			}
		}

		/// <summary>
		/// Set max torque.
		/// Or
		/// Set max torque.
		/// </summary>
		public float MaxTorque {
			get {
				return GetMaxTorque ();
			}
			set {
				SetMaxTorque (value);
			}
		}
	}
}
