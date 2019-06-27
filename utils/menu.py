import molmass as mm

def main_menu():
    print("\nWhat do you want to do?")
    for opt in options: print("{0}:\t{1}".format(opt, options[opt].__doc__))

    choice = None

    while choice == None:
        choice = input("\nChoice: ")
        try:
            options[int(choice)]()
        except (KeyError, ValueError):
            print("'{}' is an invalid option!\n".format(choice))
            choice = None

def mass_anal():
    """Analyze the masses of a given molecule"""

    print("\nEnter molecule: ", end='')
    molecule = input()
    print(mm.analyze(molecule))

    choice = input("\nWould you like to analyze another molecule? ")
    if (choice.lower().find("y")) != -1:
        mass_anal()
    else:
        main_menu()

def exit():
    """Exit the program"""
    raise SystemExit

options = {1 : mass_anal, 0 : exit}

if __name__ == "__main__":
    main_menu()