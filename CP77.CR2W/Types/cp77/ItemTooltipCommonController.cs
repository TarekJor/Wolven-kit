using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipCommonController : AGenericTooltipController
	{
		[Ordinal(0)]  [RED("DEBUG_iconErrorText")] public inkTextWidgetReference DEBUG_iconErrorText { get; set; }
		[Ordinal(1)]  [RED("DEBUG_iconErrorWrapper")] public inkWidgetReference DEBUG_iconErrorWrapper { get; set; }
		[Ordinal(2)]  [RED("DEBUG_showAdditionalInfo")] public CBool DEBUG_showAdditionalInfo { get; set; }
		[Ordinal(3)]  [RED("backgroundContainer")] public inkWidgetReference BackgroundContainer { get; set; }
		[Ordinal(4)]  [RED("data")] public CHandle<MinimalItemTooltipData> Data { get; set; }
		[Ordinal(5)]  [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(6)]  [RED("descriptionWrapper")] public inkWidgetReference DescriptionWrapper { get; set; }
		[Ordinal(7)]  [RED("itemBottomContainer")] public inkWidgetReference ItemBottomContainer { get; set; }
		[Ordinal(8)]  [RED("itemBottomController")] public CHandle<ItemTooltipBottomModule> ItemBottomController { get; set; }
		[Ordinal(9)]  [RED("itemClothingInfoContainer")] public inkWidgetReference ItemClothingInfoContainer { get; set; }
		[Ordinal(10)]  [RED("itemClothingInfoController")] public CHandle<ItemTooltipClothingInfoModule> ItemClothingInfoController { get; set; }
		[Ordinal(11)]  [RED("itemCraftedContainer")] public inkWidgetReference ItemCraftedContainer { get; set; }
		[Ordinal(12)]  [RED("itemCraftedController")] public CHandle<ItemTooltipCraftedModule> ItemCraftedController { get; set; }
		[Ordinal(13)]  [RED("itemDetailsContainer")] public inkWidgetReference ItemDetailsContainer { get; set; }
		[Ordinal(14)]  [RED("itemDetailsController")] public CHandle<ItemTooltipDetailsModule> ItemDetailsController { get; set; }
		[Ordinal(15)]  [RED("itemEquippedContainer")] public inkWidgetReference ItemEquippedContainer { get; set; }
		[Ordinal(16)]  [RED("itemEquippedController")] public CHandle<ItemTooltipEquippedModule> ItemEquippedController { get; set; }
		[Ordinal(17)]  [RED("itemEvolutionContainer")] public inkWidgetReference ItemEvolutionContainer { get; set; }
		[Ordinal(18)]  [RED("itemEvolutionController")] public CHandle<ItemTooltipEvolutionModule> ItemEvolutionController { get; set; }
		[Ordinal(19)]  [RED("itemGrenadeInfoContainer")] public inkWidgetReference ItemGrenadeInfoContainer { get; set; }
		[Ordinal(20)]  [RED("itemGrenadeInfoController")] public CHandle<ItemTooltipGrenadeInfoModule> ItemGrenadeInfoController { get; set; }
		[Ordinal(21)]  [RED("itemHeaderContainer")] public inkWidgetReference ItemHeaderContainer { get; set; }
		[Ordinal(22)]  [RED("itemHeaderController")] public CHandle<ItemTooltipHeaderController> ItemHeaderController { get; set; }
		[Ordinal(23)]  [RED("itemIconContainer")] public inkWidgetReference ItemIconContainer { get; set; }
		[Ordinal(24)]  [RED("itemIconController")] public CHandle<ItemTooltipIconModule> ItemIconController { get; set; }
		[Ordinal(25)]  [RED("itemRecipeDataContainer")] public inkWidgetReference ItemRecipeDataContainer { get; set; }
		[Ordinal(26)]  [RED("itemRecipeDataController")] public CHandle<ItemTooltipRecipeDataModule> ItemRecipeDataController { get; set; }
		[Ordinal(27)]  [RED("itemRequirementsContainer")] public inkWidgetReference ItemRequirementsContainer { get; set; }
		[Ordinal(28)]  [RED("itemRequirementsController")] public CHandle<ItemTooltipRequirementsModule> ItemRequirementsController { get; set; }
		[Ordinal(29)]  [RED("itemWeaponInfoContainer")] public inkWidgetReference ItemWeaponInfoContainer { get; set; }
		[Ordinal(30)]  [RED("itemWeaponInfoController")] public CHandle<ItemTooltipWeaponInfoModule> ItemWeaponInfoController { get; set; }
		[Ordinal(31)]  [RED("requestedModules")] public CArray<CName> RequestedModules { get; set; }

		public ItemTooltipCommonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
