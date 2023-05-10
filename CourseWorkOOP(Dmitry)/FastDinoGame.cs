
namespace CourseWorkOOP_Dmitry_
{
    //Классы объектов
    //Класс Игрового Объекта
    public class GameObject
    {
        //Поля
        private System.Drawing.Point location;
        //Структуры
        public struct OSprite
        {
            public System.Drawing.Image Texture;
            public System.Drawing.Rectangle Region;
            public OSprite(System.Drawing.Image texture, System.Drawing.Rectangle region)
            {
                Texture = texture;
                Region = region;
            }
        }

        //Свойства 
        public System.Drawing.Point Location 
        {
            get { return location; }
            set
            {
                int dx = location.X - Sprite.Region.X;
                int dy = location.Y - Sprite.Region.Y;
                location = value;
                Sprite.Region = new System.Drawing.Rectangle(
                    location.X - dx, location.Y - dy,
                    Sprite.Region.Width, Sprite.Region.Height
                    );
            }
        }
        public OSprite Sprite;

        //Конструкторы
        public GameObject(OSprite sprite, System.Drawing.Point location)
        {
            Location = location;
            Sprite = sprite;
        }
    }
    //Наследуемый класс от Игрового Объекта - Анимированный Объект
    public class AnimatedGameObject : GameObject
    {
        //Поля
        protected System.Drawing.Image[] animationTextures;
        private short[] animationCounter;

        //Конструкторы
        public AnimatedGameObject(
            OSprite sprite,
            System.Drawing.Point location,
            System.Drawing.Image[] arrayTextures)
            : base(sprite, location)
        {
            animationTextures = arrayTextures;
            animationCounter = new short[2] { 0, 0 };
        }

        //Внешние методы
        //Метод анимации
        public virtual void Animation()
        {
            if (animationCounter[1] == 0)
            {
                Sprite.Texture = animationTextures[animationCounter[0]];
                animationCounter[0]++;
                if (animationCounter[0] == animationTextures.Length - 1) animationCounter[1] = 1;
            }
            else
            {
                Sprite.Texture = animationTextures[animationCounter[0]];
                animationCounter[0]--;
                if (animationCounter[0] == 0) animationCounter[1] = 0;
            }
        }
    }
    //Наследуем класс от Анимированного Игрового Объекта - Многофункциональный Анимированный Игрвой Объект
    public class MultifunctionalAnimatedGameObject : AnimatedGameObject
    {
        //Поля
        private System.Collections.Generic.Dictionary<string, System.Drawing.Image[]> actionDictionary;
        private string action;

        //Свойства
        protected string Action
        {
            get { return action; }
            set
            {
                if (actionDictionary.ContainsKey(value))
                {
                    action = value;
                    animationTextures = actionDictionary[action];
                }
            }
        }

        //Конструкторы 
        public MultifunctionalAnimatedGameObject(
            OSprite sprite,
            System.Drawing.Point location,
            System.Drawing.Image[] arrayTextures,
            System.Collections.Generic.Dictionary<string, System.Drawing.Image[]> dictionary)
            : base(sprite, location, arrayTextures)
            => actionDictionary = dictionary;
    }
    //Интерфейс реализующий Группы
    interface Group
    {
        //Свойства
        float DistanceBetween { get; }
        bool[,] GroupMesh { get; set; }
    }
    //Наследуемый класс от Игрового Объекта и реализующий интерфейс Группы
    public class GroupOfGameObjects : GameObject, Group
    {
        //Свойства
        public float DistanceBetween { get; }
        public bool[,] GroupMesh { get; set; }

        //Конструкторы
        public GroupOfGameObjects(
            OSprite sprite,
            System.Drawing.Point location,
            float distanceBetween,
            bool[,] groupMesh)
            : base(sprite, location)
        {
            DistanceBetween = distanceBetween;
            GroupMesh = groupMesh;
        }
    }
    //Наследуемый класс от Анимированного Игрового Объекта и реализующий интерфейс группы
    public class GroupOfAnimatedGameObjects : AnimatedGameObject, Group
    {
        //Свойства
        public float DistanceBetween { get; }
        public bool[,] GroupMesh { get; set; }

        //Конструкторы
        public GroupOfAnimatedGameObjects(
            OSprite sprite,
            System.Drawing.Point location,
            System.Drawing.Image[] arrayTextures,
            float distanceBetween,
            bool[,] groupMesh)
            : base(sprite, location, arrayTextures)
        {
            DistanceBetween = distanceBetween;
            GroupMesh = groupMesh;
        }
    }
    //Наследуемый класс от Анимированного Игрового Объекта и реализующий интерфейс группы
    public class GroupOfMultifunctionalAnimatedGameObject : MultifunctionalAnimatedGameObject, Group
    {
        //Свойства
        public float DistanceBetween { get; }
        public bool[,] GroupMesh { get; set; }

        //Конструкторы
        public GroupOfMultifunctionalAnimatedGameObject(
            OSprite sprite,
            System.Drawing.Point location,
            System.Drawing.Image[] arrayTextures,
            System.Collections.Generic.Dictionary<string, System.Drawing.Image[]> dictionary,
            float distanceBetween,
            bool[,] groupMesh)
            : base(sprite, location, arrayTextures, dictionary)
        {
            DistanceBetween = distanceBetween;
            GroupMesh = groupMesh;
        }
    }

