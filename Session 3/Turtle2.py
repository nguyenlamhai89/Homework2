from turtle import *

speed(-1)
colors = ['red', 'blue', 'brown', 'yellow', 'grey']

for a in range(3, 8, 1):
    for i in range(a):
       color(colors[a - 3])
       forward(100)
       left(360/a)
            
 
