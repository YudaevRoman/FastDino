using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkOOP_Dmitry_
{
    //Класс Формы
    public partial class FastDino : Form
    {
        //Конструктор
        public FastDino()
        {
            InitializeComponent();
            InitializeApplication();
        }
        /// <summary>
        /// Управление игрой
        /// </summary>
        //Передача нажатых клавиш классу игры
        private void FastDino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (game != null && game.IsGame)
            {
                this.ActiveControl = null;
                game?.characterCommands.Enqueue(e.KeyChar);
            }
        }
        private void FastDino_KeyUp(object sender, KeyEventArgs e)
        {
            if (game != null && game.IsGame)
            {
                this.ActiveControl = null;
                game?.characterCommands.Enqueue((char)0);
            }
        }

        //Метод отключения потоков перед закрытием формы
        private void FastDino_FormClosing(object sender, FormClosingEventArgs e)
        { if (game != null) game.End(); }/// <summary>
         /// Методы Родительского меню
         /// </summary>
        //Начало игры
        private void BMenuGame_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            formMenu.OpenItem(PGame);
            LGameShowUserName.Text = TBMenuUserName.Text;
            LGameShowCoin.Text = "0";
            game.End();
            game.Run(PBGameDrawing, settings, TBMenuUserName.Text);
        }
        //Открытие настроек
        private void BMenuSettings_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            formMenu.OpenItem(PSettings);
        }//Открытие рекордов
        private void BMenuRecords_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            records.OutputIn(dGVRecords);
            formMenu.OpenItem(PRecords);
        }
        //Выход
        private void BMenuExit_Click(object sender, EventArgs e)
            => Close();
        //Изменение имени пользователя
        private void TBMenuUserName_Leave(object sender, EventArgs e)
        {
            if (settings.UserName != TBMenuUserName.Text)
                settings.UserName = TBMenuUserName.Text;
        }
        /// <summary>
        /// Методы пункта меню "Начать"
        /// </summary>
        //Открыть пунтк "Пауза"
        private void BGamePause_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            formMenu.OpenItem(PGamePause, false);
            game?.Pause();
            PGame.Enabled = false;
        }
        //Вернуться из подпункта "Пауза"
        private void BPauseBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            formMenu.CloseItem();
            game?.Continue();
            PGame.Enabled = true;
        }
        //Вернуться из подпунтка меню "Начать" (закончить игру)
        private void BGamePauseBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            formMenu.CloseItem();
            formMenu.CloseItem();
            records.AddRecord(game.GetRecord());
            game?.End();
            PGame.Enabled = true;
        }
        //Открыть пукнт "Конец игры"
        private void Game_OnEndGame(object sender, EventArgs e)
        => Invoke((MethodInvoker)delegate
        {
            this.ActiveControl = null;
            formMenu.OpenItem(PGameEnd, false);
            records.AddRecord(game.GetRecord());
            PGame.Enabled = false;
        });
        //Вернуться из подпункта "Конец игры"
        private void BEndBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            formMenu.CloseItem();
            LGameShowUserName.Text = TBMenuUserName.Text;
            LGameShowCoin.Text = "0";
            game?.Run(PBGameDrawing, settings, TBMenuUserName.Text);
            PGame.Enabled = true;
        }
        //Вернуться из подпункта меню "Начать"
        private void BGameEndBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            formMenu.CloseItem();
            formMenu.CloseItem();
            game?.End();
            PGame.Enabled = true;
        }
        //Метод отображения очков пользователя
        private void Game_OnChangeScore(object sender, EventArgs e)
            => Invoke((MethodInvoker)delegate 
            { LGameShowCoin.Text = game.Score.ToString(); });
        /// <summary>
        /// Методы пункта меню "Настройки"
        /// </summary>
        //Вернуться из настроек в меню
        private void BSettingsBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            formMenu.CloseItem();
        }
        //Развернуть во весь экран
        private void CBSettingsFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (CBSettingsFullScreen.Checked) settings.WindowState = FormWindowState.Maximized;
            else settings.WindowState = FormWindowState.Normal;
        }
        //Переключение темы
        private void BSettingsNightTheme_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            settings.Theme = ComponentTheme.NIGHT_THEME;
        }
        private void BSettingsLightTheme_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            settings.Theme = ComponentTheme.LIGHT_THEME;
        }//Событие изменение Сложности
        private void Settings_OnChangeDifficulty(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            mTBGBSettingsMaxSpawnDelay.Text = 
                Convert.ToString(settings.Difficulty.MaxSpawnDelay);
            mTBGBSettingsMinSpawnDelay.Text = 
                Convert.ToString(settings.Difficulty.MinSpawnDelay);
            mTBGBSettingsAccelerationDelay.Text = 
                Convert.ToString(settings.Difficulty.AccelerationDelay);
        }
        //Изменение сложности
        private void RBSettingsDifficultyCustom_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            settings.Difficulty = new DifficultyLevel(Difficulty.MANUAL);
            mTBGBSettingsMaxSpawnDelay.Text = settings.Difficulty.MaxSpawnDelay.ToString();
            mTBGBSettingsMinSpawnDelay.Text = settings.Difficulty.MinSpawnDelay.ToString();
            mTBGBSettingsAccelerationDelay.Text = 
                settings.Difficulty.AccelerationDelay.ToString();
            GBSettingsDifficulty.Enabled = true;
        }
        private void RBSettingsDifficultyEasy_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            settings.Difficulty = new DifficultyLevel(Difficulty.EASY);
            GBSettingsDifficulty.Enabled = false;
        }
        private void RBSettingsDifficultyNormal_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            settings.Difficulty = new DifficultyLevel(Difficulty.NORMAL);
            GBSettingsDifficulty.Enabled = false;
        }
        private void RBSettingsDifficultComplexity_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            settings.Difficulty = new DifficultyLevel(Difficulty.COMPLEX);
            GBSettingsDifficulty.Enabled = false;
        }
        //Считывание данных своей настройки сложности
        private void mTBGBSettingsMaxSpawnDelay_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(mTBGBSettingsMaxSpawnDelay.Text, out int result))
                settings.Difficulty.MaxSpawnDelay = result;
            else mTBGBSettingsMaxSpawnDelay.Text = "0";
        }
        private void mTBGBSettingsMinSpawnDelay_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(mTBGBSettingsMinSpawnDelay.Text, out int result))
                settings.Difficulty.MinSpawnDelay = result;
            else mTBGBSettingsMinSpawnDelay.Text = "0";
        }
        private void mTBGBSettingsAccelerationDelay_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(mTBGBSettingsAccelerationDelay.Text, out int result))
                settings.Difficulty.AccelerationDelay = result;
            else mTBGBSettingsAccelerationDelay.Text = "0";
        }
        //Метод обработки изменения сложности
        private void Settings_OnChacgeDifficulty(object sender, System.EventArgs e)
        {
            this.ActiveControl = null;
            mTBGBSettingsMaxSpawnDelay.Text = settings.Difficulty.MaxSpawnDelay.ToString();
            mTBGBSettingsMinSpawnDelay.Text = settings.Difficulty.MinSpawnDelay.ToString();
            mTBGBSettingsAccelerationDelay.Text =
                settings.Difficulty.AccelerationDelay.ToString();
        }
        /// <summary>
        /// Методы пункта меню "Рекорды"
        /// </summary>
        //Вернуться из рекордов в меню
        private void BRecordsBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            formMenu.CloseItem();
        }
        //Сортировки
        private void BRecordsSortByName_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            records.SortingByName();
            records.OutputIn(dGVRecords);
        }
        private void BRecordsSortByRecord_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            records.SortingByRecord();
            records.OutputIn(dGVRecords);
        }
        //Удаление рекорда
        private void BRecordsRemove_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (dGVRecords.CurrentCell != null &&
                records.Records.Count > 0)
            {
                GameRecords.Record record =
                    records.Records[dGVRecords.CurrentCell.RowIndex];
                records.DelRecord(record);
                records.OutputIn(dGVRecords);
            }
        }
        //Открыть пункт "Подробнее"
        private void BRecordsMoreDetails_Click(object sender, EventArgs e)
        {
                this.ActiveControl = null;
            if (dGVRecords.CurrentCell != null &&
                records.Records.Count > 0)
            {
                GameRecords.Record record =
                    records.Records[dGVRecords.CurrentCell.RowIndex];
                LPRecordsShowUserName.Text = record.Name;
                LPRecordsShowUserRecord.Text = Convert.ToString(record.Score);
                LPRecordsShowMaxSpawnDelay.Text =
                    Convert.ToString(record.Difficulty.MaxSpawnDelay);
                LPRecordsShowMinSpawnDelay.Text =
                    Convert.ToString(record.Difficulty.MinSpawnDelay);
                LPRecordsShowAccelerationDelay.Text =
                    Convert.ToString(record.Difficulty.AccelerationDelay);
                formMenu.OpenItem(PRecordsMoreDetails, false);
                PRecords.Enabled = false;
            }
        }
        //Выбор строки таблицы
        private void dGVRecords_SelectionChanged(object sender, EventArgs e)
        {
            if (dGVRecords.CurrentCell != null)
                for (int i = 0; i < dGVRecords.ColumnCount; i++)
                    if (!dGVRecords.Rows[dGVRecords.CurrentCell.RowIndex].Cells[i].Selected)
                        dGVRecords.Rows[dGVRecords.CurrentCell.RowIndex].Cells[i].Selected = true;
        }
        //Вернуться из подпункта "Подробнее"
        private void PRecordsMoreDetailsClose_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            formMenu.CloseItem();
            PRecords.Enabled = true;
        }

        //Костыль решения проблемы мерцания 
        //https://qastack.ru/programming/2612487/how-to-fix-the-flickering-in-user-controls
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}