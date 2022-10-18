namespace CarpeDiem.DataTools.Calculator.Responses;

public class SumResponse : ISumResponse
{
    public bool Succeeded { get; set; }

    public int Result { get; set; }

    public string Message { get; set; } = default!;
}