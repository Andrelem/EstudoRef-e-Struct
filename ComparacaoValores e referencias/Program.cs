using static System.Console;

Numero a = new Numero(2);
Numero b = new Numero(2);

if (a.N == b.N)
{
    WriteLine("A e B sao iguais");
}
else
{
    WriteLine("Não sao iguais");
}

class Numero
{
    public int N { get; set; }
    
    public Numero(int n)
    {
        N = n;
    }
}