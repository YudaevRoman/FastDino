
namespace CourseWorkOOP_Dmitry_
{

    //Интерфейс контроля Темы компонента
    interface ControllingComponentTheme
    {
        //Метод установки фона
        void UpdateTheme(
            System.Drawing.Image[] image
            );
    }

    //Модификация Button
    public class ModificationButton : 
        System.Windows.Forms.Button, 
        ControllingComponentTheme
    {
        //Метод установки фона
        public void UpdateTheme(
            System.Drawing.Image[] image
            )
        {
            if (image.Length > 0)
                BackgroundImage = image[0];
        }
    }

    //Модификация CheckBox
    public class ModificationCheckBox : 
        System.Windows.Forms.CheckBox, 
        ControllingComponentTheme
    {
        //Свойства
        public System.Drawing.Image ImageYes { get; set; }
        public System.Drawing.Image ImageNo { get; set; }
        
        //Метод установки фона
        public void UpdateTheme(
            System.Drawing.Image[] image
            )
        {
            int counter = 0;
            foreach(
                System.Drawing.Image img
                in
                image)
            {
                if (counter == 0) ImageYes = img;
                if (counter == 1) ImageNo = img;
                counter++;
            }
        }

        //Переопределение отрисовки
        protected override void OnPaint(
            System.Windows.Forms.PaintEventArgs pevent)
        {
            //Чистим фон
            pevent.Graphics.Clear(BackColor);
            //Отрисовываем текст
            using (System.Drawing.SolidBrush brush =
               new System.Drawing.SolidBrush(ForeColor))
                pevent.Graphics.DrawString(
                    Text, Font, brush,
                    pevent.ClipRectangle.Height + 2,
                    (float)(pevent.ClipRectangle.Height * 0.15));
            //Смена изображения
            if (ImageYes != null && ImageNo != null)
            {
                if (Checked) pevent.Graphics.DrawImage(ImageYes,
                        new System.Drawing.Rectangle(0, 0,
                            pevent.ClipRectangle.Height,
                            pevent.ClipRectangle.Height));
                else pevent.Graphics.DrawImage(ImageNo,
                        new System.Drawing.Rectangle(0, 0,
                            pevent.ClipRectangle.Height,
                            pevent.ClipRectangle.Height));
            }
        }
    }

    //Модификация RadioButton
    public class ModificationRadioButton : 
        System.Windows.Forms.RadioButton, 
        ControllingComponentTheme
    {
        //Свойства
        public System.Drawing.Image ImageYes { get; set; }
        public System.Drawing.Image ImageNo { get; set; }

        //Метод установки фона
        public void UpdateTheme(
            System.Drawing.Image[] image
            )
        {
            int counter = 0;
            foreach (
                System.Drawing.Image img
                in
                image)
            {
                if (counter == 0) ImageYes = img;
                if (counter == 1) ImageNo = img;
                counter++;
            }
        }
        //Переопределение отрисовки
        protected override void OnPaint(
            System.Windows.Forms.PaintEventArgs pevent)
        {
            //Чистим фон
            pevent.Graphics.Clear(BackColor);
            //Отрисовываем текст
            using (System.Drawing.SolidBrush brush =
               new System.Drawing.SolidBrush(ForeColor))
                pevent.Graphics.DrawString(
                    Text, Font, brush,
                    pevent.ClipRectangle.Height + 2,
                    (float)(pevent.ClipRectangle.Height * 0.15));
            //Смена изображения
            if (ImageYes != null && ImageNo != null)
            {
                if (Checked) pevent.Graphics.DrawImage(ImageYes,
                        new System.Drawing.Rectangle(0, 0,
                            pevent.ClipRectangle.Height,
                            pevent.ClipRectangle.Height));
                else pevent.Graphics.DrawImage(ImageNo,
                    new System.Drawing.Rectangle(0, 0,
                        pevent.ClipRectangle.Height,
                        pevent.ClipRectangle.Height));
            }
        }
    }

