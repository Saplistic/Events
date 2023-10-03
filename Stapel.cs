using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generieke_Collecties
{
    //creeer een delegate voor de event
    public delegate void WijzigingEventHandeler(object sender, string methode);

    internal class Stapel<T>
    {
        List<T> container;
        //declareer een event die gelinkt is aan de delegate
        public event WijzigingEventHandeler OnWijziging;

        public Stapel()
        {
            container = new List<T>();
        }

        public void Opzetten(T t) {
            container.Add(t);

            OnWijziging?.Invoke(this, "opzetten");
        }

        public T Afhalen() {
            T item = container[^1];
            container.RemoveAt(container.Count - 1);

            OnWijziging?.Invoke(this, "afhalen");

            return item;
        }

        public void Leegmaken() {
            container = new List<T>();

            OnWijziging?.Invoke(this, "leegmaken");
        }

        public override string ToString()
        {
            string s = "[" + string.Join(",", container) + "]";

            return "Stapel{" + s + "}";
        }

    }
}
