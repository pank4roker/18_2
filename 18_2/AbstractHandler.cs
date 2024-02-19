using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2
{
    /// <summary>
    /// Абстрактный класс обработчика документа
    /// </summary>
    abstract class AbstractHandler
    {
        /// <summary>
        /// Метод открытия
        /// </summary>
        public abstract void Open();
        /// <summary>
        /// Метод создания
        /// </summary>
        public abstract void Create();
        /// <summary>
        /// Метод изменения
        /// </summary>
        public abstract void Change();
        /// <summary>
        /// Метод сохранения
        /// </summary>
        public abstract void Save();

    }
}
