
namespace CourseWorkOOP_Dmitry_
{
    //Темы компонентов
    public enum ComponentTheme { LIGHT_THEME, NIGHT_THEME }

    //Класс Настроек Приложения
    public class ApplicationSettings
    {
        //События
        public event System.EventHandler OnChacgeDifficulty;

        //Поля
        private ControllingScaleOfFormComponents controllingScale;
        private ControllingThemeOfFormComponents controllingTheme;
        private System.Windows.Forms.FormWindowState windowState;
        private string userName;
        private ComponentTheme theme;
        private DifficultyLevel difficulty;

        //Свойства
        public System.Windows.Forms.FormWindowState WindowState
        {
            get { return windowState; }
            set
            {
                windowState = value;
                if (windowState == System.Windows.Forms.FormWindowState.Maximized)
                    controllingScale.ResizeForm(
                        System.Windows.Forms.FormBorderStyle.None,
                        windowState);
                else
                    controllingScale.ResizeForm(
                        System.Windows.Forms.FormBorderStyle.FixedSingle,
                        windowState);
            }
        }
        public ComponentTheme Theme 
        {
            get { return theme; }
            set 
            {
                theme = value;
                controllingTheme.ChangeTheme(theme);
            }
        }
        public DifficultyLevel Difficulty 
        {
            get { return difficulty; }
            set 
            {
                difficulty = value;
                if (OnChacgeDifficulty != null) 
                    OnChacgeDifficulty(null, System.EventArgs.Empty);
            }
        }
        public string UserName 
        { 
            get { return userName; }
            set { userName = value; } 
        }
        public string FileName { get; set; } = "Settings.stt";

        //Конструкторы
        public ApplicationSettings(
            System.Windows.Forms.Form form,
            System.Drawing.Color lightBackColor,
            System.Drawing.Color nightBackColor,
            System.Collections.Generic.
            Dictionary<string, System.Drawing.Image[]> lightTheme,
            System.Collections.Generic.
            Dictionary<string, System.Drawing.Image[]> nightTheme
            )
        {
            controllingScale = new ControllingScaleOfFormComponents(form);
            controllingTheme = new ControllingThemeOfFormComponents(
                lightTheme,
                nightTheme,
                form,
                lightBackColor,
                nightBackColor
                );
        }
    }
}