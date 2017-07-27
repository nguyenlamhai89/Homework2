from turtle import *

speed(-1)

for a in range(3, 7, 1):
    if a %2 == 0:
        color("Red")
    else:
        color("Blue")
    for i in range(a):
        forward(100)
        left(360/a)



 
