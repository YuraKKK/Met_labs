using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public interface IApplicationService
    {
        /// <summary>
        /// Початкова ініціалізація додатка(Створення кухарів, інгредієнтів...)
        /// </summary>
        void Initialize();
        void ShowListFoods();
        void CreateOrder();
    }
}
