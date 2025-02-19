﻿using System.Text.Json.Serialization;

namespace Contracts.DTOs
{
    public class CustomerInfo
    {
        [JsonIgnore]
        public string UserId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyImagePath { get; set; }
        public string RepresentativeName { get; set; }
        public string RepresentativeImagePath { get; set; }
        public string ContactInfo { get; set; }
        public AddressInfo JuridicalAddress { get; set; }
        public AddressInfo[] DeliveryAddresses { get; set; }
    }
}
