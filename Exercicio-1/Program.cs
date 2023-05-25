namespace Nova_pasta;
class Program
{
    static void Main(string[] args){
        Homem h = new Homem();
        Cao c = new Cao();
        Gato g = new Gato();

        Console.WriteLine("Homem - " + h.Fala());
        Console.WriteLine("Cão - " + c.Fala());
        Console.WriteLine("Gato - " + g.Fala());
    }
}