    //Классы игры
    //Класс персонажа
    public class GameCharacter : MultifunctionalAnimatedGameObject
    {
        //Перечисление
        public enum OStatus { RUN, JUMP, CROUCH, DIE, NONE }

        //Поля
        private int[] jumpCounter;
        private OStatus status;
        private OStatus bufStatus;
        private System.Drawing.Rectangle regionRUN;
        private System.Drawing.Rectangle regionCROUCH;

        //Потоки
        private System.Threading.Thread jumpAnimated;
        private System.Threading.Thread motionAnimation;

        //Свойства
        public OStatus Status
        {
            get { return status; }
            set
            {
                bufStatus = status;
                status = value;
                Action = status.ToString();
                switch(status)
                {
                    case OStatus.RUN:
                        {
                            Sprite.Region = regionRUN;
                            if (motionAnimation == null || !motionAnimation.IsAlive)
                            {
                                motionAnimation = new System.Threading.Thread(MotionAnimation);
                                motionAnimation.IsBackground = true;
                                motionAnimation.Start();
                            }
                            break;
                        }
                    case OStatus.CROUCH:
                        {
                            Sprite.Region = regionCROUCH;
                            if (motionAnimation == null || !motionAnimation.IsAlive)
                            {
                                motionAnimation = new System.Threading.Thread(MotionAnimation);
                                motionAnimation.IsBackground = true;
                                motionAnimation.Start();
                            }
                            break;
                        }
                    case OStatus.JUMP:
                        {
                            if (jumpAnimated == null || !jumpAnimated.IsAlive)
                            {
                                jumpAnimated = new System.Threading.Thread(JumpAnimation);
                                jumpAnimated.IsBackground = true;
                                jumpAnimated.Start();
                            }
                            break;
                        }
                }
            }
        }
        public OStatus BufStatus { get { return bufStatus; } }
        public int JumpSpeed { get; set; }
        public int MotionSpeed { get; set; }
        public int MaxJumpHeight { get; set; }

        //Конструкторы
        public GameCharacter(
            OSprite sprite,
            System.Drawing.Point location,
            System.Drawing.Image[] arrayTextures,
            System.Drawing.Rectangle newRegionRUN,
            System.Drawing.Rectangle newRegionCROUCH,
            int motionSpeed,
            int jumpSpeed,
            int maxJumpHeight,
            System.Collections.Generic.Dictionary<string, System.Drawing.Image[]> dictionary)
            : base(sprite, location, arrayTextures, dictionary)
        {
            MotionSpeed = motionSpeed;
            JumpSpeed = jumpSpeed;
            MaxJumpHeight = maxJumpHeight;
            jumpCounter = new int[] { 0, 0, Sprite.Texture.Height };
            regionRUN = newRegionRUN;
            regionCROUCH = newRegionCROUCH;
        }

        //Внутренние методы
        private void MotionAnimation()
        {
            while(Status != OStatus.DIE && Status != OStatus.NONE)
            {
                base.Animation();
                System.Threading.Thread.Sleep(MotionSpeed);
            }
        }
        private void JumpAnimation()
        {
            System.Drawing.Point oldLocation = Location;
            while (Status == OStatus.JUMP && Status != OStatus.DIE &&
                   Status != OStatus.NONE)
            {
                if (jumpCounter[1] == 0)
                {
                    jumpCounter[0] +=
                        (int)System.Math.Round((double)jumpCounter[2] /
                        (double)100 * (double)5.47945205);
                    Location = new System.Drawing.Point(Location.X, Location.Y -
                        (int)System.Math.Round((double)jumpCounter[2] /
                        (double)100 * (double)5.47945205));
                    if (jumpCounter[0] > MaxJumpHeight / 2) jumpCounter[1] = 1;
                }
                else
                {
                    jumpCounter[0] -=
                        (int)System.Math.Round((double)jumpCounter[2] /
                        (double)100 * (double)5.47945205);
                    Location = new System.Drawing.Point(Location.X, Location.Y +
                        (int)System.Math.Round((double)jumpCounter[2] / 
                        (double)100 * (double)5.47945205));
                    if (jumpCounter[0] <= 0)
                    {
                        jumpCounter[0] = 0;
                        jumpCounter[1] = 0;
                        Status = OStatus.RUN;
                        Location = oldLocation; 
                    }
                }
                System.Threading.Thread.Sleep(
                    (int)System.Math.Round((double)5000 / (double)JumpSpeed));
            }
        }
    }
    //Класс Препятствия Шип
    public class GameObstacleSpike : GroupOfGameObjects
    {
        //Конструктор
        public GameObstacleSpike(
            OSprite sprite,
            System.Drawing.Point location,
            float distanceBetween,
            bool[,] groupMesh)
            : base(sprite, location, distanceBetween, groupMesh) { }
    }
    //Класс Монетки
    public class GameCoin : GroupOfMultifunctionalAnimatedGameObject
    {
        //Перечисление
        public enum OStatus { RUN, NONE }

