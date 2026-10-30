using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

public static class TextureUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_FlipTextureBytesVertically_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

	static TextureUtil()
	{
		Il2CppClassPointerStore<TextureUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TextureUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureUtil>.NativeClassPtr);
		NativeMethodInfoPtr_FlipTextureBytesVertically_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureUtil>.NativeClassPtr, 100667944);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85702, RefRangeEnd = 85703, XrefRangeStart = 85701, XrefRangeEnd = 85702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FlipTextureBytesVertically(Il2CppStructArray<byte> bytes, int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlipTextureBytesVertically_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TextureUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
