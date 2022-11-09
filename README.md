# Программа
## Условие программы
Написать программу, которая из имеющегося массива сток формирует массив их строк, длина которых меньше либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. При решении не рекомендуется польоваться коллекциями, лучше обойтись исключительно массивами.
## Основной код
Для начала необходимо ввести массив строк.
Было решено, что массив будет задан пользователем при вводе с клавиатуры.
То, что введет пользователь преобразуем в строковый массив.
Далее с помошью метода ReplacementArray мы преобразовываем введенный пользователем массив в новый массив (matrix) и с помощью метода PrintArray выводим новый массив.
## Метод ReplacementArray
Вводим счетчик count и присваиваем нулю. Он нужен для определения размера нового массива (это количесво элементов массива (строк), размер которых менее или равен 3).
С помощью цикла for проверяем каждый элемент массива на условие - размер элемента менее или равен 3 символам. Если элемент массива удовлетворяет данному условию, 
то к счетчику count прибавляем 1. В результате прохождения цикла получаем размер нового массива.
Далее создаем новый пустой массив с размером count. Вводим счетчик j (индекс нового массива) и присваиваем нулю.
С помощью цикла for проверяем каждый элемент массива на условие - размер элемента менее или равен 3 символам. И если элемент массива удовлетворяет данному условию,
элементу нового массива присваиваем значение данного элемента массива и увеличиваем j на единицу, если нет - то пропускаем данный шаг и проверяем 
следующий элемент массива. Таким образом собираем новый массив из элементов массива, размер который менее или равен 3.
Возвращаем новый массив строк.
## Метод PrintArray
Для красивого вывода массива создаем метод вывода массива.
С помощью String.Join(", ",prarray) разделяем элементы массива через запятую и пробел.
Далее весь массив заключаем в квадратные скобки и выводим.
