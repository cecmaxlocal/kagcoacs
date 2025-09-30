namespace kagcoacs;

public interface IActWrite
{
    ActWrite Equals(ActWrite other);
    public bool Equals(object other);
    public int GetHashCode();
    public string ToString();
}