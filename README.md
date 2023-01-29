# FinalTask!!!

## Задание:

```sh
Написать программу которая из имеющегося массива строк формирует массив из
 строк длина которых меньше, либо равна трём символам. Массив можно задать 
 на старте, либо ввести пользователем.
```

## Алгоритм выполнения задания:
```sh
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
Использовать контроль версий в работе над этим небольшим проектом 
(не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4
 должны быть расположены в разных коммитах)
```
### Алгоритм решения задачи:
```sh
С начало объявляется два массива.Потом метод, в котором цикл соразмерный длине 
массива, внутри цикла проверка условия ( <=3 ), если да, элемент первого массива
 заносится в count элемент второго массива. Переменная count для того чтобы 
 поочередно закидывать из первого массива во второй и чтобы потом не было пробелов.
  После присвоения, переменная count увеличивается на 1 и возвращается 
  к циклу for в котором i увеличивается на 1. И так проверяется до конца.
```