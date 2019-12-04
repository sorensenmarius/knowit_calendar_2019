import numpy as np
import csv

m = np.zeros((1000, 1000), dtype=int)
pos = [0,0]
time = 0

with open("coords.csv") as f:
    reader = csv.reader(f, delimiter=',')
    next(reader)
    for row in reader:
        row = [int(row[0]), int(row[1])]
        if row[0] < pos[0]:
            for x in range(row[0], pos[0] + 1):
                m[x][pos[1]] += 1
                time += m[x][pos[1]]
        else:
            for x in range(pos[0], row[0] + 1):
                m[x][pos[1]] += 1
                time += m[x][pos[1]]
        pos[0] = row[0]

        if row[1] < pos[1]:
            for y in range(row[1] + 1, pos[1]):
                m[pos[0]][y] += 1
                time += m[pos[0]][y]
        else:
            for y in range(pos[1] + 1, row[1]):
                m[pos[0]][y] += 1
                time += m[pos[0]][y]
        pos[1] = row[1]
print(time)