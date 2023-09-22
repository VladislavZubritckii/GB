# def same_by(characteristic, objects):
# result_list = []
# for num in objects:
# if characteristic(num):
# result_list.append(num)
# if objects == result_list or result_list == []:
# return True
# return False

# def same_by(characteristic, objects):
# result_list = list(map(characteristic, objects))
# print(result_list)

# if len(objects) == sum(result_list) or sum(result_list) == 0:
# return True
# return False

def same_by(characteristic, objects):
    result_list = list(filter(characteristic, objects))
    print(result_list)

    if objects == result_list or result_list == []:
        return True
    return False


values = [5, 7, 9, 3]
if same_by(lambda x: x % 2, values):
    print('same')
else:
    print('different')