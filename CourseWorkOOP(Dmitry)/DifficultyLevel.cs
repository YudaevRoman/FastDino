
namespace CourseWorkOOP_Dmitry_
{
    //Перечисления
    [System.Serializable()]
    public enum Difficulty { MANUAL, EASY, NORMAL, COMPLEX }

    //Класс Уровня Сложности
    [System.Serializable()]
    public class DifficultyLevel
    {
        //Поля
        private Difficulty currentDifficulty;
        private int maxSpawnDelay;
        private int minSpawnDelay;
        private int accelerationDelay;


        //Свойства
        public int MaxSpawnDelay 
        {
            get { return maxSpawnDelay; }
            set
            {
                if (value <= 0) maxSpawnDelay = 1;
                else maxSpawnDelay = value;
            }
        }
        public int MinSpawnDelay
        {
            get { return minSpawnDelay; }
            set
            {
                if (value <= 0) minSpawnDelay = 1;
                else minSpawnDelay = value;
            }
        }
        public int AccelerationDelay
        {
            get { return accelerationDelay; }
            set
            {
                if (value <= 0) accelerationDelay = 1;
                else accelerationDelay = value;
            }
        }
        public Difficulty CurrentDifficulty 
        {
            get { return currentDifficulty; }
            set
            {
                currentDifficulty = value;
                switch (value)
                {
                    default:
                        {
                            SetDifficulty(0, 0, 0);
                            break;
                        }
                    case Difficulty.EASY:
                        {
                            SetDifficulty(
                                10_000, //млс 
                                4_000, //млс 
                                20_000 //млс 
                                );
                            break;
                        }
                    case Difficulty.NORMAL:
                        {
                            SetDifficulty(7_000, 3_000, 15_000);
                            break;
                        }
                    case Difficulty.COMPLEX:
                        {
                            SetDifficulty(5_000, 1_500, 10_000);
                            break;
                        }
                }
            }
        }

        //Конструкторы
        public DifficultyLevel(Difficulty difficulty) 
            => CurrentDifficulty = difficulty;
        public DifficultyLevel(
            int maxSpawnDelay,
            int minSpawnDelay,
            int acceleration)
            => SetDifficulty(
                maxSpawnDelay, 
                minSpawnDelay, 
                acceleration);

        //Внутренние методы
        private void SetDifficulty(
            int maxSpawnDelay,
            int minSpawnDelay,
            int acceleration)
        {
            MaxSpawnDelay = maxSpawnDelay;
            MinSpawnDelay = minSpawnDelay;
            AccelerationDelay = acceleration;
        }
    }
}