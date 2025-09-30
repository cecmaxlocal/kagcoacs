namespace kagcoacs;

public record BufferFiles(ActWrite ThrowIfNegative)
{
    public void Deconstruct(out ActWrite throwIfNegative)
    {
        throwIfNegative = ThrowIfNegative;
    }
}

public class CatWrite(string s)
{
    public string S { get; } = s;
}

public interface ILives
{
    void LivesName()
    {
        LivesName(new CatWrite(null));
    }

    void LivesName(CatWrite catWrite);
    RunningObject InSee { get; set; }
    ActWrite InClassName1 { get; set; }
    ActWrite PopupBusiness { get; set; }
    ActWrite Popup { get; set; }
    ActWrite InClass { get; set; }
    Dynamic Master { get; set; }
}

public class RunningObject
{
}

public class EDialog(object name)
{
    public object Name = name;
}

public class DialogStatic(EDialog eDialog)
{
    public EDialog EDialog { get; set; } = eDialog;
}

public class Both(ActWriteLives master)
{
    public ActWriteLives Master { get; } = master;
}
