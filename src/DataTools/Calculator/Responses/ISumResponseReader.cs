namespace CarpeDiem.DataTools.Calculator.Responses;

public interface ISumResponseReader
{
    bool Succeeded { get; }
    int Result { get; }
    string Message { get; }
}