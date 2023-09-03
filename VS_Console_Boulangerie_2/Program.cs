namespace VS_Console_Boulangerie_Niv2
{
    public class Program
    {
        static void Main(string[] args)
        {

            //initialisation variables pour le total des ventes et le choix de l'utilisateur
            string userPick;

            Bakery bakery = new Bakery();
            Console.WriteLine("Bonjour,\nBienvenue dans l'application Backery mgmt app!");

            //démarrage de la boucle
            do
            {
                Console.WriteLine("Veuillez tapez le numéro de votre choix:\n1) vente: baguette\n2) vente: pain\n3) consulter le produit des ventes\n4) exit");
                userPick = Console.ReadLine();

                //
                switch (userPick)
                {
                    case "1":
                        bakery.SellBaguette();
                        break;

                    case "2":
                        bakery.SellBread();
                        break;

                    case "3":
                        Console.WriteLine($"Le total actuel des ventes s'élève à {Math.Round(bakery.GetCashRegisterAmount(), 2)} €\n\n");
                        break;

                    default:
                        break;
                }
            } while (userPick != "4");

            Console.WriteLine("Merci d'avoir utilisé BakeryMgmtApp!\nNous vous souhaitons une excellente journée!");

            //ajout d'un readLine pour laisser le temps de lecture avant exit
            Console.ReadLine();
        }
    }
}