using System;
using System.Collections.Generic;

namespace HelpDesk.Common.System
{
    /// <summary>
    /// Единая точка доступа ко всем системам 
    /// Содержит 2 метода:
    ///     1) Register - для регистрации системы
    ///     2) Get - для получения инстанса системы
    /// 
    /// Хранит список всех инстансов систем либо функций, которые используются для создания систем
    ///  
    /// Перед тем, как получить систему (через метод Get) её необходимо зарегистрировать.
    /// Возможны 2 варианта регистрации:
    ///     1) Регистрации уже созданного объекта Register(object obj) - объект просто добавится в словарь с инстансами систем.
    ///     2) Регистрация системы с указанием функции, используемой при создании объекта Register<T>(Func<T> creator) либо Register<T>() (для систем, которые имеют конструктор без параметров)
    ///        В этом случае, объект будет создан только при первом вызове Get
    /// </summary>
    public class SystemManager
    {
        /// <summary>
        /// Словарь с созданными подсистемами
        /// </summary>
        private static Dictionary<Type, object> _systems = new Dictionary<Type, object>(32);

        /// <summary>
        /// Словарь с функциями для создания подсистем
        /// </summary>
        private static Dictionary<Type, Func<object>> _creators = new Dictionary<Type, Func<object>>(32);

        private static bool _getConstructsSystem;

        /// <summary>
        /// Зарегистрировать новую систему, создаваемую при первом вызове Get, с указанием функции создания экземпляра
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="creator"></param>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если система такого типа уже была зарегистрирована
        /// </exception>
        public static void Register<T>(Func<T> creator) where T : class
        {
            _creators.Add(typeof(T), () => creator());
        }

        /// <summary>
        /// Зарегистрировать новую систему, создаваемую при первом вызове Get, для типов, которые имеют конструктор без параметров
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если система такого типа уже была зарегистрирована
        /// </exception>
        public static void Register<T>() where T : class, new()
        {
            Register<T>(() => new T());
        }

        /// <summary>
        /// Зарегистрировать уже созданную систему
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если система такого типа уже была зарегистрирована
        /// </exception>
        public static void Register<T>(T obj)
        {
            _systems.Add(typeof(T), obj);
        }

        /// <summary>
        /// Получить систему указанного типа. Система должна быть предварительно зарегистрирована.
        /// Если был зарегистрирован экземпляр системы, то метод вернёт его.
        /// Если была зарегистрирована функция для создания экземпляра системы, то будет вызван он и метод вернёт созданный экземпляр.
        /// Создаваемая система не должна вызывать Get в конструкторе или Awake.
        /// В этом случае можно использовать либо Start, либо реализовать интерфейс IInitializable с методом Initialize.
        /// Методы Initialize и Start уже могут использовать Get, но полученная система может быть ещё не проинициализирована.
        /// </summary>
        /// <exception cref="SystemException">
        /// Выбрасывается, если в конструкторе системы обнаружен вложенный вызов Get.
        /// </exception>
        /// <exception cref="KeyNotFoundException">
        /// Выбрасывается, если запрашиваемая система не зарегистрирована.
        /// </exception>
        public static T Get<T>() where T : class
        {
            Type type = typeof(T);

            if (_getConstructsSystem)
            {                
                return null;
            }

            object result;
            if (!_systems.TryGetValue(type, out result))
            {
                Func<object> creator;
                if (!_creators.TryGetValue(type, out creator))
                {                    
                    return null;
                }
                _getConstructsSystem = true;
                object instance = creator();
                _getConstructsSystem = false;
                _creators.Remove(type);
                _systems.Add(type, instance);
                return instance as T;
            }
            return result as T;
        }

        /// <summary>
        /// Получить систему указанного типа. Система должна быть предварительно быть зарегистрирована.
        /// Если был зарегистрирован экземпляр системы, то метод вернёт его.
        /// Если была зарегистрирована функция для создания экземпляра системы, то будет вызван он и метод вернёт созданный экземпляр.
        /// Создаваемая система не должна вызывать Get в конструкторе или Awake.
        /// В этом случае можно использовать либо Start, либо реализовать интерфейс IInitializable с методом Initialize.
        /// Методы Initialize и Start уже могут использовать Get, но полученная система может быть ещё не проинициализирована.
        /// </summary>
        /// <exception cref="SystemException">
        /// Выбрасывается, если в конструкторе системы обнаружен вложенный вызов Get.
        /// </exception>
        /// <exception cref="KeyNotFoundException">
        /// Выбрасывается, если запрашиваемая система унаследована от UnityEngine.Object и не зарегистрирована.
        /// </exception>
        public static void Get<T>(out T obj) where T : class
        {
            obj = Get<T>();
        }

        public static void Dispose()
        {
            _systems.Clear();
            _creators.Clear();
        }
    }
}
