using System;

namespace Paterns.Models
{
    public class Lavash : BakedGoodsBuilder
    {
        public override void AddFlour()
        {
            BakedGoods.flour = new Flour() { Name = "Flour for lavash" };
        }

        public override void AddWater()
        {
            BakedGoods.water = new WaterForBakedGoods() { Name = "Water for lavash" };
        }

        public override void AddSalt()
        {
            BakedGoods.salt = new Salt() { Name = "Salt for lavash" };
        }

        public override void AddYeast()
        {
            BakedGoods.yeast = new Yeast() { Name = "Yeast for lavash" };
        }
    }

    public class Loaf : BakedGoodsBuilder
    {
        public override void AddFlour()
        {
            BakedGoods.flour = new Flour() { Name = "Flour for loaf" };
        }

        public override void AddWater()
        {
            BakedGoods.water = new WaterForBakedGoods() { Name = "Water for loaf" };
        }

        public override void AddSalt()
        {
            BakedGoods.salt = new Salt() { Name = "Salt for loaf" };
        }

        public override void AddYeast()
        {
            BakedGoods.yeast = new Yeast() { Name = "Yeast for loaf" };
        }
    }

    public class Bread : BakedGoodsBuilder
    {
        public override void AddFlour()
        {
            BakedGoods.flour = new Flour() { Name = "Flour for bread" };
        }

        public override void AddWater()
        {
            BakedGoods.water = new WaterForBakedGoods() { Name = "Water for bread" };
        }

        public override void AddSalt()
        {
            BakedGoods.salt = new Salt() { Name = "Salt for bread" };
        }

        public override void AddYeast()
        {
            BakedGoods.yeast = new Yeast() { Name = "Yeast for bread" };
        }
    }

    public class Baker
    {
        public BakedGoods MakeBakedGoods(BakedGoodsBuilder builder)
        {
            builder.CreateBakedGoods();
            builder.AddFlour();
            builder.AddWater();
            builder.AddSalt();
            builder.AddYeast();

            return builder.BakedGoods;
        }
    }

    public abstract class BakedGoodsBuilder
    {
        public BakedGoods BakedGoods { get; set; }
        public void CreateBakedGoods()
        {
            BakedGoods = new BakedGoods();
        }

        public abstract void AddFlour();
        public abstract void AddWater();
        public abstract void AddSalt();
        public abstract void AddYeast();
    }

    public class BakedGoods
    {
        public Flour flour { get; set; }
        public WaterForBakedGoods water { get; set; }
        public Salt salt { get; set; }
        public Yeast yeast { get; set; }

        public override string ToString()
        {
            string result = flour.Name + Environment.NewLine +
                    water.Name + Environment.NewLine +
                    salt.Name + Environment.NewLine +
                    yeast.Name + Environment.NewLine;
            return result;
        }
    }

    public class Flour
    {
        public string Name { get; set; }
    }

    public class WaterForBakedGoods
    {
        public string Name { get; set; }
    }

    public class Salt
    {
        public string Name { get; set; }
    }

    public class Yeast
    {
        public string Name { get; set; }
    }

    public class Bakery
    {
        
    }
}