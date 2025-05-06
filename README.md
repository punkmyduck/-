# Тестовое задание на вакансию Junior C# developer в Монополия
Исходный код программы находится в [-/Test Task/Program.cs](https://github.com/punkmyduck/-/blob/main/Test%20Task/Program.cs)

В программе содержатся следующие элементы:
- interface IMinTwoSumCalculator : интерфейс с объявлением метода для поиска суммы;
- class StandardMinTwoSumCalculator : класс, реализующий интерфейс;
- class MinTwoSumCalculatorTest : класс с тестами реализованного метода.

Реализованы следующие тесты в классе MinTwoSumCalculatorTest:
- Test_CorrectSum : базовый тест с проверкой на предложенных данных;
- Test_TwoElementsSum : тест на массиве из двух элементов;
- Test_DuplicateMinimums : тест на массиве с повторяющимися элементами;
- Test_NegativeNumbers : тест на массиве только из отрицательных элементов;
- Test_LargeArray : тест на массиве из 100.000.000 элементов;
- Test_LessThanTwoElements : тест на массиве из одного элемента, проверка на корректное выбрасывание исключения;
- Test_UnitializedArray : тест на неинициализированном массиве, проверка на корректное выбрасывание исключения.

Результаты проведения тестов:
![Скриншот вывода консоли с результатами тестов](https://raw.githubusercontent.com/punkmyduck/-/refs/heads/main/%D0%A0%D0%B5%D0%B7%D1%83%D0%BB%D1%8C%D1%82%D0%B0%D1%82%D1%8B%20%D1%82%D0%B5%D1%81%D1%82%D0%BE%D0%B2.bmp?token=GHSAT0AAAAAADB2UNU2CHYPLOYAED4IPQN62A2IMEA)
