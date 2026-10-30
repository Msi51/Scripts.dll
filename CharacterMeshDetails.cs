using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class CharacterMeshDetails : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_baseMeshPieceIdentifierMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_pieceTypeVariantDataMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_pieceTypeDataMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemMeshPiecesMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshPieces;

	private static readonly System.IntPtr NativeFieldInfoPtr_variantDetailsMap;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<CharacterVariant, HashSet<string>> baseMeshPieceIdentifierMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseMeshPieceIdentifierMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterVariant, HashSet<string>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseMeshPieceIdentifierMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<CharacterMeshPieceType, Dictionary<CharacterVariant, List<CharacterMeshPieceData>>> pieceTypeVariantDataMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pieceTypeVariantDataMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterMeshPieceType, Dictionary<CharacterVariant, List<CharacterMeshPieceData>>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pieceTypeVariantDataMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<CharacterMeshPieceType, List<CharacterMeshPieceData>> pieceTypeDataMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pieceTypeDataMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterMeshPieceType, List<CharacterMeshPieceData>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pieceTypeDataMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, List<CharacterMeshPieceData>> itemMeshPiecesMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemMeshPiecesMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, List<CharacterMeshPieceData>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemMeshPiecesMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, CharacterMeshPieceData> meshPieces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshPieces);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, CharacterMeshPieceData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshPieces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<CharacterVariant, VariantDetails> variantDetailsMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantDetailsMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterVariant, VariantDetails>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantDetailsMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static CharacterMeshDetails()
	{
		Il2CppClassPointerStore<CharacterMeshDetails>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CharacterMeshDetails");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMeshDetails>.NativeClassPtr);
		NativeFieldInfoPtr_baseMeshPieceIdentifierMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeshDetails>.NativeClassPtr, "baseMeshPieceIdentifierMap");
		NativeFieldInfoPtr_pieceTypeVariantDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeshDetails>.NativeClassPtr, "pieceTypeVariantDataMap");
		NativeFieldInfoPtr_pieceTypeDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeshDetails>.NativeClassPtr, "pieceTypeDataMap");
		NativeFieldInfoPtr_itemMeshPiecesMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeshDetails>.NativeClassPtr, "itemMeshPiecesMap");
		NativeFieldInfoPtr_meshPieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeshDetails>.NativeClassPtr, "meshPieces");
		NativeFieldInfoPtr_variantDetailsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeshDetails>.NativeClassPtr, "variantDetailsMap");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeshDetails>.NativeClassPtr, 100668665);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96626, RefRangeEnd = 96627, XrefRangeStart = 96582, XrefRangeEnd = 96626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CharacterMeshDetails()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMeshDetails>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CharacterMeshDetails(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
