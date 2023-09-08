# Требуется найти в массиве list_1 самый близкий по величине элемент к заданному числу k и вывести его.

# Пример:


# list_1 = [1, 2, 3, 4, 5]
# k = 6
# # 5

list_1 = [1, 12, 6, 7, 8, 15]
k = 11
for i in list_1:
    if i == k:
        break
    for i in list_1:
        if i < k:
            i +=1
            if i == k:
                i -= 1
                break
        elif i > k:
            i -= 1
            if i == k:
                i += 1
                break
print(i)
