using System;
using AutoMapper;
using MachinaTrader.Globals.Structure.Models;
using MongoDB.Bson;

namespace MachinaTrader.Data.MongoDB
{
    public static class Mapping
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });

            config.AssertConfigurationIsValid();

            return config.CreateMapper();
        });

        public static IMapper Mapper => Lazy.Value;
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Trade, TradeAdapter>().ReverseMap().ForMember(x => x.PaperTrading, x => x.Ignore());

            CreateMap<CandleAdapter, Candle>().ReverseMap();

            CreateMap<TradeSignal, TradeSignalAdapter>().ReverseMap();
            //CreateMap<TradeSignalAdapter, TradeSignal>();

            CreateMap<WalletTransaction, WalletTransactionAdapter>().ReverseMap();
        }
    }
}
