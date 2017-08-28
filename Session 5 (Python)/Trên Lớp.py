def say_hello():
    print("Hello")

def say_hello2(name):
    print("Hello", name)

def inc(x):
    print(x + 1)

def add(a,b):
    t = a + b
    return t

def odd_list(l):
    return[i for i in l if i % 2 != 0]
       
            
    

say_hello()

x = "Hai"

say_hello2(x)


y = add(4,12)
z = add(-1,8)


#inc(5)
#total = add(y,z)

result = odd_list([1, 3, 5, 6, 2, 123])

print(result)






