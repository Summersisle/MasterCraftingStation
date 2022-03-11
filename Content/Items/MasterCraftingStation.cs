using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using MasterCraftingStation.Content.Tiles;

namespace MasterCraftingStation.Content.Items
{
	public class MasterCraftingStationItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Master Crafting Station");
			Tooltip.SetDefault("This is a modded workbench.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.createTile = ModContent.TileType<Tiles.MasterCraftingStation>(); // This sets the id of the tile that this item should place when used.

			Item.width = 28; // The item texture's width
			Item.height = 14; // The item texture's height

			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 10;
			Item.useAnimation = 15;

			Item.maxStack = 99;
			Item.consumable = true;
			Item.value = 150;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.WorkBench)
				.AddIngredient(ItemID.StoneBlock,10)
				.Register();
		}
	}
}