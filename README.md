# HelpDesk

Упрощённая версия приложения "HelpDesk", реализованного с применением технологии WinForms. 

HelpDesk — это система поддержки, предоставляемая компанией для решения проблем, вопросов или запросов от клиентов или пользователей.

Реализация включает в себя следующее:

1. **Авторизация/Регистрация**. При регистрации выдаётся роль пользователя.
2. **Разделение на пользователя/сотрудника.** В зависимости от роли учётной записи выводится разное количество информации в главном окне программы.
     - Роль "**Пользователь**" — имеет возможность создать заявку и просматривать свои заявки.
     - Роль "**Техническая поддержка**" —  в дополнение к доступам, имеющимся у роли "Пользователь" доступны все заявки с возможностью редактирования.
     - Роль "**Разработка**" —  в дополнение к доступам, имеющимся у роли "Техническая поддержка", появляется доступ ко всем пользователям/сотрудникам с возможностью редактирования.
4. **Цветовая подсветка**. В зависимости от статуса и/или превышения срока выполнения заявки строки в главном окне подсвечиваются разными цветами.
5. **Экспорт**. Доступна выгрузка пользователей/заявок вы Excel/CSV по выбранным параметрам.

Хранение данных в JSON.

Изначальный логин/пароль - admin/admin
