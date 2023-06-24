MyClass myObj = new MyClass();

//Console.WriteLine(myObj.privateMember);

//Console.WriteLine(myObj.protectedMember);

Console.WriteLine(myObj.internalMember);

Console.WriteLine(myObj.publicMember);



public class MyClass
{
    private int privateMember = 10;
    protected int protectedMember = 20;
    internal int internalMember = 30;
    public int publicMember = 40;
}
