sizes = [5, 7, 300, 90, 24, 50, 75]
print("Hello, my name is Hai and these are my sheep sizes")
print(sizes)
max_month = int(input("Your max month??: "))

for month in range(0, max_month):
    print()
    print("MONTH ", month + 1, ":")
    for i in range(0, 7):
        sizes[i] += 50
    print("One month has passed, now here is my flock")
    print(sizes)
    print("Now my biggest sheep has size", max(sizes), "let's shear it")
    sizes.insert(sizes.index(max(sizes)), 8)
    sizes.remove(max(sizes))
    print("After shearing, here is my flock")
    print(sizes)







