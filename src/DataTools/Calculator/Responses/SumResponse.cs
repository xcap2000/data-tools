namespace CarpeDiem.DataTools.Calculator.Responses;

public class SumResponse : ISumResponse
{
    public bool Succeeded { get; set; }
    public string Result { get; set; } = "";
    public string Message { get; set; } = "";
    public string Value1Message { get; set; } = "";
    public string Value2Message { get; set; } = "";
}