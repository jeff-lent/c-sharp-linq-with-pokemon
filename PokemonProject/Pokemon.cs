using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Pokemon {
    [JsonPropertyName("Number")]
    public string? number {get;set;}
    [JsonPropertyName("Name")]
    public string? name {get;set;}
    [JsonPropertyName("Generation")]
    public string? generation {get;set;}
    [JsonPropertyName("About")]
    public string? about {get;set;}
    [JsonPropertyName("Types")]
    public List<string>? types  {get;set;}
    [JsonPropertyName("Resistant")]
    public List<string>? resistant  {get;set;}
    [JsonPropertyName("Weaknesses")]
    public List<string>? weaknesses  {get;set;}
    [JsonPropertyName("Fast Attack(s)")]
    public List<FastAttackS>? fastAttackS  {get;set;}
    [JsonPropertyName("Special Attack(s)")]
    public List<SpecialAttackS>? specialAttackS  {get;set;}
    [JsonPropertyName("Weight")]
    public Weight? weight {get;set;}
    [JsonPropertyName("Height")]
    public Height? height {get;set;}
    [JsonPropertyName("Buddy Distance")]
    public string? buddyDistance {get;set;}
    [JsonPropertyName("Base Stamina")]
    public string? baseStamina {get;set;}
    [JsonPropertyName("Base Attack")]
    public string? baseAttack {get;set;}
    [JsonPropertyName("Base Defense")]
    public string? baseDefense {get;set;}
    [JsonPropertyName("Base Flee Rate")]
    public string? baseFleeRate {get;set;}
    [JsonPropertyName("Next Evolution Requirements")]
    public NextEvolutionRequirements? nextEvolutionRequirements {get;set;}
    [JsonPropertyName("Next evolution(s)")]
    public List<NextEvolutionS>? nextEvolutionS  {get;set;}
    [JsonPropertyName("MaxCP")]
    public int maxCP {get;set;}
    [JsonPropertyName("MaxHP")]
    public int maxHP {get;set;}
    public Dictionary<string, Object> additionalProperties = new Dictionary<string, Object>();
}