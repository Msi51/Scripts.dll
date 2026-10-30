using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class ToolTypes : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetToolTypeName_Public_Static_String_ToolType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ToolTypes()
	{
		Il2CppClassPointerStore<ToolTypes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ToolTypes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToolTypes>.NativeClassPtr);
		NativeMethodInfoPtr_GetToolTypeName_Public_Static_String_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolTypes>.NativeClassPtr, 100679836);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolTypes>.NativeClassPtr, 100679837);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234698, RefRangeEnd = 234700, XrefRangeStart = 234640, XrefRangeEnd = 234698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetToolTypeName(ToolType toolType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&toolType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetToolTypeName_Public_Static_String_ToolType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ToolTypes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToolTypes>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ToolTypes(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
