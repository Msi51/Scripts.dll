using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

public class CaveGenerator : StructureGenerator
{
	private static readonly IntPtr NativeFieldInfoPtr_ENTRANCE_IDENTIFIER;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IStructureManager_IIndoorLevelManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShouldGenerate_Public_Virtual_Boolean_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Virtual_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	public unsafe static string ENTRANCE_IDENTIFIER
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTRANCE_IDENTIFIER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTRANCE_IDENTIFIER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static CaveGenerator()
	{
		Il2CppClassPointerStore<CaveGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CaveGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaveGenerator>.NativeClassPtr);
		NativeFieldInfoPtr_ENTRANCE_IDENTIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveGenerator>.NativeClassPtr, "ENTRANCE_IDENTIFIER");
		NativeMethodInfoPtr__ctor_Public_Void_IStructureManager_IIndoorLevelManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveGenerator>.NativeClassPtr, 100683735);
		NativeMethodInfoPtr_ShouldGenerate_Public_Virtual_Boolean_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveGenerator>.NativeClassPtr, 100683736);
		NativeMethodInfoPtr_Generate_Public_Virtual_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveGenerator>.NativeClassPtr, 100683737);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 269305, RefRangeEnd = 269306, XrefRangeStart = 269301, XrefRangeEnd = 269305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CaveGenerator(IStructureManager structureManager, IIndoorLevelManager indoorLevelManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaveGenerator>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)structureManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indoorLevelManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IStructureManager_IIndoorLevelManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe override bool ShouldGenerate(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShouldGenerate_Public_Virtual_Boolean_World_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269306, XrefRangeEnd = 269381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Generate(World world, Chunk chunk, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Generate_Public_Virtual_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public CaveGenerator(IntPtr pointer)
		: base(pointer)
	{
	}
}
