
namespace CourseWorkOOP_Dmitry_
{
    //Класс Контроля Масштаба Компонентов Формы
    public class ControllingScaleOfFormComponents
    {
        //Поля
        private System.Windows.Forms.Form form;
        private System.Collections.Generic.
            List<ComponentScaleData> controllingScale;

        //Структуры
        private struct ComponentScaleData
        {
            public System.Windows.Forms.Control Control;
            public System.Drawing.SizeF PercentageOfSize;
            public System.Drawing.PointF PercentageOfLocation;
        }

        //Свойства
        public System.Drawing.Size FormSize { get; set; }
        public System.Drawing.Font FormFont { get; set; }

        //Конструктор
        public ControllingScaleOfFormComponents(
            System.Windows.Forms.Form newForm)
        {
            form = newForm;
            FormSize = form.Size;
            FormFont = form.Font;
            controllingScale = new System.Collections.Generic.
                List<ComponentScaleData>(0);
            foreach (
                System.Windows.Forms.Control component
                in
                form.Controls)
                FillControls(component);
        }

        //Внешние методы
        //Изменение размера формы
        public void ResizeForm(System.Drawing.Size newSize)
        {
            form.Size = newSize;
            ReScale();
            ReSizeFont();
            FormSize = form.Size;
        }
        public void ResizeForm(
            System.Windows.Forms.FormBorderStyle style,
            System.Windows.Forms.FormWindowState state)
        {
            form.FormBorderStyle = style;
            form.WindowState = state;
            ReScale();
            ReSizeFont();
            FormSize = form.Size;
        }

        //Внутренние методы
        //Расчёт масштабов компонентов формы
        private void ReScale()
        {
            foreach (
                ComponentScaleData component
                in
                controllingScale)
            {
                component.Control.Location = new System.Drawing.Point(
                    (int)System.Math.Round(
                          (float)component.Control.Parent.Size.Width / 
                          (float)100 *
                          (float)component.PercentageOfLocation.X),
                    (int)System.Math.Round(
                          (float)component.Control.Parent.Size.Height /
                          (float)100 *
                          (float)component.PercentageOfLocation.Y)
                    );
                component.Control.Size = new System.Drawing.Size(
                    (int)System.Math.Round(
                          (float)component.Control.Parent.Size.Width / 
                          (float)100 *
                          (float)component.PercentageOfSize.Width),
                    (int)System.Math.Round(
                          (float)component.Control.Parent.Size.Height /
                          (float)100 *
                          (float)component.PercentageOfSize.Height)
                    );
            }
        }
        //Расчёт размера шрифта формы
        private void ReSizeFont()
        {
            float fontReSizingMultiplier =
                (float)form.Size.Height / (float)FormSize.Height;
            System.Drawing.Font newFont = FormFont;
            {
                float[] oldHeight = { 1, -1 };
                while (newFont.GetHeight() !=
                    FormFont.GetHeight() * fontReSizingMultiplier &&
                    newFont.GetHeight() != oldHeight[1])
                {
                    if (oldHeight[0] == 1)
                    {
                        oldHeight[1] = newFont.GetHeight();
                        oldHeight[0] = 0;
                    }
                    else oldHeight[0]++;
                    if (newFont.GetHeight() <
                       FormFont.GetHeight() * fontReSizingMultiplier)
                        newFont = new System.Drawing.Font(
                            newFont.Name,
                            newFont.Size + 1,
                            newFont.Style);
                    else if (newFont.Size - 1 != 0)
                        newFont = new System.Drawing.Font(
                            newFont.Name,
                            newFont.Size - 1,
                            newFont.Style);
                }
            }
            FormFont = newFont;
            foreach (
                System.Windows.Forms.Control component
                in
                form.Controls)
                component.Font = newFont;
        }
        //Заполнение списка компонентов
        private void FillControls(
            System.Windows.Forms.Control control)
        {
            AddScaleData(control);
            foreach (
                System.Windows.Forms.Control component
                in 
                control.Controls)
            {
                if (component.Controls.Count > 0)
                    FillControls(component);
                else AddScaleData(component);
            }
        }
        //Добавление данных в список компонентов
        private void AddScaleData(
            System.Windows.Forms.Control control)
        {
            ComponentScaleData newData = new ComponentScaleData();
            newData.Control = control;
            newData.PercentageOfSize = new System.Drawing.SizeF(
                (float)control.Width / (float)control.Parent.Width * (float)100,
                (float)control.Height / (float)control.Parent.Height * (float)100
                );
            newData.PercentageOfLocation = new System.Drawing.PointF(
                (float)control.Location.X / (float)control.Parent.Size.Width * (float)100,
                (float)control.Location.Y / (float)control.Parent.Size.Height * (float)100
                );
            controllingScale.Add(newData);
        }
    }
}