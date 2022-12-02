# Scientific-Calculator NUnitTesting

## Описание
Данное приложение выступает в роли модульного тестирование кода C# с использованием NUnit. Тестируемый проект - научный калькулятор "Scientific-Calculator" был взят из репозитория с открытым исходным кодом: https://github.com/areebbeigh/Scientific-Calculator

## Установка
1. Скопировать репозиторий на локальное хранилище
    ```
    git clone https://github.com/Amonlol/Scientific-Calculator-NUnitTesting
    ```
2. Открыть ./Scientific-Calculator/Calculator.sln через Visual Studio
3. Скомпилировать решение
4. Тест-->Запуск всех тестов

## Структура папок:
```
│   .gitignore
│   ReadMe.md
│   
├───CalculatorNUnitTests <-- Папка с модульными тестами
│   │   CalculatorNUnitTests.csproj
│   │   UnitTest1.cs
│                                 
├───Scientific-Calculator <-- Папка с тестируемым приложением
|   |   ...
|   |   Calculator.sln <-- Файл с решением
|   |   ...
```