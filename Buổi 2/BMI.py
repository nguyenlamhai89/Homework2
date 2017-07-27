height = float(input("Enter your height(cm): "))
while height <= 0:
    height = float(input("Invalid height, please try again: "))
height /= 100
    
mass = float(input("Enter your mass(kg): "))
while mass <= 0:
    mass = float(input("Invalid mass, please try again: "))
    
BMI = float(mass)/(float(height)**2)

print("Your BMI is: ", BMI)

if BMI < 16:
    print("Severely underweight")
elif 16 <= BMI < 18.5:
    print("Underweight")
elif 18.5 <= BMI < 25:
    print("Normal")
elif 25 <= BMI < 30:
    print("Overweight")
elif BMI >= 30:
    print("Obese")
