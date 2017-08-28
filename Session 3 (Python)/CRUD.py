crud = input("Welcome to our shop, what do you want (C, R, U, D)?")
shop = ['T-Shirt', 'Sweater', 'Jeans']
while True: 
    if (crud.upper() == 'C'):
        new_item = str(input('Enter new item: '))
        shop.append(new_item)
        print('Our items: ', shop)
    elif (crud.upper() == 'R'):
        print('Our items: ', shop)
    elif (crud.upper() == 'U'):
        u_position = int(input('Update position? '))
        new_item = str(input('New item?'))
        shop[u_position - 1] = new_item
        print("Our items: ", shop)
    elif (crud.upper() == 'D'):
        d_position = int(input('Delete position? '))
        del shop[d_position - 1]
        print("Our items: ", shop)
    else:
        crud = input("Try again")
