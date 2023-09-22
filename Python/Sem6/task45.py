def sum_div(num):
    s = 1
    for div in range(2, int(num**0.5+1)):
        if num % div == 0:
            s += div+num//div
    return s


k = int(input('Введите число '))
result = []
for num1 in range(2, k):
    num2 = sum_div(num1)
    sum2 = sum_div(num2)
    if num1 == sum2 and num1 != num2:
        temp = (num1, num2)
        temp_result = min(temp), max(temp)
if temp_result not in result:
    result.append(temp_result)
for i_turple in result:
    print(*i_turple)