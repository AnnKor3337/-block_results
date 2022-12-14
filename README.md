# -block_results
Итоговая проверочная работа

Необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
--[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
--[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
--[“Russia”, “Denmark”, “Kazan”] → []

Выполнено:
1. Создан репозиторий https://github.com/AnnKor3337/-block_results.git. Для дальнейшей работы репозиторий был скопирован в VSC.
2. Нарисована блок-схема
3. Текстовое описание решения поставленной задачи можно будет найти, изучив файл README.md до конца.
4. программа, решающая поставленную задачу, находится в файле Program.cs и состоит из трех методов:
    - метод, подсчитывающий элементы массива, число символов в которых меньше или равно 3. В результате выдается количество элементов (длина) нового массива.
    - метод, формирующий новый массив.
    - метод, выводящий результат - новый массив, состоящий из элементов, число символов в которых меньше или равно 3.
5. Использован контроль версии.