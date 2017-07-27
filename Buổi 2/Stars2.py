cd = int(input("Nhap chieu dai: "))

for i in range(1, cd + 1, 1):
    if i % 2 != 0:
        print("x", end="")
    else:
        print("*", end="")
     
