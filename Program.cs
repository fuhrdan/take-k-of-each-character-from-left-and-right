//*****************************************************************************
//** 2516. Take K of Each Character From Left and Right    leetcode          **
//*****************************************************************************

int takeCharacters(char* s, int k) {
    int n = strlen(s);

    int count_a = 0, count_b = 0, count_c = 0;

    for (int i = 0; i < n; i++) 
    {
        if (s[i] == 'a')
            count_a++;
        else if (s[i] == 'b')
            count_b++;
        else if (s[i] == 'c')
            count_c++;
    }

    if (count_a < k || count_b < k || count_c < k) 
    {
        return -1;
    }

    int i = 0, j = 0;
    int notDeletedWindowSize = 0;

    while (j < n) 
    {
        if (s[j] == 'a') 
        {
            count_a--;
        } 
        else if (s[j] == 'b') 
        {
            count_b--;
        } 
        else if (s[j] == 'c') 
        {
            count_c--;
        }

        while (i <= j && (count_a < k || count_b < k || count_c < k)) 
        {
            if (s[i] == 'a') 
            {
                count_a++;
            } 
            else if (s[i] == 'b') 
            {
                count_b++;
            } 
            else if (s[i] == 'c') 
            {
                count_c++;
            }
            i++;
        }

        if (j - i + 1 > notDeletedWindowSize) 
        {
            notDeletedWindowSize = j - i + 1;
        }

        j++;
    }

    return n - notDeletedWindowSize;
}