        //Поля
        private OStatus status;

        //Потоки
        private System.Threading.Thread motionAnimation;

        //Свойства
        public OStatus Status
        {
            get { return status; }
            set
            {
                status = value;
                Action = status.ToString();
                switch (status)
                {
                    case OStatus.RUN:
                        {
                            if (motionAnimation == null || !motionAnimation.IsAlive)
                            {
                                motionAnimation = new System.Threading.Thread(MotionAnimation);
                                motionAnimation.IsBackground = true;
                                motionAnimation.Start();
                            }
                            break;
                        }
                }
            }
        }
        public int MotionSpeed { get; set; }

        //Конструкторы
        public GameCoin(
            OSprite sprite,
            System.Drawing.Point location,
            System.Drawing.Image[] arrayTextures,
            int motionSpeed,
            System.Collections.Generic.Dictionary<string, System.Drawing.Image[]> dictionary,
            float distanceBetween,
            bool[,] groupMesh)
            : base(sprite, location, arrayTextures, dictionary, distanceBetween, groupMesh)
            => MotionSpeed = motionSpeed;

        //Внутренние методы
        private void MotionAnimation()
        {
            while (Status != OStatus.NONE)
            {
                base.Animation();
                System.Threading.Thread.Sleep(MotionSpeed);
            }
        }
    }


    //Класс Игры Быстрый Дино
    public class FastDinoGame
    {
        //События
        public System.EventHandler OnEndGame;
        public System.EventHandler OnChangeScore;

        //Поля
        private int gameSpeed;
        private GameCharacter character;
        private ApplicationSettings settings;
        private System.Collections.Generic.List<GameObject> gameObjects;
        private System.Collections.Concurrent.ConcurrentQueue<string> accessRequests;

        //Внешние поля
        private ModificationPictureBox map;

        //Таймеры
        private System.Windows.Forms.Timer gameAcceleration;
        private System.Windows.Forms.Timer generatingObjects;

        //Рандомайзер
        private System.Random random;

        //Потоки
        private System.Threading.Thread collisionControl; //Главный поток, по его завершению завершаются все остальные
        private System.Threading.Thread characterControl;
        private System.Threading.Thread objectsControl;
        private System.Threading.Thread renderingControl;

        //Свойства
        public System.Collections.Concurrent.ConcurrentQueue<char> characterCommands;
        public bool IsGame { get; set; }
        public int Score { get; set; }
        public string UserName { get; set; }

        //Конструкторы
        public FastDinoGame()
        {
            gameAcceleration = new System.Windows.Forms.Timer();
            gameAcceleration.Tick += new System.EventHandler(GameAcceleration_Tike);
            generatingObjects = new System.Windows.Forms.Timer();
            generatingObjects.Tick += new System.EventHandler(GeneratingObjects_Tike);
        }

