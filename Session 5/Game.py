px = 2
py = 1

bx = 1
by = 2

gx = 1
gy = 3
def mapsokoban():
    for y in range(4):
        for x in range(4):
            if (x == px) and (y == py):
                print("P", end=" ")
            elif (x == bx) and ( y == by):
                print("B", end=" ")
            elif (x == gx) and (y == gy):
                print("G", end=" ")
            else:
                print("-", end=" ")
        print()

    
while True:
    if (bx == gx) and (by == gy):
        print("---------------YOU WIN!!!---------------")
        
    mapsokoban()
    
    command = input("Your move?")
    if command.upper() == "D":
        px += 1
        if (px == bx) and (py == by):
            bx += 1
    elif command.upper() == "S":
        py += 1
        if (py == by) and (px == bx):
            by += 1
    elif command.upper() == "A":
        px -= 1
        if (px == bx) and (py == by):
            bx -= 1
    elif command.upper() == "W":
        py -= 1
        if (py == by) and (px == bx):
            by -= 1
  
    
            
        
        

   
        
    
    
