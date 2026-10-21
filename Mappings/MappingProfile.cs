using AutoMapper;

using OnboardingApi.Models;

using OnboardingApi.DTOs.Personal;
using OnboardingApi.DTOs.Address;
using OnboardingApi.DTOs.Onboarding;

namespace OnboardingApi.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Personal
        CreateMap<CreatePersonalDto, Personal>();
        CreateMap<UpdatePersonalDto, Personal>();
        CreateMap<Personal, PersonalResponseDto>();

        // Address
        CreateMap<CreateAddressDto, Address>();
        CreateMap<UpdateAddressDto, Address>();
        CreateMap<Address, AddressResponseDto>();

        // Onboarding
        CreateMap<CreateOnboardingDto, Onboarding>();
        CreateMap<UpdateOnboardingDto, Onboarding>();
        CreateMap<Onboarding, OnboardingResponseDto>();
    }
}