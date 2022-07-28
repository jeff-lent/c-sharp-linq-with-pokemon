using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class SpecialAttackS{
    [JsonPropertyName("Name")]
    public string? name {get; set;}
    [JsonPropertyName("Type")]
    public string? type {get; set;}
    public int damage {get; set;}
    public Dictionary<string, Object> additionalProperties = new Dictionary<string,Object>();
}