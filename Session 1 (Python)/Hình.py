##name1 = "nlhai"
##name2 = "abcxyz"
##name3 = "qwerty"
##name4 = "paskcvj"

names = ["nlhai","abcxyz","qwerty","paskcvj"]
print(names)
print(names[-2])

####n = input("Nhap ten ban!")
####names.append(n)
####print(names)
##
while True:
    cmd = input("Ban muon gi")
    if cmd.upper() == "THEM":
        n = input("Muon them ai?")
        names.append(n)
        print(names)
    elif cmd.lower() == "xoa":
        n = input("Muon xoa ai?")
        if n in names:
            names.remove(n)
            print(names)
        else:
            print("Ten khong ton tai")
    elif cmd.lower() == "sua":
      old_name = input("Ten muon sua")
      if old_name in names:
          index = names.index(old_name)
          new_name = input("Muon sua thanh ai?")
          
          
        
