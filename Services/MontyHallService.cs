using MontyHallApp.Model;

namespace MontyHallApp.Services
{
    public class MontyHallService
    {
        public MontyHallModel Simulate(int numberOfGames, bool switchDoor)
        {
            int wins = 0;
            Random random = new Random();

            for (int i = 0; i < numberOfGames; i++)
            {
                int carDoor = random.Next(3);
                int choosenDoor = random.Next(3);

                //If switch the door
                if (switchDoor)
                {
                    //Win if initially doesn't pick the car door
                    if (choosenDoor != carDoor)
                    {
                        wins++;
                    }
                }
                //If doesn't switch the door
                else
                {
                    //Win if initially picke the car door
                    if (choosenDoor == carDoor)
                    {
                        wins++;
                    }
                }
            }

            return new MontyHallModel
            {
                TotalGames = numberOfGames,
                Wins = wins,
                Losses = numberOfGames - wins
            };
        }
    }
}

