lol_list = []
lol_list.append("Strawberry")
lol_list.append("Chocolate")
lol_list.append("Coke")

print("Hello, welcome to LOL shop")
i = 1
for lo in lol_list:
    #string format
    print("{0}. {1}".format(lol_list.index(lo) + 1, lo))
    i += 1

item = input("Which one?")
if item in lol_list:
    lol_list.remove(item)
else:
    #todo: do you mean...?
    print("Sorry, we're out of", item)