        //Внешние методы
        //Управление игрой
        public void Run(
            ModificationPictureBox newMap,
            ApplicationSettings newSettings,
            string newUserName)
        {
            if (collisionControl == null || !collisionControl.IsAlive)
            {
                IsGame = true;
                Score = 0; 
                map = newMap; settings = newSettings; UserName = newUserName;
                characterCommands = new System.Collections.Concurrent.ConcurrentQueue<char>();
                accessRequests = new System.Collections.Concurrent.ConcurrentQueue<string>();
                gameObjects = new System.Collections.Generic.List<GameObject>();
                random = new System.Random(System.DateTime.Now.Second);
                gameSpeed = (int)(map.Width / 100 * 28.05049088);
                int tmp = settings.Difficulty.AccelerationDelay;
                gameAcceleration.Interval = settings.Difficulty.AccelerationDelay;
                generatingObjects.Interval = random.Next(
                        settings.Difficulty.MinSpawnDelay, 
                        settings.Difficulty.MaxSpawnDelay);
                collisionControl = new System.Threading.Thread(CollisionHandling);
                characterControl = new System.Threading.Thread(CharacterHandling);
                objectsControl = new System.Threading.Thread(ObjectsHandling);
                renderingControl = new System.Threading.Thread(RenderingHandling);
                collisionControl.Name = "collision"; characterControl.Name = "character";
                objectsControl.Name = "objects"; renderingControl.Name = "rendering";
                collisionControl.IsBackground = true; characterControl.IsBackground = true;
                objectsControl.IsBackground = true; renderingControl.IsBackground = true;
                //Генерация персонажа
                System.Drawing.Size textureSizeRun = new System.Drawing.Size(
                            (int)System.Math.Round(0.875 * (map.Height / 5)),
                            (int)System.Math.Round((double)(map.Height / 5)));
                System.Drawing.Size textureSizeCrouch = new System.Drawing.Size(
                            (int)System.Math.Round((double)(map.Width / 8.4)),
                            (int)System.Math.Round(0.750 * (map.Width / 8.4)));
                int regionWidthRun = (int)System.Math.Round(
                    (float)textureSizeRun.Width / (float)100 * (float)71.4285714);
                int regionHeightRun = (int)System.Math.Round(
                    (float)textureSizeRun.Height / (float)100 * (float)93.75);
                int regionWidthCrouch = (int)System.Math.Round(
                    (float)textureSizeCrouch.Width / (float)100 * (float)87.5);
                int regionHeightCrouch = (int)System.Math.Round(
                    (float)textureSizeCrouch.Height / (float)100 * (float)91.6666667);
                System.Drawing.Rectangle regionRun = new System.Drawing.Rectangle(
                    (int)(map.Width * 0.05) + (textureSizeRun.Width - regionWidthRun) / 2,
                    (int)System.Math.Round(map.Height - map.Height * 0.3 + (textureSizeRun.Height - regionHeightRun) / 2),
                    regionWidthRun, regionHeightRun);
                System.Drawing.Rectangle regionCrouch = new System.Drawing.Rectangle(
                    (int)(map.Width * 0.05) + (textureSizeCrouch.Width - regionWidthCrouch) / 2,
                    (int)System.Math.Round(map.Height - map.Height * 0.3 + (textureSizeCrouch.Height - regionHeightCrouch) / 2),
                    regionWidthCrouch, regionHeightCrouch);
                //Создание персонажа
                character = CreateGameCharacter(textureSizeRun, textureSizeCrouch, regionRun, regionCrouch,
                            new System.Drawing.Point((int)(map.Width * 0.05),
                            (int)System.Math.Round((float)map.Height - (float)map.Height * (float)0.3)),
                            gameSpeed, gameSpeed, (int)(textureSizeRun.Height * 3), settings.Theme);
                //Запуск
                character.Status = GameCharacter.OStatus.RUN;
                collisionControl.Start(); characterControl.Start();
                objectsControl.Start(); renderingControl.Start();
                gameAcceleration.Start(); generatingObjects.Start();
            }
            else
                System.Windows.Forms.MessageBox.Show(
                    "Не удалось запустить игру.\r\n" +
                    "Повторите попытку.",
                    "Сообщение",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information);
        }
        public void Pause()
        {
            if (collisionControl != null && 
                collisionControl.IsAlive) collisionControl?.Suspend();
            if (characterControl != null && 
                characterControl.IsAlive) characterControl?.Suspend();
            if (objectsControl != null && 
                objectsControl.IsAlive) objectsControl?.Suspend();
            if (renderingControl != null && 
                renderingControl.IsAlive) renderingControl?.Suspend();
            if (gameAcceleration != null) gameAcceleration.Stop();
            if (generatingObjects != null) generatingObjects.Stop();
            AnimationNone();
            if (character != null) character.Status = GameCharacter.OStatus.NONE;
        }
        public void Continue()
        {
            if (collisionControl != null && collisionControl.IsAlive
                && collisionControl.ThreadState == 
                (System.Threading.ThreadState.Suspended | 
                System.Threading.ThreadState.Background)) 
                collisionControl?.Resume();
            if (characterControl != null && characterControl.IsAlive
                && characterControl.ThreadState ==
                (System.Threading.ThreadState.Suspended |
                System.Threading.ThreadState.Background))
                characterControl?.Resume();
            if (objectsControl != null && objectsControl.IsAlive
                && objectsControl.ThreadState ==
                (System.Threading.ThreadState.Suspended |
                System.Threading.ThreadState.Background))
                objectsControl?.Resume();
            if (renderingControl != null && renderingControl.IsAlive
                && renderingControl.ThreadState ==
                (System.Threading.ThreadState.Suspended |
                System.Threading.ThreadState.Background)) 
                renderingControl?.Resume();
            if (gameAcceleration != null) gameAcceleration.Start();
            if (generatingObjects != null) generatingObjects.Start();
            AnimationTrue();
            if (character != null) character.Status = character.BufStatus;
        }
        public void End()
        { 
            Continue();
            if (character != null) character.Status = GameCharacter.OStatus.DIE;
            while (collisionControl != null && collisionControl.IsAlive) ;
            while (characterControl != null && characterControl.IsAlive) ;
            while (objectsControl != null && objectsControl.IsAlive) ;
            while (renderingControl != null && renderingControl.IsAlive) ;
            if (gameAcceleration != null) gameAcceleration.Stop();
            if (generatingObjects != null) generatingObjects.Stop();
            IsGame = false;
        }
        //Доступ к данным
        public GameRecords.Record GetRecord() 
            => new GameRecords.Record(UserName, Score, settings.Difficulty);

