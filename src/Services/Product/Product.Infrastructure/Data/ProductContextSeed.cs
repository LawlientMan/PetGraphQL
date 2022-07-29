using MongoDB.Driver;
using Product.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Product.Infrastructure.Data
{
    internal class ProductContextSeed
    {
        private static readonly List<string> Genders = new List<string>() { "U","M","F"};

        public static void SeedData(IMongoDatabase database)
        {
            InsertStyles(database);
        }

        private static void InsertStyles(IMongoDatabase database)
        {
            IMongoCollection<Style> styleMongoCollection = database.GetCollection<Style>(nameof(Style));
            IMongoCollection<SKU> skuMongoCollection = database.GetCollection<SKU>(nameof(SKU));

            styleMongoCollection.DeleteMany(_ => true);
            skuMongoCollection.DeleteMany(_ => true);

            Random rand = new Random();
            List<Style> styles = new List<Style>();
            for (int i = 0; i < 10; i++)
            {
                Style style = new Style()
                {
                    StyleCode = "StyleCode" + i,
                    Name = "Name" + i,
                    Description = "Description" + i,
                    PdpUrl = "htpps://PdpUrl" + i,
                    Options = Enumerable.Range(0, rand.Next(0, 10)).Select(j =>
                        new Option()
                        {
                            Id = Guid.NewGuid(),
                            ColourCode = "ColourCode" + j,
                            ColourName = "ColourName" + j,
                            Gender = Genders[rand.Next(Genders.Count)],
                            CalculatedBulletPoints = Enumerable.Range(0, rand.Next(0, 10)).Select(i => rand.Next(100).ToString()).ToList()
                        }).ToList()
                };
                styles.Add(style);
            }
            styleMongoCollection.InsertMany(styles);

            foreach (Style item in styles)
            {
                foreach (Option option in item.Options)
                {
                    List<SKU> skus = Enumerable.Range(1, rand.Next(1, 5)).Select(i => new SKU()
                    {
                        OptionId = option.Id,
                        SkuId = option.Id+ "SkuId" + i,
                        Ean = option.Id + "Ean" + i,
                        Edp = option.Id + "Edp" + i
                    }).ToList();

                    skuMongoCollection.InsertMany(skus);
                }
            }
        }
    }
}
