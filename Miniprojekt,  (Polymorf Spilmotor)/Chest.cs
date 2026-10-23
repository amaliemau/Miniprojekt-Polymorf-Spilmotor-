public class Chest : IInteractable
{

    public Rarity ChestRarity { get; set; }

    public bool IsOpened { get; set; }

    public int GoldAmount { get; set; }



    public Chest(Rarity chestRarity)
    {

        ChestRarity = chestRarity;
        IsOpened = false;
    }


    public void Interact(Player player)
    {
        if (IsOpened)
        {

            Console.WriteLine("The chest is already opened.");
            return;
        }


        GoldAmount = ChestRarity switch
        {
            Rarity.Common => 10,
            Rarity.Uncommon => 25,
            Rarity.Rare => 50,
            Rarity.Epic => 100,
            Rarity.Legendary => 250,
            _ => 0
        };

        IsOpened = true;

        player.AddGold(GoldAmount);
        Console.WriteLine($"You opened a {ChestRarity} chest and found {GoldAmount} gold!");

      

    }

    public string Description
    {
        get
        {
            return $"A {ChestRarity} chest";
        }
    }
}

public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}