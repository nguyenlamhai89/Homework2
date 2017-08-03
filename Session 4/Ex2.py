prices = {
    "banana" : 4,
    "apple" : 2,
    "orange" : 1.5,
    "pear" : 3
    }

purchases_items = {
    "banana" : 5,
    "apple" : 4,
    "orange" : 3,
    "pear" : 2
    }
print(prices)
print()
total = 0

for key1 in prices:
    print(key1, ",quantity:", purchases_items[key1], ",unit price:", prices[key1])
    cost = purchases_items[key1]*prices[key1]
    total += cost
print("TOTAL:", total)



