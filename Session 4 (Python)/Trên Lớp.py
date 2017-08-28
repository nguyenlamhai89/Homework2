from random import randint

def print_ninjas(ninjas):
    for ninja in ninjas:
        print(ninja)

def get_buff(ninja):
    if randint(1, 6) < ninja["luck"]:
        return 1.5
    else:
        return 1

def dummy():
    return 2

print(dummy())

def fight(attacker, defender):
    _atk = attacker["atk"]
    _def = defender["def"]

    if randint(1, 6) < attacker["luck"]:
        print("{0} has a critical attack".format(attacker["name"]))
        _atk *= 1.5

    if randint(1, 6) < defender["luck"]:
        print("{0} has bonus shield".format(defender["name"]))
        _def *= 1.5
    

    if attacker["hp"] > 0 and defender["hp"] > 0:
        if _atk > _def:
            damage = (_atk - _def)
            print("{0} lost {1} hp".format(defender["name"], damage))
            defender["hp"] -= damage
        else:
            damage = (_def - _atk)
            print("{0} lost {1} hp".format(attacker["name"], damage))
            attacker["hp"] -= (_def - _atk)
    
ninjas = [
    {
        "name" : "Naruto",
        "atk" : 8,
        
        "hp" : 10,
        "def" : 6,
        "luck": 4
    },
    {
        "name" : "Sasuke",
        "atk" : 7,
        "hp" : 10,
        "def" : 7,
        "luck": 2
    },
    {
        "name" : "Garaa",
        "atk" : 7,
        "hp" : 10,
        "def" : 5,
        "luck": 5
    },
    {
        "name" : "Minato",
        "atk" : 7.5,
        "hp" : 10,
        "def" : 7,
        "luck": 0
    }
]
print(ninja)

while len(ninjas) > 1:

    for atk_index in range(len(ninjas)):
        if atk_index < len(ninjas) - 1:
            def_index = atk_index + 1
        else:
            def_index = 0

        attacker = ninjas[atk_index]
        defender = ninjas[def_index]

        print("{0} attacks {1}".format(attacker["name"], defender["name"]))

fight(attacker, defender)
print("*********************************************************")

ninjas = [ninja for ninja in ninjas if ninja["hp"] > 0]
    
for ninja in ninjas:
        print("name: {0}, atk: {2}, def: {3}, hp: {1}".format(ninja["name"],
                                                              ninja["hp"], ninja["atk"], ninja["def"]))

    input()
