using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.IO;

public static class FileUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_HR_ERROR_HANDLE_DISK_FULL;

	private static readonly System.IntPtr NativeFieldInfoPtr_HR_ERROR_DISK_FULL;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDiskFull_Public_Static_Boolean_IOException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyDirectory_Public_Static_Int32_String_String_Boolean_Boolean_0;

	public unsafe static int HR_ERROR_HANDLE_DISK_FULL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HR_ERROR_HANDLE_DISK_FULL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HR_ERROR_HANDLE_DISK_FULL, (void*)(&num));
		}
	}

	public unsafe static int HR_ERROR_DISK_FULL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HR_ERROR_DISK_FULL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HR_ERROR_DISK_FULL, (void*)(&num));
		}
	}

	static FileUtil()
	{
		Il2CppClassPointerStore<FileUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FileUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileUtil>.NativeClassPtr);
		NativeFieldInfoPtr_HR_ERROR_HANDLE_DISK_FULL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUtil>.NativeClassPtr, "HR_ERROR_HANDLE_DISK_FULL");
		NativeFieldInfoPtr_HR_ERROR_DISK_FULL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUtil>.NativeClassPtr, "HR_ERROR_DISK_FULL");
		NativeMethodInfoPtr_IsDiskFull_Public_Static_Boolean_IOException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUtil>.NativeClassPtr, 100667732);
		NativeMethodInfoPtr_CopyDirectory_Public_Static_Int32_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUtil>.NativeClassPtr, 100667733);
	}

	[CallerCount(0)]
	public unsafe static bool IsDiskFull(IOException e)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDiskFull_Public_Static_Boolean_IOException_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 81438, RefRangeEnd = 81439, XrefRangeStart = 81416, XrefRangeEnd = 81438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CopyDirectory(string sourceDir, string destinationDir, bool recursive, bool overwrite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceDir);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(destinationDir);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recursive;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &overwrite;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyDirectory_Public_Static_Int32_String_String_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public FileUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
