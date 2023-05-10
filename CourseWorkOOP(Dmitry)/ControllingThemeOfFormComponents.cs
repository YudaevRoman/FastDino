
namespace CourseWorkOOP_Dmitry_
{
    //Класс Контроля Темы Компонентов Формы
    public class ControllingThemeOfFormComponents
    {
        //Поля
        private System.Windows.Forms.Form form;
        private System.Drawing.Color LightBackColor;
        private System.Drawing.Color NightBackColor;
        private System.Collections.Generic.
        Dictionary<string, System.Drawing.Image[]> LightTheme;
        private System.Collections.Generic.
        Dictionary<string, System.Drawing.Image[]> NightTheme;
        private System.Collections.
        Generic.List<System.Windows.Forms.Control> controllingTheme;

        //Конструкторы
        public ControllingThemeOfFormComponents(
            System.Collections.Generic.
            Dictionary<string, System.Drawing.Image[]> lightTheme,
            System.Collections.Generic.
            Dictionary<string, System.Drawing.Image[]> nightTheme,
            System.Windows.Forms.Form newForm,
            System.Drawing.Color lightBackColor,
            System.Drawing.Color nightBackColor)
        {
            LightTheme = lightTheme;
            NightTheme = nightTheme;
            controllingTheme = new System.Collections.Generic.
                List<System.Windows.Forms.Control>(0);
            form = newForm;
            LightBackColor = lightBackColor;
            NightBackColor = nightBackColor;
            foreach (
                System.Windows.Forms.Control component
                in
                form.Controls)
                FillControls(component);
        }

        //Внешние методы
        //Метод смены темы
        public void ChangeTheme(ComponentTheme theme)
        {
            switch (theme)
            {
                case ComponentTheme.LIGHT_THEME:
                    {
                        form.BackColor = LightBackColor;
                        foreach (
                            System.Collections.Generic.
                            KeyValuePair<string, System.Drawing.Image[]> component
                            in
                            LightTheme)
                        {
                            System.Windows.Forms.Control control =
                                controllingTheme.Find(i => i.Name == component.Key);
                            if (control is ControllingComponentTheme updateTheme)
                                updateTheme.UpdateTheme(component.Value);
                        }
                        break;
                    }
                case ComponentTheme.NIGHT_THEME:
                    {
                        form.BackColor = NightBackColor;
                        foreach (
                               System.Collections.Generic.
                               KeyValuePair<string, System.Drawing.Image[]> component
                               in
                               NightTheme)
                        {
                            System.Windows.Forms.Control control =
                                controllingTheme.Find(i => i.Name == component.Key);
                            if (control is ControllingComponentTheme updateTheme)
                                updateTheme.UpdateTheme(component.Value);
                        }
                        break;
                    }
            }
        }

        //Внутренние методы
        //Заполнение списка компонентов
        private void FillControls(
            System.Windows.Forms.Control control)
        {
            if(LightTheme.ContainsKey(control.Name) ||
               NightTheme.ContainsKey(control.Name)) 
                controllingTheme.Add(control);
            foreach (
                System.Windows.Forms.Control component
                in
                control.Controls)
            {
                if (component.Controls.Count > 0)
                    FillControls(component);
                else
                if (LightTheme.ContainsKey(component.Name) ||
                    NightTheme.ContainsKey(component.Name)) 
                    controllingTheme.Add(component);
            }
        }
    }
}
