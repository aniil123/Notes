using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.ViewModel
{
    /// <summary>
    /// Запись пользователя.
    /// </summary>
    public class NoteVM
    {
        /// <summary>
        /// Название записи.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Текст записи.
        /// </summary>
        public string Content { get; set; } = "";

        /// <summary>
        /// Дата и время создания записи.
        /// </summary>
        public string Date { get; }

        /// <summary>
        /// Инициализирует объект записи именем и текущей датой и временем.
        /// </summary>
        /// <param name="name">Название записи.</param>
        public NoteVM(string name)
        {
            Name = name;
            Date = DateTime.Now.ToShortDateString() + " " +
                   DateTime.Now.ToShortTimeString();
        }
    }
}
