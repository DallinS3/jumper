# print words having len 10 or more
with open ("10000_words.txt", 'r') as file:
    s = file.read()
    x = s.split()
    for i in x:
        if len(i) > 5:
            i = i.capitalize()
            print(i)


# def read_data():
#     f = open("10000_words.txt", 'r')
#     s = f.read()
#     x = s.split()
#     for i in x:
#         if len(i) > 5:
#             i = i.capitalize()
#             print(i)

# read_data()