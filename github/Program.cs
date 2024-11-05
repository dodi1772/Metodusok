namespace github
{
	internal class Program
	{
		static void Main(string[] args)
		{
			osszeadas(3,7);
			Console.WriteLine(Duplaz(3));
			int elso = 5;
			int masodik = 10;
			Csere(ref elso, ref masodik);
            Console.WriteLine(elso+" "+masodik);
        }
		static int osszeadas(int a, int b)
		{
			return a + b;
		}
		static int Duplaz(int szam)
		{
			szam = szam * 2;
			return szam;
		}
		static void Csere(ref int a,ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
	}
}
