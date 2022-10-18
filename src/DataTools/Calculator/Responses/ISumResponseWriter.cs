namespace CarpeDiem.DataTools.Calculator.Responses;

public interface ISumResponseWriter
{
    bool Succeeded { set; }
    int Result { set; }
    string Message { set; }
}