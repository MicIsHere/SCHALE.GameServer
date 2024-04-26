// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RecipeSelectionGroupExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static RecipeSelectionGroupExcel GetRootAsRecipeSelectionGroupExcel(ByteBuffer _bb) { return GetRootAsRecipeSelectionGroupExcel(_bb, new RecipeSelectionGroupExcel()); }
  public static RecipeSelectionGroupExcel GetRootAsRecipeSelectionGroupExcel(ByteBuffer _bb, RecipeSelectionGroupExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RecipeSelectionGroupExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long RecipeSelectionGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RecipeSelectionGroupComponentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType ParcelType { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long ParcelId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ResultAmountMin { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ResultAmountMax { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.RecipeSelectionGroupExcel> CreateRecipeSelectionGroupExcel(FlatBufferBuilder builder,
      long RecipeSelectionGroupId = 0,
      long RecipeSelectionGroupComponentId = 0,
      SCHALE.Common.FlatData.ParcelType ParcelType = SCHALE.Common.FlatData.ParcelType.None,
      long ParcelId = 0,
      long ResultAmountMin = 0,
      long ResultAmountMax = 0) {
    builder.StartTable(6);
    RecipeSelectionGroupExcel.AddResultAmountMax(builder, ResultAmountMax);
    RecipeSelectionGroupExcel.AddResultAmountMin(builder, ResultAmountMin);
    RecipeSelectionGroupExcel.AddParcelId(builder, ParcelId);
    RecipeSelectionGroupExcel.AddRecipeSelectionGroupComponentId(builder, RecipeSelectionGroupComponentId);
    RecipeSelectionGroupExcel.AddRecipeSelectionGroupId(builder, RecipeSelectionGroupId);
    RecipeSelectionGroupExcel.AddParcelType(builder, ParcelType);
    return RecipeSelectionGroupExcel.EndRecipeSelectionGroupExcel(builder);
  }

  public static void StartRecipeSelectionGroupExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddRecipeSelectionGroupId(FlatBufferBuilder builder, long recipeSelectionGroupId) { builder.AddLong(0, recipeSelectionGroupId, 0); }
  public static void AddRecipeSelectionGroupComponentId(FlatBufferBuilder builder, long recipeSelectionGroupComponentId) { builder.AddLong(1, recipeSelectionGroupComponentId, 0); }
  public static void AddParcelType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType parcelType) { builder.AddInt(2, (int)parcelType, 0); }
  public static void AddParcelId(FlatBufferBuilder builder, long parcelId) { builder.AddLong(3, parcelId, 0); }
  public static void AddResultAmountMin(FlatBufferBuilder builder, long resultAmountMin) { builder.AddLong(4, resultAmountMin, 0); }
  public static void AddResultAmountMax(FlatBufferBuilder builder, long resultAmountMax) { builder.AddLong(5, resultAmountMax, 0); }
  public static Offset<SCHALE.Common.FlatData.RecipeSelectionGroupExcel> EndRecipeSelectionGroupExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.RecipeSelectionGroupExcel>(o);
  }
}


static public class RecipeSelectionGroupExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*RecipeSelectionGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*RecipeSelectionGroupComponentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*ParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*ResultAmountMin*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*ResultAmountMax*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}