using HelloWorld.ENums;

namespace HelloWorld;

public interface ISymbol
{
    ECharacters _c { get; }
    char ToChar();
    string Connect2Symbols(ISymbol c2);
}