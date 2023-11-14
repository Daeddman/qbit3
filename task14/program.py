def ГНЧЭ (m, c=0):
    for i in range(1, m+1):
        for _ in range(i):
            c += 1
            if c > m:
                return
            yield str(i)

print(' '.join(ГНЧЭ (int(input()))))
