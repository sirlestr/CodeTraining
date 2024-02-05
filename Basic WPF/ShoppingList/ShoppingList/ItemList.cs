using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ShoppingList
{
    public class ItemList 
    {
        public ObservableCollection<ShoppingItem> Items { get; set; }
       


        public ItemList()
        {
            Items = new ObservableCollection<ShoppingItem>() ;

        }

        public void AddItem(string item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            else
            {
                ShoppingItem si = new ShoppingItem(item);
                Items.Add(si);
            }
        }

        public void RemoveItem(ShoppingItem item)
        {
            Items.Remove(item);
        }
        /*
        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(Items.GetType());
            using (StreamWriter sw = new StreamWriter(cesta))
            {
                serializer.Serialize(sw, Items);
            }
        }

        public void Load()
        {
            XmlSerializer serializer = new XmlSerializer(Items.GetType());
            if (File.Exists(cesta))
            {
                using (StreamReader sr = new StreamReader(cesta))
                {
                    Items = (ObservableCollection<ShoppingItem>)serializer.Deserialize(sr);
                }
            }
            else
            {
                Items = new ObservableCollection<ShoppingItem>();
            }
        }*/
    }
}
