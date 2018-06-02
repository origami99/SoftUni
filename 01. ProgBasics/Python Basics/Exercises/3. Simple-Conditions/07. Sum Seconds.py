import math

time1 = int(input())
time2 = int(input())
time3 = int(input())

total_time = time1 + time2 + time3

mins = math.floor(total_time / 60)
secs = total_time % 60

if secs <= 9:
    print(f'{mins}:0{secs}')
else:
    print(f'{mins}:{secs}')