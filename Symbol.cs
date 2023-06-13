using HelloWorld.ENums;

namespace HelloWorld;

public class Symbol : ISymbol
{
    public Symbol(ECharacters c)
    {
        _c = c;
    }

    public ECharacters _c { get; private set; }


    public char ToChar()
    {
        return Convert.ToChar(_c.ToString());
    }

    public string Connect2Symbols(ISymbol c2)
    {
        return ToChar() + c2.ToChar().ToString();
    }

    public void ChangeCase(ECase _case)
    {
        if (_case == ECase.LOWERCASE)
        {
            _c = (ECharacters)Char.ToLower((char)_c);
        }
        else
        {
            _c = (ECharacters)Char.ToUpper((char)_c);
        }
    }
}