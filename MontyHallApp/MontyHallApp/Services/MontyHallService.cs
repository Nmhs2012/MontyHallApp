using MontyHallApp.Model;

namespace MontyHallApp.Services
{
    public class MontyHallService
    {
        public MontyHallSimulationResults Simulate(int numberOfGames, bool switchDoor)
        {
            int wins = 0;
            bool isWin = false;
            Random random = new Random();
            List<GameResult> gameResults = new List<GameResult>();

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
                        isWin = true;
                    }
                }
                //If doesn't switch the door
                else
                {
                    //Win if initially picke the car door
                    if (choosenDoor == carDoor)
                    {
                        wins++;
                        isWin = true;
                    }
                }

                var result = new GameResult
                {
                    CarDoor = carDoor,
                    ChoosenDoor = choosenDoor,
                    SwitchDoor = switchDoor,
                    Win = isWin
                };

                gameResults.Add(result);
            }

            var summary = new MontyHallModel
                {
                    TotalGames = numberOfGames,
                    Wins = wins,
                    Losses = numberOfGames - wins,
                    WinPercentage = (double)wins / numberOfGames * 100
        };
            

            return new MontyHallSimulationResults
            {
                Summary = summary,
                GameResults = gameResults
            };
        }
    }
}

