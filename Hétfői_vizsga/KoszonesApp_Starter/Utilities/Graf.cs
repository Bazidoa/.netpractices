using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    /// <summary>
    /// T tipusú pontokat tartalmazó gráf
    /// </summary>
    /// <typeparam name="T">A gráf pontjainak közös tipusa</typeparam>
    public class Graf<T>
    {
        private List<T> grafPontok = new List<T>();
        private List<GrafEl<T>> elek = new List<GrafEl<T>>();
        /// <summary>
        /// Létrehoz egy üres gráfot
        /// </summary>
        public Graf(){}
        /// <summary>
        /// Felvesz egy új pontot a gráfba és visszaadja az ehez a ponthoz tartozó éleket
        /// </summary>
        /// <param name="grafPont"></param>
        /// <returns>Az új élek a gráfban</returns>
        public GrafEl<T>[] AddPont(T grafPont)
        {
            List<GrafEl<T>> ujElek = new List<GrafEl<T>>();
            for (int i = 0; i < grafPontok.Count; i++)
            {
                ujElek.Add(new GrafEl<T>(grafPont, grafPontok[i]));
            }
            grafPontok.Add(grafPont);
            BuildElek();
            return ujElek.ToArray();
        }
        /// <summary>
        /// A gráfot alkotó pontok
        /// </summary>
        public T[] Pontok
        {
            get
            {
                return this.grafPontok.ToArray();
            }
        }
        private void BuildElek()
        {
            this.elek.Clear();
            for (int i = 0; i < grafPontok.Count - 1; i++)
            {
                for (int j = i + 1; j < grafPontok.Count; j++)
                {
                    elek.Add(new GrafEl<T>(grafPontok[i], grafPontok[j]));
                }
            }
        }
        /// <summary>
        /// A gráfot alkotó pontok közötti élek
        /// </summary>
        public GrafEl<T>[] Elek
        {
            get
            {
                return this.elek.ToArray();
            }
        }
    }
    /// <summary>
    /// A gráf két pontját összekötő vonal
    /// </summary>
    /// <typeparam name="T">A gráf pontjainak tipusa</typeparam>
    public class GrafEl<T>
    {
        private T egyikVegpont;
        private T masikVegpont;
        /// <summary>
        /// Létrehoz egy vonalat (élt), amely két gráfpontot köt össze
        /// </summary>
        /// <param name="egyikVegpont"></param>
        /// <param name="masikVegpont"></param>
        public GrafEl(T egyikVegpont, T masikVegpont)
        {
            this.egyikVegpont = egyikVegpont;
            this.masikVegpont = masikVegpont;
        }

        public T EgyikVegpont
        {
            get
            {
                return egyikVegpont;
            }
        }

        public T MasikVegpont
        {
            get
            {
                return masikVegpont;
            }
        }
    }

    public class GrafIranyitottEl<T>
    {
        private T kezdoPont;
        private T vegPont;

        public GrafIranyitottEl(T kezdoPont, T vegPont)
        {
            this.kezdoPont = kezdoPont;
            this.vegPont = vegPont;
        }

        public T KezdoPont
        {
            get
            {
                return kezdoPont;
            }
        }

        public T Vegpont
        {
            get
            {
                return vegPont;
            }
        }
    }
}
