namespace kagcoacs;

/// <inheritdoc cref="get_Instance" />
public class DxLives
{
    protected DxLives()
    {
        _ = new NetPipeStyleUriParser();
    }

    public string WeakReference { get; set; }

    public static Dx Instance1 { get; set; } = new();

    public static Dx Instance { get; set; } = Instance1;
}

public record struct Dx
{
}
