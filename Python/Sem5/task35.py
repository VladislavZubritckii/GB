def is_number_simple(num: int) -> bool:
    if num % 2 == 0 and num != 2:
        return False

    for i in range(3, int(num ** 0.5) + 1, 2):
        if num % i == 0:
            return False
    return True


n = int(input('Введите число: '))
if is_number_simple(num=n):
    print(f'Число {n} является простым')
else:
    print(f'Число {n} простым не является')

