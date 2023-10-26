def enter_first_name():
    return input("Введите имя абонента: ").title()


def enter_second_name():
    return input("Введите фамилию абонента: ").title()


def enter_family_name():
    return input("Введите отчество абонента: ").title()


def enter_phone_number():
    return input("Введите номер телефона: ")


def enter_address_number():
    return input("Введите адрес абонента: ").title()


def enter_data():
    name = enter_first_name()
    surname = enter_second_name()
    family = enter_family_name()
    number = enter_phone_number()
    address = enter_address_number()
    with open('book.txt', 'a', encoding='utf-8') as file:
        file.write(f'{name} {surname} {family}\n{number}\n{address}\n\n')


def print_data():
    with open('book.txt', 'r', encoding='utf-8') as file:
        print(file.read())


def search_line():
    print('Выбертите вариант поиска:\n'
    '1. Имя\n'
    '2. Фамилия\n'
    '3. Отчество\n'
    '4. Телефон\n'
    '5. Адрес')
    index = int(input('Введите вариант: ')) - 1
    searched = input('Введите поисковые данные: ').title()
    with open('book.txt', 'r', encoding='utf-8') as file:
        data = file.read().strip().split('\n\n')
        for item in data:
            new_item = item.replace('\n', ' ').split()
            if searched in new_item[index]:
                print(item, end="\n\n")

def delete_contact():
    with open('book.txt', 'r', encoding='utf-8') as file:
        X = input('Введите Имя или Фамилию для удаления: ').title()
        lines = file.readlines()
        with open('book.txt', 'w', encoding='utf-8') as file:
            for line in lines:
                if X in line:
                    lines.remove(line)
                else:  
                    file.write(lines)

def interface():
    cmd = 0
    while cmd != '5':
        print("Выберите действие: \n"
        "1. Добавить контакт\n"
        "2. Вывести все контакты\n"
        "3. Поиск контакта\n"
        "4. Удаление контакта\n"
        "5. Выход\n")
        cmd = input("Введите действие: ")
        while cmd not in ('1', '2', '3', '4', "5"):
            print('Некорректный ввод')
        match cmd:
            case '1':
                enter_data()
            case '2':
                print_data()
            case '3':
                search_line()
            case "4":
                delete_contact()
            case '5':
                print('Всего доброго! ')

interface()