        //Внутренние методы
        //Метод обработки потока игры
        //Методы обработки потоков
        private void CollisionHandling()
        {
            int count = 0;
            string tmp = "";
            System.Collections.Generic.List<int> counter;
            while (character.Status != GameCharacter.OStatus.DIE)
            {
                tmp = "";
                accessRequests.Enqueue(collisionControl.Name);
                while (tmp != collisionControl.Name)
                    accessRequests.TryPeek(out tmp);
                count = 0;
                counter = new System.Collections.Generic.List<int>();
                for(int z = 0; z < gameObjects.Count; z++)
                {
                    if (gameObjects[z] is GameObstacleSpike spike)
                    {
                        for (int i = 0; i < spike.GroupMesh.GetLength(0); i++)
                            for (int j = 0; j < spike.GroupMesh.GetLength(1); j++)
                            {
                                if (spike.GroupMesh[i, j] != false)
                                {
                                    GameObject @object1 = new GameObject(spike.Sprite, spike.Location);
                                    object1.Location = new System.Drawing.Point(
                                        spike.Location.X + j * spike.Sprite.Texture.Size.Width,
                                        spike.Location.Y + i * spike.Sprite.Texture.Size.Height
                                        );
                                    int dx = (spike.Sprite.Region.X - spike.Location.X) * 2;
                                    int dy = (spike.Sprite.Region.Y - spike.Location.Y) * 2;
                                    object1.Sprite.Region = new System.Drawing.Rectangle(
                                        spike.Sprite.Region.X + j * spike.Sprite.Region.Width + j * dx,
                                        spike.Sprite.Region.Y + i * spike.Sprite.Region.Height + i * dy,
                                        spike.Sprite.Region.Width, spike.Sprite.Region.Height
                                        );
                                    if (CollisionCheck(character, object1) ||
                                        CollisionCheck(object1, character))
                                    {
                                        AnimationNone();
                                        character.Status = GameCharacter.OStatus.DIE;
                                        if (OnEndGame != null)
                                            OnEndGame(null, System.EventArgs.Empty);
                                    }
                                }
                            }
                        if (spike.Location.X +
                            spike.Sprite.Texture.Width * spike.GroupMesh.GetLength(1) <= 0)
                            counter.Add(count);
                    }
                    else if (gameObjects[z] is GameCoin coin)
                    {
                        for (int i = 0; i < coin.GroupMesh.GetLength(0); i++)
                            for (int j = 0; j < coin.GroupMesh.GetLength(1); j++)
                            {
                                if (coin.GroupMesh[i, j] != false)
                                {
                                    GameObject @object1 = new GameObject(coin.Sprite, coin.Location);
                                    object1.Location = new System.Drawing.Point(
                                        coin.Location.X + j * coin.Sprite.Texture.Size.Width,
                                        coin.Location.Y + i * coin.Sprite.Texture.Size.Height
                                        );
                                    int dx = (coin.Sprite.Region.X - coin.Location.X) * 2;
                                    int dy = (coin.Sprite.Region.Y - coin.Location.Y) * 2;
                                    object1.Sprite.Region = new System.Drawing.Rectangle(
                                        coin.Sprite.Region.X + j * coin.Sprite.Region.Width + j * dx,
                                        coin.Sprite.Region.Y + i * coin.Sprite.Region.Height + i * dy,
                                        coin.Sprite.Region.Width, coin.Sprite.Region.Height
                                        );
                                    if (CollisionCheck(character, object1) ||
                                        CollisionCheck(object1, character))
                                    {
                                        Score++;
                                        coin.GroupMesh[i, j] = false;
                                        if (OnChangeScore != null)
                                            OnChangeScore(null, System.EventArgs.Empty);
                                    }
                                }
                            }
                        if (coin.Location.X +
                            coin.Sprite.Texture.Width * coin.GroupMesh.GetLength(1) <= 0)
                            counter.Add(count);
                    }
                    count++;
                }
                while (counter.Count > 0)
                {
                    gameObjects.RemoveAt(counter[0]);
                    counter.RemoveAt(0);
                }
                while (!accessRequests.TryDequeue(out tmp)) ;
                System.Threading.Thread.Sleep(
                    (int)System.Math.Round((double)1000 / (double)gameSpeed));
            }
            IsGame = false;
        }
        private void CharacterHandling()
        {
            string tmp;
            while ((bool)collisionControl?.IsAlive)
            {
                tmp = "";
                accessRequests.Enqueue(characterControl.Name);
                while (tmp != characterControl.Name)
                    accessRequests.TryPeek(out tmp);
                while (characterCommands.Count > 0)
                {
                    if (characterCommands.TryDequeue(out char c))
                    {
                        if (character.Status != GameCharacter.OStatus.JUMP &&
                            character.Status != GameCharacter.OStatus.DIE)
                        {
                            if (c == 32)
                            {
                                character.Status = GameCharacter.OStatus.RUN;
                                character.Status = GameCharacter.OStatus.JUMP;
                            }
                            else if (c == 's' || c == 'S' || c == 'ы' || c == 'Ы' || c == 40)
                            {
                                character.Status = GameCharacter.OStatus.CROUCH;
                            }
                            else if (c == 0) character.Status = GameCharacter.OStatus.RUN;
                        }
                    }
                }
                while (!accessRequests.TryDequeue(out tmp)) ;
                System.Threading.Thread.Sleep(
                    (int)System.Math.Round((double)1000 / (double)gameSpeed));
            }
        }
        private void ObjectsHandling()
        {
            string tmp;
            while ((bool)collisionControl?.IsAlive)
            {
                tmp = "";
                accessRequests.Enqueue(objectsControl.Name);
                while (tmp != objectsControl.Name)
                    accessRequests.TryPeek(out tmp);
                for (int z = 0; z < gameObjects.Count; z++)
                {
                    gameObjects[z].Location = new System.Drawing.Point(
                        gameObjects[z].Location.X - 
                        (int)System.Math.Round((double)map.Width / (double)100 * (double)0.701262272), 
                        gameObjects[z].Location.Y
                    );
                }
                while (!accessRequests.TryDequeue(out tmp)) ;
                System.Threading.Thread.Sleep(
                    (int)System.Math.Round((double)5000 / (double)gameSpeed));
            }
        }
        private void RenderingHandling()
        {
            string tmp;
            System.Drawing.Bitmap bmp;
            System.Drawing.Graphics draw;
            while ((bool)collisionControl?.IsAlive)
            {
                tmp = "";
                accessRequests.Enqueue(renderingControl.Name);
                while (tmp != renderingControl.Name)
                    accessRequests.TryPeek(out tmp);
                bmp = new System.Drawing.Bitmap(map.Width, map.Height);
                draw = System.Drawing.Graphics.FromImage(bmp);
                for (int z = 0; z < gameObjects.Count; z++)
                {
                    if (gameObjects[z] is GameCoin coin)
                    {
                        for (int i = 0; i < coin.GroupMesh.GetLength(0); i++)
                            for (int j = 0; j < coin.GroupMesh.GetLength(1); j++)
                            {
                                if (coin.GroupMesh[i, j] != false)
                                {
                                    GameObject @object1 = new GameObject(
                                        coin.Sprite, coin.Location
                                        );
                                    object1.Location = new System.Drawing.Point(
                                        object1.Location.X + j * object1.Sprite.Texture.Size.Width,
                                        object1.Location.Y + i * object1.Sprite.Texture.Size.Height
                                        );
                                    draw.DrawImage(@object1.Sprite.Texture, @object1.Location);
                                }
                            }
                    }
                    else if (gameObjects[z] is GameObstacleSpike spike)
                    {
                        for (int i = 0; i < spike.GroupMesh.GetLength(0); i++)
                            for (int j = 0; j < spike.GroupMesh.GetLength(1); j++)
                            {
                                if (spike.GroupMesh[i, j] != false)
                                {
                                    GameObject @object1 = new GameObject(
                                        spike.Sprite, spike.Location
                                        );
                                    object1.Location = new System.Drawing.Point(
                                        object1.Location.X + j * object1.Sprite.Texture.Size.Width,
                                        object1.Location.Y + i * object1.Sprite.Texture.Size.Height
                                        );
                                    object1.Sprite.Region = new System.Drawing.Rectangle(
                                        object1.Location.X, object1.Location.Y,
                                        object1.Sprite.Region.Width, object1.Sprite.Region.Height
                                        );
                                    draw.DrawImage(@object1.Sprite.Texture, @object1.Location);
                                }
                            }
                    }
                }
                draw.DrawImage(character.Sprite.Texture, character.Location);
                map.Image = bmp;
                while (!accessRequests.TryDequeue(out tmp)) ;
                System.Threading.Thread.Sleep(
                    (int)System.Math.Round((double)71300 / (double)map.Width));
            }
        }
        //Методы обработки таймеров
        private void GameAcceleration_Tike(object sender, System.EventArgs e)
        {
            if ((bool)collisionControl?.IsAlive && gameSpeed < 1000)
            {
                gameSpeed++;
                gameAcceleration.Start();
            }
        }
        private void GeneratingObjects_Tike(object sender, System.EventArgs e)
        {
            if (gameObjects.Count < 30)
            {
                if ((bool)collisionControl?.IsAlive)
                {
                    //Генерация Шипов
                    System.Drawing.Size textureSize = new System.Drawing.Size(
                                (int)System.Math.Round((float)0.721804511 * ((float)map.Height / (float)8)),
                                (int)System.Math.Round((float)((float)map.Height / (float)8))
                                );
                    int regionWidth = (int)System.Math.Round((float)textureSize.Width / (float)100 * (float)55.555555556);
                    int regionHeight = (int)System.Math.Round((float)textureSize.Height / (float)100 * (float)71.4285714);
                    System.Drawing.Rectangle region = new System.Drawing.Rectangle(
                        map.Width + (textureSize.Width - regionWidth) / 2,
                        (int)System.Math.Round((float)map.Height - (float)map.Height * (float)0.2 +
                        ((float)textureSize.Height - (float)regionHeight) / 2),
                        regionWidth, regionHeight);
                    bool[,] groupMesh = new bool[1, InterectRandom(1, 2)];
                    for (int i = 0; i < groupMesh.GetLength(0); i++)
                        for (int j = 0; j < groupMesh.GetLength(1); j++)
                            groupMesh[i, j] = true;
                    gameObjects.Add(
                        CreateGameSpike(textureSize, region,
                            new System.Drawing.Point(map.Width,
                                (int)System.Math.Round(map.Height - map.Height * 0.22)),
                            0, groupMesh, settings.Theme));
                    //Генерация Монет
                    if (InterectRandom(1, 2) == 1)
                    {
                        int shift = textureSize.Width * groupMesh.GetLength(1);
                        groupMesh = new bool[InterectRandom(1, 3), InterectRandom(1, 3)];
                        textureSize = new System.Drawing.Size(
                                    (int)System.Math.Round((float)0.571428571 * ((float)map.Height / (float)8)),
                                    (int)System.Math.Round(((float)((float)map.Height / (float)8))));
                        groupMesh = new bool[InterectRandom(1, 3), InterectRandom(1, 3)];
                        System.Drawing.Point location = new System.Drawing.Point(
                            map.Width + shift,
                            (int)System.Math.Round(
                                map.Height - map.Height * 0.2 - groupMesh.GetLength(0) * textureSize.Height));
                        regionWidth = (int)System.Math.Round((float)textureSize.Width / (float)100 * (float)75);
                        regionHeight = (int)System.Math.Round((float)textureSize.Height / (float)100 * (float)85.7142857);
                        region = new System.Drawing.Rectangle(
                            location.X + (textureSize.Width - regionWidth) / 2,
                            location.Y + (textureSize.Height - regionHeight) / 2,
                            regionWidth, regionHeight);
                        //if (groupMesh.GetLength(0) > 1)
                        //    region.Location = new System.Drawing.Point( 
                        //        region.Location.X,
                        //        region.Location.Y - groupMesh.GetLength(0) * textureSize.Height);
                        for (int i = 0; i < groupMesh.GetLength(0); i++)
                            for (int j = 0; j < groupMesh.GetLength(1); j++)
                                groupMesh[i, j] = true;
                        GameCoin coin = CreateGameCoin(textureSize, region, location, gameSpeed, 1, groupMesh, settings.Theme);
                        coin.Status = GameCoin.OStatus.RUN;
                        gameObjects.Add(coin);
                    }
                    //Запуск нового таймера
                    generatingObjects.Interval =
                        random.Next(
                            settings.Difficulty.MinSpawnDelay,
                            settings.Difficulty.MaxSpawnDelay);
                    generatingObjects.Start();
                }
            }
        }
        //Метод проверки коллизии
        private bool CollisionCheck(GameObject object1, GameObject object2)
        {
            int dx1 = object1.Sprite.Region.X + object1.Sprite.Region.Width;
            int dy1 = object1.Sprite.Region.Y + object1.Sprite.Region.Height;
            int dx2 = object2.Sprite.Region.X + object2.Sprite.Region.Width;
            int dy2 = object2.Sprite.Region.Y + object2.Sprite.Region.Height;
            if (dx1 > object2.Sprite.Region.X && dy1 > object2.Sprite.Region.Y &&
                object1.Sprite.Region.X < object2.Sprite.Region.X &&
                object1.Sprite.Region.Y < object2.Sprite.Region.Y)
                return true;
            if (dx1 > dx2 && dy1 > object2.Sprite.Region.Y &&
                object1.Sprite.Region.X < dx2 &&
                object1.Sprite.Region.Y < object2.Sprite.Region.Y)
                return true;
            if (dx1 > object2.Sprite.Region.X &&
                object2.Sprite.Region.X > object1.Sprite.Region.X &&
                object1.Sprite.Region.Y > object2.Sprite.Region.Y &&
                dy2 > object1.Sprite.Region.Y)
                return true;
            return false;
        }
        //Методы контроля анимации объектов
        private void AnimationNone()
        {
            if (collisionControl != null && collisionControl.IsAlive)
            {
                foreach (GameObject @object in gameObjects)
                    if (@object is GameCoin coin)
                        coin.Status = GameCoin.OStatus.NONE;
            }
        }
        private void AnimationTrue()
        {
            if (collisionControl != null && collisionControl.IsAlive)
            {
                foreach (GameObject @object in gameObjects)
                    if (@object is GameCoin coin)
                        coin.Status = GameCoin.OStatus.RUN;
            }
        }
        //Методы обработки изображения
        private System.Drawing.Image ScaleImage(
            System.Drawing.Image image,
            System.Drawing.Size newSize)
        {
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(newSize.Width, newSize.Height);
            System.Drawing.Graphics draw = System.Drawing.Graphics.FromImage(bmp);
            draw.DrawImage( image,
                new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height),
                new System.Drawing.Rectangle(0, 0, image.Width, image.Height),
                System.Drawing.GraphicsUnit.Pixel);
            return bmp;
        }
        //Метод увелечения случайности рандома (от 0 до 100)
        private int InterectRandom(int min, int max)
        {
            int count = max - min + 1;
            int zon = 100 / count;
            int error = 100 - zon * count;
            int ran = random.Next(1, 100);
            for (int i = 1; i <= count; i++)
                if (zon * i >= ran + error &&
                    zon * i >= ran - error) return min + i - 1;
            return min;
        }
        //Методы создания объектов
        private GameCharacter CreateGameCharacter(
            System.Drawing.Size textureSizeRun,
            System.Drawing.Size textureSizeCrouch,
            System.Drawing.Rectangle regionRun,
            System.Drawing.Rectangle regionCrouch,
            System.Drawing.Point location,
            int motionSpeed,
            int jumpSpeed,
            int jumpHeight,
            ComponentTheme theme)
        {
            System.Collections.Generic.Dictionary<string, System.Drawing.Image[]> dn;
            dn = new System.Collections.Generic.Dictionary<string, System.Drawing.Image[]>();
            if(theme == ComponentTheme.LIGHT_THEME)
            {
                dn.Add(GameCharacter.OStatus.RUN.ToString(), new System.Drawing.Image[] {
                    ScaleImage(Properties.Resources.Светлая_ПерсонажДвижение1, textureSizeRun),
                    ScaleImage(Properties.Resources.Светлая_ПерсонажДвижение2, textureSizeRun),
                    ScaleImage(Properties.Resources.Светлая_ПерсонажДвижение3, textureSizeRun)
                });
                dn.Add(GameCharacter.OStatus.CROUCH.ToString(), new System.Drawing.Image[] {
                    ScaleImage(Properties.Resources.Светлая_ПерсонажПрисяд1, textureSizeCrouch),
                    ScaleImage(Properties.Resources.Светлая_ПерсонажПрисяд2, textureSizeCrouch),
                    ScaleImage(Properties.Resources.Светлая_ПерсонажПрисяд3, textureSizeCrouch)
                });
            }
            else
            {
                dn.Add(GameCharacter.OStatus.RUN.ToString(), new System.Drawing.Image[] {
                    ScaleImage(Properties.Resources.Тёмная_ПерсонажДвижение1, textureSizeRun),
                    ScaleImage(Properties.Resources.Тёмная_ПерсонажДвижение2, textureSizeRun),
                    ScaleImage(Properties.Resources.Тёмная_ПерсонажДвижение3, textureSizeRun),
                });
                dn.Add(GameCharacter.OStatus.CROUCH.ToString(), new System.Drawing.Image[] {
                    ScaleImage(Properties.Resources.Тёмная_ПерсонажПрисяд1, textureSizeCrouch),
                    ScaleImage(Properties.Resources.Тёмная_ПерсонажПрисяд2, textureSizeCrouch),
                    ScaleImage(Properties.Resources.Тёмная_ПерсонажПрисяд3, textureSizeCrouch)
                });
            }
            return new GameCharacter(
                new GameObject.OSprite(
                    dn[GameCharacter.OStatus.RUN.ToString()][0],
                    regionRun),
                location,
                dn[GameCharacter.OStatus.RUN.ToString()],
                regionRun, regionCrouch,
                motionSpeed, jumpSpeed, jumpHeight, dn);
        }
        private GameObstacleSpike CreateGameSpike(
            System.Drawing.Size textureSize,
            System.Drawing.Rectangle region,
            System.Drawing.Point location,
            float distanceBetween,
            bool[,] groupMesh,
            ComponentTheme theme)
        {
            System.Drawing.Image image;
            if(theme == ComponentTheme.LIGHT_THEME)
                image = ScaleImage(Properties.Resources.Светлая_Шип, textureSize);
            else
                image = ScaleImage(Properties.Resources.Тёмная_Шип, textureSize);
            return new GameObstacleSpike(
                new GameObject.OSprite(image, region),
                location,
                distanceBetween,
                groupMesh);
        }
        private GameCoin CreateGameCoin(
            System.Drawing.Size textureSize,
            System.Drawing.Rectangle region,
            System.Drawing.Point location,
            int motionSpeed,
            float distanceBetween,
            bool[,] groupMesh,
            ComponentTheme theme)
        {
            System.Collections.Generic.Dictionary<string, System.Drawing.Image[]> dn;
            dn = new System.Collections.Generic.Dictionary<string, System.Drawing.Image[]>();
            if (theme == ComponentTheme.LIGHT_THEME)
                dn.Add(GameCharacter.OStatus.RUN.ToString(), new System.Drawing.Image[] {
                    ScaleImage(Properties.Resources.Светлая_МонеткаДвижение1, textureSize),
                    ScaleImage(Properties.Resources.Светлая_МонеткаДвижение2, textureSize),
                    ScaleImage(Properties.Resources.Светлая_МонеткаДвижение3, textureSize),
                    ScaleImage(Properties.Resources.Светлая_МонеткаДвижение4, textureSize),
                    ScaleImage(Properties.Resources.Светлая_МонеткаДвижение5, textureSize)
                });
            else
                dn.Add(GameCharacter.OStatus.RUN.ToString(), new System.Drawing.Image[] {
                    ScaleImage(Properties.Resources.Тёмная_МонеткаДвижение1, textureSize),
                    ScaleImage(Properties.Resources.Тёмная_МонеткаДвижение2, textureSize),
                    ScaleImage(Properties.Resources.Тёмная_МонеткаДвижение3, textureSize),
                    ScaleImage(Properties.Resources.Тёмная_МонеткаДвижение4, textureSize),
                    ScaleImage(Properties.Resources.Тёмная_МонеткаДвижение5, textureSize)
                });
            return new GameCoin(
                new GameObject.OSprite(
                    dn[GameCharacter.OStatus.RUN.ToString()][0],
                    region),
                location,
                dn[GameCharacter.OStatus.RUN.ToString()],
                motionSpeed, dn, distanceBetween, groupMesh);
        }
    }
}