using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.GarbageCollection_Net
{
    class MyClass : IDisposable // интерфейс
    {
        public MyClass() //конструктор
        {

        }

        ~MyClass() //деструктор - вызывается в тот момент, когда экземпляр класса будет уничтожаться. Вызвать его вручную нельзя
        {
            //можно определить корректное закрытие потока(пример)
        }
        public void Dispose()
        {
            //как объект будет уничтожен
            GC.Collect();
        }
    }
}
