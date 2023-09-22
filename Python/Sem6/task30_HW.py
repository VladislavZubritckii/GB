# Задача 30: Заполните массив элементами арифметической
# прогрессии. Её первый элемент, разность и количество
# элементов нужно ввести с клавиатуры. Формула для
# получения n-го члена прогрессии:
# an = a1 + (n-1) * d.
# Каждое число вводится с новой строки.
# Ввод: 7 2 5
# Вывод: 7 9 11 13 15
import random


first_element = random.randint(1,10)
step_element = random.randint(1,10)
lenght_element = random.randint(1,10)

print(f'Первый элемент {first_element}')
print(f'Шаг {step_element}')
print(f'Длинна {lenght_element}')


for i in range(lenght_element):
    n = first_element + i * step_element
    print(n)

