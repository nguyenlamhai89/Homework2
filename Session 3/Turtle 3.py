from turtle import *

speed(-1)
colors = ['red', 'blue', 'brown', 'yellow', 'grey']


for i in range(0, 5):
    begin_fill()
    color(colors[i])
    for a in range(0, 2):
        forward(50)
        left(90)
        forward(100)
        left(90)
    forward(50)
    end_fill()
    
        
    
