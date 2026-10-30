using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[StructLayout(LayoutKind.Explicit)]
public struct InventorySectionData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_inventorySectionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_numSlots;

	private static readonly System.IntPtr NativeFieldInfoPtr_numRows;

	private static readonly System.IntPtr NativeFieldInfoPtr_numCols;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxStackAmountFactor;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	[FieldOffset(0)]
	public InventorySectionType inventorySectionType;

	[FieldOffset(4)]
	public int numSlots;

	[FieldOffset(8)]
	public int numRows;

	[FieldOffset(12)]
	public int numCols;

	[FieldOffset(16)]
	public int maxStackAmountFactor;

	static InventorySectionData()
	{
		Il2CppClassPointerStore<InventorySectionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InventorySectionData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySectionData>.NativeClassPtr);
		NativeFieldInfoPtr_inventorySectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySectionData>.NativeClassPtr, "inventorySectionType");
		NativeFieldInfoPtr_numSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySectionData>.NativeClassPtr, "numSlots");
		NativeFieldInfoPtr_numRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySectionData>.NativeClassPtr, "numRows");
		NativeFieldInfoPtr_numCols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySectionData>.NativeClassPtr, "numCols");
		NativeFieldInfoPtr_maxStackAmountFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySectionData>.NativeClassPtr, "maxStackAmountFactor");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySectionData>.NativeClassPtr, 100673450);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140910, XrefRangeEnd = 140962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventorySectionData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
