namespace VS_Console_Boulangerie_Niv2
{
    public class Program
    {
        private enum UserChoice
        {
            SELL_BAGUETTE = 1,
            SELL_BREAD = 2,
            GET_CASH_AMOUNT = 3,
            QUIT = 4,
            UNASSIGNED
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //initialisation variables pour le total des ventes et le choix de l'utilisateur
            string userPick;

            Bakery bakery = new Bakery();
            Console.WriteLine("Bonjour,\nBienvenue dans l'application Backery mgmt app!");

            UserChoice userChoice = UserChoice.UNASSIGNED;

            //démarrage de la boucle
            do
            {
                Console.WriteLine("Veuillez tapez le numéro de votre choix:\n1) vente: baguette\n2) vente: pain\n3) consulter le produit des ventes\n4) exit");
                userPick = Console.ReadLine();
                if (Enum.TryParse(userPick, out userChoice))
                {
                    switch (userChoice)
                    {
                        case UserChoice.SELL_BAGUETTE:
                            bakery.SellBaguette();
                            break;

                        case UserChoice.SELL_BREAD:
                            bakery.SellBread();
                            break;

                        case UserChoice.GET_CASH_AMOUNT:
                            Console.WriteLine($"Le total actuel des ventes s'élève à {Math.Round(bakery.GetCashRegisterAmount(), 2)} €\n\n");
                            break;

                        case UserChoice.QUIT:
                            Console.WriteLine("Merci d'avoir utilisé BakeryMgmtApp!\nNous vous souhaitons une excellente journée!");
                            //ajout d'un readLine pour laisser le temps de lecture avant exit
                            Console.ReadLine();
                            Environment.Exit(1);
                            break;
                    }
                }
            } while (true);
        }
    }
}