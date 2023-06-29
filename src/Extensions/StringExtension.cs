namespace HelloWorld;

public static class StringExtension
{
    public static unsafe string Mutate(this string self, string value)
    {
        fixed (char* selfPtr = self)
        {
            value.AsSpan().CopyTo(new Span<char>(selfPtr, self.Length));
            int* l = (int*)selfPtr;
            l[-1] = value.Length;
        }

        return self;
    }
}