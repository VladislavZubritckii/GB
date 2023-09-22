import random

n= random.randint(3,5)
m= random.randint(3,5)

list_1 = [random.randint(1,10) for i in range(n)]
list_2 = [random.randint(1,10) for j in range(m)]

print(n, list_1)
print(m, list_2)

list_3=[num for num in list_1 if num not in list_2]

print(list_3)

