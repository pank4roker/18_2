using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_2_2_
{
    /// <summary>
    /// Абстрактный класс печатной продукции
    /// </summary>
    abstract class Printedprod
    {
        /// <summary>
        /// Поле названия и его свойство
        /// </summary>
        string name;
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Абстрактный метод вывода информации
        /// </summary>
        public abstract void Info();
        /// <summary>
        /// Абстрактный метод подсчета цены
        /// </summary>
        /// <returns></returns>
        public abstract double Cost();

    }
}
