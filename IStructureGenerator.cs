using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

public class IStructureGenerator : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ShouldGenerate_Public_Abstract_Virtual_New_Boolean_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	static IStructureGenerator()
	{
		Il2CppClassPointerStore<IStructureGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IStructureGenerator");
		NativeMethodInfoPtr_ShouldGenerate_Public_Abstract_Virtual_New_Boolean_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStructureGenerator>.NativeClassPtr, 100683738);
		NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStructureGenerator>.NativeClassPtr, 100683739);
	}

	[CallerCount(0)]
	public unsafe virtual bool ShouldGenerate(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShouldGenerate_Public_Abstract_Virtual_New_Boolean_World_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Generate(World world, Chunk chunk, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IStructureGenerator(IntPtr pointer)
		: base(pointer)
	{
	}
}