    //Класс "Окна" на основе ModificationPanel
    public class PanelWindow :
        System.Windows.Forms.Panel,
        ControllingComponentTheme
    {
        //События
        public event System.EventHandler OnCloseClick;

        //Поля
        private System.Windows.Forms.Button close;
        private System.Drawing.Point locationOffset;

        //Свойства 
        public System.Drawing.Image CloseButtonImage
        {
            get { return close.BackgroundImage; }
            set { close.BackgroundImage = value; }
        }

        //Коснтрукторы
        public PanelWindow() : base()
        {
            //
            // Инициализация кнопки закрытия PanelWindow
            //
            close = new System.Windows.Forms.Button();
            close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            close.Margin = new System.Windows.Forms.Padding(4);
            close.UseVisualStyleBackColor = true;
            close.Click += new System.EventHandler(close_Click);
            //
            // Инициализация PanelWindow
            //
            MouseDown += new System.Windows.Forms.
            MouseEventHandler(PanelWindow_MouseDown);
            MouseMove += new System.Windows.Forms.
            MouseEventHandler(PanelWindow_MouseMove);
            Controls.Add(close);
        }

        //Внешние методы
        public void SetSize(System.Drawing.Size newSize)
        {
            close.Location = new System.Drawing.Point(
                    (int)System.Math.Round(
                          (float)93.127962085 /
                          (float)100 *
                          (float)newSize.Width),
                    (int)System.Math.Round(
                          (float)1.915708812 /
                          (float)100 *
                          (float)newSize.Height));
            close.Size = new System.Drawing.Size(
                    (int)System.Math.Round(
                          (float)4.739336492 /
                          (float)100 *
                          (float)newSize.Width),
                    (int)System.Math.Round(
                          (float)7.662835249 /
                          (float)100 *
                          (float)newSize.Height));
            close.UseVisualStyleBackColor = true;
            Size = newSize;
        }
        //Метод установки фона
        public void UpdateTheme(
            System.Drawing.Image[] image
            )
        {
            int counter = 0;
            foreach (
                System.Drawing.Image img
                in
                image)
            {
                if (counter == 0) close.BackgroundImage = img;
                if (counter == 1) BackgroundImage = img;
                counter++;
            }
        }

        //Внутренние методы
        //Событие клика по кнопке закрытия
        private void close_Click(object sender, System.EventArgs e)
            => OnCloseClick?.Invoke(sender, e);
        //Методы движения окна
        private void PanelWindow_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                locationOffset = new System.Drawing.Point(
                    Location.X - System.Windows.Forms.Cursor.Position.X,
                    Location.Y - System.Windows.Forms.Cursor.Position.Y
                    );
        }
        private void PanelWindow_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Location = new System.Drawing.Point(
                    System.Windows.Forms.Cursor.Position.X + locationOffset.X,
                    System.Windows.Forms.Cursor.Position.Y + locationOffset.Y
                    );
                if (Location.X < 0 || Location.Y < 0)
                {
                    if(Location.X < 0)
                    Location = new System.Drawing.Point(0, Location.Y);
                    if(Location.Y < 0)
                    Location = new System.Drawing.Point(Location.X, 0);
                    locationOffset = new System.Drawing.Point(
                        Location.X - System.Windows.Forms.Cursor.Position.X,
                        Location.Y - System.Windows.Forms.Cursor.Position.Y
                        );
                }
                else
                if (Location.X + Size.Width > Parent.Size.Width ||
                    Location.Y + Size.Height > Parent.Size.Height)
                {
                    if (Location.X + Size.Width > Parent.Size.Width)
                        Location = new System.Drawing.Point(
                            Parent.Size.Width - Size.Width,
                            Location.Y
                            );
                    if (Location.Y + Size.Height > Parent.Size.Height)
                        Location = new System.Drawing.Point(
                            Location.X,
                            Parent.Size.Height - Size.Height
                            );
                    locationOffset = new System.Drawing.Point(
                        Location.X - System.Windows.Forms.Cursor.Position.X,
                        Location.Y - System.Windows.Forms.Cursor.Position.Y
                        );
                }
            }
        }
    }

    //Модификация DataGridViwe
    public class ModificationDataGridView :
        System.Windows.Forms.DataGridView,
        ControllingComponentTheme
    {
        //Метод установки фона
        public void UpdateTheme(
            System.Drawing.Image[] image
            )
        {
            BackgroundColor = Parent.BackColor;
            GridColor = Parent.BackColor;
            RowsDefaultCellStyle.BackColor = Parent.BackColor;
            RowsDefaultCellStyle.SelectionBackColor = Parent.BackColor;
        }
    }

    //Модификация PictureBox
    public class ModificationPictureBox : 
        System.Windows.Forms.PictureBox, 
        ControllingComponentTheme
    {
        //Метод установки фона
        public void UpdateTheme(
            System.Drawing.Image[] image
            )
        {
            if (image.Length > 0) BackgroundImage = image[0];
        }
    }
}