using System.Windows.Forms;

namespace FirstGame
{
    class Physics
    {

        public bool IsCollide(Player player, MapChanges map, Label scoreLabel)
        {
            var isColliding = false;
            if ((player.ballX / 20) + player.directionX > MapChanges.mapWidth - 1 || (player.ballX / 20) + player.directionX < 0)
            {
                player.directionX *= -1;
                isColliding = true;
            }
            if ((player.ballY / 20) + player.directionY < 0)
            {
                player.directionY *= -1;
                isColliding = true;
            }

            if (map.map[(player.ballY / 20) + player.directionY, player.ballX / 20] != 0)
            {
                var addScore = false;
                isColliding = true;

                if (map.map[(player.ballY / 20) + player.directionY, player.ballX / 20] > 10 && map.map[(player.ballY / 20) + player.directionY, player.ballX / 20] < 99)
                {
                    map.map[(player.ballY / 20) + player.directionY, player.ballX / 20] = 0;
                    map.map[(player.ballY / 20) + player.directionY, (player.ballX / 20) - 1] = 0;
                    addScore = true;
                }
                else if (map.map[(player.ballY / 20) + player.directionY, player.ballX / 20] < 9)
                {
                    map.map[(player.ballY / 20) + player.directionY, player.ballX / 20] = 0;
                    map.map[(player.ballY / 20) + player.directionY, (player.ballX / 20) + 1] = 0;
                    addScore = true;
                }
                if (addScore)
                {
                    player.score += 50;
                    if (player.score % 200 == 0 && player.score > 0)
                    {
                        map.AddLine();
                    }
                }
                player.directionY *= -1;
            }
            if (map.map[player.ballY / 20, (player.ballX / 20) + player.directionX] != 0)
            {
                var addScore = false;
                isColliding = true;

                if (map.map[player.ballY / 20, (player.ballX / 20) + player.directionX] > 10 && map.map[(player.ballY / 20) + player.directionY, player.ballX / 20] < 99)
                {
                    map.map[player.ballY / 20, (player.ballX / 20) + player.directionX] = 0;
                    map.map[player.ballY / 20, (player.ballX / 20) + player.directionX - 1] = 0;
                    addScore = true;
                }
                else if (map.map[player.ballY / 20, (player.ballX / 20) + player.directionX] < 9)
                {
                    map.map[player.ballY / 20, (player.ballX / 20) + player.directionX] = 0;
                    map.map[player.ballY / 20, (player.ballX / 20) + player.directionX + 1] = 0;
                    addScore = true;
                }
                if (addScore)
                {
                    player.score += 50;
                    if (player.score % 200 == 0 && player.score > 0)
                    {
                        map.AddLine();
                    }
                }
                player.directionX *= -1;
            }
            scoreLabel.Text = $"Score: {player.score}";

            return isColliding;
        }

    }
}
