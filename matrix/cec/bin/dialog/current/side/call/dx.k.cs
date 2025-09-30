namespace kagcoacs
{
    public class InRunning(InClass master, RunningObject inSee, InSee name)
    {
        public InClass Master { get; set; } = master;

        public RunningObject InSee { get; set; } = inSee;

        public InSee Name { get; set; } = name;
    }

    public class String(string name)
    {
        public string Name { get; set; } = name;
    }

    public partial record Lives
    {
        public static string NameLives => null;
    }

    public class InClassNameImpl : DxLives;

    public class InKids(ActWrite popup)
    {
        public ActWrite Popup { get; set; } = popup;
    }

    public abstract partial record Lives : ActWrite
    {
        public InClassLives InClassName => null;


        /*
         * is a C# method declaration with some advanced modifiers combined:
         *
         *  private protected: This access modifier means the method is accessible only within its declaring
         *  class or types derived from the declaring class, but only if they are in the same assembly.
         *
         *  virtual: This method can be overridden by derived classes to provide a different implementation.
         *
         *  partial: The method can have its definition split across multiple parts of a partial class or struct.
         *  Partial methods must be void and cannot have out parameters. However, according to the standard C# rules,
         *  partial methods generally cannot be virtual or have access modifiers, but starting from newer versions of
         *  C# (like C# 9 and later), partial methods can have access modifiers and can be declared virtual in partial
         *  classes.
         *
         *  void: The method does not return a value.
         *
         *  The method takes a parameter of type TDialogLives.
         *
         *  The method body uses an expression body syntax to immediately throw a NotImplementedException, indicating
         *  that the method has not yet been implemented and serves as a placeholder.
         *
         *  In sum, this line declares a method ThrowObjNow which is intended to be potentially overridden and implemented
         *  in parts of a partial class, but currently throws an exception indicating it's not implemented. The method's
         *  scope is limited to within the assembly and derived classes only. This combination is useful when designing
         *  extensible libraries with partial classes and a mix of accessibility for method implementation separation.
         *
         *  The "throw new NotImplementedException();" is a common placeholder used when a method's body is not yet written,
         *  which throws an exception if called to indicate that the intended functionality is missing.
         *
         *
         */
        protected abstract void ObjNow ();
    }

    public class InClassLives
    {
    }

    public class ObjNow;

    public interface IM2Lives;

    public class M2BaseLives : IM2Lives;

    public class M2 : M2BaseLives;

    public class InSee(InClass inClassName)
    {
        protected InClass InClassName = inClassName;
    }

    public class InClass;

    public class Stat(ActWrite popupText)
    {
        public ActWrite PopupText { get; } = popupText;
    }

    public class InPopup(ActWrite inSee, ActWrite writeScript)
    {
        public ActWrite See { get; } = inSee;
        public ActWrite InSeeLives { get; set; } = inSee;

        public ActWrite WriteScript { get; set; } = writeScript;
    }

    public abstract class RunningObjectTable
    {
        public abstract RunningObject InSee { get; set; }
        public abstract InSee Name { get; set; }
        public abstract ActWrite InClassName1 { get; set; }
        public abstract ActWrite PopupBusiness { get; set; }
        public abstract ActWrite Popup { get; set; }
        public abstract ActWrite InClass { get; set; }
        public abstract Dynamic Master { get; set; }
        public ActWrite PopupText;

    }
}

namespace System
{
    public class Dynamic;
}