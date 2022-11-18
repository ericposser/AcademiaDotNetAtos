namespace AulaTryGatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int x;
				Console.WriteLine("Informe um valor para x: ");
				x = int.Parse(Console.ReadLine());
				Console.WriteLine("o valor de x é: ");
				Console.WriteLine("O valor 50 dividido por " + x + " resulta em " + (50/x));
			}
			catch(DivideByZeroException)
			{
				Console.WriteLine("nao e possivel dividir por zero");
			}
			catch(FormatException)
			{
				Console.WriteLine("apenas numeros devem ser digitados");
			}
			catch (OverflowException)
			{
				Console.WriteLine("Numero muito grande");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				
			}
        }
    }
}