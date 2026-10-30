using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct SerializableFieldNetworkState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_delayBetweenUpdates;

	private static readonly System.IntPtr NativeFieldInfoPtr_syncReliably;

	private static readonly System.IntPtr NativeFieldInfoPtr_networkSyncOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_noNetworkSync;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithDelay_Public_Static_SerializableFieldNetworkState_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSyncOnly_Public_Static_SerializableFieldNetworkState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NoNetworkSync_Public_Static_SerializableFieldNetworkState_0;

	[FieldOffset(0)]
	public float delayBetweenUpdates;

	[FieldOffset(4)]
	[MarshalAs(UnmanagedType.U1)]
	public bool syncReliably;

	[FieldOffset(5)]
	[MarshalAs(UnmanagedType.U1)]
	public bool networkSyncOnly;

	[FieldOffset(6)]
	[MarshalAs(UnmanagedType.U1)]
	public bool noNetworkSync;

	static SerializableFieldNetworkState()
	{
		Il2CppClassPointerStore<SerializableFieldNetworkState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SerializableFieldNetworkState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableFieldNetworkState>.NativeClassPtr);
		NativeFieldInfoPtr_delayBetweenUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableFieldNetworkState>.NativeClassPtr, "delayBetweenUpdates");
		NativeFieldInfoPtr_syncReliably = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableFieldNetworkState>.NativeClassPtr, "syncReliably");
		NativeFieldInfoPtr_networkSyncOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableFieldNetworkState>.NativeClassPtr, "networkSyncOnly");
		NativeFieldInfoPtr_noNetworkSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableFieldNetworkState>.NativeClassPtr, "noNetworkSync");
		NativeMethodInfoPtr_WithDelay_Public_Static_SerializableFieldNetworkState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableFieldNetworkState>.NativeClassPtr, 100679504);
		NativeMethodInfoPtr_NetworkSyncOnly_Public_Static_SerializableFieldNetworkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableFieldNetworkState>.NativeClassPtr, 100679505);
		NativeMethodInfoPtr_NoNetworkSync_Public_Static_SerializableFieldNetworkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableFieldNetworkState>.NativeClassPtr, 100679506);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 233110, RefRangeEnd = 233129, XrefRangeStart = 233110, XrefRangeEnd = 233110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SerializableFieldNetworkState WithDelay(float delay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delay);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithDelay_Public_Static_SerializableFieldNetworkState_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SerializableFieldNetworkState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 233129, RefRangeEnd = 233144, XrefRangeStart = 233129, XrefRangeEnd = 233129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SerializableFieldNetworkState NetworkSyncOnly()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NetworkSyncOnly_Public_Static_SerializableFieldNetworkState_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SerializableFieldNetworkState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233144, RefRangeEnd = 233146, XrefRangeStart = 233144, XrefRangeEnd = 233144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SerializableFieldNetworkState NoNetworkSync()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NoNetworkSync_Public_Static_SerializableFieldNetworkState_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SerializableFieldNetworkState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializableFieldNetworkState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
