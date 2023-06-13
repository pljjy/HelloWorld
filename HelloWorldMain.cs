namespace HelloWorld;
using ENums;
internal class HelloWorldMain
{
    public static void Main(string[] args)
    {
        ISymbol symbol1 = new Symbol(ECharacters.H);
        Symbol symbol2 = new Symbol(ECharacters.E);
        Symbol symbol3 = new Symbol(ECharacters.L);
        Symbol symbol4 = new Symbol(ECharacters.O);
        ISymbol symbol5 = new Symbol(ECharacters.COMMA);
        ISymbol symbol6 = new Symbol(ECharacters.SPACE);
        ISymbol symbol7 = new Symbol(ECharacters.W);
        Symbol symbol8 = new Symbol(ECharacters.R);
        Symbol symbol9 = new Symbol(ECharacters.D);

        symbol2.ChangeCase(ECase.LOWERCASE);
        symbol3.ChangeCase(ECase.LOWERCASE);
        symbol4.ChangeCase(ECase.LOWERCASE);
        symbol8.ChangeCase(ECase.LOWERCASE);
        symbol9.ChangeCase(ECase.LOWERCASE);

        string He = symbol1.Connect2Symbols(symbol2);
        string ll = symbol3.Connect2Symbols(symbol3);
        string oComma = symbol4.Connect2Symbols(symbol5);
        string spaceW = symbol6.Connect2Symbols(symbol7);
        string or = symbol4.Connect2Symbols(symbol8);
        string ld = symbol3.Connect2Symbols(symbol9);

        string[] HelloWorld = new string[6]
        {
            He,
            ll,
            oComma,
            spaceW,
            or,
            ld
        };

        unsafe
        {
            fixed (string* ptrToArray = &HelloWorld[0])
            {
                for (int i = 0; i < HelloWorld.Length; i++)
                {
                    Console.Write(*(ptrToArray+i));
                }
            }
        }

    }
}