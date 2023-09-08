list_letters = {1:"aeioulnstrавеинорст",
                2:"dgдклмпу",
                3:"bcmpбгёья",
                4:"fhvwyйы",
                5:"kжзхцч",
                8:"jxшэю",
                10:"qzфщъ"}

word = input("Введите слово: ").upper()
summ = 0
for i in word:
    for k, v in list_letters.items():
        if i in v:
            summ += k
print(summ)