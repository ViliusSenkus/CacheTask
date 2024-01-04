﻿namespace Application.DTOs.Responses;

public record CreatePairResponse
{
    public string Key { get; set; } = "";
    public List<object> Value { get; set; } = [];
    public DateTime ExpiresAt { get; set; }
    public int? ExpirationPeriodInSeconds { get; set; }
}
