namespace CarpeDiem.DataTools.Calculator.Responses;

public interface ISumResponse
{
    bool Succeeded { get; set; }
    string Result { get; set; }
    string Value1Message { get; set; }
    string Value2Message { get; set; }
    string Message { get; set; }
}