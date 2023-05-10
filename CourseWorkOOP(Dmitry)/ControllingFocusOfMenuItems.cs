
namespace CourseWorkOOP_Dmitry_
{
    //Класс Контроля Фокуса Пунктов Меню
    public class ControllingFocusOfMenuItems
    {
        //Поля
        private System.Collections.Generic.
        List<System.Windows.Forms.Control> controllingItems;

        //Свойства
        public System.Windows.Forms.Control FocusedItem { get; set; }

        //Конструкторы
        public ControllingFocusOfMenuItems(
            System.Collections.Generic.
            List<System.Windows.Forms.Control> newControllingItems,
            System.Windows.Forms.Control newFocusedItem) 
        {
            controllingItems = newControllingItems;
            SetFocusToItem(newFocusedItem.Name);
        }
        public ControllingFocusOfMenuItems(
            System.Windows.Forms.Control newItems)
        {
            controllingItems = new System.Collections.Generic.
                List<System.Windows.Forms.Control> { newItems };
            SetFocusToItem(newItems.Name);
        }

        //Внешние методы
        //Добавить пункт в контролируемые
        public void AddItem(System.Windows.Forms.Control item)
        {
            controllingItems.Add(item);
            item.Visible = false;
        }
        //Убрать пунтк из контролируемых
        public void DelItem(System.Windows.Forms.Control item)
            => controllingItems.Remove(item);
        //Уставноить фокус на пункт
        public void SetFocusToItem(string itemName)
        {
            if (controllingItems.Exists(
                item => item.Name == itemName))
            {
                foreach (
                    System.Windows.Forms.Control item
                    in
                    controllingItems)
                    item.Visible = false;
                FocusedItem = controllingItems.Find(
                    item => item.Name == itemName);
                FocusedItem.Visible = true;
            }
        }
        //Уставноить фокус на пункт
        public void SetFocusToItem(string itemName, bool visible)
        {
            if (controllingItems.Exists(
                item => item.Name == itemName))
            {
                if (visible)
                    foreach (
                        System.Windows.Forms.Control item
                        in
                        controllingItems)
                        item.Visible = false;
                FocusedItem = controllingItems.Find(
                    item => item.Name == itemName);
                FocusedItem.Visible = true;
                FocusedItem.BringToFront();
            }
        }
    }
}
