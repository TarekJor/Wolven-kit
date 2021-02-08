using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EffectSharedDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("angle")] public gamebbScriptID_Float Angle { get; set; }
		[Ordinal(1)]  [RED("attack")] public gamebbScriptID_Variant Attack { get; set; }
		[Ordinal(2)]  [RED("attackData")] public gamebbScriptID_Variant AttackData { get; set; }
		[Ordinal(3)]  [RED("attackId")] public gamebbScriptID_Variant AttackId { get; set; }
		[Ordinal(4)]  [RED("attackNumber")] public gamebbScriptID_Int32 AttackNumber { get; set; }
		[Ordinal(5)]  [RED("attackStatModList")] public gamebbScriptID_Variant AttackStatModList { get; set; }
		[Ordinal(6)]  [RED("box")] public gamebbScriptID_Vector4 Box { get; set; }
		[Ordinal(7)]  [RED("charge")] public gamebbScriptID_Float Charge { get; set; }
		[Ordinal(8)]  [RED("debugBool")] public gamebbScriptID_Bool DebugBool { get; set; }
		[Ordinal(9)]  [RED("dotCycleDuration")] public gamebbScriptID_Float DotCycleDuration { get; set; }
		[Ordinal(10)]  [RED("dotLastApplicationTime")] public gamebbScriptID_Float DotLastApplicationTime { get; set; }
		[Ordinal(11)]  [RED("duration")] public gamebbScriptID_Float Duration { get; set; }
		[Ordinal(12)]  [RED("effectName")] public gamebbScriptID_String EffectName { get; set; }
		[Ordinal(13)]  [RED("effectorRecordName")] public gamebbScriptID_String EffectorRecordName { get; set; }
		[Ordinal(14)]  [RED("enable")] public gamebbScriptID_Bool Enable { get; set; }
		[Ordinal(15)]  [RED("entity")] public gamebbScriptID_EntityPtr Entity { get; set; }
		[Ordinal(16)]  [RED("fallback_weaponPierce")] public gamebbScriptID_Bool Fallback_weaponPierce { get; set; }
		[Ordinal(17)]  [RED("fallback_weaponPierceChargeLevel")] public gamebbScriptID_Float Fallback_weaponPierceChargeLevel { get; set; }
		[Ordinal(18)]  [RED("flags")] public gamebbScriptID_Variant Flags { get; set; }
		[Ordinal(19)]  [RED("forceVisionAppearanceData")] public gamebbScriptID_Variant ForceVisionAppearanceData { get; set; }
		[Ordinal(20)]  [RED("forward")] public gamebbScriptID_Vector4 Forward { get; set; }
		[Ordinal(21)]  [RED("fxPackage")] public gamebbScriptID_Variant FxPackage { get; set; }
		[Ordinal(22)]  [RED("fxResource")] public gamebbScriptID_Variant FxResource { get; set; }
		[Ordinal(23)]  [RED("highlightPriority")] public gamebbScriptID_Int32 HighlightPriority { get; set; }
		[Ordinal(24)]  [RED("highlightType")] public gamebbScriptID_Int32 HighlightType { get; set; }
		[Ordinal(25)]  [RED("highlightedTargets")] public gamebbScriptID_Variant HighlightedTargets { get; set; }
		[Ordinal(26)]  [RED("hitCooldown")] public gamebbScriptID_Float HitCooldown { get; set; }
		[Ordinal(27)]  [RED("impactOrientationSlot")] public gamebbScriptID_CName ImpactOrientationSlot { get; set; }
		[Ordinal(28)]  [RED("infiniteDuration")] public gamebbScriptID_Bool InfiniteDuration { get; set; }
		[Ordinal(29)]  [RED("maxPathLength")] public gamebbScriptID_Float MaxPathLength { get; set; }
		[Ordinal(30)]  [RED("meleeCleave")] public gamebbScriptID_Bool MeleeCleave { get; set; }
		[Ordinal(31)]  [RED("minRayAngleDiff")] public gamebbScriptID_Float MinRayAngleDiff { get; set; }
		[Ordinal(32)]  [RED("muzzlePosition")] public gamebbScriptID_Vector4 MuzzlePosition { get; set; }
		[Ordinal(33)]  [RED("outlineType")] public gamebbScriptID_Int32 OutlineType { get; set; }
		[Ordinal(34)]  [RED("playerOwnedWeapon")] public gamebbScriptID_Bool PlayerOwnedWeapon { get; set; }
		[Ordinal(35)]  [RED("position")] public gamebbScriptID_Vector4 Position { get; set; }
		[Ordinal(36)]  [RED("projectileHitEvent")] public gamebbScriptID_Variant ProjectileHitEvent { get; set; }
		[Ordinal(37)]  [RED("radius")] public gamebbScriptID_Float Radius { get; set; }
		[Ordinal(38)]  [RED("range")] public gamebbScriptID_Float Range { get; set; }
		[Ordinal(39)]  [RED("raycastEnd")] public gamebbScriptID_Vector4 RaycastEnd { get; set; }
		[Ordinal(40)]  [RED("renderMaterialOverride")] public gamebbScriptID_Bool RenderMaterialOverride { get; set; }
		[Ordinal(41)]  [RED("rotation")] public gamebbScriptID_Quaternion Rotation { get; set; }
		[Ordinal(42)]  [RED("slotName")] public gamebbScriptID_CName SlotName { get; set; }
		[Ordinal(43)]  [RED("statType")] public gamebbScriptID_Int32 StatType { get; set; }
		[Ordinal(44)]  [RED("statusEffect")] public gamebbScriptID_Variant StatusEffect { get; set; }
		[Ordinal(45)]  [RED("stimType")] public gamebbScriptID_Int32 StimType { get; set; }
		[Ordinal(46)]  [RED("stimuliAxisConstraints")] public gamebbScriptID_Vector4 StimuliAxisConstraints { get; set; }
		[Ordinal(47)]  [RED("stimuliAxisFilter")] public gamebbScriptID_Bool StimuliAxisFilter { get; set; }
		[Ordinal(48)]  [RED("stimuliConeFilter")] public gamebbScriptID_Bool StimuliConeFilter { get; set; }
		[Ordinal(49)]  [RED("stimuliEvent")] public gamebbScriptID_Variant StimuliEvent { get; set; }
		[Ordinal(50)]  [RED("stimuliNavigationTest")] public gamebbScriptID_Bool StimuliNavigationTest { get; set; }
		[Ordinal(51)]  [RED("stimuliRaycastTest")] public gamebbScriptID_Bool StimuliRaycastTest { get; set; }
		[Ordinal(52)]  [RED("targetComponent")] public gamebbScriptID_Variant TargetComponent { get; set; }
		[Ordinal(53)]  [RED("targets")] public gamebbScriptID_Variant Targets { get; set; }
		[Ordinal(54)]  [RED("value")] public gamebbScriptID_Float Value { get; set; }

		public EffectSharedDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
