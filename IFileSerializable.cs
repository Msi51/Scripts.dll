using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IFileSerializable : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_FileSerialize_Public_Abstract_Virtual_New_Void_FileBinarySerializer_0;

	static IFileSerializable()
	{
		Il2CppClassPointerStore<IFileSerializable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IFileSerializable");
		NativeMethodInfoPtr_FileSerialize_Public_Abstract_Virtual_New_Void_FileBinarySerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFileSerializable>.NativeClassPtr, 100679372);
	}

	[CallerCount(0)]
	public unsafe virtual void FileSerialize(FileBinarySerializer serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FileSerialize_Public_Abstract_Virtual_New_Void_FileBinarySerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IFileSerializable(IntPtr pointer)
		: base(pointer)
	{
	}
}
