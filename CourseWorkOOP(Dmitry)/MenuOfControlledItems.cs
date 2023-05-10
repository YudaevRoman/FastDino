
namespace CourseWorkOOP_Dmitry_
{
    //Класс Меню Контролируемых Пунктов
    public class MenuOfControlledItems
    {
        //Поля
        private ControllingFocusOfMenuItems controllingItems;
        private System.Collections.Generic.List<MenuItem> items;

        //Структуры
        public struct MenuItem
        {
            public string Name;
            public string Parent;
            public System.Collections.Generic.
                List<string> ChildItems;
            public MenuItem(
                string name, 
                string parent,
                System.Collections.Generic.
                List<string> childItems)
            {
                Name = name;
                Parent = parent;
                ChildItems = childItems;
            }
        }

        //Конструкторы
        public MenuOfControlledItems(
            System.Windows.Forms.Control parentItem)
        {
            controllingItems =
                new ControllingFocusOfMenuItems(parentItem);
            items = new System.Collections.Generic.List<MenuItem> { 
                new MenuItem(
                    parentItem.Name,
                    null,
                    new System.Collections.Generic.List<string>(0)
                    )
            };
        }

        //Внешние методы
        //Добавить пункт
        public void AddItem(
            System.Windows.Forms.Control parent,
            System.Windows.Forms.Control child
            ) 
        {
            if(items.Exists(item => item.Name == parent.Name))
            {
                items.Find(item => item.Name == parent.Name).
                    ChildItems.Add(child.Name);
                items.Add(new MenuItem(
                    child.Name,
                    parent.Name,
                    new System.Collections.Generic.List<string>(0)
                    ));
                controllingItems.AddItem(child);
            }
        }
        //Убрать пункт
        public void DellItem(
            System.Windows.Forms.Control item) 
        {
            if (items.Exists(i => i.Name == item.Name))
            {
                MenuItem delItem =
                    items.Find(i => i.Name == item.Name);
                items.Find(i => i.Name == delItem.Parent).
                    ChildItems.Remove(delItem.Name);
                items.Remove(delItem);
                controllingItems.DelItem(item);
            }
        }
        //Открыть пункт
        public void OpenItem(
            System.Windows.Forms.Control item) 
        {
            if (CurrentItem().ChildItems.
                Exists(j => j == item.Name))
                controllingItems.SetFocusToItem(item.Name);
        }
        public void OpenItem(
            System.Windows.Forms.Control item,
            bool visible)
        {
            if (CurrentItem().ChildItems.
                Exists(j => j == item.Name))
                controllingItems.SetFocusToItem(item.Name, visible);
        }
        //Закрыть пункт
        public void CloseItem() 
        {
            MenuItem item = CurrentItem();
            if (item.Parent != null)
                controllingItems.SetFocusToItem(item.Parent);
        }
        //Текущий пункт
        public MenuItem CurrentItem() 
            => items.Find(i => i.Name ==
                    controllingItems.FocusedItem.Name);
    }
}