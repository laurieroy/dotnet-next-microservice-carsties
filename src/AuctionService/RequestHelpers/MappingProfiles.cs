﻿using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelpers;

public class MappingProfiles: Profile
{
public MappingProfiles()
{
    CreateMap<Auction, AuctionDTO>().IncludeMembers(x => x.Item);
    CreateMap<AuctionDTO, Auction>();
    CreateMap<CreateAuctionDTO, Auction>().ForMember(d => d.Item, o=>o.MapFrom(s => s));
    CreateMap<AuctionDTO, Item>();
}
}
