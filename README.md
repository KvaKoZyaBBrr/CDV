# Тестовое задание ЦВД

1. Имеется структура данных

> CREATE TABLE department
    (id int(11), name varchar(100));

> CREATE TABLE employee
    (id int(11), department_id int(11), chief_id int(11), name varchar(100), salary int(11));

>INSERT INTO department
    (id, name)
VALUES
    (1, "D1"),
    (2, "D2"),
    (3, "D3");

>INSERT INTO employee
    (id, department_id, chief_id, name, salary)
VALUES
    (1, 1, 5, "John", 100),
    (2, 1, 5, "Misha", 600),
    (3, 2, 6, "Eugen", 300),
    (4, 2, 6, "Tolya", 400),
    (5, 3, 7, "Stepan", 500),
    (6, 3, 7, "Alex", 1000),
    (7, 3, NULL, "Ivan", 1100);

2. Напишите программу, которая оперируя заданной структурой, покажет:

        1. Суммарную зарплату в разрезе департаментов (без руководителей и с руководителями)
        2. Департамент, в котором у сотрудника зарплата максимальна
        3. Зарплаты руководителей департаментов (по убыванию)

        

3. Условия:
   
        1. Можно использовать любую СУБД, либо другой источник данных (например перенести данные в CSV-файлы).
        2. Программу реализовать на .Net (C#)
        3. Выложить проект на github
        4. Прислать ссылку на dpankrashov@centrvd.ru
        5. Интерфейс - любой (можно консольный)
        6. Плюсом будет наличие документации по использованию
        7. Любые дополнения\улучшения, которые вы сочтете уместными

# Dev:

> Используется PostgreSQL под Docker. 
> 
> docker pull postgres
> 
> docker run --name pgs -e POSTGRES_PASSWORD=123 -u postgres -d -p 5432:5432 postgres
> 
> выполнены скрипты из dbScripts.sql
> 



> БД не консистентна, так как не удается полностью определить руководителя отдела, если отдел находится под другим отделом. Поэтому добавил поле chief_id в department и связал его в employee.id. Иначе опредить руководителя можно было только в случае если у него не было своего руководителя (ну или по зп, но это семантическая связка, а не логическая, плюс не всегда верная), однако зачастую в организациях есть строгая иерархия и получается в компании только один руководитель. Поэтому изменение позволяет добавить руководителя сразу к департаменту (связь не жесткая, так как можно добавить null, что будет означать, что руковдителя нет), а также реализовать такую ситуацию, когда руководитель отдела по факту работает в другом отделе (например руководитель отдела разработки frontend работает в отделе разработки fullstack)  

