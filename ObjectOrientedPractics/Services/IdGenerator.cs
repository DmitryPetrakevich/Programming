namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс генератора уникального идентификатора.
    /// </summary>
    class IdGenerator
    {
        /// <summary>
        /// Начальный номер идентификатора.
        /// </summary>
        private int _id;

        /// <summary>
        /// Получение следующего по порядку идентификатора.
        /// </summary>
        /// <returns>Идентификатор.</returns>
        public int GetNextId()
        {
            return _id++;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="IdGenerator"/>
        /// </summary>
        /// <param name="currentId"><see cref="_id">Начальный номер идентификатора</see></param>
        public IdGenerator()
        {
            _id = 0;
        }
    }
}
