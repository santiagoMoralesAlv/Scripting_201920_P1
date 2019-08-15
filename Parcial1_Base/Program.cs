using Parcial1_Base.Logic;
namespace Parcial1_Base
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //System.Console.ReadLine();
            PageantJury ConcursoPrueba = new PageantJury();

            Doll doll = new Doll("2Pac");
            Accessory vestido = new Dress(15,Dress.EColor.Black, Dress.EDressCategory.Casual);
            doll.Wear(vestido);
            Accessory accesorio = new Necklace(20000);
            doll.Wear(accesorio);
            doll.Remove(vestido);
            ConcursoPrueba.AddContestant(doll);

            doll = new Doll("Snoop Dog");
            accesorio = new Dress(10, Dress.EColor.White, Dress.EDressCategory.Suit);
            doll.Wear(accesorio);
            accesorio = new Necklace(60);
            doll.Wear(accesorio);
            accesorio = new Bracelet(160);
            doll.Wear(accesorio);
            ConcursoPrueba.AddContestant(doll);

            doll = new Doll("Mexicano 777");
            accesorio = new Dress(25, Dress.EColor.Pink, Dress.EDressCategory.Party);
            doll.Wear(accesorio);
            ConcursoPrueba.AddContestant(doll);

            doll = new Doll("El judio");
            accesorio = new Dress(5, Dress.EColor.Green, Dress.EDressCategory.Casual);
            doll.Wear(accesorio);
            accesorio = new Bracelet(700);
            doll.Wear(accesorio);
            ConcursoPrueba.AddContestant(doll);




            if (ConcursoPrueba.GetWinner() == null)
            {
                System.Console.WriteLine("Sin ganador");
            }
            else {
                System.Console.WriteLine("ganador = "+ ConcursoPrueba.GetWinner().Name);
            }

            System.Console.WriteLine("Pulse enter para salir");
            System.Console.ReadLine();
        }
    }
}