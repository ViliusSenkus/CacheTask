﻿namespace Application.DTOs.Requests;

public record CreatePairRequest
{
    public string Key { get; set; } = "";
    public List<object> Value { get; set; } = [];
    public int? ExpirationPeriodInSeconds { get; set; }
}
