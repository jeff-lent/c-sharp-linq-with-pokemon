using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Weight{
    [JsonPropertyName("Minimum")]
    public string? minimum {get; set;}
    [JsonPropertyName("Maximum")]
    public string? maximum {get; set;}
    public Dictionary<string, Object> additionalProperties = new Dictionary<string,Object>();
}