
namespace CourseWorkOOP_Dmitry_
{
    partial class FastDino
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Код инициализирующий пользовательские поля, объекты и свойства
        /// </summary>
        private void InitializeApplication()
        {
            game = new FastDinoGame();
            game.OnEndGame += Game_OnEndGame;
            game.OnChangeScore += Game_OnChangeScore;
            System.Collections.Generic.Dictionary<string, System.Drawing.Image[]> lightTheme;
            System.Collections.Generic.Dictionary<string, System.Drawing.Image[]> nightTheme;
            lightTheme = new System.Collections.Generic.Dictionary<string, System.Drawing.Image[]>(0);
            nightTheme = new System.Collections.Generic.Dictionary<string, System.Drawing.Image[]>(0);
            PRecordsMoreDetails.SetSize(PRecordsMoreDetails.Size);
            PRecordsMoreDetails.OnCloseClick += PRecordsMoreDetailsClose_Click;
            PGamePause.SetSize(PGamePause.Size);
            PGamePause.OnCloseClick += BPauseBack_Click;
            PGameEnd.SetSize(PGameEnd.Size);
            PGameEnd.OnCloseClick += Game_OnEndGame;
            //
            // Заполнения словаря Светлой темы
            //
            lightTheme.Add(BMenuGame.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(BMenuRecords.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(BMenuSettings.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(BMenuExit.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(BSettingsBack.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(BSettingsLightTheme.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Тема });
            lightTheme.Add(CBSettingsFullScreen.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_АктивныйВыбор, Properties.Resources.Светлая_ПустойВыбор });
            lightTheme.Add(RBSettingsDifficultyCustom.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_ТекущийВыбор, Properties.Resources.Светлая_ПустойВыбор });
            lightTheme.Add(RBSettingsDifficultyEasy.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_ТекущийВыбор, Properties.Resources.Светлая_ПустойВыбор });
            lightTheme.Add(RBSettingsDifficultyNormal.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_ТекущийВыбор, Properties.Resources.Светлая_ПустойВыбор });
            lightTheme.Add(RBSettingsDifficultComplexity.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_ТекущийВыбор, Properties.Resources.Светлая_ПустойВыбор });
            lightTheme.Add(BRecordsBack.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(BRecordsRemove.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(BRecordsMoreDetails.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(BRecordsSortByName.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(BRecordsSortByRecord.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(PRecordsMoreDetails.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Закрыть, Properties.Resources.Светлая_ОкноПрограммы });
            lightTheme.Add(BGamePause.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_МенюИгровогоПроцесса});
            lightTheme.Add(PBGameDrawing.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_ФонИгры});
            lightTheme.Add(PGamePause.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Закрыть, Properties.Resources.Светлая_ОкноПрограммы });
            lightTheme.Add(BPauseBack.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка});
            lightTheme.Add(BGamePauseBack.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(PGameEnd.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Закрыть, Properties.Resources.Светлая_ОкноПрограммы });
            lightTheme.Add(BEndBack.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(BGameEndBack.Name, new System.Drawing.Image[] { Properties.Resources.Светлая_Кнопка });
            lightTheme.Add(dGVRecords.Name, null);
            //
            // Заполнение словаря Тёмной темы
            //
            nightTheme.Add(BMenuGame.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(BMenuRecords.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(BMenuSettings.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(BMenuExit.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(BSettingsBack.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(BSettingsNightTheme.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Тема });
            nightTheme.Add(CBSettingsFullScreen.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_АктивныйВыбор, Properties.Resources.Тёмная_ПустойВыбор });
            nightTheme.Add(RBSettingsDifficultyCustom.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_ТекущийВыбор, Properties.Resources.Тёмная_ПустойВыбор });
            nightTheme.Add(RBSettingsDifficultyEasy.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_ТекущийВыбор, Properties.Resources.Тёмная_ПустойВыбор });
            nightTheme.Add(RBSettingsDifficultyNormal.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_ТекущийВыбор, Properties.Resources.Тёмная_ПустойВыбор });
            nightTheme.Add(RBSettingsDifficultComplexity.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_ТекущийВыбор, Properties.Resources.Тёмная_ПустойВыбор });
            nightTheme.Add(BRecordsBack.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(BRecordsRemove.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(BRecordsMoreDetails.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(BRecordsSortByName.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(BRecordsSortByRecord.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(PRecordsMoreDetails.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Закрыть, Properties.Resources.Тёмная_ОкноПрограммы });
            nightTheme.Add(BGamePause.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_МенюИгровогоПроцесса });
            nightTheme.Add(PBGameDrawing.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_ФонИгры });
            nightTheme.Add(PGamePause.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Закрыть, Properties.Resources.Тёмная_ОкноПрограммы });
            nightTheme.Add(BPauseBack.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(BGamePauseBack.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(PGameEnd.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Закрыть, Properties.Resources.Тёмная_ОкноПрограммы });
            nightTheme.Add(BEndBack.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(BGameEndBack.Name, new System.Drawing.Image[] { Properties.Resources.Тёмная_Кнопка });
            nightTheme.Add(dGVRecords.Name, null);
            //
            // Инициализация Настроек приложения
            //
            settings = new ApplicationSettings(
                this, 
                System.Drawing.Color.LightSkyBlue, 
                System.Drawing.Color.SlateBlue, 
                lightTheme, 
                nightTheme);
            settings.OnChacgeDifficulty += Settings_OnChacgeDifficulty;
            settings.Difficulty = new DifficultyLevel(CourseWorkOOP_Dmitry_.Difficulty.EASY);
            settings.WindowState = System.Windows.Forms.FormWindowState.Normal;
            settings.Theme = ComponentTheme.LIGHT_THEME;
            //
            // Инициализация Меню приложения
            //
            formMenu = new MenuOfControlledItems(PMenu);
            formMenu.AddItem(PMenu, PSettings);
            formMenu.AddItem(PMenu, PRecords);
            formMenu.AddItem(PMenu, PGame);
            formMenu.AddItem(PRecords, PRecordsMoreDetails);
            formMenu.AddItem(PGame, PGamePause);
            formMenu.AddItem(PGame, PGameEnd);
            records = new GameRecords();
        }

        private ApplicationSettings settings;
        private MenuOfControlledItems formMenu;
        private GameRecords records;
        private FastDinoGame game;

        /// <summary>
        /// Системный код инициализации
        /// </summary>
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastDino));
            this.PMenu = new System.Windows.Forms.Panel();
            this.TBMenuUserName = new System.Windows.Forms.TextBox();
            this.LMenuUserName = new System.Windows.Forms.Label();
            this.BMenuExit = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.BMenuSettings = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.BMenuRecords = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.BMenuGame = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.PSettings = new System.Windows.Forms.Panel();
            this.LSettingsDifficulity = new System.Windows.Forms.Label();
            this.GBSettingsDifficulty = new System.Windows.Forms.GroupBox();
            this.mTBGBSettingsAccelerationDelay = new System.Windows.Forms.MaskedTextBox();
            this.mTBGBSettingsMinSpawnDelay = new System.Windows.Forms.MaskedTextBox();
            this.mTBGBSettingsMaxSpawnDelay = new System.Windows.Forms.MaskedTextBox();
            this.LGBSettingsMinSpawnDelay = new System.Windows.Forms.Label();
            this.LGBSettingsAccelerationDelay = new System.Windows.Forms.Label();
            this.LGBSettingsMaxSpawnDelay = new System.Windows.Forms.Label();
            this.RBSettingsDifficultComplexity = new CourseWorkOOP_Dmitry_.ModificationRadioButton();
            this.RBSettingsDifficultyNormal = new CourseWorkOOP_Dmitry_.ModificationRadioButton();
            this.RBSettingsDifficultyEasy = new CourseWorkOOP_Dmitry_.ModificationRadioButton();
            this.RBSettingsDifficultyCustom = new CourseWorkOOP_Dmitry_.ModificationRadioButton();
            this.CBSettingsFullScreen = new CourseWorkOOP_Dmitry_.ModificationCheckBox();
            this.BSettingsNightTheme = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.BSettingsLightTheme = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.BSettingsBack = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.PRecords = new System.Windows.Forms.Panel();
            this.BRecordsRemove = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.dGVRecords = new CourseWorkOOP_Dmitry_.ModificationDataGridView();
            this.CGVRecordsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGVRecordsRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGVRecordsDifficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRecordsSortByRecord = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.BRecordsSortByName = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.BRecordsMoreDetails = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.BRecordsBack = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.PGame = new System.Windows.Forms.Panel();
            this.BGamePause = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.LGameShowCoin = new System.Windows.Forms.Label();
            this.LGameShowUserName = new System.Windows.Forms.Label();
            this.LGameCoin = new System.Windows.Forms.Label();
            this.LGameUserName = new System.Windows.Forms.Label();
            this.PBGameDrawing = new CourseWorkOOP_Dmitry_.ModificationPictureBox();
            this.PGameEnd = new CourseWorkOOP_Dmitry_.PanelWindow();
            this.label1 = new System.Windows.Forms.Label();
            this.BGameEndBack = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.BEndBack = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.LEnd = new System.Windows.Forms.Label();
            this.PGamePause = new CourseWorkOOP_Dmitry_.PanelWindow();
            this.BGamePauseBack = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.BPauseBack = new CourseWorkOOP_Dmitry_.ModificationButton();
            this.LPause = new System.Windows.Forms.Label();
            this.PRecordsMoreDetails = new CourseWorkOOP_Dmitry_.PanelWindow();
            this.LPRecordsShowUserRecord = new System.Windows.Forms.Label();
            this.LPRecordsShowUserName = new System.Windows.Forms.Label();
            this.LPRecordsShowAccelerationDelay = new System.Windows.Forms.Label();
            this.LPRecordsShowMinSpawnDelay = new System.Windows.Forms.Label();
            this.LPRecordsShowMaxSpawnDelay = new System.Windows.Forms.Label();
            this.LPRecordsUserDifficulity = new System.Windows.Forms.Label();
            this.LPRecordsMinSpawnDelay = new System.Windows.Forms.Label();
            this.LPRecordsAccelerationDelay = new System.Windows.Forms.Label();
            this.LPRecordsMaxSpawnDelay = new System.Windows.Forms.Label();
            this.LPRecordsUserRecord = new System.Windows.Forms.Label();
            this.LPRecordsUserName = new System.Windows.Forms.Label();
            this.PMenu.SuspendLayout();
            this.PSettings.SuspendLayout();
            this.GBSettingsDifficulty.SuspendLayout();
            this.PRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRecords)).BeginInit();
            this.PGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBGameDrawing)).BeginInit();
            this.PGameEnd.SuspendLayout();
            this.PGamePause.SuspendLayout();
            this.PRecordsMoreDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // PMenu
            // 
            this.PMenu.Controls.Add(this.TBMenuUserName);
            this.PMenu.Controls.Add(this.LMenuUserName);
            this.PMenu.Controls.Add(this.BMenuExit);
            this.PMenu.Controls.Add(this.BMenuSettings);
            this.PMenu.Controls.Add(this.BMenuRecords);
            this.PMenu.Controls.Add(this.BMenuGame);
            this.PMenu.Location = new System.Drawing.Point(13, 13);
            this.PMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(671, 340);
            this.PMenu.TabIndex = 0;
            // 
            // TBMenuUserName
            // 
            this.TBMenuUserName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBMenuUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBMenuUserName.Location = new System.Drawing.Point(371, 290);
            this.TBMenuUserName.Name = "TBMenuUserName";
            this.TBMenuUserName.Size = new System.Drawing.Size(195, 31);
            this.TBMenuUserName.TabIndex = 13;
            this.TBMenuUserName.Text = "User";
            this.TBMenuUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBMenuUserName.Leave += new System.EventHandler(this.TBMenuUserName_Leave);
            // 
            // LMenuUserName
            // 
            this.LMenuUserName.AutoSize = true;
            this.LMenuUserName.Location = new System.Drawing.Point(84, 290);
            this.LMenuUserName.Name = "LMenuUserName";
            this.LMenuUserName.Size = new System.Drawing.Size(283, 29);
            this.LMenuUserName.TabIndex = 11;
            this.LMenuUserName.Text = "Имя пользователя: ";
            // 
            // BMenuExit
            // 
            this.BMenuExit.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BMenuExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMenuExit.FlatAppearance.BorderSize = 0;
            this.BMenuExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMenuExit.Location = new System.Drawing.Point(455, 62);
            this.BMenuExit.Margin = new System.Windows.Forms.Padding(4);
            this.BMenuExit.Name = "BMenuExit";
            this.BMenuExit.Size = new System.Drawing.Size(170, 52);
            this.BMenuExit.TabIndex = 3;
            this.BMenuExit.Text = "Выход";
            this.BMenuExit.UseVisualStyleBackColor = true;
            this.BMenuExit.Click += new System.EventHandler(this.BMenuExit_Click);
            // 
            // BMenuSettings
            // 
            this.BMenuSettings.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BMenuSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMenuSettings.FlatAppearance.BorderSize = 0;
            this.BMenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMenuSettings.Location = new System.Drawing.Point(363, 141);
            this.BMenuSettings.Margin = new System.Windows.Forms.Padding(4);
            this.BMenuSettings.Name = "BMenuSettings";
            this.BMenuSettings.Size = new System.Drawing.Size(170, 52);
            this.BMenuSettings.TabIndex = 2;
            this.BMenuSettings.Text = "Настройки";
            this.BMenuSettings.UseVisualStyleBackColor = true;
            this.BMenuSettings.Click += new System.EventHandler(this.BMenuSettings_Click);
            // 
            // BMenuRecords
            // 
            this.BMenuRecords.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BMenuRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMenuRecords.FlatAppearance.BorderSize = 0;
            this.BMenuRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMenuRecords.Location = new System.Drawing.Point(143, 141);
            this.BMenuRecords.Margin = new System.Windows.Forms.Padding(4);
            this.BMenuRecords.Name = "BMenuRecords";
            this.BMenuRecords.Size = new System.Drawing.Size(170, 52);
            this.BMenuRecords.TabIndex = 1;
            this.BMenuRecords.Text = "Рекорды";
            this.BMenuRecords.UseVisualStyleBackColor = true;
            this.BMenuRecords.Click += new System.EventHandler(this.BMenuRecords_Click);
            // 
            // BMenuGame
            // 
            this.BMenuGame.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BMenuGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMenuGame.FlatAppearance.BorderSize = 0;
            this.BMenuGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMenuGame.Location = new System.Drawing.Point(46, 60);
            this.BMenuGame.Margin = new System.Windows.Forms.Padding(4);
            this.BMenuGame.Name = "BMenuGame";
            this.BMenuGame.Size = new System.Drawing.Size(170, 52);
            this.BMenuGame.TabIndex = 0;
            this.BMenuGame.Text = "Начать";
            this.BMenuGame.UseVisualStyleBackColor = true;
            this.BMenuGame.Click += new System.EventHandler(this.BMenuGame_Click);
            // 
            // PSettings
            // 
            this.PSettings.Controls.Add(this.LSettingsDifficulity);
            this.PSettings.Controls.Add(this.GBSettingsDifficulty);
            this.PSettings.Controls.Add(this.RBSettingsDifficultComplexity);
            this.PSettings.Controls.Add(this.RBSettingsDifficultyNormal);
            this.PSettings.Controls.Add(this.RBSettingsDifficultyEasy);
            this.PSettings.Controls.Add(this.RBSettingsDifficultyCustom);
            this.PSettings.Controls.Add(this.CBSettingsFullScreen);
            this.PSettings.Controls.Add(this.BSettingsNightTheme);
            this.PSettings.Controls.Add(this.BSettingsLightTheme);
            this.PSettings.Controls.Add(this.BSettingsBack);
            this.PSettings.Location = new System.Drawing.Point(12, 12);
            this.PSettings.Name = "PSettings";
            this.PSettings.Size = new System.Drawing.Size(673, 342);
            this.PSettings.TabIndex = 4;
            this.PSettings.Visible = false;
            // 
            // LSettingsDifficulity
            // 
            this.LSettingsDifficulity.AutoSize = true;
            this.LSettingsDifficulity.Location = new System.Drawing.Point(3, 129);
            this.LSettingsDifficulity.Name = "LSettingsDifficulity";
            this.LSettingsDifficulity.Size = new System.Drawing.Size(166, 29);
            this.LSettingsDifficulity.TabIndex = 10;
            this.LSettingsDifficulity.Text = "Сложность";
            // 
            // GBSettingsDifficulty
            // 
            this.GBSettingsDifficulty.Controls.Add(this.mTBGBSettingsAccelerationDelay);
            this.GBSettingsDifficulty.Controls.Add(this.mTBGBSettingsMinSpawnDelay);
            this.GBSettingsDifficulty.Controls.Add(this.mTBGBSettingsMaxSpawnDelay);
            this.GBSettingsDifficulty.Controls.Add(this.LGBSettingsMinSpawnDelay);
            this.GBSettingsDifficulty.Controls.Add(this.LGBSettingsAccelerationDelay);
            this.GBSettingsDifficulty.Controls.Add(this.LGBSettingsMaxSpawnDelay);
            this.GBSettingsDifficulty.Enabled = false;
            this.GBSettingsDifficulty.Location = new System.Drawing.Point(204, 160);
            this.GBSettingsDifficulty.Name = "GBSettingsDifficulty";
            this.GBSettingsDifficulty.Size = new System.Drawing.Size(464, 179);
            this.GBSettingsDifficulty.TabIndex = 9;
            this.GBSettingsDifficulty.TabStop = false;
            this.GBSettingsDifficulty.Text = "Настройка сложности    [Млс.]";
            // 
            // mTBGBSettingsAccelerationDelay
            // 
            this.mTBGBSettingsAccelerationDelay.Location = new System.Drawing.Point(360, 132);
            this.mTBGBSettingsAccelerationDelay.Mask = "00000";
            this.mTBGBSettingsAccelerationDelay.Name = "mTBGBSettingsAccelerationDelay";
            this.mTBGBSettingsAccelerationDelay.Size = new System.Drawing.Size(80, 38);
            this.mTBGBSettingsAccelerationDelay.TabIndex = 12;
            this.mTBGBSettingsAccelerationDelay.ValidatingType = typeof(int);
            this.mTBGBSettingsAccelerationDelay.Leave += new System.EventHandler(this.mTBGBSettingsAccelerationDelay_Leave);
            // 
            // mTBGBSettingsMinSpawnDelay
            // 
            this.mTBGBSettingsMinSpawnDelay.Location = new System.Drawing.Point(360, 88);
            this.mTBGBSettingsMinSpawnDelay.Mask = "00000";
            this.mTBGBSettingsMinSpawnDelay.Name = "mTBGBSettingsMinSpawnDelay";
            this.mTBGBSettingsMinSpawnDelay.Size = new System.Drawing.Size(80, 38);
            this.mTBGBSettingsMinSpawnDelay.TabIndex = 11;
            this.mTBGBSettingsMinSpawnDelay.ValidatingType = typeof(int);
            this.mTBGBSettingsMinSpawnDelay.Leave += new System.EventHandler(this.mTBGBSettingsMinSpawnDelay_Leave);
            // 
            // mTBGBSettingsMaxSpawnDelay
            // 
            this.mTBGBSettingsMaxSpawnDelay.BeepOnError = true;
            this.mTBGBSettingsMaxSpawnDelay.Location = new System.Drawing.Point(360, 44);
            this.mTBGBSettingsMaxSpawnDelay.Mask = "00000";
            this.mTBGBSettingsMaxSpawnDelay.Name = "mTBGBSettingsMaxSpawnDelay";
            this.mTBGBSettingsMaxSpawnDelay.Size = new System.Drawing.Size(80, 38);
            this.mTBGBSettingsMaxSpawnDelay.TabIndex = 10;
            this.mTBGBSettingsMaxSpawnDelay.ValidatingType = typeof(int);
            this.mTBGBSettingsMaxSpawnDelay.Leave += new System.EventHandler(this.mTBGBSettingsMaxSpawnDelay_Leave);
            // 
            // LGBSettingsMinSpawnDelay
            // 
            this.LGBSettingsMinSpawnDelay.AutoSize = true;
            this.LGBSettingsMinSpawnDelay.Location = new System.Drawing.Point(1, 91);
            this.LGBSettingsMinSpawnDelay.Name = "LGBSettingsMinSpawnDelay";
            this.LGBSettingsMinSpawnDelay.Size = new System.Drawing.Size(359, 29);
            this.LGBSettingsMinSpawnDelay.TabIndex = 8;
            this.LGBSettingsMinSpawnDelay.Text = "Мин.  задержка спавна: ";
            // 
            // LGBSettingsAccelerationDelay
            // 
            this.LGBSettingsAccelerationDelay.AutoSize = true;
            this.LGBSettingsAccelerationDelay.Location = new System.Drawing.Point(1, 135);
            this.LGBSettingsAccelerationDelay.Name = "LGBSettingsAccelerationDelay";
            this.LGBSettingsAccelerationDelay.Size = new System.Drawing.Size(329, 29);
            this.LGBSettingsAccelerationDelay.TabIndex = 2;
            this.LGBSettingsAccelerationDelay.Text = "Задержка ускорения: ";
            // 
            // LGBSettingsMaxSpawnDelay
            // 
            this.LGBSettingsMaxSpawnDelay.AutoSize = true;
            this.LGBSettingsMaxSpawnDelay.Location = new System.Drawing.Point(1, 47);
            this.LGBSettingsMaxSpawnDelay.Name = "LGBSettingsMaxSpawnDelay";
            this.LGBSettingsMaxSpawnDelay.Size = new System.Drawing.Size(364, 29);
            this.LGBSettingsMaxSpawnDelay.TabIndex = 0;
            this.LGBSettingsMaxSpawnDelay.Text = "Макс задержка спавна: ";
            // 
            // RBSettingsDifficultComplexity
            // 
            this.RBSettingsDifficultComplexity.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBSettingsDifficultComplexity.FlatAppearance.BorderSize = 0;
            this.RBSettingsDifficultComplexity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBSettingsDifficultComplexity.ImageNo = null;
            this.RBSettingsDifficultComplexity.ImageYes = null;
            this.RBSettingsDifficultComplexity.Location = new System.Drawing.Point(5, 293);
            this.RBSettingsDifficultComplexity.Name = "RBSettingsDifficultComplexity";
            this.RBSettingsDifficultComplexity.Size = new System.Drawing.Size(197, 33);
            this.RBSettingsDifficultComplexity.TabIndex = 8;
            this.RBSettingsDifficultComplexity.Text = "Сложно";
            this.RBSettingsDifficultComplexity.UseVisualStyleBackColor = true;
            this.RBSettingsDifficultComplexity.CheckedChanged += new System.EventHandler(this.RBSettingsDifficultComplexity_CheckedChanged);
            // 
            // RBSettingsDifficultyNormal
            // 
            this.RBSettingsDifficultyNormal.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBSettingsDifficultyNormal.FlatAppearance.BorderSize = 0;
            this.RBSettingsDifficultyNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBSettingsDifficultyNormal.ImageNo = null;
            this.RBSettingsDifficultyNormal.ImageYes = null;
            this.RBSettingsDifficultyNormal.Location = new System.Drawing.Point(5, 244);
            this.RBSettingsDifficultyNormal.Name = "RBSettingsDifficultyNormal";
            this.RBSettingsDifficultyNormal.Size = new System.Drawing.Size(197, 33);
            this.RBSettingsDifficultyNormal.TabIndex = 7;
            this.RBSettingsDifficultyNormal.Text = "Нормально";
            this.RBSettingsDifficultyNormal.UseVisualStyleBackColor = true;
            this.RBSettingsDifficultyNormal.CheckedChanged += new System.EventHandler(this.RBSettingsDifficultyNormal_CheckedChanged);
            // 
            // RBSettingsDifficultyEasy
            // 
            this.RBSettingsDifficultyEasy.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBSettingsDifficultyEasy.Checked = true;
            this.RBSettingsDifficultyEasy.FlatAppearance.BorderSize = 0;
            this.RBSettingsDifficultyEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBSettingsDifficultyEasy.ImageNo = null;
            this.RBSettingsDifficultyEasy.ImageYes = null;
            this.RBSettingsDifficultyEasy.Location = new System.Drawing.Point(5, 205);
            this.RBSettingsDifficultyEasy.Name = "RBSettingsDifficultyEasy";
            this.RBSettingsDifficultyEasy.Size = new System.Drawing.Size(197, 33);
            this.RBSettingsDifficultyEasy.TabIndex = 6;
            this.RBSettingsDifficultyEasy.TabStop = true;
            this.RBSettingsDifficultyEasy.Text = "Легко";
            this.RBSettingsDifficultyEasy.UseVisualStyleBackColor = true;
            this.RBSettingsDifficultyEasy.CheckedChanged += new System.EventHandler(this.RBSettingsDifficultyEasy_CheckedChanged);
            // 
            // RBSettingsDifficultyCustom
            // 
            this.RBSettingsDifficultyCustom.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBSettingsDifficultyCustom.FlatAppearance.BorderSize = 0;
            this.RBSettingsDifficultyCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBSettingsDifficultyCustom.ImageNo = null;
            this.RBSettingsDifficultyCustom.ImageYes = null;
            this.RBSettingsDifficultyCustom.Location = new System.Drawing.Point(5, 161);
            this.RBSettingsDifficultyCustom.Name = "RBSettingsDifficultyCustom";
            this.RBSettingsDifficultyCustom.Size = new System.Drawing.Size(197, 33);
            this.RBSettingsDifficultyCustom.TabIndex = 5;
            this.RBSettingsDifficultyCustom.Text = "Своя";
            this.RBSettingsDifficultyCustom.UseVisualStyleBackColor = true;
            this.RBSettingsDifficultyCustom.CheckedChanged += new System.EventHandler(this.RBSettingsDifficultyCustom_CheckedChanged);
            // 
            // CBSettingsFullScreen
            // 
            this.CBSettingsFullScreen.Appearance = System.Windows.Forms.Appearance.Button;
            this.CBSettingsFullScreen.FlatAppearance.BorderSize = 0;
            this.CBSettingsFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBSettingsFullScreen.ImageNo = null;
            this.CBSettingsFullScreen.ImageYes = null;
            this.CBSettingsFullScreen.Location = new System.Drawing.Point(5, 64);
            this.CBSettingsFullScreen.Name = "CBSettingsFullScreen";
            this.CBSettingsFullScreen.Size = new System.Drawing.Size(410, 33);
            this.CBSettingsFullScreen.TabIndex = 4;
            this.CBSettingsFullScreen.Text = "Развернуть во весь экран";
            this.CBSettingsFullScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBSettingsFullScreen.UseVisualStyleBackColor = true;
            this.CBSettingsFullScreen.CheckedChanged += new System.EventHandler(this.CBSettingsFullScreen_CheckedChanged);
            // 
            // BSettingsNightTheme
            // 
            this.BSettingsNightTheme.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Тёмная_Тема;
            this.BSettingsNightTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BSettingsNightTheme.FlatAppearance.BorderSize = 0;
            this.BSettingsNightTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSettingsNightTheme.Location = new System.Drawing.Point(556, 5);
            this.BSettingsNightTheme.Margin = new System.Windows.Forms.Padding(4);
            this.BSettingsNightTheme.Name = "BSettingsNightTheme";
            this.BSettingsNightTheme.Size = new System.Drawing.Size(52, 52);
            this.BSettingsNightTheme.TabIndex = 3;
            this.BSettingsNightTheme.UseVisualStyleBackColor = true;
            this.BSettingsNightTheme.Click += new System.EventHandler(this.BSettingsNightTheme_Click);
            // 
            // BSettingsLightTheme
            // 
            this.BSettingsLightTheme.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Тема;
            this.BSettingsLightTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BSettingsLightTheme.FlatAppearance.BorderSize = 0;
            this.BSettingsLightTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSettingsLightTheme.Location = new System.Drawing.Point(616, 5);
            this.BSettingsLightTheme.Margin = new System.Windows.Forms.Padding(4);
            this.BSettingsLightTheme.Name = "BSettingsLightTheme";
            this.BSettingsLightTheme.Size = new System.Drawing.Size(52, 52);
            this.BSettingsLightTheme.TabIndex = 2;
            this.BSettingsLightTheme.UseVisualStyleBackColor = true;
            this.BSettingsLightTheme.Click += new System.EventHandler(this.BSettingsLightTheme_Click);
            // 
            // BSettingsBack
            // 
            this.BSettingsBack.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BSettingsBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BSettingsBack.FlatAppearance.BorderSize = 0;
            this.BSettingsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSettingsBack.Location = new System.Drawing.Point(5, 5);
            this.BSettingsBack.Margin = new System.Windows.Forms.Padding(4);
            this.BSettingsBack.Name = "BSettingsBack";
            this.BSettingsBack.Size = new System.Drawing.Size(170, 52);
            this.BSettingsBack.TabIndex = 1;
            this.BSettingsBack.Text = "Вернуться";
            this.BSettingsBack.UseVisualStyleBackColor = true;
            this.BSettingsBack.Click += new System.EventHandler(this.BSettingsBack_Click);
            // 
            // PRecords
            // 
            this.PRecords.Controls.Add(this.BRecordsRemove);
            this.PRecords.Controls.Add(this.dGVRecords);
            this.PRecords.Controls.Add(this.BRecordsSortByRecord);
            this.PRecords.Controls.Add(this.BRecordsSortByName);
            this.PRecords.Controls.Add(this.BRecordsMoreDetails);
            this.PRecords.Controls.Add(this.BRecordsBack);
            this.PRecords.Location = new System.Drawing.Point(12, 12);
            this.PRecords.Name = "PRecords";
            this.PRecords.Size = new System.Drawing.Size(673, 342);
            this.PRecords.TabIndex = 5;
            // 
            // BRecordsRemove
            // 
            this.BRecordsRemove.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BRecordsRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BRecordsRemove.FlatAppearance.BorderSize = 0;
            this.BRecordsRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRecordsRemove.Location = new System.Drawing.Point(23, 69);
            this.BRecordsRemove.Margin = new System.Windows.Forms.Padding(4);
            this.BRecordsRemove.Name = "BRecordsRemove";
            this.BRecordsRemove.Size = new System.Drawing.Size(179, 52);
            this.BRecordsRemove.TabIndex = 8;
            this.BRecordsRemove.Text = "Удалить";
            this.BRecordsRemove.UseVisualStyleBackColor = true;
            this.BRecordsRemove.Click += new System.EventHandler(this.BRecordsRemove_Click);
            // 
            // dGVRecords
            // 
            this.dGVRecords.AllowUserToAddRows = false;
            this.dGVRecords.AllowUserToDeleteRows = false;
            this.dGVRecords.AllowUserToResizeColumns = false;
            this.dGVRecords.AllowUserToResizeRows = false;
            this.dGVRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVRecords.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dGVRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CGVRecordsName,
            this.CGVRecordsRecord,
            this.CGVRecordsDifficulty});
            this.dGVRecords.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dGVRecords.Location = new System.Drawing.Point(237, 17);
            this.dGVRecords.Name = "dGVRecords";
            this.dGVRecords.ReadOnly = true;
            this.dGVRecords.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dGVRecords.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVRecords.Size = new System.Drawing.Size(436, 320);
            this.dGVRecords.TabIndex = 7;
            this.dGVRecords.SelectionChanged += new System.EventHandler(this.dGVRecords_SelectionChanged);
            // 
            // CGVRecordsName
            // 
            this.CGVRecordsName.HeaderText = "Имя";
            this.CGVRecordsName.Name = "CGVRecordsName";
            this.CGVRecordsName.ReadOnly = true;
            this.CGVRecordsName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CGVRecordsRecord
            // 
            this.CGVRecordsRecord.HeaderText = "Рекорд";
            this.CGVRecordsRecord.Name = "CGVRecordsRecord";
            this.CGVRecordsRecord.ReadOnly = true;
            this.CGVRecordsRecord.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CGVRecordsDifficulty
            // 
            this.CGVRecordsDifficulty.HeaderText = "Сложн.";
            this.CGVRecordsDifficulty.Name = "CGVRecordsDifficulty";
            this.CGVRecordsDifficulty.ReadOnly = true;
            this.CGVRecordsDifficulty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BRecordsSortByRecord
            // 
            this.BRecordsSortByRecord.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BRecordsSortByRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BRecordsSortByRecord.FlatAppearance.BorderSize = 0;
            this.BRecordsSortByRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRecordsSortByRecord.Location = new System.Drawing.Point(5, 267);
            this.BRecordsSortByRecord.Margin = new System.Windows.Forms.Padding(4);
            this.BRecordsSortByRecord.Name = "BRecordsSortByRecord";
            this.BRecordsSortByRecord.Size = new System.Drawing.Size(216, 73);
            this.BRecordsSortByRecord.TabIndex = 6;
            this.BRecordsSortByRecord.Text = "Сортировать по Рекорду";
            this.BRecordsSortByRecord.UseVisualStyleBackColor = true;
            this.BRecordsSortByRecord.Click += new System.EventHandler(this.BRecordsSortByRecord_Click);
            // 
            // BRecordsSortByName
            // 
            this.BRecordsSortByName.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BRecordsSortByName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BRecordsSortByName.FlatAppearance.BorderSize = 0;
            this.BRecordsSortByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRecordsSortByName.Location = new System.Drawing.Point(5, 189);
            this.BRecordsSortByName.Margin = new System.Windows.Forms.Padding(4);
            this.BRecordsSortByName.Name = "BRecordsSortByName";
            this.BRecordsSortByName.Size = new System.Drawing.Size(216, 73);
            this.BRecordsSortByName.TabIndex = 5;
            this.BRecordsSortByName.Text = "Сортировать по Имени";
            this.BRecordsSortByName.UseVisualStyleBackColor = true;
            this.BRecordsSortByName.Click += new System.EventHandler(this.BRecordsSortByName_Click);
            // 
            // BRecordsMoreDetails
            // 
            this.BRecordsMoreDetails.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BRecordsMoreDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BRecordsMoreDetails.FlatAppearance.BorderSize = 0;
            this.BRecordsMoreDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRecordsMoreDetails.Location = new System.Drawing.Point(23, 129);
            this.BRecordsMoreDetails.Margin = new System.Windows.Forms.Padding(4);
            this.BRecordsMoreDetails.Name = "BRecordsMoreDetails";
            this.BRecordsMoreDetails.Size = new System.Drawing.Size(179, 52);
            this.BRecordsMoreDetails.TabIndex = 4;
            this.BRecordsMoreDetails.Text = "Подробнее";
            this.BRecordsMoreDetails.UseVisualStyleBackColor = true;
            this.BRecordsMoreDetails.Click += new System.EventHandler(this.BRecordsMoreDetails_Click);
            // 
            // BRecordsBack
            // 
            this.BRecordsBack.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BRecordsBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BRecordsBack.FlatAppearance.BorderSize = 0;
            this.BRecordsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRecordsBack.Location = new System.Drawing.Point(23, 9);
            this.BRecordsBack.Margin = new System.Windows.Forms.Padding(4);
            this.BRecordsBack.Name = "BRecordsBack";
            this.BRecordsBack.Size = new System.Drawing.Size(179, 52);
            this.BRecordsBack.TabIndex = 2;
            this.BRecordsBack.Text = "Вернуться";
            this.BRecordsBack.UseVisualStyleBackColor = true;
            this.BRecordsBack.Click += new System.EventHandler(this.BRecordsBack_Click);
            // 
            // PGame
            // 
            this.PGame.Controls.Add(this.BGamePause);
            this.PGame.Controls.Add(this.LGameShowCoin);
            this.PGame.Controls.Add(this.LGameShowUserName);
            this.PGame.Controls.Add(this.LGameCoin);
            this.PGame.Controls.Add(this.LGameUserName);
            this.PGame.Controls.Add(this.PBGameDrawing);
            this.PGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PGame.Location = new System.Drawing.Point(0, 0);
            this.PGame.Name = "PGame";
            this.PGame.Size = new System.Drawing.Size(697, 366);
            this.PGame.TabIndex = 6;
            this.PGame.Visible = false;
            // 
            // BGamePause
            // 
            this.BGamePause.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_МенюИгровогоПроцесса;
            this.BGamePause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BGamePause.FlatAppearance.BorderSize = 0;
            this.BGamePause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGamePause.Location = new System.Drawing.Point(4, 4);
            this.BGamePause.Margin = new System.Windows.Forms.Padding(4);
            this.BGamePause.Name = "BGamePause";
            this.BGamePause.Size = new System.Drawing.Size(52, 52);
            this.BGamePause.TabIndex = 2;
            this.BGamePause.UseVisualStyleBackColor = true;
            this.BGamePause.Click += new System.EventHandler(this.BGamePause_Click);
            // 
            // LGameShowCoin
            // 
            this.LGameShowCoin.AutoSize = true;
            this.LGameShowCoin.Location = new System.Drawing.Point(338, 29);
            this.LGameShowCoin.Name = "LGameShowCoin";
            this.LGameShowCoin.Size = new System.Drawing.Size(0, 29);
            this.LGameShowCoin.TabIndex = 6;
            // 
            // LGameShowUserName
            // 
            this.LGameShowUserName.AutoSize = true;
            this.LGameShowUserName.Location = new System.Drawing.Point(338, 4);
            this.LGameShowUserName.Name = "LGameShowUserName";
            this.LGameShowUserName.Size = new System.Drawing.Size(0, 29);
            this.LGameShowUserName.TabIndex = 5;
            // 
            // LGameCoin
            // 
            this.LGameCoin.AutoSize = true;
            this.LGameCoin.BackColor = System.Drawing.Color.Transparent;
            this.LGameCoin.Location = new System.Drawing.Point(63, 33);
            this.LGameCoin.Name = "LGameCoin";
            this.LGameCoin.Size = new System.Drawing.Size(92, 29);
            this.LGameCoin.TabIndex = 4;
            this.LGameCoin.Text = "Счёт: ";
            // 
            // LGameUserName
            // 
            this.LGameUserName.AutoSize = true;
            this.LGameUserName.BackColor = System.Drawing.Color.Transparent;
            this.LGameUserName.Location = new System.Drawing.Point(63, 4);
            this.LGameUserName.Name = "LGameUserName";
            this.LGameUserName.Size = new System.Drawing.Size(283, 29);
            this.LGameUserName.TabIndex = 3;
            this.LGameUserName.Text = "Имя пользователя: ";
            // 
            // PBGameDrawing
            // 
            this.PBGameDrawing.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_ФонИгры;
            this.PBGameDrawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBGameDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBGameDrawing.Location = new System.Drawing.Point(0, 0);
            this.PBGameDrawing.Name = "PBGameDrawing";
            this.PBGameDrawing.Size = new System.Drawing.Size(697, 366);
            this.PBGameDrawing.TabIndex = 7;
            this.PBGameDrawing.TabStop = false;
            // 
            // PGameEnd
            // 
            this.PGameEnd.BackColor = System.Drawing.Color.Transparent;
            this.PGameEnd.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_ОкноПрограммы;
            this.PGameEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PGameEnd.CloseButtonImage = null;
            this.PGameEnd.Controls.Add(this.label1);
            this.PGameEnd.Controls.Add(this.BGameEndBack);
            this.PGameEnd.Controls.Add(this.BEndBack);
            this.PGameEnd.Controls.Add(this.LEnd);
            this.PGameEnd.Location = new System.Drawing.Point(123, 40);
            this.PGameEnd.Name = "PGameEnd";
            this.PGameEnd.Size = new System.Drawing.Size(467, 303);
            this.PGameEnd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ваш счёт был сохранён";
            // 
            // BGameEndBack
            // 
            this.BGameEndBack.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BGameEndBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BGameEndBack.FlatAppearance.BorderSize = 0;
            this.BGameEndBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGameEndBack.Location = new System.Drawing.Point(113, 190);
            this.BGameEndBack.Margin = new System.Windows.Forms.Padding(4);
            this.BGameEndBack.Name = "BGameEndBack";
            this.BGameEndBack.Size = new System.Drawing.Size(240, 51);
            this.BGameEndBack.TabIndex = 18;
            this.BGameEndBack.Text = "Покинуть игру";
            this.BGameEndBack.UseVisualStyleBackColor = true;
            this.BGameEndBack.Click += new System.EventHandler(this.BGameEndBack_Click);
            // 
            // BEndBack
            // 
            this.BEndBack.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BEndBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BEndBack.FlatAppearance.BorderSize = 0;
            this.BEndBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEndBack.Location = new System.Drawing.Point(113, 131);
            this.BEndBack.Margin = new System.Windows.Forms.Padding(4);
            this.BEndBack.Name = "BEndBack";
            this.BEndBack.Size = new System.Drawing.Size(240, 52);
            this.BEndBack.TabIndex = 17;
            this.BEndBack.Text = "Перезапустить";
            this.BEndBack.UseVisualStyleBackColor = true;
            this.BEndBack.Click += new System.EventHandler(this.BEndBack_Click);
            // 
            // LEnd
            // 
            this.LEnd.AutoSize = true;
            this.LEnd.Location = new System.Drawing.Point(123, 62);
            this.LEnd.Name = "LEnd";
            this.LEnd.Size = new System.Drawing.Size(215, 29);
            this.LEnd.TabIndex = 16;
            this.LEnd.Text = "Игра окончена";
            // 
            // PGamePause
            // 
            this.PGamePause.BackColor = System.Drawing.Color.Transparent;
            this.PGamePause.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_ОкноПрограммы;
            this.PGamePause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PGamePause.CloseButtonImage = null;
            this.PGamePause.Controls.Add(this.BGamePauseBack);
            this.PGamePause.Controls.Add(this.BPauseBack);
            this.PGamePause.Controls.Add(this.LPause);
            this.PGamePause.Location = new System.Drawing.Point(115, 32);
            this.PGamePause.Name = "PGamePause";
            this.PGamePause.Size = new System.Drawing.Size(467, 303);
            this.PGamePause.TabIndex = 8;
            // 
            // BGamePauseBack
            // 
            this.BGamePauseBack.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BGamePauseBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BGamePauseBack.FlatAppearance.BorderSize = 0;
            this.BGamePauseBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGamePauseBack.Location = new System.Drawing.Point(136, 175);
            this.BGamePauseBack.Margin = new System.Windows.Forms.Padding(4);
            this.BGamePauseBack.Name = "BGamePauseBack";
            this.BGamePauseBack.Size = new System.Drawing.Size(194, 66);
            this.BGamePauseBack.TabIndex = 18;
            this.BGamePauseBack.Text = "Покинуть игру";
            this.BGamePauseBack.UseVisualStyleBackColor = true;
            this.BGamePauseBack.Click += new System.EventHandler(this.BGamePauseBack_Click);
            // 
            // BPauseBack
            // 
            this.BPauseBack.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_Кнопка;
            this.BPauseBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BPauseBack.FlatAppearance.BorderSize = 0;
            this.BPauseBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPauseBack.Location = new System.Drawing.Point(136, 116);
            this.BPauseBack.Margin = new System.Windows.Forms.Padding(4);
            this.BPauseBack.Name = "BPauseBack";
            this.BPauseBack.Size = new System.Drawing.Size(194, 52);
            this.BPauseBack.TabIndex = 17;
            this.BPauseBack.Text = "Продолжить";
            this.BPauseBack.UseVisualStyleBackColor = true;
            this.BPauseBack.Click += new System.EventHandler(this.BPauseBack_Click);
            // 
            // LPause
            // 
            this.LPause.AutoSize = true;
            this.LPause.Location = new System.Drawing.Point(74, 61);
            this.LPause.Name = "LPause";
            this.LPause.Size = new System.Drawing.Size(318, 29);
            this.LPause.TabIndex = 16;
            this.LPause.Text = "Игра приостановлена";
            // 
            // PRecordsMoreDetails
            // 
            this.PRecordsMoreDetails.BackColor = System.Drawing.Color.Transparent;
            this.PRecordsMoreDetails.BackgroundImage = global::CourseWorkOOP_Dmitry_.Properties.Resources.Светлая_ОкноПрограммы;
            this.PRecordsMoreDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PRecordsMoreDetails.CloseButtonImage = null;
            this.PRecordsMoreDetails.Controls.Add(this.LPRecordsShowUserRecord);
            this.PRecordsMoreDetails.Controls.Add(this.LPRecordsShowUserName);
            this.PRecordsMoreDetails.Controls.Add(this.LPRecordsShowAccelerationDelay);
            this.PRecordsMoreDetails.Controls.Add(this.LPRecordsShowMinSpawnDelay);
            this.PRecordsMoreDetails.Controls.Add(this.LPRecordsShowMaxSpawnDelay);
            this.PRecordsMoreDetails.Controls.Add(this.LPRecordsUserDifficulity);
            this.PRecordsMoreDetails.Controls.Add(this.LPRecordsMinSpawnDelay);
            this.PRecordsMoreDetails.Controls.Add(this.LPRecordsAccelerationDelay);
            this.PRecordsMoreDetails.Controls.Add(this.LPRecordsMaxSpawnDelay);
            this.PRecordsMoreDetails.Controls.Add(this.LPRecordsUserRecord);
            this.PRecordsMoreDetails.Controls.Add(this.LPRecordsUserName);
            this.PRecordsMoreDetails.Location = new System.Drawing.Point(131, 31);
            this.PRecordsMoreDetails.Name = "PRecordsMoreDetails";
            this.PRecordsMoreDetails.Size = new System.Drawing.Size(467, 303);
            this.PRecordsMoreDetails.TabIndex = 0;
            // 
            // LPRecordsShowUserRecord
            // 
            this.LPRecordsShowUserRecord.AutoSize = true;
            this.LPRecordsShowUserRecord.BackColor = System.Drawing.Color.Transparent;
            this.LPRecordsShowUserRecord.Location = new System.Drawing.Point(287, 85);
            this.LPRecordsShowUserRecord.Name = "LPRecordsShowUserRecord";
            this.LPRecordsShowUserRecord.Size = new System.Drawing.Size(0, 29);
            this.LPRecordsShowUserRecord.TabIndex = 17;
            // 
            // LPRecordsShowUserName
            // 
            this.LPRecordsShowUserName.AutoSize = true;
            this.LPRecordsShowUserName.BackColor = System.Drawing.Color.Transparent;
            this.LPRecordsShowUserName.Location = new System.Drawing.Point(287, 56);
            this.LPRecordsShowUserName.Name = "LPRecordsShowUserName";
            this.LPRecordsShowUserName.Size = new System.Drawing.Size(0, 29);
            this.LPRecordsShowUserName.TabIndex = 16;
            // 
            // LPRecordsShowAccelerationDelay
            // 
            this.LPRecordsShowAccelerationDelay.AutoSize = true;
            this.LPRecordsShowAccelerationDelay.BackColor = System.Drawing.Color.Transparent;
            this.LPRecordsShowAccelerationDelay.Location = new System.Drawing.Point(368, 224);
            this.LPRecordsShowAccelerationDelay.Name = "LPRecordsShowAccelerationDelay";
            this.LPRecordsShowAccelerationDelay.Size = new System.Drawing.Size(0, 29);
            this.LPRecordsShowAccelerationDelay.TabIndex = 15;
            // 
            // LPRecordsShowMinSpawnDelay
            // 
            this.LPRecordsShowMinSpawnDelay.AutoSize = true;
            this.LPRecordsShowMinSpawnDelay.BackColor = System.Drawing.Color.Transparent;
            this.LPRecordsShowMinSpawnDelay.Location = new System.Drawing.Point(368, 198);
            this.LPRecordsShowMinSpawnDelay.Name = "LPRecordsShowMinSpawnDelay";
            this.LPRecordsShowMinSpawnDelay.Size = new System.Drawing.Size(0, 29);
            this.LPRecordsShowMinSpawnDelay.TabIndex = 14;
            // 
            // LPRecordsShowMaxSpawnDelay
            // 
            this.LPRecordsShowMaxSpawnDelay.AutoSize = true;
            this.LPRecordsShowMaxSpawnDelay.BackColor = System.Drawing.Color.Transparent;
            this.LPRecordsShowMaxSpawnDelay.Location = new System.Drawing.Point(368, 169);
            this.LPRecordsShowMaxSpawnDelay.Name = "LPRecordsShowMaxSpawnDelay";
            this.LPRecordsShowMaxSpawnDelay.Size = new System.Drawing.Size(0, 29);
            this.LPRecordsShowMaxSpawnDelay.TabIndex = 13;
            // 
            // LPRecordsUserDifficulity
            // 
            this.LPRecordsUserDifficulity.AutoSize = true;
            this.LPRecordsUserDifficulity.BackColor = System.Drawing.Color.Transparent;
            this.LPRecordsUserDifficulity.Location = new System.Drawing.Point(20, 140);
            this.LPRecordsUserDifficulity.Name = "LPRecordsUserDifficulity";
            this.LPRecordsUserDifficulity.Size = new System.Drawing.Size(166, 29);
            this.LPRecordsUserDifficulity.TabIndex = 12;
            this.LPRecordsUserDifficulity.Text = "Сложность";
            // 
            // LPRecordsMinSpawnDelay
            // 
            this.LPRecordsMinSpawnDelay.AutoSize = true;
            this.LPRecordsMinSpawnDelay.BackColor = System.Drawing.Color.Transparent;
            this.LPRecordsMinSpawnDelay.Location = new System.Drawing.Point(20, 198);
            this.LPRecordsMinSpawnDelay.Name = "LPRecordsMinSpawnDelay";
            this.LPRecordsMinSpawnDelay.Size = new System.Drawing.Size(359, 29);
            this.LPRecordsMinSpawnDelay.TabIndex = 11;
            this.LPRecordsMinSpawnDelay.Text = "Мин.  задержка спавна: ";
            // 
            // LPRecordsAccelerationDelay
            // 
            this.LPRecordsAccelerationDelay.AutoSize = true;
            this.LPRecordsAccelerationDelay.BackColor = System.Drawing.Color.Transparent;
            this.LPRecordsAccelerationDelay.Location = new System.Drawing.Point(20, 227);
            this.LPRecordsAccelerationDelay.Name = "LPRecordsAccelerationDelay";
            this.LPRecordsAccelerationDelay.Size = new System.Drawing.Size(329, 29);
            this.LPRecordsAccelerationDelay.TabIndex = 10;
            this.LPRecordsAccelerationDelay.Text = "Задержка ускорения: ";
            // 
            // LPRecordsMaxSpawnDelay
            // 
            this.LPRecordsMaxSpawnDelay.AutoSize = true;
            this.LPRecordsMaxSpawnDelay.BackColor = System.Drawing.Color.Transparent;
            this.LPRecordsMaxSpawnDelay.Location = new System.Drawing.Point(20, 169);
            this.LPRecordsMaxSpawnDelay.Name = "LPRecordsMaxSpawnDelay";
            this.LPRecordsMaxSpawnDelay.Size = new System.Drawing.Size(364, 29);
            this.LPRecordsMaxSpawnDelay.TabIndex = 9;
            this.LPRecordsMaxSpawnDelay.Text = "Макс задержка спавна: ";
            // 
            // LPRecordsUserRecord
            // 
            this.LPRecordsUserRecord.AutoSize = true;
            this.LPRecordsUserRecord.BackColor = System.Drawing.Color.Transparent;
            this.LPRecordsUserRecord.Location = new System.Drawing.Point(20, 85);
            this.LPRecordsUserRecord.Name = "LPRecordsUserRecord";
            this.LPRecordsUserRecord.Size = new System.Drawing.Size(92, 29);
            this.LPRecordsUserRecord.TabIndex = 2;
            this.LPRecordsUserRecord.Text = "Счёт: ";
            // 
            // LPRecordsUserName
            // 
            this.LPRecordsUserName.AutoSize = true;
            this.LPRecordsUserName.BackColor = System.Drawing.Color.Transparent;
            this.LPRecordsUserName.Location = new System.Drawing.Point(20, 56);
            this.LPRecordsUserName.Name = "LPRecordsUserName";
            this.LPRecordsUserName.Size = new System.Drawing.Size(283, 29);
            this.LPRecordsUserName.TabIndex = 1;
            this.LPRecordsUserName.Text = "Имя пользователя: ";
            // 
            // FastDino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(697, 366);
            this.Controls.Add(this.PGame);
            this.Controls.Add(this.PRecords);
            this.Controls.Add(this.PGameEnd);
            this.Controls.Add(this.PGamePause);
            this.Controls.Add(this.PRecordsMoreDetails);
            this.Controls.Add(this.PMenu);
            this.Controls.Add(this.PSettings);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("asinastra", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FastDino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Быстрый Дино";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FastDino_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FastDino_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FastDino_KeyUp);
            this.PMenu.ResumeLayout(false);
            this.PMenu.PerformLayout();
            this.PSettings.ResumeLayout(false);
            this.PSettings.PerformLayout();
            this.GBSettingsDifficulty.ResumeLayout(false);
            this.GBSettingsDifficulty.PerformLayout();
            this.PRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVRecords)).EndInit();
            this.PGame.ResumeLayout(false);
            this.PGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBGameDrawing)).EndInit();
            this.PGameEnd.ResumeLayout(false);
            this.PGameEnd.PerformLayout();
            this.PGamePause.ResumeLayout(false);
            this.PGamePause.PerformLayout();
            this.PRecordsMoreDetails.ResumeLayout(false);
            this.PRecordsMoreDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PMenu;
        private ModificationButton BMenuExit;
        private ModificationButton BMenuSettings;
        private ModificationButton BMenuRecords;
        private ModificationButton BMenuGame;
        private System.Windows.Forms.Panel PSettings;
        private ModificationButton BSettingsNightTheme;
        private ModificationButton BSettingsLightTheme;
        private ModificationButton BSettingsBack;
        private ModificationRadioButton RBSettingsDifficultComplexity;
        private ModificationRadioButton RBSettingsDifficultyNormal;
        private ModificationRadioButton RBSettingsDifficultyEasy;
        private System.Windows.Forms.Label LSettingsDifficulity;
        private System.Windows.Forms.GroupBox GBSettingsDifficulty;
        private System.Windows.Forms.Label LGBSettingsAccelerationDelay;
        private System.Windows.Forms.Label LGBSettingsMaxSpawnDelay;
        private System.Windows.Forms.Label LGBSettingsMinSpawnDelay;
        private System.Windows.Forms.MaskedTextBox mTBGBSettingsAccelerationDelay;
        private System.Windows.Forms.MaskedTextBox mTBGBSettingsMinSpawnDelay;
        private System.Windows.Forms.MaskedTextBox mTBGBSettingsMaxSpawnDelay;
        private System.Windows.Forms.Panel PRecords;
        private ModificationButton BRecordsBack;
        private ModificationButton BRecordsMoreDetails;
        private ModificationButton BRecordsSortByRecord;
        private ModificationButton BRecordsSortByName;
        private ModificationDataGridView dGVRecords;
        private ModificationRadioButton RBSettingsDifficultyCustom;
        private ModificationCheckBox CBSettingsFullScreen;
        private System.Windows.Forms.Label LPRecordsUserName;
        private System.Windows.Forms.Label LPRecordsUserRecord;
        private System.Windows.Forms.Label LPRecordsMaxSpawnDelay;
        private System.Windows.Forms.Label LPRecordsAccelerationDelay;
        private System.Windows.Forms.Label LPRecordsMinSpawnDelay;
        private System.Windows.Forms.Label LPRecordsUserDifficulity;
        private PanelWindow PRecordsMoreDetails;
        private System.Windows.Forms.Label LPRecordsShowAccelerationDelay;
        private System.Windows.Forms.Label LPRecordsShowMinSpawnDelay;
        private System.Windows.Forms.Label LPRecordsShowMaxSpawnDelay;
        private System.Windows.Forms.Label LPRecordsShowUserRecord;
        private System.Windows.Forms.Label LPRecordsShowUserName;
        private System.Windows.Forms.Panel PGame;
        private ModificationButton BGamePause;
        private ModificationPictureBox PBGameDrawing;
        private System.Windows.Forms.Label LGameShowCoin;
        private System.Windows.Forms.Label LGameShowUserName;
        private System.Windows.Forms.Label LGameCoin;
        private System.Windows.Forms.Label LGameUserName;
        private PanelWindow PGamePause;
        private ModificationButton BGamePauseBack;
        private ModificationButton BPauseBack;
        private System.Windows.Forms.Label LPause;
        private PanelWindow PGameEnd;
        private ModificationButton BGameEndBack;
        private ModificationButton BEndBack;
        private System.Windows.Forms.Label LEnd;
        private System.Windows.Forms.Label label1;
        private ModificationButton BRecordsRemove;
        private System.Windows.Forms.TextBox TBMenuUserName;
        private System.Windows.Forms.Label LMenuUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGVRecordsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGVRecordsRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGVRecordsDifficulty;
    }
}