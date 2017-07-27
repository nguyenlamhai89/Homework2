cd = int(input("Nhap chieu dai: "))
cr = int(input("Nhap chieu rong: "))

for i in range(1, cd + 1, 1):
    for j in range(1, cr + 1, 1):
        if i % 2 != 0:
            if j % 2 != 0:
                print("x", end="")
            else:
                print("*", end="")
        else:
            if j % 2 == 0:
                print("x", end="")
            else:
                print("*", end="")
    print()

       


    
         
