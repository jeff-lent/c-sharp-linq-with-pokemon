using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class NextEvolutionRequirements{
    [JsonPropertyName("Amount")]
    public int amount {get; set;}
    [JsonPropertyName("Name")]
    public string? name {get; set;}
    public Dictionary<string, Object> additionalProperties = new Dictionary<string,Object>();
}