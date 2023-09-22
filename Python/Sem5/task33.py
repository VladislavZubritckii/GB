import random

def min_max_search(lst):
    minNum = lst[0]
    maxNum = lst[0]
    for num in lst[1:]:
        if num < minNum:
            minNum = num
        if num > maxNum:
            maxNum = num
    return minNum, maxNum

def change(minN, maxN, lst):
    for i in range (len(lst)):
        if lst[i] == maxN:
            lst[i] = minN
    return lst

n = 5
list_1 = [random.randint(1,5) for _ in range(n)]

minNum, maxNum = min_max_search(list_1)
print(list_1)
print(change(minNum, maxNum, list_1))
