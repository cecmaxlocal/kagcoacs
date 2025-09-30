namespace kagcoacs;

public interface IActWriteLives : IActWrite
{
    new bool Equals(ActWrite other);
    new bool Equals(object other);
    new int GetHashCode();
    new string ToString();
}

public record ActWrite : IActWriteLives
{
    ActWrite IActWrite.Equals(ActWrite other)
    {
        var actWrite = new ActWrite(other);
        return actWrite;
    }
}

public record ActWriteImpl : ActWrite;