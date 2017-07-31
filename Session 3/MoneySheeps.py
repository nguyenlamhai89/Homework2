sizes = [5, 7, 300, 90, 24, 50, 75]
print("Hello, my name is Hai and these are my sheep sizes")
print(sizes)

print("Now my biggest sheep has size", max(sizes), "let's shear it")
sizes.insert(sizes.index(max(sizes)), 8)
sizes.remove(max(sizes))
print("After shearing, here is my flock")
print(sizes)
max_month = int(input("Your max month??: "))

for month in range(0, max_month - 1):
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
month += 1
print()
print("MONTH ", month + 1, ":")
for i in range(0, 7):
    sizes[i] += 50
print("One month has passed, now here is my flock")
print(sizes)

total_sizes = sizes[0] + sizes[1] + sizes[2] + sizes[3] + sizes[4] + sizes[5] + sizes[6] 
print("My flock has size in total: ", total_sizes)
money = total_sizes * 2
print("I would get", total_sizes, "* 2$ =", money, "$")
