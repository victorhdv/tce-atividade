namespace Api.Exceptions;

[Serializable]
public class DivisaoZeroException : Exception
{
    public DivisaoZeroException() { }

    public DivisaoZeroException(string message)
        : base(message) { }

    public DivisaoZeroException(string message, Exception inner)
        : base(message, inner) { }
}