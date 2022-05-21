# Multiple-inheritance-in-CSharp

### Задача:  
Есть группа похожих объектов A,B,C, …  
В этих объектах есть методы X1, X2, X3 - их комбинации в конкретном объекте встречаются ВСЕ возможные, например:  
A => {X1}, объект А содержит только метод Х1  
B => {X2}, объект В содержит только метод Х2  
C => {X1, X2}, объект С содержит методы Х1 и Х2  
D => {X2, X3}, объект D содержит методы Х2 и Х3  
E => {X1, X3}, объект E содержит методы Х1 и Х3  
F => {X3}, объект F содержит только метод Х3  
...

### Решение:
Использование интерфейсов с реализацией. (Доступно в версии C# 8.0 и выше)